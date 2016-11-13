//-----------------------------------------------
// 数据层接口
// 信息系统-商品
// 创建：2016.11.09 高振亮
// 修改：2016.11.09 高振亮
//-----------------------------------------------

using Sd.Model;

namespace Sd.IDAL
{
    /// <summary>
    /// 商品信息
    /// <remarks>
    /// 创建：2016.11.09 高振亮
    /// 修改：2016.11.09 高振亮
    /// </remarks>
    /// </summary>
    public interface IGoodsDal : IBaseDal<spxx>
    {
    }

    /// <summary>
    /// 商品品牌
    /// <remarks>
    /// 创建：2016.11.09 高振亮
    /// 修改：2016.11.09 高振亮
    /// </remarks>
    /// </summary>
    public interface ISpPpDal : IBaseDal<spPmlb>
    {
    }

    /// <summary>
    /// 产品系列
    /// <remarks>
    /// 创建：2016.11.09 高振亮
    /// 修改：2016.11.09 高振亮
    /// </remarks>
    /// </summary>
    public interface ICpXlDal : IBaseDal<cpxl>
    {
    }

    /// <summary>
    /// 产品系列类型
    /// <remarks>
    /// 创建：2016.11.09 高振亮
    /// 修改：2016.11.09 高振亮
    /// </remarks>
    /// </summary>
    public interface ICpXlLxDal : IBaseDal<cpxllx>
    {
    }

    /// <summary>
    /// 商品计量单位
    /// <remarks>
    /// 创建：2016.11.09 高振亮
    /// 修改：2016.11.09 高振亮
    /// </remarks>
    /// </summary>
    public interface IJlDwbDal : IBaseDal<jldwb>
    {
    }

    /// <summary>
    /// 商品分类
    /// <remarks>
    /// 创建：2016.11.12 高振亮
    /// 修改：2016.11.12 高振亮
    /// </remarks>
    /// </summary>
    public interface ISpflDal : IBaseDal<spfl>
    {
    }

    /// <summary>
    /// 产品规格
    /// <remarks>
    /// 创建：2016.11.13 高振亮
    /// 修改：2016.11.13 高振亮
    /// </remarks>
    /// </summary>
    public interface IGgxxbDal : IBaseDal<ggxxb>
    {
    }
}
