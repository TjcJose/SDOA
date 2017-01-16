//-----------------------------------------------
// 业务层接口
// 在途系统
// 创建：2017.01.08 高振亮
// 修改：2017.01.08 高振亮
//-----------------------------------------------

using Sd.Model;

namespace Sd.IBLL
{
    /// <summary>
    /// 在途运输单类
    /// <remarks>
    /// 创建：2017.01.08 高振亮
    /// 修改：2017.01.08 高振亮
    /// </remarks>
    /// </summary>
    public interface IZtysdService : IBaseService<zt_ysd>
    {
    }

    /// <summary>
    /// 在途运输单明细类
    /// <remarks>
    /// 创建：2017.01.08 高振亮
    /// 修改：2017.01.08 高振亮
    /// </remarks>
    /// </summary>
    public interface IZtysdmxService : IBaseService<zt_ysdmx>
    {
    }
}
