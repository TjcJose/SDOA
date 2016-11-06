//-----------------------------------------------
// 业务层接口
// 信息系统-客户
// 创建：2016.11.03 高振亮
// 修改：2016.11.03 高振亮
//-----------------------------------------------

using Sd.Model;

namespace Sd.IBLL
{
    /// <summary>
    /// 客户信息类  
    /// <remarks>
    /// 创建：2016.11.03 高振亮
    /// 修改：2016.11.03 高振亮
    /// </remarks>
    /// </summary>
    public interface ICustomerService : IBaseService<khxx>
    {
    }

    /// <summary>
    /// 种类表类  
    /// <remarks>
    /// 创建：2016.11.03 高振亮
    /// 修改：2016.11.03 高振亮
    /// </remarks>
    /// </summary>
    public interface IZlService : IBaseService<zlb>
    {
    }
}
