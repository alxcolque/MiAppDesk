using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Referencias
using MiAppDesk.Model;


namespace MiAppDesk.Controller
{
    public class C_Sucursal
    {
        private int _ID;
        private string _Nombre;
        private string _Ciudad;
        private string _Direccion;
        private string _NIT;

        
        //Variables státicas
        public static int IdDepto;
        public static int IdCiudad;
        public static int IdUbi;
        //Instanciar
        M_Sucursal obj = new M_Sucursal();
        M_Ciudad obj1 = new M_Ciudad();

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

        public string Ciudad
        {
            get
            {
                return _Ciudad;
            }

            set
            {
                _Ciudad = value;
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

        public string NIT
        {
            get
            {
                return _NIT;
            }

            set
            {
                _NIT = value;
            }
        }
        //Metodos de CRUD
        public List<C_Sucursal> Listado(string buscar)
        {
            return obj.ListarI(buscar);
        }
        public void Insertar(C_Sucursal dato)
        {
            obj.Insertar(dato);
        }
        public void Editar(C_Sucursal dato)
        {
            obj.Editar(dato);
        }
        public void Eliminar(C_Sucursal dato)
        {
            obj.Eliminar(dato);
        }
        

    }
}
