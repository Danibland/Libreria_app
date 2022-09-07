using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBRERIA
{
    public class Usuario
    {
        private string _usuario;
        private int _rol;

        public string usuario 
        {
            get 
            {
                return _usuario;
            }
            set 
            {
                _usuario = value;
            } 
        }
        public int rol 
        {
            get
            {
                return _rol;
            }
            set
            {
                _rol = value;
            }
        }

        public Usuario()
        {

        }
    }
}
