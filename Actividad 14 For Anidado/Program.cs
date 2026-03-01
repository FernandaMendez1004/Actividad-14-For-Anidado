using static System.Net.WebRequestMethods;

Console.WriteLine("Actividad No. 14 For Anidado ");
Console.WriteLine("Seleccione una opcion segun el no. de ejercicio");
Console.WriteLine("1.Mostrar un cuadrado de 5x5 con números 1.\r\n 2.Mostrar un rectángulo de 4 filas y 6 columnas con asteriscos.\r\n 3.Mostrar un triángulo creciente de 5 filas con asteriscos.\r\n4.Mostrar un triángulo invertido de 5 filas.\r\n5.Mostrar una tabla de multiplicar del 1 al 5 (todas juntas).");
Console.WriteLine("6.Mostrar una matriz 3x3 con números consecutivos del 1 al 9. \r\n 7.Mostrar las combinaciones posibles de números del 1 al 3 (ejemplo: 1-1, 1-2...).\r\n8.Mostrar una tabla donde las filas sean del 1 al 4 y las columnas del 1 al 4.\r\n9.Mostrar un patrón donde cada fila tenga el número de la fila repetido.\r\n10.Mostrar un patrón numérico como:");
int ejercicio = int.Parse(Console.ReadLine());

switch (ejercicio)
{  
    case 1:
        Console.WriteLine("Ejercicio 1");
        for (int i = 1; i <= 5; i++)
        {
            if (i == 1 || i == 5)
                Console.WriteLine("11111");
            else
                Console.WriteLine("1   1");
        }
        break;
    case 2:
        Console.WriteLine("Ejercicio 2 ");
        for (int i = 1; i <= 4; i++)
        {
            if (i == 1 || i == 4)
                Console.WriteLine("111111");
            else
                Console.WriteLine("1    1");
        }
        break;
    case 3:
        Console.WriteLine("Ejercicio 3");
        for(int i = 1;i <= 5; i++)
        {
            Console.WriteLine();
            for (int j = 1; j <= i; j++)
            { Console.Write($"*"); }
        }
        break;
    case 4:
        Console.WriteLine("Ejercicio 4");
        for (int i = 5; i >= 1; i--)
        {
            Console.WriteLine();
            for (int j = 1; j <= i; j++)
            { Console.Write($"*"); }
        }
        break;
    case 5:
        Console.WriteLine("Ejercicio 5");
        for ( int i = 1; i<=5 ; i++)
        {
            Console.WriteLine($"Tabla de Multiplicar del:  {i}");
            for (int j = 1;j<= 10; j++)
            {
                           Console.WriteLine($" {i} * { j} = { i*j }"); }
        }
        Console.WriteLine();
        break;
    case 6:
        int num6 = 1;
        Console.WriteLine("Ejercicio 6");
        for (int i = 1; i <= 3; i++)   // filas
        {
            for (int j = 1; j <= 3; j++) // columnas
            {
                Console.Write(num6 + " ");
                num6++;
            }
            Console.WriteLine();
        }
        break;
        
    case 7:
        Console.WriteLine("Ejercicio 7");
        for (int i = 1; i <= 3; i++)
        {
            for(int j = 1; j <= 3; j++)
            Console.WriteLine($"{i} - {j}");
        }
        break;
    case 8:
        Console.WriteLine("Ejercicio 8");
        for (int i = 1; i <= 4; i++)
        {
            for (int j = 1; j <= 4; j++)
                Console.Write($"{  j  } - {  i  }  ");
            Console.WriteLine();
        }
        break;
    case 9:
        Console.WriteLine(" Ejercicio 9");
        for (int i = 1; i<=5; i++)
        {
            for (int j=1; j<=i; j++)
            {
                Console.Write($"{i}");
            }
            Console.WriteLine();
        }
        break;

}
