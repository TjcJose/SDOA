//-----------------------------------------------
// 数据层
// 系统管理
// 创建：2016.10.30 高振亮
// 修改：2016.10.30 高振亮
//-----------------------------------------------

using Sd.IDAL;
using Sd.Model;

namespace Sd.DAL
{
    /// <summary>
    /// 权限组类  
    /// <remarks>
    /// 创建：2016.10.30 高振亮
    /// 修改：2016.10.30 高振亮
    /// </remarks>
    /// </summary>
    public class CompetenceDal : BaseDal<CompetenceSet>, ICompetenceDal
    {
    }

    /// <summary>
    /// 用户类  
    /// <remarks>
    /// 创建：2016.10.31 高振亮
    /// 修改：2016.10.31 高振亮
    /// </remarks>
    /// </summary>
    public class UserDal : BaseDal<password>, IUserDal
    {
    }

    /// <summary>
    /// 用户权限类  
    /// <remarks>
    /// 创建：2016.11.01 高振亮
    /// 修改：2016.11.01 高振亮
    /// </remarks>
    /// </summary>
    public class UserCompetenceDal : BaseDal<UserCompetence>, IUserCompetenceDal
    {
    }
}
