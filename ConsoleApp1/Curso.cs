using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Curso
    {
        private int id;
        private string descricao;
        private Disciplina[] disciplinas;

        public int Id { get => id; set => id = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public Disciplina[] Disciplinas { get => disciplinas; set => disciplinas = value; }

        public Curso(int id)
        {
            Id = id;
            disciplinas = new Disciplina[12];
            for(int i = 0; i < 12; i++)
            {
                disciplinas[i] = new Disciplina();
            }
        }
        
        public Curso(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
        }

        public bool AdicionarDisciplina(Disciplina disciplina)
        {

        }

        public Disciplina PesquisarDisciplina(Disciplina disciplina)
        {

        }

        public bool RemoverDisciplina(Disciplina disciplina)
        {

        }
    }
}
