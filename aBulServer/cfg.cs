using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aBulServer
{
    public static class cfg
    {
        private static string path2db = "C:/db/";
        private static string path2users = path2db+"users/";
        private static string passwordListFile = path2db +"password.txt";
        private static string loginListFile = path2db+ "login.txt";
        private static string logPassListFile = path2db+ "logpass.txt";
        public static string Path2db { get => path2db; set => path2db = value; }
        public static string Path2users { get => path2users; set => path2users = value; }
        public static string PasswordListFile { get => passwordListFile; set => passwordListFile = value; }
        public static string LoginListFile { get => loginListFile; set => loginListFile = value; }
        public static string LogPassListFile { get => logPassListFile; set => logPassListFile = value; }
    }
}