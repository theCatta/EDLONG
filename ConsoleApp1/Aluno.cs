﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Aluno
    {
        private int id;
        private string name;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        public Aluno(int id, string name)
        {
            Id= id;
            Name = name;
        }

        public bool PodeMatricular(Curso curso)
        {

        }

    }
}
