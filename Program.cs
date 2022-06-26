Console.Clear();

string opEscolhida;

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
Logaritmo Natural [LN]");

Console.WriteLine();

Console.Write("Qual a operação que será feita? ");
opEscolhida = Console.ReadLine()!;

switch (opEscolhida)

{
    case "+" or "a":
        Aritmetica.Soma();
        return;

    case "-" or "s":
        Aritmetica.Diferenca();
        return;

    case "*" or "m":
        Aritmetica.Produto();
        return;

    case "/" or "d":
        Aritmetica.Quociente();
        return;

    case "E" or "e":
        Aritmetica.Potencia();
        return;

    case "R" or "r":
        Aritmetica.Raiz();
        return;

    case "AC" or "ac":
        Aritmetica.AreaCirculo();
        return;

    case "CC" or "cc":
        Aritmetica.ComprimentoCirculo();
        return;

    case "VC" or "vc":
        Aritmetica.VolumeCilindro();
        return;

    case "LOG" or "log":
        Aritmetica.Log();
        return;

    case "LN" or "ln":
        Aritmetica.Ln();
        return;

    default:

        Console.WriteLine("Selecione uma das teclas indicadas no menu.");
        return;
}