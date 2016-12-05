//-----------------------------------------------
// 数据层接口
// 共通类
// 创建：2016.11.17 高振亮
// 修改：2016.11.17 高振亮
//-----------------------------------------------

namespace Sd.IDAL
{
    /// <summary>
    /// 存储过程
    /// <remarks>
    /// 创建：2016.11.15 高振亮
    /// 修改：2016.11.15 高振亮
    /// </remarks>
    /// </summary>
    public interface IProcDal
    {
        /// <summary>
        /// 存储过程执行
        /// </summary>
        /// 创建：2016.11.21 高振亮
        /// 修改：2016.11.21 高振亮
        /// <param name="strProc">存储过程执行SQL语句</param>
        /// <param name="parameters">传入参数</param>
        /// <returns>返回</returns>
        object ExecProc(string strProc, object[] parameters);
    }
}
