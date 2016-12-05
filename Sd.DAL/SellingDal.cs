//-----------------------------------------------
// 数据层
// 销售系统-销售单
// 创建：2016.11.30 高振亮
// 修改：2016.11.30 高振亮
//-----------------------------------------------

using Sd.IDAL;
using Sd.Model;

namespace Sd.DAL
{
    /// <summary>
    /// 销售单信息  
    /// <remarks>
    /// 创建：2016.11.30 高振亮
    /// 修改：2016.11.30 高振亮
    /// </remarks>
    /// </summary>
    public class XsdDal : BaseDal<xsd>, IXsdDal
    {
    }

    /// <summary>
    /// 销售单明细信息  
    /// <remarks>
    /// 创建：2016.11.30 高振亮
    /// 修改：2016.11.30 高振亮
    /// </remarks>
    /// </summary>
    public class XsdmxDal : BaseDal<xsdmx>, IXsdmxDal
    {
    }
}
