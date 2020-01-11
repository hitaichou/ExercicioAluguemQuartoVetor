using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioAluguemQuartoVetor
{
    class Pensao
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        //public int Quarto { get; set; }

        //construtor
        public Pensao(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        //Sobreposição
        public override string ToString()
        {
            return Nome + ", " + Email;
        }
    }
}
