//-----------------------------------------------
// 业务层接口
// 财务系统
// 创建：2017.01.05 高振亮
// 修改：2017.01.05 高振亮
//-----------------------------------------------

using Sd.Model;

namespace Sd.IBLL
{
    /// <summary>
    /// 回收货款单接口
    /// <remarks>
    /// 创建：2017.01.05 高振亮
    /// 修改：2017.01.05 高振亮
    /// </remarks>
    /// </summary>
    public interface IHshkdService : IBaseService<hshkd>
    {
    }

    /// <summary>
    /// 在途运费付款单接口
    /// <remarks>
    /// 创建：2017.01.08 高振亮
    /// 修改：2017.01.08 高振亮
    /// </remarks>
    /// </summary>
    public interface IJhyfbService : IBaseService<jhyfb>
    {
    }
    /// <summary>
    /// 在途运费付款明细单接口
    /// <remarks>
    /// 创建：2017.01.08 高振亮
    /// 修改：2017.01.08 高振亮
    /// </remarks>
    /// </summary>
    public interface IJhyfmxbService : IBaseService<jhyfmxb>
    {
    }

    /// <summary>
    /// 收入进账单接口
    /// <remarks>
    /// 创建：2017.01.09 高振亮
    /// 修改：2017.01.09 高振亮
    /// </remarks>
    /// </summary>
    public interface IQtsrdService : IBaseService<qtsrd>
    {
    }
    /// <summary>
    /// 收入进账单明细接口
    /// <remarks>
    /// 创建：2017.01.09 高振亮
    /// 修改：2017.01.09 高振亮
    /// </remarks>
    /// </summary>
    public interface IQtsrmxService : IBaseService<qtsrmx>
    {
    }

    /// <summary>
    /// 货款结算单接口
    /// <remarks>
    /// 创建：2017.01.09 高振亮
    /// 修改：2017.01.09 高振亮
    /// </remarks>
    /// </summary>
    public interface IHkjsdService : IBaseService<zt_hkyfjsd>
    {
    }

    /// <summary>
    /// 费用开支单接口
    /// <remarks>
    /// 创建：2017.01.10 高振亮
    /// 修改：2017.01.10 高振亮
    /// </remarks>
    /// </summary>
    public interface IFykzdService : IBaseService<fykzd>
    {
    }
    /// <summary>
    /// 费用开支单明细接口
    /// <remarks>
    /// 创建：2017.01.10 高振亮
    /// 修改：2017.01.10 高振亮
    /// </remarks>
    /// </summary>
    public interface IFykzdmxService : IBaseService<fykzdmx>
    {
    }
}
