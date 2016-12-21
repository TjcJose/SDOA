//-----------------------------------------------
// 共通系统-打印
// 打印设置
// 创建：2016.12.13 高振亮
// 修改：2016.12.13 高振亮
//-----------------------------------------------

using System.Collections;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Sd.UI.Properties;

namespace Sd.UI.Common
{
    public class ComPrint
    {
        //声明一个Stream对象的列表用来保存报表的输出数据
        //LocalReport对象的Render方法会将报表按页输出为多个Stream对象。
        private List<Stream> _mStreams;

        //用来记录当前打印到第几页了
        private int _mCurrentPageIndex;

        public void Run(string strRdlcName, string strRdlcDsName, IEnumerable printDs)
        {
            var report = new LocalReport();
            //设置需要打印的报表的文件名称。
            report.ReportPath = report.ReportPath = System.AppDomain.CurrentDomain.BaseDirectory + "rdlc\\" + strRdlcName;
            //创建要打印的数据源
            report.DataSources.Add(new ReportDataSource(strRdlcDsName, printDs));
            //刷新报表中的需要呈现的数据
            report.Refresh();

            string deviceInfo =
              "<DeviceInfo>" +
              "  <OutputFormat>EMF</OutputFormat>" +
              "  <PageWidth>8.5in</PageWidth>" +
              "  <PageHeight>11in</PageHeight>" +
              "  <MarginTop>0.25in</MarginTop>" +
              "  <MarginLeft>0.25in</MarginLeft>" +
              "  <MarginRight>0.25in</MarginRight>" +
              "  <MarginBottom>0.25in</MarginBottom>" +
              "</DeviceInfo>";
            Warning[] warnings;

            _mStreams = new List<Stream>();

            report.Render("Image", deviceInfo, CreateStream, out warnings);

            Print();
        }

        //用来提供Stream对象的函数，用于LocalReport对象的Render方法的第三个参数。
        private Stream CreateStream(string name, string fileNameExtension,
            Encoding encoding, string mimeType, bool willSeek)
        {
            //如果需要将报表输出的数据保存为文件，请使用FileStream对象。
            Stream stream = new MemoryStream();
            _mStreams.Add(stream);
            return stream;
        }

        private void Print()
        {
            _mCurrentPageIndex = 0;

            if (_mStreams == null || _mStreams.Count == 0)
                return;
            //声明PrintDocument对象用于数据的打印
            PrintDocument printDoc = new PrintDocument();
            //指定需要使用的打印机的名称，使用空字符串""来指定默认打印机
            //printDoc.PrinterSettings.PrinterName = "";
            //判断指定的打印机是否可用
            if (!printDoc.PrinterSettings.IsValid)
            {
                MessageBox.Show(MsgResx.print_noprinter);
                return;
            }
            //声明PrintDocument对象的PrintPage事件，具体的打印操作需要在这个事件中处理。
            printDoc.PrintPage += PrintPage;
            //执行打印操作，Print方法将触发PrintPage事件。
            printDoc.Print();
        }

        private void PrintPage(object sender, PrintPageEventArgs ev)
        {
            //Metafile对象用来保存EMF或WMF格式的图形，
            //我们在前面将报表的内容输出为EMF图形格式的数据流。
            _mStreams[_mCurrentPageIndex].Position = 0;
            Metafile pageImage = new Metafile(_mStreams[_mCurrentPageIndex]);
            //指定是否横向打印
            ev.PageSettings.Landscape = false;
            //这里的Graphics对象实际指向了打印机
            ev.Graphics.DrawImage(pageImage, 0, 0);
            _mStreams[_mCurrentPageIndex].Close();
            _mCurrentPageIndex++;
            //设置是否需要继续打印
            ev.HasMorePages = (_mCurrentPageIndex < _mStreams.Count);
        }
    }
}
