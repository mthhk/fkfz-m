using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace cms_m.utils
{
    public class FileUtil
    {
        public static String GetFileNameFromPath(String absPath)
        {
            FileInfo info = new FileInfo(absPath);
            if (info.Exists)
            {
                return info.Name;
            }

            return null;
        }
    }
}
