﻿using System;
using System.Collections.Generic;
using System.Text;

namespace exercicioAumento
{
    class Funcionario
    {

        public int id { get; set; }



        public string nome { get; set; }
        public double salario { get; set; }

        public void setSalario(double salario)
        {
            this.salario = salario;
        }

        public double getSalario()
        {
            return this.salario;
        }

    }
}
