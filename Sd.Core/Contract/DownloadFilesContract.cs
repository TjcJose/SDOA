namespace Sd.Core.Contract
{
    public class DownloadFileContract
    {
        private string fileName;

        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }
    }
}
