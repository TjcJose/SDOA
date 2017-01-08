//-----------------------------------------------
// 数据层
// 共通类
// 创建：2016.11.17 高振亮
// 修改：2016.11.17 高振亮
//-----------------------------------------------

using System.Data.Entity;
using System.Linq;
using Sd.IDAL;

namespace Sd.DAL
{
    /// <summary>
    /// 存储过程 
    /// <remarks>
    /// 创建：2016.11.15 高振亮
    /// 修改：2016.11.15 高振亮
    /// </remarks>
    /// </summary>
    public class ProcDal : IProcDal
    {
        protected DbContext DContext = DbContextFactory.GetCurrentContext();

        /// <summary>
        /// 存储过程执行
        /// </summary>
        /// 创建：2016.11.21 高振亮
        /// 修改：2016.11.21 高振亮
        /// <param name="strProc">存储过程执行SQL语句</param>
        /// <param name="parameters">传入参数</param>
        /// <returns>返回</returns>
        public object ExecProc(string strProc, object[] parameters)
        {
            var singleOrDefault = DContext.Database.SqlQuery<object>(strProc,
                parameters).SingleOrDefault();

            return ((System.Data.SqlClient.SqlParameter)parameters[parameters.Length-1]).Value;
        }


    }


}
