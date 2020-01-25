using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Referencias
using MiAppDesk.Model;
using System.Globalization;

namespace MiAppDesk.Controller
{
    public class C_Item
    {
        private int _ID;
        private string _Nombre;
        private double _Precio;
        private string _Fabricante;
        private string _Unidad;
        private string _Tipo;

        public static int IdTipo;
        public static int IdItem;
        //private int IdTi
        
        public static string nom; 
        public static string pre;
        public static string fab;
        public static string uni;
        public static string tip;

        /// <summary>
        /// Getters and Settes By: Colque
        /// </summary>
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

        public double Precio
        {
            get
            {
                return _Precio;
            }
            set
            {
                _Precio = value;
            }
        }

        public string Fabricante
        {
            get
            {
                return _Fabricante;
            }
            set
            {
                _Fabricante = value;
            }
        }

        public string Unidad
        {
            get
            {
                return _Unidad;
            }
            set
            {
                _Unidad = value;
            }
        }

        public string Tipo
        {
            get
            {
                return _Tipo;
            }
            set
            {
                _Tipo = value;
            }
        }

        /*public int IdTipo
        {
            get
            {
                return _IdTipo;
            }
            set
            {
                _IdTipo = value;
            }
        }*/
        //Instancias
        //Instanciar
        M_Item obj = new M_Item();
        
        //Metodos de CRUD
        public List<C_Item> Listado(string buscar)
        {
            return obj.ListarI(buscar);
        }
        public void Insertar(C_Item dato)
        {
            obj.Insertar(dato);
        }
        public void Editar(C_Item dato)
        {
            obj.Editar(dato);
        }
        public void Eliminar(C_Item dato)
        {
            obj.Eliminar(dato);
        }

    }
}
