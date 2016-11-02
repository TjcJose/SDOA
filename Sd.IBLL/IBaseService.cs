using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Sd.IBLL
{
    /// <summary>
    /// 业务层接口
    /// 基类  
    /// <remarks>
    /// 创建：2016.07.06 高振亮
    /// 修改：2016.07.06 高振亮
    /// </remarks>
    /// </summary>
    public interface IBaseService<T> where T : class ,new()
    {
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="entity">数据实体</param>
        /// <returns>返回查询结果</returns>
        T Add(T entity);
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="entity">数据实体</param>
        /// <returns>是否成功</returns>
        bool Delete(T entity);
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="entity">数据实体</param>
        /// <returns>是否成功</returns>
        bool Update(T entity);
        /// <summary>
        /// 批处理操作
        /// </summary>
        /// <param name="entityList">数据实体集</param>
        /// <param name="entityState">操作</param>
        /// <returns></returns>
        bool PatchById(List<T> entityList, string entityState);
        /// <summary>
        /// 是否存在
        /// </summary>
        /// <param name="anyLambda">查询表达式</param>
        /// <returns>布尔值</returns>
        bool Exist(Expression<Func<T, bool>> anyLambda);
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="whereLambda"></param>
        /// <returns></returns>
        T Find(Expression<Func<T, bool>> whereLambda);
        /// <summary>
        /// 查找数据列表
        /// </summary>
        /// <param name="whereLamdba"></param>
        /// <param name="orderName"></param>
        /// <param name="isAsc"></param>
        /// <returns></returns>
        IQueryable<T> FindList(Expression<Func<T, bool>> whereLamdba, string orderName, bool isAsc);
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
        IQueryable<T> FindPageList(int pageIndex, int pageSize, out int totalRecord, Expression<Func<T, bool>> whereLamdba, string orderName, bool isAsc); 
    }
}
