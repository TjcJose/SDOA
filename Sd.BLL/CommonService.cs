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

        public object GetProcZhfkdlhb(object[] param)
        {
            IProcDal procDal = new ProcDal();

            return procDal.ExecProc("EXEC [dbo].[proc_zhfkdlhb] @rq,@jsrq,@czy,@y5,@y6,@y7,@y8,@y9,@y10,@y11,@xsbsql,@syy,@result OUTPUT", param);
        }

        public object GetProcZhjkdlhb(object[] param)
        {
            IProcDal procDal = new ProcDal();

            return procDal.ExecProc("EXEC [dbo].[proc_zhjkdlhb] @rq,@jsrq,@czy,@y0,@y1,@y2,@y3,@y4,@xsbsql,@djzlsql,@xszlsql,@syy,@khmc,@result OUTPUT", param);
        }
    }

}
