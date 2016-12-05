//-----------------------------------------------
// 业务层
// 共通方法
// 创建：2016.11.22 高振亮
// 修改：2016.11.22 高振亮
//-----------------------------------------------

using Sd.DAL;
using Sd.IBLL;
using Sd.IDAL;

namespace Sd.BLL
{
    /// <summary>
    /// 票号取得
    /// <remarks>
    /// 创建：2016.11.22 高振亮
    /// 修改：2016.11.22 高振亮
    /// </remarks>
    /// </summary>
    public class CommonService : ICommonService
    {
        public object GetProcPh(object[] param)
        {
            IProcDal procDal = new ProcDal();

            return procDal.ExecProc("EXEC [dbo].[proc_PH] @djlb,@xsbmc,@result OUTPUT", param);
        }
    }

}
