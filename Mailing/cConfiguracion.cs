using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mailing
{
    public static class cConfiguracion
    {
        static string mailEmisor = "";
        static bool EnableSsl = false;
        static string password = "";
        static string _serverHost = null;
        static int _puerto = 0;
        static bool _esHTML = true;
        static string _nombreEmisor = "";

        public static string NombreEmisor
        {
            get { return cConfiguracion._nombreEmisor; }
            set { cConfiguracion._nombreEmisor = value; }
        }
        public static string MailEmisor
        {
            get { return cConfiguracion.mailEmisor; }
            set { cConfiguracion.mailEmisor = value; }
        }

        public static string Password
        {
            get { return cConfiguracion.password; }
            set { cConfiguracion.password = value; }
        }
        

        public static bool EnableSsl1
        {
            get { return cConfiguracion.EnableSsl; }
            set { cConfiguracion.EnableSsl = value; }
        }
        

        public static bool EsHTML
        {
            get { return cConfiguracion._esHTML; }
            set { cConfiguracion._esHTML = value; }
        }
        
        
        
        public static int Puerto
        {
            get { return cConfiguracion._puerto; }
            set { cConfiguracion._puerto = value; }
        }//19
       
        public static string ServerHost
        {
            get { return cConfiguracion._serverHost; }
            set {
                
                cConfiguracion._serverHost = value; }
        }
       
        
    }
}
