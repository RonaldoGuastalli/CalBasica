﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AtividadeS1_2_Calculadora_Client.Service.Calculadora {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Service.Calculadora.ICalculator")]
    public interface ICalculator {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Somar", ReplyAction="http://tempuri.org/ICalculator/SomarResponse")]
        float Somar(float valor1, float valor2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Somar", ReplyAction="http://tempuri.org/ICalculator/SomarResponse")]
        System.Threading.Tasks.Task<float> SomarAsync(float valor1, float valor2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Subtrair", ReplyAction="http://tempuri.org/ICalculator/SubtrairResponse")]
        float Subtrair(float valor1, float valor2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Subtrair", ReplyAction="http://tempuri.org/ICalculator/SubtrairResponse")]
        System.Threading.Tasks.Task<float> SubtrairAsync(float valor1, float valor2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Multiplicar", ReplyAction="http://tempuri.org/ICalculator/MultiplicarResponse")]
        float Multiplicar(float valor1, float valor2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Multiplicar", ReplyAction="http://tempuri.org/ICalculator/MultiplicarResponse")]
        System.Threading.Tasks.Task<float> MultiplicarAsync(float valor1, float valor2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Dividir", ReplyAction="http://tempuri.org/ICalculator/DividirResponse")]
        float Dividir(float valor1, float valor2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Dividir", ReplyAction="http://tempuri.org/ICalculator/DividirResponse")]
        System.Threading.Tasks.Task<float> DividirAsync(float valor1, float valor2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalculatorChannel : AtividadeS1_2_Calculadora_Client.Service.Calculadora.ICalculator, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculatorClient : System.ServiceModel.ClientBase<AtividadeS1_2_Calculadora_Client.Service.Calculadora.ICalculator>, AtividadeS1_2_Calculadora_Client.Service.Calculadora.ICalculator {
        
        public CalculatorClient() {
        }
        
        public CalculatorClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculatorClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public float Somar(float valor1, float valor2) {
            return base.Channel.Somar(valor1, valor2);
        }
        
        public System.Threading.Tasks.Task<float> SomarAsync(float valor1, float valor2) {
            return base.Channel.SomarAsync(valor1, valor2);
        }
        
        public float Subtrair(float valor1, float valor2) {
            return base.Channel.Subtrair(valor1, valor2);
        }
        
        public System.Threading.Tasks.Task<float> SubtrairAsync(float valor1, float valor2) {
            return base.Channel.SubtrairAsync(valor1, valor2);
        }
        
        public float Multiplicar(float valor1, float valor2) {
            return base.Channel.Multiplicar(valor1, valor2);
        }
        
        public System.Threading.Tasks.Task<float> MultiplicarAsync(float valor1, float valor2) {
            return base.Channel.MultiplicarAsync(valor1, valor2);
        }
        
        public float Dividir(float valor1, float valor2) {
            return base.Channel.Dividir(valor1, valor2);
        }
        
        public System.Threading.Tasks.Task<float> DividirAsync(float valor1, float valor2) {
            return base.Channel.DividirAsync(valor1, valor2);
        }
    }
}
