//-----------------------------------------------
// 业务层
// 财务系统
// 创建：2017.01.05 高振亮
// 修改：2017.01.05 高振亮
//-----------------------------------------------

using Sd.DAL;
using Sd.IBLL;
using Sd.Model;

namespace Sd.BLL
{
    /// <summary>
    /// 回收货款单类
    /// <remarks>
    /// 创建：2017.01.05 高振亮
    /// 修改：2017.01.05 高振亮
    /// </remarks>
    /// </summary>
    public class HshkdService : BaseService<hshkd>, IHshkdService
    {
        public HshkdService() : base(DbSession.HshkdDal) { }
    }
}
