using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Referencias------------------Alekis COL
using MiAppDesk.Model;

namespace MiAppDesk.Controller
{
    public class C_Inicio
    {
        private int _IDIT;
        private int _IDCL;
        private int _IDSU;
        private int _TipoOrden;
        private string _Producto;
        private int _Cantidad;
        private double _Precio;
        //Variables státicas
        public static string prod;
        public static int idit;
        public static string idcl;//combo
        public static int cant;
        public static int tipo;
        //Instanciar
        M_Inicio obj = new M_Inicio();

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

        public int IDCL
        {
            get
            {
                return _IDCL;
            }

            set
            {
                _IDCL = value;
            }
        }

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

        public int TipoOrden
        {
            get
            {
                return _TipoOrden;
            }

            set
            {
                _TipoOrden = value;
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
        //Metodos de CRUD
        public List<C_Inicio> Listado(string buscar)
        {
            return obj.ListarI(buscar);
        }
        public void Insertar(C_Inicio dato)
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
