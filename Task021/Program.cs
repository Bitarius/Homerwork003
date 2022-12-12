/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int x1 = GetNumber("Введите координату X первой точки: ");
int y1 = GetNumber("Введите координату Y первой точки: ");
int z1 = GetNumber("Введите координату Z первой точки: ");
int x2 = GetNumber("Введите координату X второй точки: ");
int y2 = GetNumber("Введите координату Y второй точки: ");
int z2 = GetNumber("Введите координату Z второй точки: ");

int A = x2 - x1;
int B = y2 - y1;
int C = z1 - z2;

double distance = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Расстояние между точками {distance}");

int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

