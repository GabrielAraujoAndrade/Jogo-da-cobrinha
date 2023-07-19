using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Jogo_da_cobrinha
{
    internal class Configs
    {   
        public static int Largura { get; set; }
        public static int Altura { get; set; }

        public static string Direcoes;

        public Configs()
        {
            Largura = Altura = 16;
            Direcoes = "esq";
                
        }
    }
}
