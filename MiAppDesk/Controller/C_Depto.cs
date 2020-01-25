using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Referencias
using MiAppDesk.Model;


namespace MiAppDesk.Controller
{
    public class C_Depto
    {
        //Llenar Combobox
        private int _IdD;
        private string _NombreD;
        //Instanciar
        M_Depto obj = new M_Depto();
        //De departamento
        public int IdD
        {
            get
            {
                return _IdD;
            }

            set
            {
                _IdD = value;
            }
        }

        public string NombreD
        {
            get
            {
                return _NombreD;
            }

            set
            {
                _NombreD = value;
            }
        }
        //LLenado de Combo
        public List<C_Depto> ListCombo(string buscar)
        {
            return obj.ListarCombo(buscar);
        }

    }
}
