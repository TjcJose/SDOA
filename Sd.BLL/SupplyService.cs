//-----------------------------------------------
// 业务层
// 信息系统-供货商
// 创建：2016.11.13 高振亮
// 修改：2016.11.13 高振亮
//-----------------------------------------------

using Sd.DAL;
using Sd.IBLL;
using Sd.Model;

namespace Sd.BLL
{
    /// <summary>
    /// 供货商信息类
    /// <remarks>
    /// 创建：2016.11.13 高振亮
    /// 修改：2016.11.13 高振亮
    /// </remarks>
    /// </summary>
    public class GhsxxService : BaseService<ghsxx>, IGhsxxService
    {
        public GhsxxService() : base(DbSession.GhsxxDal) { }
    }
}
