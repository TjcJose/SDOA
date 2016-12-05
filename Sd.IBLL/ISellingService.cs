//-----------------------------------------------
// 业务层接口
// 信息系统-销售
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
    public interface ISellingService : ICommonService
    {
        string GetPh(string strXsbmc);
    }

    /// <summary>
    /// 销售单  
    /// <remarks>
    /// 创建：2016.11.30 高振亮
    /// 修改：2016.11.30 高振亮
    /// </remarks>
    /// </summary>
    public interface IXsdService : IBaseService<xsd>
    {
    }

    /// <summary>
    /// 销售单明细  
    /// <remarks>
    /// 创建：2016.11.30 高振亮
    /// 修改：2016.11.30 高振亮
    /// </remarks>
    /// </summary>
    public interface IXsdmxService : IBaseService<xsdmx>
    {
    }
}
