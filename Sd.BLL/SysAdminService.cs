// 业务层
// 系统管理
// 创建：2016.10.30 高振亮

using Sd.DAL;
using Sd.IBLL;
using Sd.Model;

namespace Sd.BLL
{
    /// <summary>
    /// 权限组类
    /// <remarks>
    /// 创建：2016.10.30 高振亮
    /// 修改：2016.10.30 高振亮
    /// </remarks>
    /// </summary>
    public class CompetenceService : BaseService<CompetenceSet>, ICompetenceService
    {
        public CompetenceService() : base(DbSession.CompetenceDal) { }
    }

    /// <summary>
    /// 用户类
    /// <remarks>
    /// 创建：2016.10.31 高振亮
    /// 修改：2016.10.31 高振亮
    /// </remarks>
    /// </summary>
    public class UserService : BaseService<password>, IUserService
    {
        public UserService() : base(DbSession.UserDal) { }
    }

    /// <summary>
    /// 用户权限类
    /// <remarks>
    /// 创建：2016.11.01 高振亮
    /// 修改：2016.11.01 高振亮
    /// </remarks>
    /// </summary>
    public class UserCompetenceService : BaseService<UserCompetence>, IUserCompetenceService
    {
        public UserCompetenceService() : base(DbSession.UserCompetenceDal) { }
    }
}
