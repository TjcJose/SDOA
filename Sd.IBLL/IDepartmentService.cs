//-----------------------------------------------
// 业务层接口
// 信息系统-部门
// 创建：2016.11.03 高振亮
// 修改：2016.11.03 高振亮
//-----------------------------------------------

using Sd.Model;

namespace Sd.IBLL
{
    /// <summary>
    /// 销售部信息类  
    /// <remarks>
    /// 创建：2016.11.03 高振亮
    /// 修改：2016.11.03 高振亮
    /// </remarks>
    /// </summary>
    public interface IXsbxxService : IBaseService<xsbxx>
    {
    }

    /// <summary>
    /// 职员信息类  
    /// <remarks>
    /// 创建：2016.11.03 高振亮
    /// 修改：2016.11.03 高振亮
    /// </remarks>
    /// </summary>
    public interface IZyxxService : IBaseService<zyxx>
    {
    }

    /// <summary>
    /// 销区信息类  
    /// <remarks>
    /// 创建：2016.11.06 高振亮
    /// 修改：2016.11.06 高振亮
    /// </remarks>
    /// </summary>
    public interface IXqxxService : IBaseService<xqxx>
    {
    }

    /// <summary>
    /// 大部门信息类  
    /// <remarks>
    /// 创建：2016.11.06 高振亮
    /// 修改：2016.11.06 高振亮
    /// </remarks>
    /// </summary>
    public interface IBigDepartmentService : IBaseService<bigDepartment>
    {
    }
}
