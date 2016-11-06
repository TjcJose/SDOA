//-----------------------------------------------
// 业务层
// 信息系统-部门
// 创建：2016.11.03 高振亮
// 修改：2016.11.03 高振亮
//-----------------------------------------------
using Sd.DAL;
using Sd.IBLL;
using Sd.Model;

namespace Sd.BLL
{
    /// <summary>
    /// 销售部信息类
    /// <remarks>
    /// 创建：2016.11.03 高振亮
    /// 修改：2016.11.03 高振亮
    /// </remarks>
    /// </summary>
    public class XsbxxService : BaseService<xsbxx>, IXsbxxService
    {
        public XsbxxService() : base(DbSession.XsbxxDal) { }
    }

    /// <summary>
    /// 职员信息类
    /// <remarks>
    /// 创建：2016.11.03 高振亮
    /// 修改：2016.11.03 高振亮
    /// </remarks>
    /// </summary>
    public class ZyxxService : BaseService<zyxx>, IZyxxService
    {
        public ZyxxService() : base(DbSession.ZyxxDal) { }
    }

    /// <summary>
    /// 销区信息类
    /// <remarks>
    /// 创建：2016.11.06 高振亮
    /// 修改：2016.11.06 高振亮
    /// </remarks>
    /// </summary>
    public class XqxxService : BaseService<xqxx>, IXqxxService
    {
        public XqxxService() : base(DbSession.XqxxDal) { }
    }
}
