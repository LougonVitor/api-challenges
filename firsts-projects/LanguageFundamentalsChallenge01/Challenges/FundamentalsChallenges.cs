using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageFundamentalsChallenge01.Challenges;

internal class FundamentalChallenges
{
    //Challenge 01 : Receives a name and prints
    public void ImprimirNome()
    {
        Console.WriteLine("Digite se nome: ");
        string nome = Console.ReadLine();

        Console.WriteLine($"Olá, {nome}! Seja muito bbem-vindo!");
    }

    //Challenge 02
    public void ImprimirNomeSobrenome()
    {
        Console.WriteLine("Digite se nome: ");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite se sobrenome: ");
        string sobrenome = Console.ReadLine();

        Console.WriteLine($"Olá, {nome} {sobrenome}! Seja muito bbem-vindo!");
    }

    //Challenge 03
    public void RetornarResultadosMatematicos()
    {
        double valor1 = 10f;
        double valor2 = 25.5f;

        Console.WriteLine("A soma entre os dois números é: " + (valor1 + valor2));
        Console.WriteLine("A subtração entre os dois números é: " + (valor1 - valor2));
        Console.WriteLine("A multiplicação entre os dois números é: " + (valor1 * valor2));

        if (valor2 <= 0)
        {
            Console.WriteLine("Segundo valor é zero, divisão cancelada");
        }
        else
        {
            Console.WriteLine("A divisão entre os dois números é: " + valor1 / valor2);
        }

        Console.WriteLine("A média entre os dois números é: " + (valor1 + valor2) / 2);
    }

    //Challenge 04
    public void DigitarEMostrarQuantidadeDeCaracteres()
    {
        Console.WriteLine("Digite algo: ");
        string texto = Console.ReadLine();
        string palavra = texto.Trim();

        Console.WriteLine($"Sua coleçao de caracteres possui {palavra.Length} chars.");
    }

    //Challenge 05
    public void ValidarPlaca()
    {
        char[] alfabetoMinusculo = new char[]
        { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
        char[] alfabetoMaiusculo = new char[]
        { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};
        char[] numeros = new char[]
        { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        Console.WriteLine("Digite sua placa: ");
        string placa = Console.ReadLine();

        bool isLetraPrimeirosDigitos =
            (alfabetoMinusculo.Contains(placa[0]) || alfabetoMaiusculo.Contains(placa[0]))
            && (alfabetoMinusculo.Contains(placa[1]) || alfabetoMaiusculo.Contains(placa[1]))
            && (alfabetoMinusculo.Contains(placa[2]) || alfabetoMaiusculo.Contains(placa[2]))
            ? true
            : false;

        bool isNumerosUltimosDigitos =
            numeros.Contains(placa[3])
            && numeros.Contains(placa[4])
            && numeros.Contains(placa[5])
            && numeros.Contains(placa[6])
            ? true
            : false;

        if (isLetraPrimeirosDigitos && isNumerosUltimosDigitos)
        {
            Console.WriteLine($"A placa : {placa}. É válida!");
        }
        else
        {
            Console.WriteLine($"A placa digitada não é validad. Placa: {placa}");
        }
    }

    //Challenge 06
    public void MostrarData()
    {
        bool isTrue = true;

        while (isTrue)
        {
            Console.WriteLine("Escolha o Formato da Data que deseja exibir:");
            Console.WriteLine("1 - Completa \n2 - Apenas Data \n3 - Apenas Hora \n4 - Data Com o Mês Por Extenso \n5 - Sair");
            string inputUsuario = Console.ReadLine();

            if (inputUsuario.Equals("1"))
            {
                string dataFormatada = DateTime.Now.ToLongDateString();
                string horas = DateTime.Now.ToLongTimeString();
                Console.WriteLine($"Sua data completa é: {dataFormatada}, {horas}");
                Console.WriteLine();
            }
            else if (inputUsuario.Equals("2"))
            {
                DateOnly dataFormatada = DateOnly.FromDateTime(DateTime.Now);
                Console.WriteLine($"Sua data é: {dataFormatada}");
                Console.WriteLine();
            }
            else if (inputUsuario.Equals("3"))
            {
                int dataFormatada = DateTime.Now.Hour;
                Console.WriteLine($"Sua hora é: {dataFormatada} Horas");
                Console.WriteLine();
            }
            else if (inputUsuario.Equals("4"))
            {
                string data = DateOnly.FromDateTime(DateTime.Now).ToString("dd MMM yyyy");
                Console.WriteLine($"Sua data é: {data}");
                Console.WriteLine();
            }
            else if (inputUsuario.Equals("5"))
            {
                Console.WriteLine("Fechando aplicação!");
                Console.WriteLine();
                isTrue = false;
            }
        }
    }
}