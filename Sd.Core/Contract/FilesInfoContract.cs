using System.Collections.Generic;

namespace Sd.Core.Contract
{
    public class FilesInfoContract
    {
        private IList<FileUnit> allFileInfoList = new List<FileUnit>();
        public IList<FileUnit> AllFileInfoList
        {
            get { return allFileInfoList; }
            set { allFileInfoList = value; }
        }

    }
}
