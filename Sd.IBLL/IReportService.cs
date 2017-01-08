//-----------------------------------------------
// 业务层接口
// 报表系统
// 创建：2016.11.03 高振亮
// 修改：2016.11.03 高振亮
//-----------------------------------------------

using Sd.Model;

namespace Sd.IBLL
{
    /// <summary>
    /// 销售单号取得  
    /// <remarks>
    /// 创建：2016.11.22 高振亮
    /// 修改：2016.11.22 高振亮
    /// </remarks>
    /// </summary>
    public interface IReportService : ICommonService
    {
        string GetZhfkdlhb(string rq, string jsrq, string czy);

        string GetZhjkdlhb(string rq, string jsrq, string czy);
    }
    /// <summary>
    /// 进款单信息 
    /// <remarks>
    /// 创建：2017.01.03 高振亮
    /// 修改：2017.01.03 高振亮
    /// </remarks>
    /// </summary>
    public interface IJkdsrService : IBaseService<jkdsr>
    {
    }
    /// <summary>
    /// 付款单信息  
    /// <remarks>
    /// 创建：2017.01.03 高振亮
    /// 修改：2017.01.03 高振亮
    /// </remarks>
    /// </summary>
    public interface IFkdsrService : IBaseService<fkdsr>
    {
    }
}
