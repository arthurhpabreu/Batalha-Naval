using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatalhaNaval
{
    class Jogador
    {
        private string nome;
        private int pontos;
        public Jogador()
        {

        }
        public int Pontos
        {
            get
            {
                return pontos;
            }
            set
            {
                pontos = value;
            }
        }
        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }
    }
}
