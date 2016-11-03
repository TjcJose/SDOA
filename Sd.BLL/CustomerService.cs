// 业务层
// 信息系统-客户
// 创建：2016.11.03 高振亮

using Sd.DAL;
using Sd.IBLL;
using Sd.Model;

namespace Sd.BLL
{
    /// <summary>
    /// 客户信息类
    /// <remarks>
    /// 创建：2016.11.03 高振亮
    /// 修改：2016.11.03 高振亮
    /// </remarks>
    /// </summary>
    public class CustomerService : BaseService<khxx>, ICustomerService
    {
        public CustomerService() : base(DbSession.CustomerDal) { }
    }

    /// <summary>
    /// 种类表类
    /// <remarks>
    /// 创建：2016.11.03 高振亮
    /// 修改：2016.11.03 高振亮
    /// </remarks>
    /// </summary>
    public class ZlService : BaseService<zlb>, IZlService
    {
        public ZlService() : base(DbSession.ZlDal) { }
    }
}
