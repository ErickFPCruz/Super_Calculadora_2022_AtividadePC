﻿//Console.Clear();

string opEscolhida;

do
{
    Console.WriteLine(@"Escolha uma operação para efetuar:
                    
Adição [+]
Subtração [-]
Multiplicação [*]
Divisão [/]
Exponenciação [E]
Radiciação [R]
Área de um círculo [AC]
Comprimento de um círculo [CC]
Volume de um cilindro [VC]
Logaritmo [LOG]
Logaritmo Natural [LN]
Sair [0]");

    Console.WriteLine();

    Console.Write("Qual a operação que será feita? ");
    opEscolhida = Console.ReadLine()!;

    switch (opEscolhida)

    {
        case "+" or "a":
            Aritmetica.Soma();
            break;

        case "-" or "s":
            Aritmetica.Diferenca();
            break;

        case "*" or "m":
            Aritmetica.Produto();
            break;

        case "/" or "d":
            Aritmetica.Quociente();
            break;

        case "E" or "e":
            Aritmetica.Potencia();
            break;

        case "R" or "r":
            Aritmetica.Raiz();
            break;

        case "AC" or "ac":
            Aritmetica.AreaCirculo();
            break;

        case "CC" or "cc":
            Aritmetica.ComprimentoCirculo();
            break;

        case "VC" or "vc":
            Aritmetica.VolumeCilindro();
            break;

        case "LOG" or "log":
            Aritmetica.Log();
            break;

        case "LN" or "ln":
            Aritmetica.Ln();
            break;

        case "0":
            return;

        default:

            Console.WriteLine("Selecione uma das teclas indicadas no menu.");
            break;
    }

    Console.ReadKey();
} while (opEscolhida != "0");