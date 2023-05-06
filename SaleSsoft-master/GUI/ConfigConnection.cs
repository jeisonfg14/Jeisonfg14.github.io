using System;
using System.Collections.Generic;
using System.Text;

using System.Configuration;

namespace PresentacionGUI
{
    public static class ConfigConnection
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
    }
}

