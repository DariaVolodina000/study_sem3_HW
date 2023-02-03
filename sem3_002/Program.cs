// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

int IntputInt(string messege)
{
    Console.WriteLine(messege);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int ax = IntputInt("Введите координату x точки A");
int ay = IntputInt("Введите координату y точки A");
int az = IntputInt("Введите координату z точки A");

int bx = IntputInt("Введите координату x точки B");
int by = IntputInt("Введите координату y точки B");
int bz = IntputInt("Введите координату z точки B");

double Distance(double x1, double x2, double x3, double y1, double y2, double y3)
{
    double a = x1 - y1;
    double b = x2 - y2;
    double c = x3 - y3;
    return Math.Sqrt(a * a + b * b + c * c);
}

double result = Distance(ax, ay, az, bx, by, bz);
Console.Write($"Расстояни между точками A и B = {result}");



