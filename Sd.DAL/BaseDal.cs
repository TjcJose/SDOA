using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Linq.Expressions;
using Sd.IDAL;

namespace Sd.DAL
{
    /// <summary>
    /// 数据层
    /// 基类  
    /// <remarks>
    /// 创建：2016.07.06 高振亮
    /// 修改：2016.07.06 高振亮
    /// </remarks>
    /// </summary>
    public class BaseDal<T> : IBaseDal<T> where T : class ,new()
    {
        protected DbContext DContext = DbContextFactory.GetCurrentContext();
        public T Add(T entity)
        {
            DContext.Entry(entity).State = EntityState.Added;

            try
            {
                DContext.SaveChanges();

                return entity;
            }
            catch (Exception)
            {
                DContext.Dispose();

                DContext = DbContextFactory.ResetCurrentContext();

                return null;
            }
          
        }

        public int Count(Expression<Func<T, bool>> predicate)
        {
            return DContext.Set<T>().Count(predicate);
        }

        public bool Update(T entity)
        {
            DContext.Set<T>().Attach(entity);
            DContext.Entry(entity).State = EntityState.Modified;

            try
            {
                return DContext.SaveChanges() > 0;
            }
            catch (DbEntityValidationException)
            {
                /*var error = "";
                foreach (var item in ex.EntityValidationErrors)
                {
                    foreach (var item2 in item.ValidationErrors)
                    {
                        error = string.Format("{0}:{1}\r\n", item2.PropertyName, item2.ErrorMessage);
                    }
                }*/
                DContext.Dispose();

                DContext = DbContextFactory.ResetCurrentContext();

                return false;
            }
        }

        public bool Delete(T entity)
        {
            DContext.Set<T>().Attach(entity);
            DContext.Entry(entity).State = EntityState.Deleted;

            try
            {
                return DContext.SaveChanges() > 0;
            }
            catch (Exception e)
            {

                DContext.Dispose();

                DContext = DbContextFactory.ResetCurrentContext();

                return false;
            }
        }

        /// <summary>
        /// 批量处理
        /// </summary>
        /// <param name="entityList">实体</param>
        /// <param name="strEntityState">执行操作</param>
        /// <returns></returns>
        public bool PatchById(List<T> entityList, string strEntityState)
        {
            EntityState entityState;
            if (strEntityState.Equals("delete"))
            {
                entityState = EntityState.Deleted;
            }
            else if (strEntityState.Equals("add"))
            {
                entityState = EntityState.Added;
            }
            else if (strEntityState.Equals("update"))
            {
                entityState = EntityState.Modified;
            }
            else
            {
                return false;
            }

            foreach (var entity in entityList)
            {
                DContext.Set<T>().Attach(entity);
                DContext.Entry(entity).State = entityState;
            }

            return DContext.SaveChanges() > 0;
        }

        public bool Exist(Expression<Func<T, bool>> anyLambda)
        {
            return DContext.Set<T>().Any(anyLambda);
        }

        public T Find(Expression<Func<T, bool>> whereLambda)
        {
            var entity = DContext.Set<T>().FirstOrDefault(whereLambda);
            return entity;
        }

        /// <summary>
        /// 排序
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="source">原IQueryable</param>
        /// <param name="propertyName">排序属性名</param>
        /// <param name="isAsc">是否正序</param>
        /// <returns>排序后的IQueryable</returns>
        private IQueryable<T> OrderBy(IQueryable<T> source, string propertyName, bool isAsc)
        {
            if (source == null) throw new ArgumentNullException("source", "不能为空");
            if (string.IsNullOrEmpty(propertyName)) return source;
            var parameter = Expression.Parameter(source.ElementType);
            var property = Expression.Property(parameter, propertyName);
            if (property == null) throw new ArgumentNullException("propertyName", "属性不存在");
            var lambda = Expression.Lambda(property, parameter);
            var methodName = isAsc ? "OrderBy" : "OrderByDescending";
            var resultExpression = Expression.Call(typeof(Queryable), methodName, new[] { source.ElementType, property.Type }, source.Expression, Expression.Quote(lambda));
            return source.Provider.CreateQuery<T>(resultExpression);
        }

        public IQueryable<T> FindList(Expression<Func<T, bool>> whereLamdba, string orderName, bool isAsc)
        {
            var list = DContext.Set<T>().Where(whereLamdba);
            list = OrderBy(list, orderName, isAsc);
            return list;
        }

        public IQueryable<T> FindPageList(int pageIndex, int pageSize, out int totalRecord, Expression<Func<T, bool>> whereLamdba, string orderName, bool isAsc)
        {
            var list = DContext.Set<T>().Where(whereLamdba);
            totalRecord = list.Count();
            list = OrderBy(list, orderName, isAsc).Skip((pageIndex - 1) * pageSize).Take(pageSize);
            return list;
        }
    }
}
