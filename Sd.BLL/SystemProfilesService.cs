using System;
using Sd.DAL;
using Sd.IBLL;
using Sd.Model;

namespace Sd.BLL
{
    /// <summary>
    /// 业务层
    /// 公司信息类
    /// <remarks>
    /// 创建：2016.07.06 高振亮
    /// 修改：2016.07.06 高振亮
    /// </remarks>
    /// </summary>
    public class GsxxService : BaseService<gsxx>, IGsxxService
    {
        public GsxxService() : base(DbSession.GsxxDal) { }
    }
}
