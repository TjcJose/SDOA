//-----------------------------------------------
// 业务层
// 财务系统
// 创建：2017.01.05 高振亮
// 修改：2017.01.05 高振亮
//-----------------------------------------------

using Sd.DAL;
using Sd.IBLL;
using Sd.Model;

namespace Sd.BLL
{
    /// <summary>
    /// 回收货款单类
    /// <remarks>
    /// 创建：2017.01.05 高振亮
    /// 修改：2017.01.05 高振亮
    /// </remarks>
    /// </summary>
    public class HshkdService : BaseService<hshkd>, IHshkdService
    {
        public HshkdService() : base(DbSession.HshkdDal) { }
    }
    /// <summary>
    /// 在途运费付款单类
    /// <remarks>
    /// 创建：2017.01.08 高振亮
    /// 修改：2017.01.08 高振亮
    /// </remarks>
    /// </summary>
    public class JhyfbService : BaseService<jhyfb>, IJhyfbService
    {
        public JhyfbService() : base(DbSession.JhyfbDal) { }
    }

    /// <summary>
    /// 在途运费付款明细单类
    /// <remarks>
    /// 创建：2017.01.08 高振亮
    /// 修改：2017.01.08 高振亮
    /// </remarks>
    /// </summary>
    public class JhyfmxbService : BaseService<jhyfmxb>, IJhyfmxbService
    {
        public JhyfmxbService() : base(DbSession.JhyfmxbDal) { }
    }
    /// <summary>
    /// 收入进账单类
    /// <remarks>
    /// 创建：2017.01.09 高振亮
    /// 修改：2017.01.09 高振亮
    /// </remarks>
    /// </summary>
    public class QtsrdService : BaseService<qtsrd>, IQtsrdService
    {
        public QtsrdService() : base(DbSession.QtsrdDal) { }
    }

    /// <summary>
    /// 收入进账单明细类
    /// <remarks>
    /// 创建：2017.01.09 高振亮
    /// 修改：2017.01.09 高振亮
    /// </remarks>
    /// </summary>
    public class QtsrmxService : BaseService<qtsrmx>, IQtsrmxService
    {
        public QtsrmxService() : base(DbSession.QtsrmxDal) { }
    }

    /// <summary>
    /// 货款结算单类
    /// <remarks>
    /// 创建：2017.01.09 高振亮
    /// 修改：2017.01.09 高振亮
    /// </remarks>
    /// </summary>
    public class HkjsdService : BaseService<zt_hkyfjsd>, IHkjsdService
    {
        public HkjsdService() : base(DbSession.HkjsdDal) { }
    }

    /// <summary>
    /// 费用开支单类
    /// <remarks>
    /// 创建：2017.01.10 高振亮
    /// 修改：2017.01.10 高振亮
    /// </remarks>
    /// </summary>
    public class FykzdService : BaseService<fykzd>, IFykzdService
    {
        public FykzdService() : base(DbSession.FykzdDal) { }
    }

    /// <summary>
    /// 费用开支单明细类
    /// <remarks>
    /// 创建：2017.01.10 高振亮
    /// 修改：2017.01.10 高振亮
    /// </remarks>
    /// </summary>
    public class FykzdmxService : BaseService<fykzdmx>, IFykzdmxService
    {
        public FykzdmxService() : base(DbSession.FykzdmxDal) { }
    }
}
