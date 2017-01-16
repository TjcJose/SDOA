//-----------------------------------------------
// 数据层接口
// 财务系统
// 创建：2017.01.05 高振亮
// 修改：2017.01.05 高振亮
//-----------------------------------------------

using Sd.Model;

namespace Sd.IDAL
{
    /// <summary>
    /// 回收货款单接口
    /// <remarks>
    /// 创建：2017.01.05 高振亮
    /// 修改：2017.01.05 高振亮
    /// </remarks>
    /// </summary>
    public interface IHshkdDal : IBaseDal<hshkd>
    {
    }

    /// <summary>
    /// 在途运费付款单接口
    /// <remarks>
    /// 创建：2017.01.08 高振亮
    /// 修改：2017.01.08 高振亮
    /// </remarks>
    /// </summary>
    public interface IJhyfbDal : IBaseDal<jhyfb>
    {
    }

    /// <summary>
    /// 在途运费付款明细单接口
    /// <remarks>
    /// 创建：2017.01.08 高振亮
    /// 修改：2017.01.08 高振亮
    /// </remarks>
    /// </summary>
    public interface IJhyfmxbDal : IBaseDal<jhyfmxb>
    {
    }

    /// <summary>
    /// 收入进账单接口
    /// <remarks>
    /// 创建：2017.01.09 高振亮
    /// 修改：2017.01.09 高振亮
    /// </remarks>
    /// </summary>
    public interface IQtsrdDal : IBaseDal<qtsrd>
    {
    }

    /// <summary>
    /// 收入进账单明细接口
    /// <remarks>
    /// 创建：2017.01.09 高振亮
    /// 修改：2017.01.09 高振亮
    /// </remarks>
    /// </summary>
    public interface IQtsrmxDal : IBaseDal<qtsrmx>
    {
    }

    /// <summary>
    /// 货款结算单接口
    /// <remarks>
    /// 创建：2017.01.09 高振亮
    /// 修改：2017.01.09 高振亮
    /// </remarks>
    /// </summary>
    public interface IHkjsdDal : IBaseDal<zt_hkyfjsd>
    {
    }

    /// <summary>
    /// 费用开支单接口
    /// <remarks>
    /// 创建：2017.01.10 高振亮
    /// 修改：2017.01.10 高振亮
    /// </remarks>
    /// </summary>
    public interface IFykzdDal : IBaseDal<fykzd>
    {
    }

    /// <summary>
    /// 费用开支单明细接口
    /// <remarks>
    /// 创建：2017.01.10 高振亮
    /// 修改：2017.01.10 高振亮
    /// </remarks>
    /// </summary>
    public interface IFykzdmxDal : IBaseDal<fykzdmx>
    {
    }
}
