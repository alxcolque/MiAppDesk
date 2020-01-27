using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Referencias------------------Alekis COL
using MiAppDesk.Model;

namespace MiAppDesk.Controller
{
    public class C_Cliente
    {
        private int _ID;
        private string _Nombre;
        private string _Telefono;
        private string _Direccion;
        //Variables státicas
        public static int IdCli;
        public static string nom;
        public static string tel;
        public static string dir;
        //Instanciar
        M_Cliente obj = new M_Cliente();

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

        public string Telefono
        {
            get
            {
                return _Telefono;
            }

            set
            {
                _Telefono = value;
            }
        }

        public string Direccion
        {
            get
            {
                return _Direccion;
            }

            set
            {
                _Direccion = value;
            }
        }
        //Metodos de CRUD
        public List<C_Cliente> Listado(string buscar)
        {
            return obj.ListarI(buscar);
        }
        public void Insertar(C_Cliente dato)
        {
            obj.Insertar(dato);
        }
        public void Editar(C_Cliente dato)
        {
            obj.Editar(dato);
        }
        public void Eliminar(C_Cliente dato)
        {
            obj.Eliminar(dato);
        }

    }
}
