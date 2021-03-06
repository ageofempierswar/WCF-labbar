﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Denna kod har genererats av ett verktyg.
//     Körtidsversion:4.0.30319.42000
//
//     Ändringar i denna fil kan orsaka fel och kommer att förloras om
//     koden återgenereras.
// </auto-generated>
//------------------------------------------------------------------------------



[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="http://Christopher.CalculatorHost", ConfigurationName="ICalculator")]
public interface ICalculator
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://Christopher.CalculatorHost/ICalculator/Add", ReplyAction="http://Christopher.CalculatorHost/ICalculator/AddResponse")]
    double Add(double a, double b);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://Christopher.CalculatorHost/ICalculator/Add", ReplyAction="http://Christopher.CalculatorHost/ICalculator/AddResponse")]
    System.Threading.Tasks.Task<double> AddAsync(double a, double b);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://Christopher.CalculatorHost/ICalculator/Subtract", ReplyAction="http://Christopher.CalculatorHost/ICalculator/SubtractResponse")]
    double Subtract(double a, double b);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://Christopher.CalculatorHost/ICalculator/Subtract", ReplyAction="http://Christopher.CalculatorHost/ICalculator/SubtractResponse")]
    System.Threading.Tasks.Task<double> SubtractAsync(double a, double b);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://Christopher.CalculatorHost/ICalculator/Multiply", ReplyAction="http://Christopher.CalculatorHost/ICalculator/MultiplyResponse")]
    double Multiply(double a, double b);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://Christopher.CalculatorHost/ICalculator/Multiply", ReplyAction="http://Christopher.CalculatorHost/ICalculator/MultiplyResponse")]
    System.Threading.Tasks.Task<double> MultiplyAsync(double a, double b);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://Christopher.CalculatorHost/ICalculator/Divide", ReplyAction="http://Christopher.CalculatorHost/ICalculator/DivideResponse")]
    double Divide(double a, double b);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://Christopher.CalculatorHost/ICalculator/Divide", ReplyAction="http://Christopher.CalculatorHost/ICalculator/DivideResponse")]
    System.Threading.Tasks.Task<double> DivideAsync(double a, double b);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface ICalculatorChannel : ICalculator, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class CalculatorClient : System.ServiceModel.ClientBase<ICalculator>, ICalculator
{
    
    public CalculatorClient()
    {
    }
    
    public CalculatorClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public CalculatorClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public CalculatorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public CalculatorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public double Add(double a, double b)
    {
        return base.Channel.Add(a, b);
    }
    
    public System.Threading.Tasks.Task<double> AddAsync(double a, double b)
    {
        return base.Channel.AddAsync(a, b);
    }
    
    public double Subtract(double a, double b)
    {
        return base.Channel.Subtract(a, b);
    }
    
    public System.Threading.Tasks.Task<double> SubtractAsync(double a, double b)
    {
        return base.Channel.SubtractAsync(a, b);
    }
    
    public double Multiply(double a, double b)
    {
        return base.Channel.Multiply(a, b);
    }
    
    public System.Threading.Tasks.Task<double> MultiplyAsync(double a, double b)
    {
        return base.Channel.MultiplyAsync(a, b);
    }
    
    public double Divide(double a, double b)
    {
        return base.Channel.Divide(a, b);
    }
    
    public System.Threading.Tasks.Task<double> DivideAsync(double a, double b)
    {
        return base.Channel.DivideAsync(a, b);
    }
}
