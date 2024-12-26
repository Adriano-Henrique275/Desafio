using System;

namespace Desafio;

public class OperacoesMatematicas
{
    public double Numero1 { get; set; }
    public double Numero2 { get; set; }

    public OperacoesMatematicas(double numero1, double numero2)
    {
        Numero1 = numero1;
        Numero2 = numero2;
    }

    public double Soma()
    {
        return Numero1 + Numero2;
    }

    public double Subtracao()
    {
        return Numero1 - Numero2;
    }

    public double Multiplicacao()
    {
        return Numero1 * Numero2;
    }

    public double Divisao()
    {
        if (Numero2 == 0)
        {
            throw new DivideByZeroException("Divisão por zero não é permitida.");
        }
        return Numero1 / Numero2;
    }

    public double Media()
    {
        return (Numero1 + Numero2) / 2;
    }
}

