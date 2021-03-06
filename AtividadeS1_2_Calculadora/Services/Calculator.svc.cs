﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AtividadeS1_2_Calculadora_Server.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Calculator" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Calculator.svc or Calculator.svc.cs at the Solution Explorer and start debugging.
    public class Calculator : ICalculator
    {

        public float Somar(float valor1, float valor2)
        {
            return valor1 + valor2;
        }

        public float Subtrair(float valor1, float valor2)
        {
            return valor1 - valor2;
        }

        public float Multiplicar(float valor1, float valor2)
        {
            return valor1 * valor2;
        }

        public float Dividir(float valor1, float valor2)
        {
            return valor1 / valor2;
        }
    }
}
