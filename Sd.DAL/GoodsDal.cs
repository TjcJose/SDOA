//-----------------------------------------------
// 数据层
// 信息系统-商品
// 创建：2016.11.11 高振亮
// 修改：2016.11.11 高振亮
//-----------------------------------------------

using Sd.IDAL;
using Sd.Model;

namespace Sd.DAL
{
    /// <summary>
    /// 商品信息类  
    /// <remarks>
    /// 创建：2016.11.11 高振亮
    /// 修改：2016.11.11 高振亮
    /// </remarks>
    /// </summary>
    public class GoodsDal : BaseDal<spxx>, IGoodsDal
    {
    }

    /// <summary>
    /// 商品品牌类  
    /// <remarks>
    /// 创建：2016.11.11 高振亮
    /// 修改：2016.11.11 高振亮
    /// </remarks>
    /// </summary>
    public class SpPpDal : BaseDal<spPmlb>, ISpPpDal
    {
    }

    /// <summary>
    /// 产品系列类  
    /// <remarks>
    /// 创建：2016.11.11 高振亮
    /// 修改：2016.11.11 高振亮
    /// </remarks>
    /// </summary>
    public class CpXlDal : BaseDal<cpxl>, ICpXlDal
    {
    }
    /// <summary>
    /// 产品系列类型  
    /// <remarks>
    /// 创建：2016.11.11 高振亮
    /// 修改：2016.11.11 高振亮
    /// </remarks>
    /// </summary>
    public class CpXlLxDal : BaseDal<cpxllx>, ICpXlLxDal
    {
    }
    /// <summary>
    /// 商品计量单位
    /// <remarks>
    /// 创建：2016.11.11 高振亮
    /// 修改：2016.11.11 高振亮
    /// </remarks>
    /// </summary>
    public class JlDwbDal : BaseDal<jldwb>, IJlDwbDal
    {
    }
    /// <summary>
    /// 商品分类
    /// <remarks>
    /// 创建：2016.11.12 高振亮
    /// 修改：2016.11.12 高振亮
    /// </remarks>
    /// </summary>
    public class SpflDal : BaseDal<spfl>, ISpflDal
    {
    }
    /// <summary>
    /// 产品规格
    /// <remarks>
    /// 创建：2016.11.13 高振亮
    /// 修改：2016.11.13 高振亮
    /// </remarks>
    /// </summary>
    public class GgxxbDal : BaseDal<ggxxb>, IGgxxbDal
    {
    }
}
