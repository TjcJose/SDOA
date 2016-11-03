// 数据层接口
// 信息系统-部门
// 创建：2016.11.03 高振亮

using Sd.Model;

namespace Sd.IDAL
{
    /// <summary>
    /// 销售部信息
    /// <remarks>
    /// 创建：2016.11.03 高振亮
    /// 修改：2016.11.03 高振亮
    /// </remarks>
    /// </summary>
    public interface IXsbxxDal : IBaseDal<xsbxx>
    {
    }

    /// <summary>
    /// 职员信息
    /// <remarks>
    /// 创建：2016.11.03 高振亮
    /// 修改：2016.11.03 高振亮
    /// </remarks>
    /// </summary>
    public interface IZyxxDal : IBaseDal<zyxx>
    {
    }
}
