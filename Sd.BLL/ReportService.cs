//-----------------------------------------------
// 业务层
// 报表系统
// 创建：2017.01.03 高振亮
// 修改：2017.01.03 高振亮
//-----------------------------------------------

using System.Data;
using Sd.DAL;
using Sd.IBLL;
using Sd.Model;

namespace Sd.BLL
{
    public class ReportService : CommonService, IReportService
    {
        public string GetZhfkdlhb(string rq, string jsrq, string czy)
        {
            System.Data.SqlClient.SqlParameter[] parameters =
            {
                new System.Data.SqlClient.SqlParameter("@rq", rq),
                new System.Data.SqlClient.SqlParameter("@jsrq", jsrq),
                new System.Data.SqlClient.SqlParameter("@czy", czy),
                new System.Data.SqlClient.SqlParameter("@y5", 1),
                new System.Data.SqlClient.SqlParameter("@y6", 1),
                new System.Data.SqlClient.SqlParameter("@y7", 1),
                new System.Data.SqlClient.SqlParameter("@y8", 1),
                new System.Data.SqlClient.SqlParameter("@y9", 1),
                new System.Data.SqlClient.SqlParameter("@y10", 1),
                new System.Data.SqlClient.SqlParameter("@y11", 1),
                new System.Data.SqlClient.SqlParameter("@xsbsql", ""),
                new System.Data.SqlClient.SqlParameter("@syy", "全部"),
                new System.Data.SqlClient.SqlParameter("@result", SqlDbType.Int)
            };

            parameters[12].Direction = ParameterDirection.Output;

            return GetProcZhfkdlhb(parameters).ToString();
        }

        public string GetZhjkdlhb(string rq, string jsrq, string czy)
        {
            System.Data.SqlClient.SqlParameter[] parameters =
            {
                new System.Data.SqlClient.SqlParameter("@rq", rq),
                new System.Data.SqlClient.SqlParameter("@jsrq", jsrq),
                new System.Data.SqlClient.SqlParameter("@czy", czy),
                new System.Data.SqlClient.SqlParameter("@y0", 1),
                new System.Data.SqlClient.SqlParameter("@y1", 1),
                new System.Data.SqlClient.SqlParameter("@y2", 1),
                new System.Data.SqlClient.SqlParameter("@y3", 1),
                new System.Data.SqlClient.SqlParameter("@y4", 1),
                new System.Data.SqlClient.SqlParameter("@xsbsql", ""),
                new System.Data.SqlClient.SqlParameter("@djzlsql", ""),
                new System.Data.SqlClient.SqlParameter("@xszlsql", ""),
                new System.Data.SqlClient.SqlParameter("@syy", "全部"),
                new System.Data.SqlClient.SqlParameter("@khmc", "全部"),
                new System.Data.SqlClient.SqlParameter("@result", SqlDbType.Int)
            };

            parameters[13].Direction = ParameterDirection.Output;

            return GetProcZhjkdlhb(parameters).ToString();
        }
    }

    public class JkdsrService : BaseService<jkdsr>, IJkdsrService
    {
        public JkdsrService() : base(DbSession.JkdsrDal) { }
    }

    public class FkdsrService : BaseService<fkdsr>, IFkdsrService
    {
        public FkdsrService() : base(DbSession.FkdsrDal) { }
    }
}
