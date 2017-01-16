//-----------------------------------------------
// 业务层
// 在途系统
// 创建：2017.01.08 高振亮
// 修改：2017.01.08 高振亮
//-----------------------------------------------

using Sd.DAL;
using Sd.IBLL;
using Sd.Model;

namespace Sd.BLL
{
    /// <summary>
    /// 在途运输单类
    /// <remarks>
    /// 创建：2017.01.08 高振亮
    /// 修改：2017.01.08 高振亮
    /// </remarks>
    /// </summary>
    public class ZtysdService : BaseService<zt_ysd>, IZtysdService
    {
        public ZtysdService() : base(DbSession.ZtysdDal) { }
    }

    /// <summary>
    /// 在途运输单明细类
    /// <remarks>
    /// 创建：2017.01.08 高振亮
    /// 修改：2017.01.08 高振亮
    /// </remarks>
    /// </summary>
    public class ZtysdmxService : BaseService<zt_ysdmx>, IZtysdmxService
    {
        public ZtysdmxService() : base(DbSession.ZtysdmxDal) { }
    }
}
