using System.Data.Entity;
using EntityFramework.Extensions;
using System.Runtime.Remoting.Messaging;

namespace Sd.DAL
{
    /// <summary>
    /// 数据层
    /// 获取当前数据上下文
    /// 创建：2016.03.05 高振亮
    /// 修改：2016.03.05 高振亮
    /// </summary>
    class DbContextFactory
    {
        /// <summary>
        /// 获取当前数据上下文
        /// </summary>
        /// <returns></returns>
        public static DbContext GetCurrentContext()
        {
            
            var dContext = CallContext.GetData("SdContext") as DbContext;
            if (dContext != null) return dContext;
            dContext = new DbContext("SdEntities");
            CallContext.SetData("SdContext", dContext);
            return dContext;
        }

        public static DbContext ResetCurrentContext()
        {
            var dContext = new DbContext("SdEntities");
            CallContext.SetData("SdContext", dContext);
            return dContext;
        }
    }
}
