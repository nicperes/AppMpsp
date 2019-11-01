using System;
using Xamarin.Forms;

[assembly: Dependency(typeof(AppMPSP.Droid.Layers.Data.Config.DBConfig))]
namespace AppMPSP.Droid.Layers.Data.Config
{
    public class DBConfig
    {
        private String _path;
        public String Path {
            get
            {
                if ( String.IsNullOrEmpty(_path)) {
                   _path = 
                       System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                }
                return _path;
            }
        }
    }
}
