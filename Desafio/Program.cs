using System;
using Desafio;

class Program
{
    static void Main()
    {
        bool exit = false;
        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("===== Menu =====");
            Console.WriteLine("1. Nome com Saudação");
            Console.WriteLine("2. Nome completo");
            Console.WriteLine("3. Operações Matematicas");
            Console.WriteLine("4. Quantidade de caracteres");
            Console.WriteLine("5. Verifica Placa");
            Console.WriteLine("6. Datas");
            Console.WriteLine("0. Sair");
            Console.Write("Escolha uma opção: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Digite seu nome: ");
                    var nome = Console.ReadLine();
                    Console.WriteLine("Olá, " + nome +"! Seja muito bem-vindo!");
                    break;
                case "2":
                    Console.WriteLine("Digite seu nome: ");
                    var nomeCompleto = Console.ReadLine();
                    Console.WriteLine("Digite seu sobrenome: ");
                    var sobreNome = Console.ReadLine();
                    Console.WriteLine(nomeCompleto + " " + sobreNome);
                    break;
                case "3":
                    Console.WriteLine("Digite o primeiro número:"); 
                    double num1 = Convert.ToDouble(Console.ReadLine()); 
                    Console.WriteLine("Digite o segundo número:"); 
                    double num2 = Convert.ToDouble(Console.ReadLine()); 
                    OperacoesMatematicas operacoes = new OperacoesMatematicas(num1, num2); 
                    Console.WriteLine($"Soma: {operacoes.Soma()}"); 
                    Console.WriteLine($"Subtração: {operacoes.Subtracao()}"); 
                    Console.WriteLine($"Multiplicação: {operacoes.Multiplicacao()}"); 
                    Console.WriteLine($"Divisão: {(num2 != 0 ? operacoes.Divisao().ToString() : "Erro: Divisão por zero!")}"); 
                    Console.WriteLine($"Média: {operacoes.Media()}");
                    break;
                case "4":
                    Console.WriteLine("digita uma ou mais palavras");
                    var palavra = Console.ReadLine();
                    Console.WriteLine(palavra.Length + "palavras");
                    break;
                case "5":
                    Console.WriteLine("Digite a placa do veículo:");
                    string placa = Console.ReadLine();

                    VerificadorDePlacas verificador = new VerificadorDePlacas(placa);
                    if (verificador.Validar()) 
                    { 
                        Console.WriteLine("Verdadeiro"); 
                    } 
                    else 
                    { 
                        Console.WriteLine("Falso");
                    }
                    break;
                case "6":
                    Console.WriteLine("Data em alguns formatos!");
                    ExibidorDeData exibidor = new ExibidorDeData(); 
                    exibidor.ExibirFormatoCompleto(); 
                    exibidor.ExibirData(); 
                    exibidor.ExibirHora(); 
                    exibidor.ExibirDataComMesPorExtenso();
                    break;
                case "0":
                    exit = true;
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida, tente novamente.");
                    break;
            }

            // Pausa antes de voltar ao menu
            if (!exit)
            {
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}
