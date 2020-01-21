using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//libs
using MiAppDesk.Model;

namespace MiAppDesk.Controller
{
    class C_Sesion
    {
        public static string Usuario;
        public static string Clave;
        public static string rol = "1";
        public void resp()
        {
            M_Sesion obj = new M_Sesion();
            obj.login();
        }
    }
}
