using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Referencias
using MiAppDesk.Model;


namespace MiAppDesk.Controller
{
    public class C_Ciudad
    {
        private int _ID;
        private string _Ciudad;
        private string _Departamento;
        //Variables státicas
        public static int IdCiudad;
        public static int IdDepto;
        

        //Instanciar
        M_Ciudad obj = new M_Ciudad();

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

        public string Departamento
        {
            get
            {
                return _Departamento;
            }

            set
            {
                _Departamento = value;
            }
        }
        
        //Metodos de CRUD
        public List<C_Ciudad> Listado(string buscar)
        {
            return obj.ListarI(buscar);
        }
        public void Insertar(C_Ciudad dato)
        {
            obj.Insertar(dato);
        }
        public void Editar(C_Ciudad dato)
        {
            obj.Editar(dato);
        }
        public void Eliminar(C_Ciudad dato)
        {
            obj.Eliminar(dato);
        }
        
    }
}
