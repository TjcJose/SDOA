//-----------------------------------------------
// 业务层
// 信息系统-商品
// 创建：2016.11.11 高振亮
// 修改：2016.11.11 高振亮
//-----------------------------------------------

using Sd.DAL;
using Sd.IBLL;
using Sd.Model;

namespace Sd.BLL
{
    /// <summary>
    /// 商品信息
    /// <remarks>
    /// 创建：2016.11.11 高振亮
    /// 修改：2016.11.11 高振亮
    /// </remarks>
    /// </summary>
    public class GoodsService : BaseService<spxx>, IGoodsService
    {
        public GoodsService() : base(DbSession.GoodsDal) { }
    }

    /// <summary>
    /// 商品品牌
    /// <remarks>
    /// 创建：2016.11.11 高振亮
    /// 修改：2016.11.11 高振亮
    /// </remarks>
    /// </summary>
    public class SpPpService : BaseService<spPmlb>, ISpPpService
    {
        public SpPpService() : base(DbSession.SpPpDal) { }
    }
    /// <summary>
    /// 产品系列
    /// <remarks>
    /// 创建：2016.11.11 高振亮
    /// 修改：2016.11.11 高振亮
    /// </remarks>
    /// </summary>
    public class CpXlService : BaseService<cpxl>, ICpXlService
    {
        public CpXlService() : base(DbSession.CpXlDal) { }
    }
    /// <summary>
    /// 产品系列类型
    /// <remarks>
    /// 创建：2016.11.11 高振亮
    /// 修改：2016.11.11 高振亮
    /// </remarks>
    /// </summary>
    public class CpXlLxService : BaseService<cpxllx>, ICpXlLxService
    {
        public CpXlLxService() : base(DbSession.CpXlLxDal) { }
    }
    /// <summary>
    /// 商品计量单位
    /// <remarks>
    /// 创建：2016.11.11 高振亮
    /// 修改：2016.11.11 高振亮
    /// </remarks>
    /// </summary>
    public class JlDwbService : BaseService<jldwb>, IJlDwbService
    {
        public JlDwbService() : base(DbSession.JlDwbDal) { }
    }
    /// <summary>
    /// 商品分类
    /// <remarks>
    /// 创建：2016.11.12 高振亮
    /// 修改：2016.11.12 高振亮
    /// </remarks>
    /// </summary>
    public class SpflService : BaseService<spfl>, ISpflService
    {
        public SpflService() : base(DbSession.SpflDal) { }
    }

    /// <summary>
    /// 产品规格
    /// <remarks>
    /// 创建：2016.11.13 高振亮
    /// 修改：2016.11.13 高振亮
    /// </remarks>
    /// </summary>
    public class GgxxbService : BaseService<ggxxb>, IGgxxbService
    {
        public GgxxbService() : base(DbSession.GgxxbDal) { }
    }
}
