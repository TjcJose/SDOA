// 数据层
// 信息系统-客户
// 创建：2016.11.03 高振亮

using Sd.IDAL;
using Sd.Model;

namespace Sd.DAL
{
    /// <summary>
    /// 客户信息类  
    /// <remarks>
    /// 创建：2016.11.03 高振亮
    /// 修改：2016.11.03 高振亮
    /// </remarks>
    /// </summary>
    public class CustomerDal : BaseDal<khxx>, ICustomerDal
    {
    }

    /// <summary>
    /// 种类表类  
    /// <remarks>
    /// 创建：2016.11.03 高振亮
    /// 修改：2016.11.03 高振亮
    /// </remarks>
    /// </summary>
    public class ZlDal : BaseDal<zlb>, IZlDal
    {
    }
}
