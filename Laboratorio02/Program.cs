// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ejercicio 1");

Console.WriteLine("Ingrese un numero entero");
try
{
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Resultado");
    if (n == 0)
    {
        Console.WriteLine("Su numero es 0");
    }
    if (n > 0)
    {
        Console.WriteLine("Su numero es positivo");
    }
    else
    {
        Console.WriteLine("Su numero es negativo");
    }
}
catch (Exception ex)
{
    Console.WriteLine("No ingreso un numero. " +ex.Message);
}


Console.WriteLine("Ejercicio 2");
Console.WriteLine("Ingrese el numero del dia de la semana");
int d = Convert.ToInt32(Console.ReadLine());

if (d >= 1 && d <=7)
{
    switch (d)
    {
        case 1:
            Console.WriteLine("Lunes");
            break;
        case 2:
            Console.WriteLine("Martes");
            break;
        case 3:
            Console.WriteLine("Miercoles");
            break;
        case 4:
            Console.WriteLine("Jueves");
            break;
        case 5:
            Console.WriteLine("Viernes");
            break;
        case 6:
            Console.WriteLine("Sabado");
            break;
        case 7:
            Console.WriteLine("Domingo");
            break;
    }
}
else
{
    Console.WriteLine("Error: el numero a ingresar debe estar contenido entre 1 y 7");
}