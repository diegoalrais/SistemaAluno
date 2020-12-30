using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGA.ApplicationCore.Entity
{
    class Aluno
    {
        public Aluno()
        {

        }

        public int AlunoId { get; set; }
        
        public string Nome { get; set; }

        public int DataNascimento { get; set; }

        public string Ano { get; set; }

        public char Turma { get; set; }

    }
}
