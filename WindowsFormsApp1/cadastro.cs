using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Cadastro
    {
        public string pokenome;
        public int atk;
        public int hp;
        public DateTime data;
        public string pokebola;

        public bool cadastrar()
        {
            if (pokenome.Length >= 3 && atk > 0 && hp > 0)
            {
                return true ;
            }
            else
            {
                return  false;
            }
        }
    }  
}
