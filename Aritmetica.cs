public class Aritmetica
{
    public static void Soma()
    {
        double nr1, nr2, resultado;

        Console.WriteLine("\nSoma");

        Console.Write("1° parcela = ");
        nr1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("2° parcela = ");
        nr2 = Convert.ToDouble(Console.ReadLine());

        resultado = nr1 + nr2;
        Console.WriteLine($"\nTotal = {resultado:N4}");

        Console.ReadKey();
        return;
    }
    public static void Diferenca()
    {
        double nr1, nr2, resultado;

        Console.WriteLine("Digite os valores: ");

        Console.Write("Minuendo = ");
        nr1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Subtraendo = ");
        nr2 = Convert.ToDouble(Console.ReadLine());

        resultado = nr1 - nr2;
        Console.WriteLine($"\nTotal = {resultado:N4}");

        Console.ReadKey();
        return;
    }
    public static void Produto()
    {
        double nr1, nr2, resultado;

        Console.WriteLine("Digite os valores: ");

        Console.Write("1° fator = ");
        nr1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("2° fator = ");
        nr2 = Convert.ToDouble(Console.ReadLine());

        resultado = nr1 * nr2;
        Console.WriteLine($"\nTotal = {resultado:N4}");

        Console.ReadKey();
        return;
    }
    public static void Quociente()
    {
        double nr1, nr2, resultado;

        Console.WriteLine("Digite os valores: ");

        Console.Write("Dividendo = ");
        nr1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Divisor = ");
        nr2 = Convert.ToDouble(Console.ReadLine());

        if (nr2 == 0)
        {
            Console.WriteLine("Não existe divisão por 0... Tente novamente...");
        }

        else
        {
            resultado = nr1 / nr2;
            Console.WriteLine($"\nTotal = {resultado:N4}");
        }

        Console.ReadKey();
        return;
    }
    public static void Potencia()
    {
        double nr1, nr2, resultado;

        Console.WriteLine("Digite os valores: ");

        Console.Write("Base = ");
        nr1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Expoente = ");
        nr2 = Convert.ToDouble(Console.ReadLine());

        resultado = Math.Pow(nr1, nr2);
        Console.WriteLine($"\nTotal = {resultado:N4}");

        Console.ReadKey();
        return;
    }
    public static void Raiz()
    {
        double nr1, nr2, resultado;

        Console.WriteLine("Digite os valores: ");

        Console.Write("Base = ");
        nr1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Índice = ");
        nr2 = Convert.ToDouble(Console.ReadLine());

        if (nr2 == 0)
        {
            Console.WriteLine("Não existe raiz nula de um número... Tente novamente...");
        }

        else if (nr1 < 0)
        {
            Console.WriteLine("Não existe base negativa em uma raiz... Tente novamente...");
        }

        else
        {
            resultado = Math.Pow(nr1, 1 / nr2);
            Console.WriteLine($"\nTotal = {resultado:N4}");
        }

        Console.ReadKey();
        return;
    }
    public static void AreaCirculo()
    {
        double nr1, resultado;

        Console.WriteLine("Digite os valores: ");

        Console.Write("Raio = ");
        nr1 = Convert.ToDouble(Console.ReadLine());

        if (nr1 <= 0)
        {
            Console.WriteLine("Um raio é sempre positivo! Tente novamente...");
        }

        else
        {
            resultado = Math.PI * Math.Pow(nr1, 2);
            Console.WriteLine($"\nTotal = {resultado:N4}");
        }
    }
    public static void ComprimentoCirculo()
    {
        double nr1, resultado;

        Console.WriteLine("Digite os valores: ");

        Console.Write("Raio = ");
        nr1 = Convert.ToDouble(Console.ReadLine());

        if (nr1 <= 0)
        {
            Console.WriteLine("Um raio é sempre positivo! Tente novamente...");
        }

        else
        {
            resultado = 2 * Math.PI * nr1;
            Console.WriteLine($"\nTotal = {resultado:N4}");
        }
    }
    public static void VolumeCilindro()
    {
        double nr1, nr2, resultado;

        Console.WriteLine("Digite os valores: ");

        Console.Write("Raio = ");
        nr1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Altura = ");
        nr2 = Convert.ToDouble(Console.ReadLine());

        if (nr1 <= 0)
        {
            Console.WriteLine("Um raio é sempre positivo! Tente novamente...");
        }

        else if (nr2 <= 0)
        {
            Console.WriteLine("Uma altura é sempre positiva! Tente novamente...");
        }

        else
        {
            resultado = Math.PI * Math.Pow(nr1, 2) * nr2;
            Console.WriteLine($"\nTotal = {resultado:N4}");
        }
    }
    public static void Log()
    {
        double nr1, nr2, resultado;

        Console.WriteLine("Digite os valores: ");

        Console.Write("Logaritmando = ");
        nr1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Base Log. = ");
        nr2 = Convert.ToDouble(Console.ReadLine());

        if (nr1 <= 0)
        {
            Console.WriteLine("O Logaritmando precisa ser positivo! Tente novamente...");
        }

        else if (nr2 <= 0)
        {
            Console.WriteLine("A base precisa ser positiva! Tente novamente...");
        }

        else if (nr2 == 1)
        {
            Console.WriteLine("A base não pode ser 1, se não gera incompatibilidade! Tente novamente...");
        }

        else
        {
            resultado = Math.Log(nr1, nr2);
            Console.WriteLine($"\nTotal = {resultado:N4}");
        }
    }
    public static void Ln()
    {
        double nr1, resultado;

        Console.WriteLine("Digite os valores: ");

        Console.Write("Logaritmando = ");
        nr1 = Convert.ToDouble(Console.ReadLine());

        if (nr1 <= 0)
        {
            Console.WriteLine("O Logaritmando precisa ser positivo! Tente novamente...");
        }

        else
        {
            resultado = Math.Log(nr1, Math.E);
            Console.WriteLine($"\nTotal = {resultado:N4}");
        }
    }
}