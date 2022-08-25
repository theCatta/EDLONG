using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Disciplina
    {
        private int id;
        private string descricao;
        private Aluno[] alunos;

        public int Id { get => id; set => id = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        internal Aluno[] Alunos { get => alunos; set => alunos = value; }


        public Disciplina()
        {
            alunos = new Aluno[15];
            /*
            for (int i = 0; i < alunos.Length; i++)
            {
                alunos[i] = new Aluno();
            */
        }
        
        Disciplina(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
        }

        public bool MatricularAluno(Aluno aluno)
        {

        }

        public bool DesmatricularAluno(Aluno aluno)
        {

        }
    }
}
