//-----------------------------------------------
// 公共类
// 字符相关类
// 创建：2016.11.05 高振亮
// 修改：2016.10.05 高振亮
//-----------------------------------------------

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
    }
}
