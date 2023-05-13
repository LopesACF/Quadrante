Console.Clear();

﻿﻿double x, y;
string local;

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("--- Quadrante Cartesiano ---\n");
Thread.Sleep(500);

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("Entre com o ponto desejado.");
Thread.Sleep(500);

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("x: ");
x = Convert.ToDouble(Console.ReadLine());
Thread.Sleep(500);


Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("y: ");
y = Convert.ToDouble(Console.ReadLine());
Thread.Sleep(500);

if(x == 0 && y == 0) local = "a origem";
else if (x == 0) local = "o eixo das ordenadas";
else if (y == 0) local = "o eixo das abscissas";
else if (y > 0)

{
    if (x > 0)
        local = "o quadrante 1";
    else
        local = "o quadrante 2";
}
else
{
    if (x < 0)
        local = "o quadrante 3";
    else
        local = "o quadrante 4";
}

Console.ForegroundColor = ConsoleColor.DarkBlue;

Console.WriteLine($"\nO ponto ({x}, {y}) fica n{local}.");

Console.ResetColor();