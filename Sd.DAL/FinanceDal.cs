//-----------------------------------------------
// 数据层
// 财务系统
// 创建：2017.01.05 高振亮
// 修改：2017.01.05 高振亮
//-----------------------------------------------

using Sd.IDAL;
using Sd.Model;

namespace Sd.DAL
{
    /// <summary>
    /// 回收货款单
    /// <remarks>
    /// 创建：2017.01.05 高振亮
    /// 修改：2017.01.05 高振亮
    /// </remarks>
    /// </summary>
    public class HshkdDal : BaseDal<hshkd>, IHshkdDal
    {
    }

    /// <summary>
    /// 在途运费付款单
    /// <remarks>
    /// 创建：2017.01.08 高振亮
    /// 修改：2017.01.08 高振亮
    /// </remarks>
    /// </summary>
    public class JhyfbDal : BaseDal<jhyfb>, IJhyfbDal
    {
    }
    /// <summary>
    /// 在途运费付款明细单
    /// <remarks>
    /// 创建：2017.01.08 高振亮
    /// 修改：2017.01.08 高振亮
    /// </remarks>
    /// </summary>
    public class JhyfmxbDal : BaseDal<jhyfmxb>, IJhyfmxbDal
    {
    }

    /// <summary>
    /// 收入进账单
    /// <remarks>
    /// 创建：2017.01.09 高振亮
    /// 修改：2017.01.09 高振亮
    /// </remarks>
    /// </summary>
    public class QtsrdDal : BaseDal<qtsrd>, IQtsrdDal
    {
    }
    /// <summary>
    /// 收入进账单明细
    /// <remarks>
    /// 创建：2017.01.09 高振亮
    /// 修改：2017.01.09 高振亮
    /// </remarks>
    /// </summary>
    public class QtsrmxDal : BaseDal<qtsrmx>, IQtsrmxDal
    {
    }

    /// <summary>
    /// 货款结算单
    /// <remarks>
    /// 创建：2017.01.09 高振亮
    /// 修改：2017.01.09 高振亮
    /// </remarks>
    /// </summary>
    public class HkjsdDal : BaseDal<zt_hkyfjsd>, IHkjsdDal
    {
    }

    /// <summary>
    /// 费用开支单
    /// <remarks>
    /// 创建：2017.01.10 高振亮
    /// 修改：2017.01.10 高振亮
    /// </remarks>
    /// </summary>
    public class FykzdDal : BaseDal<fykzd>, IFykzdDal
    {
    }
    /// <summary>
    /// 费用开支单明细
    /// <remarks>
    /// 创建：2017.01.10 高振亮
    /// 修改：2017.01.10 高振亮
    /// </remarks>
    /// </summary>
    public class FykzdmxDal : BaseDal<fykzdmx>, IFykzdmxDal
    {
    }
}
