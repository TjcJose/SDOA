using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Sd.IDAL;

namespace Sd.BLL
{
    /// <summary>
    /// 业务层
    /// 基类
    /// <remarks>
    /// 创建：2016.07.06 高振亮
    /// 修改：2016.07.06 高振亮
    /// </remarks>
    /// </summary>
    public abstract class BaseService<T> where T : class, new()
    {
        protected IBaseDal<T> CurrentDal { get; set; } //获取当前数据操作类。
        protected BaseService(IBaseDal<T> currentDal) { CurrentDal = currentDal; }

        public T Add(T entity)
        {
            return CurrentDal.Add(entity);
        }

        public bool Update(T entity)
        {
            return CurrentDal.Update(entity);
        }

        public bool Delete(T entity)
        {
            return CurrentDal.Delete(entity);
        }

        /// <summary>
        /// 批处理操作
        /// </summary>
        /// <param name="entityList">数据实体集</param>
        /// <param name="entityState">操作</param>
        /// <returns></returns>
        public bool PatchById(List<T> entityList, string entityState)
        {
            return CurrentDal.PatchById(entityList, entityState);
        }

        public bool Exist(Expression<Func<T, bool>> whereLamdba)
        {
            return CurrentDal.Exist(whereLamdba);
        }
        /// <summary>
        /// 查找数据
        /// </summary>
        /// <param name="whereLamdba"></param>
        /// <returns></returns>
        public T Find(Expression<Func<T, bool>> whereLamdba)
        {
            return CurrentDal.Find(whereLamdba);
        }
        public IQueryable<T> FindList(Expression<Func<T, bool>> whereLamdba, string orderName, bool isAsc)
        {
            return CurrentDal.FindList(whereLamdba, orderName, isAsc);
        }
        /// <summary>
        /// 查找分页数据列表
        /// </summary>
        /// <param name="pageIndex">当前页</param>
        /// <param name="pageSize">每页记录数</param>
        /// <param name="totalRecord">总记录数</param>
        /// <param name="whereLamdba">查询表达式</param>
        /// <param name="orderName">排序列名</param>
        /// <param name="isAsc">是否升序</param>
        /// <returns></returns>
        public IQueryable<T> FindPageList(int pageIndex, int pageSize, out int totalRecord,
            Expression<Func<T, bool>> whereLamdba, string orderName, bool isAsc)
        {
            return CurrentDal.FindPageList(pageIndex, pageSize, out totalRecord, whereLamdba, orderName, isAsc);
        }
    }
}
