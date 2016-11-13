//-----------------------------------------------
// 业务层接口
// 信息系统-商品
// 创建：2016.11.11 高振亮
// 修改：2016.11.11 高振亮
//-----------------------------------------------

using Sd.Model;

namespace Sd.IBLL
{
    /// <summary>
    /// 商品信息 
    /// <remarks>
    /// 创建：2016.11.11 高振亮
    /// 修改：2016.11.11 高振亮
    /// </remarks>
    /// </summary>
    public interface IGoodsService : IBaseService<spxx>
    {
    }

    /// <summary>
    /// 商品品牌  
    /// <remarks>
    /// 创建：2016.11.11 高振亮
    /// 修改：2016.11.11 高振亮
    /// </remarks>
    /// </summary>
    public interface ISpPpService : IBaseService<spPmlb>
    {
    }

    /// <summary>
    /// 产品系列  
    /// <remarks>
    /// 创建：2016.11.11 高振亮
    /// 修改：2016.11.11 高振亮
    /// </remarks>
    /// </summary>
    public interface ICpXlService : IBaseService<cpxl>
    {
    }

    /// <summary>
    /// 产品系列类型  
    /// <remarks>
    /// 创建：2016.11.11 高振亮
    /// 修改：2016.11.11 高振亮
    /// </remarks>
    /// </summary>
    public interface ICpXlLxService : IBaseService<cpxllx>
    {
    }

    /// <summary>
    /// 商品计量单位  
    /// <remarks>
    /// 创建：2016.11.11 高振亮
    /// 修改：2016.11.11 高振亮
    /// </remarks>
    /// </summary>
    public interface IJlDwbService : IBaseService<jldwb>
    {
    }

    /// <summary>
    /// 商品分类  
    /// <remarks>
    /// 创建：2016.11.12 高振亮
    /// 修改：2016.11.12 高振亮
    /// </remarks>
    /// </summary>
    public interface ISpflService : IBaseService<spfl>
    {
    }

    /// <summary>
    /// 产品规格  
    /// <remarks>
    /// 创建：2016.11.13 高振亮
    /// 修改：2016.11.13 高振亮
    /// </remarks>
    /// </summary>
    public interface IGgxxbService : IBaseService<ggxxb>
    {
    }
}
