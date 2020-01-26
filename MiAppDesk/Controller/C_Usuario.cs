using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Referencias------------------Alekis COL
using MiAppDesk.Model;

namespace MiAppDesk.Controller
{
    public class C_Usuario
    {
        private int _ID;
        private string _Nombre;
        private string _Usuario;
        private string _Clave;
        private string _Cargo;
        //Variables státicas
        public static int IdUsuario;
        public static int IdRol;
        public static string nom;
        public static string usu;
        public static string cla;

        //Instanciar
        M_Rol obj1 = new M_Rol();
        M_Usuario obj = new M_Usuario();

        public int ID
        {
            get
            {
                return _ID;
            }

            set
            {
                _ID = value;
            }
        }

        public string Nombre
        {
            get
            {
                return _Nombre;
            }

            set
            {
                _Nombre = value;
            }
        }

        public string Usuario
        {
            get
            {
                return _Usuario;
            }

            set
            {
                _Usuario = value;
            }
        }

        public string Clave
        {
            get
            {
                return _Clave;
            }

            set
            {
                _Clave = value;
            }
        }

        public string Cargo
        {
            get
            {
                return _Cargo;
            }

            set
            {
                _Cargo = value;
            }
        }
        //Metodos de CRUD
        public List<C_Usuario> Listado(string buscar)
        {
            return obj.ListarI(buscar);
        }
        public void Insertar(C_Usuario dato)
        {
            obj.Insertar(dato);
        }
        public void Editar(C_Usuario dato)
        {
            obj.Editar(dato);
        }
        public void Eliminar(C_Usuario dato)
        {
            obj.Eliminar(dato);
        }

    }
}
