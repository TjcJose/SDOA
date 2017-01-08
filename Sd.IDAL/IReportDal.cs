//-----------------------------------------------
// 数据层接口
// 销售系统-销售单
// 创建：2016.11.30 高振亮
// 修改：2016.11.30 高振亮
//-----------------------------------------------

using Sd.Model;

namespace Sd.IDAL
{
    /// <summary>
    /// 进款单  
    /// <remarks>
    /// 创建：2017.01.03 高振亮
    /// 修改：2017.01.03 高振亮
    /// </remarks>
    /// </summary>
    public interface IJkdsrDal : IBaseDal<jkdsr>
    {
    }

    /// <summary>
    /// 付款单  
    /// <remarks>
    /// 创建：2017.01.03 高振亮
    /// 修改：2017.01.03 高振亮
    /// </remarks>
    /// </summary>
    public interface IFkdsrDal : IBaseDal<fkdsr>
    {
    }
}
