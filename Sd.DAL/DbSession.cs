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

        /// <summary>
        /// 销区信息
        /// <remarks>
        /// 创建：2016.11.06 高振亮<br />
        /// 修改：2016.11.06 高振亮
        /// </remarks>
        /// </summary>
        public static IXqxxDal XqxxDal
        {
            get
            {
                return new XqxxDal();
            }
        }
        
        /// <summary>
        /// 大部门信息
        /// <remarks>
        /// 创建：2016.11.06 高振亮<br />
        /// 修改：2016.11.06 高振亮
        /// </remarks>
        /// </summary>
        public static IBigDepartmentDal BigDepartmentDal
        {
            get
            {
                return new BigDepartmentDal();
            }
        }

        /// <summary>
        /// 商品信息
        /// <remarks>
        /// 创建：2016.11.11 高振亮<br />
        /// 修改：2016.11.11 高振亮
        /// </remarks>
        /// </summary>
        public static IGoodsDal GoodsDal
        {
            get
            {
                return new GoodsDal();
            }
        }

        /// <summary>
        /// 商品品牌
        /// <remarks>
        /// 创建：2016.11.11 高振亮<br />
        /// 修改：2016.11.11 高振亮
        /// </remarks>
        /// </summary>
        public static ISpPpDal SpPpDal
        {
            get
            {
                return new SpPpDal();
            }
        }

        /// <summary>
        /// 产品系列
        /// <remarks>
        /// 创建：2016.11.11 高振亮<br />
        /// 修改：2016.11.11 高振亮
        /// </remarks>
        /// </summary>
        public static ICpXlDal CpXlDal
        {
            get
            {
                return new CpXlDal();
            }
        }

        /// <summary>
        /// 产品系列类型
        /// <remarks>
        /// 创建：2016.11.11 高振亮<br />
        /// 修改：2016.11.11 高振亮
        /// </remarks>
        /// </summary>
        public static ICpXlLxDal CpXlLxDal
        {
            get
            {
                return new CpXlLxDal();
            }
        }

        /// <summary>
        /// 商品计量单位
        /// <remarks>
        /// 创建：2016.11.11 高振亮<br />
        /// 修改：2016.11.11 高振亮
        /// </remarks>
        /// </summary>
        public static IJlDwbDal JlDwbDal
        {
            get
            {
                return new JlDwbDal();
            }
        }

        /// <summary>
        /// 商品分类
        /// <remarks>
        /// 创建：2016.11.12 高振亮<br />
        /// 修改：2016.11.12 高振亮
        /// </remarks>
        /// </summary>
        public static ISpflDal SpflDal
        {
            get
            {
                return new SpflDal();
            }
        }

        /// <summary>
        /// 产品规格
        /// <remarks>
        /// 创建：2016.11.13 高振亮<br />
        /// 修改：2016.11.13 高振亮
        /// </remarks>
        /// </summary>
        public static IGgxxbDal GgxxbDal
        {
            get
            {
                return new GgxxbDal();
            }
        }

        /// <summary>
        /// 供货商信息
        /// <remarks>
        /// 创建：2016.11.13 高振亮<br />
        /// 修改：2016.11.13 高振亮
        /// </remarks>
        /// </summary>
        public static IGhsxxDal GhsxxDal
        {
            get
            {
                return new GhsxxDal();
            }
        }
        #endregion
        #region 销售系统
        /// <summary>
        /// 销售单
        /// <remarks>
        /// 创建：2016.11.30 高振亮<br />
        /// 修改：2016.11.30 高振亮
        /// </remarks>
        /// </summary>
        public static IXsdDal XsdDal
        {
            get
            {
                return new XsdDal();
            }
        }

        /// <summary>
        /// 销售单明细
        /// <remarks>
        /// 创建：2016.11.30 高振亮<br />
        /// 修改：2016.11.30 高振亮
        /// </remarks>
        /// </summary>
        public static IXsdmxDal XsdmxDal
        {
            get
            {
                return new XsdmxDal();
            }
        }
        #endregion
    }
}
