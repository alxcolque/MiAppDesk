using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Referencias
using MiAppDesk.Model;


namespace MiAppDesk.Controller
{
    public class C_CiudadCombo
    {
        //Combo ciudad
        private int _IdCi;
        private string _NombreCi;
        M_Ciudad obj1 = new M_Ciudad();

        public int IdCi
        {
            get
            {
                return _IdCi;
            }

            set
            {
                _IdCi = value;
            }
        }

        public string NombreCi
        {
            get
            {
                return _NombreCi;
            }

            set
            {
                _NombreCi = value;
            }
        }

        //Metodo Listar ciudades para combobox
        public List<C_CiudadCombo> ListC(string buscar)
        {
            return obj1.ListarC(buscar);
        }
    }
}
