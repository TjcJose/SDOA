// 业务层接口
// 系统管理
// 创建：2016.10.30 高振亮

using Sd.Model;

namespace Sd.IBLL
{
    /// <summary>
    /// 权限组类  
    /// <remarks>
    /// 创建：2016.10.30 高振亮
    /// 修改：2016.10.30 高振亮
    /// </remarks>
    /// </summary>
    public interface ICompetenceService : IBaseService<CompetenceSet>
    {
    }

    /// <summary>
    /// 用户类(操作员)  
    /// <remarks>
    /// 创建：2016.10.31 高振亮
    /// 修改：2016.10.31 高振亮
    /// </remarks>
    /// </summary>
    public interface IUserService : IBaseService<password>
    {
    }

    /// <summary>
    /// 用户权限类
    /// <remarks>
    /// 创建：2016.11.01 高振亮
    /// 修改：2016.11.01 高振亮
    /// </remarks>
    /// </summary>
    public interface IUserCompetenceService : IBaseService<UserCompetence>
    {
    }
}
