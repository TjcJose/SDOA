using System;
using System.IO;
using System.Windows.Forms;
using Sd.UI.Properties;

namespace Sd.UI
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginFrm());*/

            try
            {
                //处理未捕获的异常  
                Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
                //处理UI线程异常  
                Application.ThreadException += Application_ThreadException;
                //处理非UI线程异常  
                AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new LoginFrm());
            }
            catch (Exception ex)
            {
                var strDateInfo = "出现应用程序未处理的异常：" + DateTime.Now + "\r\n";
                var str = string.Format(strDateInfo + "异常类型：{0}\r\n异常消息：{1}\r\n异常信息：{2}\r\n",
                    ex.GetType().Name, ex.Message, ex.StackTrace);

                WriteLog(str);
                //frmBug f = new frmBug(str);//友好提示界面
                //f.ShowDialog();
                MessageBox.Show("发生致命错误，请及时联系作者！", ComValueResx.confrim, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///这就是我们要在发生未处理异常时处理的方法，我这是写出错详细信息到文本，如出错后弹出一个漂亮的出错提示窗体，给大家做个参考
        ///做法很多，可以是把出错详细信息记录到文本、数据库，发送出错邮件到作者信箱或出错后重新初始化等等
        ///这就是仁者见仁智者见智，大家自己做了。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {

            string str;
            var strDateInfo = "出现应用程序未处理的异常：" + DateTime.Now + "\r\n";
            var error = e.Exception;

            if (error != null)
            {
                if ("The underlying provider failed on Open.".Equals(e.Exception.Message))
                {
                   
                    MessageBox.Show("服务器连接错误，请确认网络是否连接！", ComValueResx.confrim, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                str = string.Format(strDateInfo + "异常类型：{0}\r\n异常消息：{1}\r\n异常信息：{2}\r\n",
                    error.GetType().Name, error.Message, error.StackTrace);
            }
            else
            {
                str = string.Format("应用程序线程错误:{0}", e);
            }
            WriteLog(str);
            //frmBug f = new frmBug(str);//友好提示界面
            //f.ShowDialog();
            MessageBox.Show("发生致命错误，请及时联系作者！", ComValueResx.confrim, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            string str;
            var error = e.ExceptionObject as Exception;
            var strDateInfo = "出现应用程序未处理的异常：" + DateTime.Now + "\r\n";
            if (error != null)
            {
                str = string.Format(strDateInfo + "Application UnhandledException:{0};\n\r堆栈信息:{1}", error.Message,
                    error.StackTrace);
            }
            else
            {
                str = string.Format("Application UnhandledError:{0}", e);
            }
            WriteLog(str);
//frmBug f = new frmBug(str);//友好提示界面
            //f.ShowDialog();
            MessageBox.Show("发生致命错误，请停止当前操作并及时联系作者！", ComValueResx.confrim, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// 写文件
        /// </summary>
        /// <param name="str"></param>
        static void WriteLog(string str)
        {
            if (!Directory.Exists("ErrLog"))
            {
                Directory.CreateDirectory("ErrLog");
            }

            var logPath =
                Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf(@"\", StringComparison.Ordinal)) +
                @"\ErrLog\";

            if (!Directory.Exists(logPath))//若文件夹不存在则新建文件夹   
            {
                Directory.CreateDirectory(logPath); //新建文件夹   
            }

            using (var sw = new StreamWriter(logPath + @"ErrLog.txt", true))
            {
                sw.WriteLine(str);
                sw.WriteLine("---------------------------------------------------------");
                sw.Close();
            }
        }
    }
}
