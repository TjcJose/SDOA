//-----------------------------------------------
// 公共类
// 字符相关类
// 创建：2016.11.05 高振亮
// 修改：2016.10.05 高振亮
//-----------------------------------------------

using System;
using System.Security.Cryptography;
using System.Text;
using Microsoft.International.Converters.PinYinConverter;

namespace Sd.Common
{
    public class StringUtil
    {
        /// <summary> 
        /// 汉字转化为拼音首字母
        /// </summary> 
        /// <param name="str">汉字</param> 
        /// <returns>首字母</returns> 
        public static string GetFirstPinyin(string str)
        {
            string r = string.Empty;
            foreach (char obj in str)
            {
                try
                {
                    
                    var chineseChar = new ChineseChar(obj);
                    var t = chineseChar.Pinyins[0];
                    r += t.Substring(0, 1);
                }
                catch
                {
                    r += obj.ToString();
                }
            }
            return r;
        }

        /// <summary>
        /// MD5 64位加密
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static string Md5Encrypt64(string password)
        {
            var cl = password;
            //string pwd = "";
            var md5 = MD5.Create(); //实例化一个md5对像
            // 加密后是一个字节类型的数组，这里要注意编码UTF8/Unicode等的选择　
            var s = md5.ComputeHash(Encoding.UTF8.GetBytes(cl));
            return Convert.ToBase64String(s);
        }

        public static string StrTrimEnd(string str)
        {
            return str == null ? "" : str.TrimEnd();
        }
    }
}
