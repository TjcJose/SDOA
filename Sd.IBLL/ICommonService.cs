//-----------------------------------------------
// 业务层接口
// 共通方法
// 创建：2016.11.22 高振亮
// 修改：2016.11.22 高振亮
//-----------------------------------------------

namespace Sd.IBLL
{

    public interface ICommonService
    {
        /// <summary>
        /// 票号取得
        /// <remarks>
        /// 创建：2016.11.22 高振亮
        /// 修改：2016.11.22 高振亮
        /// </remarks>
        /// </summary>
        object GetProcPh(object[] param);

        object GetProcZhfkdlhb(object[] param);

        object GetProcZhjkdlhb(object[] param);
    }
}
