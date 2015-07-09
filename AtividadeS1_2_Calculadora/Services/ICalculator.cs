using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AtividadeS1_2_Calculadora_Server.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICalculator" in both code and config file together.
    [ServiceContract]
    public interface ICalculator
    {

        [OperationContract]
        float Somar(float valor1, float valor2);

        [OperationContract]
        float Subtrair(float valor1, float valor2);

        [OperationContract]
        float Multiplicar(float valor1, float valor2);

        [OperationContract]
        float Dividir(float valor1, float valor2);
    }
}
