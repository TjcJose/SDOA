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
    /// 销售单信息
    /// <remarks>
    /// 创建：2016.11.30 高振亮
    /// 修改：2016.11.30 高振亮
    /// </remarks>
    /// </summary>
    public interface IXsdDal : IBaseDal<xsd>
    {
    }

    /// <summary>
    /// 销售单明细信息
    /// <remarks>
    /// 创建：2016.11.30 高振亮
    /// 修改：2016.11.30 高振亮
    /// </remarks>
    /// </summary>
    public interface IXsdmxDal : IBaseDal<xsdmx>
    {
    }

    /// <summary>
    /// 销售订货单信息
    /// <remarks>
    /// 创建：2017.01.04 高振亮
    /// 修改：2017.01.04 高振亮
    /// </remarks>
    /// </summary>
    public interface IXsdhdDal : IBaseDal<xsdhd>
    {
    }
    /// <summary>
    /// 销售订货单明细信息
    /// <remarks>
    /// 创建：2017.01.04 高振亮
    /// 修改：2017.01.04 高振亮
    /// </remarks>
    /// </summary>
    public interface IXsdhdmxDal : IBaseDal<xsdhdmx>
    {
    }
}
