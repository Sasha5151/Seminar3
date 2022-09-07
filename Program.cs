//Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 или Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// int Prompt(string message)
// {
//     System.Console.Write(message);
//     string value = Console.ReadLine();
//     return Convert.ToInt32 (value);
// }

// bool ValidateCoord(int xCoord , int yCoord)
// {

//     if (xCoord == 0 || yCoord == 0)
//     {
//          System.Console.WriteLine("одна из координат находиться на оси .");
//          return false;
//     }
//     return true;
// }

// void FindQuarter(int x , int y)
// {
//        if (x > 0 && y > 0)
//     {
//         System.Console.WriteLine("первая четверть ");
//     }
//          if (x < 0 && y > 0)
//     {
//         System.Console.WriteLine("вторая четверть ");
//     }
//         if (x < 0 && y < 0)
//     {
//         System.Console.WriteLine("третья четверть ");
//     }
//          if (x > 0 && y < 0)
//     {
//         System.Console.WriteLine("четвертая четверть ");
//     }
// }

// int xCoord = Prompt ("Введите Х : ");
// int yCoord = Prompt ("Введите Y : ");

// if (ValidateCoord(xCoord,yCoord))
// {
//     FindQuarter(xCoord, yCoord);
// }

//End



//Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).

// int Prompt(string message)
// {
//     System.Console.Write(message);
//     string value = Console.ReadLine();
//     return Convert.ToInt32 (value);
// }

// bool ValidateQuarter(int Quarter)
// {
//     if (Quarter > 0 && Quarter < 5)
//     {
//          return true;
//     }
//          System.Console.WriteLine("ошибка ввода");
//     return false;
// }

// void GetQuarter(int Quarter)
// {
//        if (Quarter == 1)
//     {
//         System.Console.WriteLine("x > 0 & y > 0 ");
//     }
//          if (Quarter == 2)
//     {
//         System.Console.WriteLine("x < 0 & y > 0  ");
//     }
//         if (Quarter == 3)
//     {
//         System.Console.WriteLine("x < 0 & y < 0 ");
//     }
//          if (Quarter == 4)
//     {
//         System.Console.WriteLine("x > 0 & y < 0 ");
//     }
// }

// int Q = Prompt ("Введите номер четверти  : ");

// if (ValidateQuarter(Q))
// {
//     GetQuarter(Q);
// }

// End


//Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09 
//A (7,-5); B (1,-1) -> 7,21

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    return Convert.ToInt32(value);
}
//int []Coord2 = new int [2];
int[] InputCoords(int n)
{
    int[] Coord = new int[2];
    Coord[0] = Prompt($"Введите координаты {n} точки Х : ");
    Coord[1] = Prompt($"Введите координаты {n} точки Y : ");
    return Coord;
}
int Sqr(int n)
{
    return n * n;
}
int[] Coord1 = InputCoords(1);
int[] Coord2 = InputCoords(2);
//Coord2[0] = Prompt ("Введите координаты второй точки Х : ");
//Coord2[1] = Prompt ("Введите координаты второй точки Y : ");

double result = Math.Sqrt(Sqr(Coord2[0] - Coord1[0]) + Sqr(Coord2[1] - Coord1[1]));
System.Console.WriteLine(result);

//end
