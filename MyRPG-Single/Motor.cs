using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRPG_Single
{
    interface Motor
    {
        int id { get; set; }
        bool seleccion { get; set; }
        void Atacar(string arma1, string arma2, string personaje);
    }
}
