//-----------------------------------------------
// 数据层
// 在途系统
// 创建：2017.01.08 高振亮
// 修改：2017.01.08 高振亮
//-----------------------------------------------

using Sd.IDAL;
using Sd.Model;

namespace Sd.DAL
{
    /// <summary>
    /// 在途运输单
    /// <remarks>
    /// 创建：2017.01.08 高振亮
    /// 修改：2017.01.08 高振亮
    /// </remarks>
    /// </summary>
    public class ZtysdDal : BaseDal<zt_ysd>, IZtysdDal
    {
    }
    /// <summary>
    /// 在途运输单明细
    /// <remarks>
    /// 创建：2017.01.08 高振亮
    /// 修改：2017.01.08 高振亮
    /// </remarks>
    /// </summary>
    public class ZtysdmxDal : BaseDal<zt_ysdmx>, IZtysdmxDal
    {
    }
}
