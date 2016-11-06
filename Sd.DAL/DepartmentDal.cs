//-----------------------------------------------
// 数据层
// 信息系统-部门
// 创建：2016.11.03 高振亮
// 修改：2016.11.03 高振亮
//-----------------------------------------------

using Sd.IDAL;
using Sd.Model;

namespace Sd.DAL
{
    /// <summary>
    /// 销售部信息类  
    /// <remarks>
    /// 创建：2016.11.03 高振亮
    /// 修改：2016.11.03 高振亮
    /// </remarks>
    /// </summary>
    public class XsbxxDal : BaseDal<xsbxx>, IXsbxxDal
    {
    }

    /// <summary>
    /// 职员信息  
    /// <remarks>
    /// 创建：2016.11.03 高振亮
    /// 修改：2016.11.03 高振亮
    /// </remarks>
    /// </summary>
    public class ZyxxDal : BaseDal<zyxx>, IZyxxDal
    {
    }

    /// <summary>
    /// 销区信息  
    /// <remarks>
    /// 创建：2016.11.06 高振亮
    /// 修改：2016.11.06 高振亮
    /// </remarks>
    /// </summary>
    public class XqxxDal : BaseDal<xqxx>, IXqxxDal
    {
    }
}
