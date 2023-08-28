// напишите метод DistanceBetweenPoints, который принимает
//  на вход координаты двух точек pointA и pointB в виде
//   массива целых чисел, и возвращает расстояние между 
//   ними в 3D пространстве

// int[] GetCoor (string message)
// {
//     int[] coordinates = new int[3];
//     Console.Write(message + "X: ");
//     coordinates[0] = int.Parse(Console.ReadLine()!);
//     Console.Write(message + "Y: ");
//     coordinates[1] = int.Parse(Console.ReadLine()!);
//     Console.Write(message + "Z: ");
//     coordinates[2] = int.Parse(Console.ReadLine()!);
//     return coordinates;
// }

double DistanceBetweenPoints()
{
    int[] pointA = new int[3];
    System.Console.WriteLine("Введите для точки А координату ");
    pointA[0] = int.Parse(Console.ReadLine()!);
    pointA[1] = int.Parse(Console.ReadLine()!);
    pointA[2] = int.Parse(Console.ReadLine()!);
    int[] pointB = new int[3];
    System.Console.WriteLine("Введите для точки B координату ");
    pointB[0] = int.Parse(Console.ReadLine()!);
    pointB[1] = int.Parse(Console.ReadLine()!);
    pointB[2] = int.Parse(Console.ReadLine()!);
    double dist = Math.Sqrt(Math.Pow(pointA[0] - pointB[0], 2) + Math.Pow(pointA[1] - pointB[1], 2) + Math.Pow(pointA[2] - pointB[2], 2));
    return Math.Round(dist, 2);
}

// int[] pointA = GetCoor("Введите для точки А координату ");
// int[] pointB = GetCoor("Введите для точки B координату ");
double result = DistanceBetweenPoints();
result = Math.Round(result, 2);
System.Console.WriteLine(result);