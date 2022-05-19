using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine


{
    public class Application
    {
        public static string windows_persistentDataPath
        {
            get { return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "AppData", "LocalLow", "Crows Crows Crows", "The Stanley Parable_ Ultra Deluxe");}
        }


        public static string parallels_persistentDataPath
        {
            get { return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyComputer) , "Y:", "Library", "Application Support", "com.crowscrowscrows.thestanleyparableultradeluxe"); }
        }
    }
}
