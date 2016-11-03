using Sd.IDAL;

namespace Sd.DAL
{
    /// <summary>
    /// 简单工厂
    /// <remarks>
    /// 创建：2016.03.06 高振亮<br />
    /// 修改：2016.03.06 高振亮
    /// </remarks>
    /// </summary>
    public static class DbSession
    {
        #region 系统管理
        /// <summary>
        /// 权限组
        /// <remarks>
        /// 创建：2016.10.30 高振亮<br />
        /// 修改：2016.10.30 高振亮
        /// </remarks>
        /// </summary>
        public static ICompetenceDal CompetenceDal
        {
            get
            {
                return new CompetenceDal();
            }
        }

        /// <summary>
        /// 用户
        /// <remarks>
        /// 创建：2016.10.31 高振亮<br />
        /// 修改：2016.10.31 高振亮
        /// </remarks>
        /// </summary>
        public static IUserDal UserDal
        {
            get
            {
                return new UserDal();
            }
        }

        /// <summary>
        /// 用户权限
        /// <remarks>
        /// 创建：2016.11.01 高振亮<br />
        /// 修改：2016.11.01 高振亮
        /// </remarks>
        /// </summary>
        public static IUserCompetenceDal UserCompetenceDal
        {
            get
            {
                return new UserCompetenceDal();
            }
        }

        public static IGsxxDal GsxxDal
        {
            get
            {
                return new GsxxDal();
            }
        }
        #endregion

        #region 信息系统
        /// <summary>
        /// 客户信息
        /// <remarks>
        /// 创建：2016.11.03 高振亮<br />
        /// 修改：2016.11.03 高振亮
        /// </remarks>
        /// </summary>
        public static ICustomerDal CustomerDal
        {
            get
            {
                return new CustomerDal();
            }
        }

        /// <summary>
        /// 种类表
        /// <remarks>
        /// 创建：2016.11.03 高振亮<br />
        /// 修改：2016.11.03 高振亮
        /// </remarks>
        /// </summary>
        public static IZlDal ZlDal
        {
            get
            {
                return new ZlDal();
            }
        }

        /// <summary>
        /// 销售部信息
        /// <remarks>
        /// 创建：2016.11.03 高振亮<br />
        /// 修改：2016.11.03 高振亮
        /// </remarks>
        /// </summary>
        public static IXsbxxDal XsbxxDal
        {
            get
            {
                return new XsbxxDal();
            }
        }

        /// <summary>
        /// 职员信息
        /// <remarks>
        /// 创建：2016.11.03 高振亮<br />
        /// 修改：2016.11.03 高振亮
        /// </remarks>
        /// </summary>
        public static IZyxxDal ZyxxDal
        {
            get
            {
                return new ZyxxDal();
            }
        }
        #endregion
    }
}
