//-----------------------------------------------
// 数据层接口
// 在途系统
// 创建：2017.01.08 高振亮
// 修改：2017.01.08 高振亮
//-----------------------------------------------

using Sd.Model;

namespace Sd.IDAL
{
    /// <summary>
    /// 在途运输单
    /// <remarks>
    /// 创建：2017.01.08 高振亮
    /// 修改：2017.01.08 高振亮
    /// </remarks>
    /// </summary>
    public interface IZtysdDal : IBaseDal<zt_ysd>
    {
    }

    /// <summary>
    /// 在途运输单明细
    /// <remarks>
    /// 创建：2017.01.08 高振亮
    /// 修改：2017.01.08 高振亮
    /// </remarks>
    /// </summary>
    public interface IZtysdmxDal : IBaseDal<zt_ysdmx>
    {
    }
}
