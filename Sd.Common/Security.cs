//-----------------------------------------------
// 公共类
// 安全相关类
// 创建：2016.12.22 高振亮
// 修改：2016.12.22 高振亮
//-----------------------------------------------

namespace Sd.Common
{
    public class Security
    {
        /// <summary>
        /// 加密算法
        /// </summary>
        /// <param name="strPwd">加密前字符串</param>
        /// <returns>加密后字符串</returns>
        public static string Encode(string strPwd)
        {
            return BCrypt.Net.BCrypt.HashPassword(strPwd, BCrypt.Net.BCrypt.GenerateSalt());
        }
        /// <summary>
        /// 密码校对
        /// </summary>
        /// <param name="strPwd">密码</param>
        /// <param name="strEncode">加密后字符串</param>
        /// <returns>是否匹配</returns>
        public static bool Check(string strPwd, string strEncode)
        {
            return BCrypt.Net.BCrypt.Verify(strPwd, strEncode);
        }
    }
}
