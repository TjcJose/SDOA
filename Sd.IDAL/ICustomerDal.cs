// 数据层接口
// 信息系统-客户
// 创建：2016.11.03 高振亮

using Sd.Model;

namespace Sd.IDAL
{
    /// <summary>
    /// 客户信息
    /// <remarks>
    /// 创建：2016.11.03 高振亮
    /// 修改：2016.11.03 高振亮
    /// </remarks>
    /// </summary>
    public interface ICustomerDal : IBaseDal<khxx>
    {
    }

    /// <summary>
    /// 种类信息
    /// <remarks>
    /// 创建：2016.11.03 高振亮
    /// 修改：2016.11.03 高振亮
    /// </remarks>
    /// </summary>
    public interface IZlDal : IBaseDal<zlb>
    {
    }
}
