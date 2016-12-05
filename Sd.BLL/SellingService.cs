//-----------------------------------------------
// 业务层
// 销售系统-销售
// 创建：2016.11.22 高振亮
// 修改：2016.11.22 高振亮
//-----------------------------------------------

using System.Data;
using Sd.DAL;
using Sd.IBLL;
using Sd.Model;

namespace Sd.BLL
{
    /// <summary>
    /// 销售系统
    /// <remarks>
    /// 创建：2016.11.03 高振亮
    /// 修改：2016.11.03 高振亮
    /// </remarks>
    /// </summary>
    public class SellingService: CommonService, ISellingService
    {

        //public string GetProcPh()
        //{
        //    IProcDal procDal = new ProcDal();

        //    procDal.ExecProc("EXEC [dbo].[proc_PH] @djlb,@xsbmc,@result OUTPUT", );
        //}
        public string GetPh(string strXsbmc)
        {
            System.Data.SqlClient.SqlParameter[] parameters =
            {
                new System.Data.SqlClient.SqlParameter("@djlb", "销售单"),
                new System.Data.SqlClient.SqlParameter("@xsbmc", strXsbmc),
                new System.Data.SqlClient.SqlParameter("@result", SqlDbType.Char, 10 )
            };

            parameters[2].Direction = ParameterDirection.Output;

            return  GetProcPh(parameters).ToString().Trim();
        }
    }

    /// <summary>
    /// 销售单
    /// <remarks>
    /// 创建：2016.11.03 高振亮
    /// 修改：2016.11.03 高振亮
    /// </remarks>
    /// </summary>
    public class XsdService : BaseService<xsd>, IXsdService
    {
        public XsdService() : base(DbSession.XsdDal) { }
    }

    /// <summary>
    /// 销售单明细
    /// <remarks>
    /// 创建：2016.11.03 高振亮
    /// 修改：2016.11.03 高振亮
    /// </remarks>
    /// </summary>
    public class XsdmxService : BaseService<xsdmx>, IXsdmxService
    {
        public XsdmxService() : base(DbSession.XsdmxDal) { }
    }
}
