using System;
using System.Globalization;

namespace Desafio;
public class ExibidorDeData
{
    public void ExibirFormatoCompleto() 
    { 
        string formatoCompleto = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss", new CultureInfo("pt-BR")); 
        Console.WriteLine("Formato completo: " + formatoCompleto); 
    }
    
    public void ExibirData() 
    { 
        string data = DateTime.Now.ToString("dd/MM/yyyy"); 
        Console.WriteLine("Apenas a data: " + data); 
    }

    public void ExibirHora() 
    { 
        string hora = DateTime.Now.ToString("HH:mm"); 
        Console.WriteLine("Apenas a hora: " + hora); 
    }
    
    public void ExibirDataComMesPorExtenso() 
    { 
        string dataComMesPorExtenso = DateTime.Now.ToString("dd 'de' MMMM 'de' yyyy", new CultureInfo("pt-BR"));
        Console.WriteLine("Data com mês por extenso: " + dataComMesPorExtenso); 
    }
}
