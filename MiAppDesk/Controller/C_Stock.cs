using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Referencias------------------Alekis COL
using MiAppDesk.Model;

namespace MiAppDesk.Controller
{
    public class C_Stock
    {
        private int _IDSU;
        private int _IDIT;
        private string _Producto;
        private int _Cantidad;
        private string _Fecha;
        private string _Sucursal;
        //Variables státicas

        public static int suc;
        public static int pro;
        public static int can;
        //Instanciar
        M_Stock obj = new M_Stock();

        public int IDSU
        {
            get
            {
                return _IDSU;
            }

            set
            {
                _IDSU = value;
            }
        }

        public int IDIT
        {
            get
            {
                return _IDIT;
            }

            set
            {
                _IDIT = value;
            }
        }

        public string Producto
        {
            get
            {
                return _Producto;
            }

            set
            {
                _Producto = value;
            }
        }

        public int Cantidad
        {
            get
            {
                return _Cantidad;
            }

            set
            {
                _Cantidad = value;
            }
        }

        public string Fecha
        {
            get
            {
                return _Fecha;
            }

            set
            {
                _Fecha = value;
            }
        }

        public string Sucursal
        {
            get
            {
                return _Sucursal;
            }

            set
            {
                _Sucursal = value;
            }
        }




        //Metodos de CRUD
        public List<C_Stock> Listado(string buscar)
        {
            return obj.ListarI(buscar);
        }
        public void Insertar(C_Stock dato)
        {
            obj.Insertar(dato);
        }
        /*public void Editar(C_Stock dato)
        {
            obj.Editar(dato);
        }*/
        public void Eliminar()
        {
            obj.Eliminar();
        }
    }
}
