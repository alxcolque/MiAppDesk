using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Referencias
using MiAppDesk.Model;

namespace MiAppDesk.Controller
{
    public class C_Rol
    {
        private int _ID;
        private string _Nombre;
        //Instanciar
        M_Rol obj = new M_Rol();
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
        //Metodos de CRUD
        public List<C_Rol> Listado(string buscar)
        {
            return obj.ListarI(buscar);
        }
        public void Insertar(C_Rol dato)
        {
            obj.Insertar(dato);
        }
        public void Editar(C_Rol dato)
        {
            obj.Editar(dato);
        }
        public void Eliminar(C_Rol dato)
        {
            obj.Eliminar(dato);
        }
    }
}
