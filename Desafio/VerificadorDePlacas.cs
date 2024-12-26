using System;
using System.Text.RegularExpressions;

namespace Desafio;
public class VerificadorDePlacas
{
    public string Placa { get; set; }
    public VerificadorDePlacas(string placa) 
    { 
        Placa = placa; 
    }

    public bool Validar()
    { 
        if (Placa.Length != 7) 
        { 
            return false; 
        }
        
        string padrao = @"^[a-zA-Z]{3}[0-9]{4}$"; 
        
        Regex regex = new Regex(padrao); 
                                         
        return regex.IsMatch(Placa); 
    }
}
