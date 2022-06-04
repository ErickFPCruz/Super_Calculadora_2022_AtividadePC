Console.Clear();

string opEscolhida;

Console.WriteLine(@"Escolha uma operação para efetuar:
                    
Adição [+]
Subtração [-]
Multiplicação [*]
Divisão [/]
Exponenciação [E]
Radiciação [R]");

Console.WriteLine();

Console.Write("Qual a operação que será feita? ");
opEscolhida = Console.ReadLine()!;

switch (opEscolhida)

{
    case "+":

    {double nr1, nr2, resultado;

    Console.WriteLine("Digite os valores: ");
    
    nr1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"1° número = {nr1}");

    nr2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"2° número = {nr2}");

    resultado = nr1 + nr2;
    Console.WriteLine($"Total = {resultado}");

    Console.ReadKey();
    break;}

    case "-":

    {double nr1, nr2, resultado;

    Console.WriteLine("Digite os valores: ");
    
    nr1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"1° número = {nr1}");

    nr2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"2° número = {nr2}");

    resultado = nr1 - nr2;
    Console.WriteLine($"Total = {resultado}");

    Console.ReadKey();
    break;}

    case "*":

    {double nr1, nr2, resultado;

    Console.WriteLine("Digite os valores: ");
    
    nr1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"1° número = {nr1}");

    nr2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"2° número = {nr2}");

    resultado = nr1 * nr2;
    Console.WriteLine($"Total = {resultado}");

    Console.ReadKey();
    break;}

    case "/":

    {double nr1, nr2, resultado;

    Console.WriteLine("Digite os valores: ");
    
    nr1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"1° número = {nr1}");

    nr2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"2° número = {nr2}");

        if (nr2 == 0)
        {
            Console.WriteLine("Não existe divisão por 0... Tente novamente...");
        }

        else
        {
            resultado = nr1 / nr2;
            Console.WriteLine($"Total = {resultado}");
        }

    Console.ReadKey();
    break;}

    case "E":

    {double nr1, nr2, resultado;

    Console.WriteLine("Digite os valores: ");
    
    nr1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"Base = {nr1}");

    nr2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"Expoente = {nr2}");

    resultado = Math.Pow(nr1, nr2);
    Console.WriteLine($"Total = {resultado}");

    Console.ReadKey();
    break;}

    case "R":
    {double nr1, nr2, resultado;

    Console.WriteLine("Digite os valores: ");
    
    nr1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"Base = {nr1}");

    nr2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"Raiz = {nr2}");

    if (nr2 == 0)
        {
            Console.WriteLine("Não existe divisão por 0... Tente novamente...");
        }

        else
        {
            resultado = Math.Pow(nr1, 1 / nr2);
            Console.WriteLine($"Total = {resultado}");
        }

    Console.ReadKey();
    break;}

    default:

    Console.WriteLine("Selecione uma das teclas indicadas no menu.");
    break;
}