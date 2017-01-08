//-----------------------------------------------
// 数据层
// 报表系统
// 创建：2017.01.03 高振亮
// 修改：2017.01.03 高振亮
//-----------------------------------------------

using Sd.IDAL;
using Sd.Model;

namespace Sd.DAL
{
    /// <summary>
    /// 进款单  
    /// <remarks>
    /// 创建：2017.01.03 高振亮
    /// 修改：2017.01.03 高振亮
    /// </remarks>
    /// </summary>
    public class JkdsrDal : BaseDal<jkdsr>, IJkdsrDal
    {
    }

    /// <summary>
    /// 付款单  
    /// <remarks>
    /// 创建：2017.01.03 高振亮
    /// 修改：2017.01.03 高振亮
    /// </remarks>
    /// </summary>
    public class FkdsrDal : BaseDal<fkdsr>, IFkdsrDal
    {
    }
}
