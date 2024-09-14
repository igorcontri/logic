// See https://aka.ms/new-console-template for more information

void menu()
{
    Console.WriteLine(@"
======= Menu =======

1 - Potenciação
2 - Cubo
3 - MDC
4 - Fibonacci Recursivo
5 - Fibonacci Iterativo
6 - Conversor Binário

x - Sair

--> Escolha uma opção: 
");
}

int potencia(int x, int y)
{
    int resultado = 0;

    if (y == 0)
        resultado = 1;

    else if (y != 0)
        resultado = x * potencia(x, y-1);

    return resultado;
}

void cubos(int n)
{
    int i = 1;

    if (i <= n)
    {   
        cubos(n - 1);
        int cubo = n * n * n;
        Console.WriteLine($"O cubo de {n} é: {cubo}");
    }
}

int mdc(int x, int y)
{
    int resultado;

    if (x == y)
        resultado = x;

    else if (x < y)
        resultado = mdc(y, x);

    else
        resultado = mdc(x - y, y);

    return resultado;
}

int fib_recursivo(int n)
{
    int resultado = 0;

    if (n == 0 || n == 1)
        resultado = n;

    if (n >= 2)
        resultado = fib_recursivo(n - 1) + fib_recursivo(n - 2);

    return resultado;
}

int fib_iterativo(int n)
{
    if (n == 0 || n == 1)
    return n;

    int a = 0, b = 1, auxiliar;

    for (int i = 2; i <= n; i++)
    {
        auxiliar = a + b;
        a = b;
        b = auxiliar;
    }

    return b;
}

void binario(int n)
{
    if (n > 1)
    {
        binario(n / 2); 
    }

    Console.Write(n % 2);  
}

string op; 
op = "init";

while (op != "x"){

    menu();
    op = Console.ReadLine();

    if (op == "1")
    {
        Console.WriteLine("======= C2ALCULAR POTENCIA =======");

        int x, y;
        Console.WriteLine("Informe um valor Para X: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe um valor Para Y: ");
        y = Convert.ToInt32(Console.ReadLine());

        int resultado = potencia(x, y);
        Console.WriteLine("====================");
        Console.WriteLine($"O resultado de {x} elevado a {y} é: {resultado}");
        Console.WriteLine("====================");
    }

    if (op == "2")
    {
        Console.WriteLine("======= CALCULAR CUBOS =======");

        int n;
        Console.WriteLine("Informe um valor para 'n': ");
        n = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("====================");
        cubos(n);
        Console.WriteLine("\n====================");
    }

    if (op == "3")
    {
        Console.WriteLine("======= CALCULAR MDC =======");

        int x, y;
        Console.WriteLine("Informe um valor Para X: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe um valor Para Y: ");
        y = Convert.ToInt32(Console.ReadLine());

        int resultado = mdc(x, y);

        Console.WriteLine("====================");
        Console.WriteLine($"O MDC de {x} e {y} é: {resultado}");
        Console.WriteLine("====================");
    }

    if (op == "4")
    {
        Console.WriteLine("======= FIBONACCI RECURSIVO =======");

        int n;
        Console.WriteLine("Informe um valor para 'n': ");
        n = Convert.ToInt32(Console.ReadLine());
        
        int resultado = fib_recursivo(n);

        Console.WriteLine("====================");
        Console.WriteLine($"O termo que ocupa a posição {n} é: {resultado}");
        Console.WriteLine("====================");
    }

    if (op == "5")
    {
        Console.WriteLine("======= FIBONACCI ITERATIVO =======");

        int n;
        Console.WriteLine("Informe um valor para 'n': ");
        n = Convert.ToInt32(Console.ReadLine());
        
        int resultado = fib_iterativo(n);

        Console.WriteLine("====================");
        Console.WriteLine($"O termo que ocupa a posição {n} é: {resultado}");
        Console.WriteLine("====================");
    }

    if (op == "6")
    {
        Console.WriteLine("======= BASE BINÁRIA =======");

        int n;
        Console.WriteLine("Informe um valor para 'n': ");
        n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("====================");
        binario(n);
        Console.WriteLine("\n====================");
    }
}