// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.Clear();
int DataEntryPoint(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}
void FindDistance(int x1,int y1,int z1,int x2,int y2,int z2)
{
    Console.WriteLine("Координаты точки A("+x1+","+y1+","+z1+")");
    Console.WriteLine("Координаты точки B("+x2+","+y2+","+z2+")");
    double x = Math.Pow((x2-x1),2);
    double y = Math.Pow((y2-y1),2);
    double z = Math.Pow((z2-z1),2);
    double xyz = Math.Sqrt(x+y+z);
    Console.WriteLine("Расстояние между двух точек => "+xyz);
}

int x1 = DataEntryPoint("Введите координату X первой точки:");
int y1 = DataEntryPoint("Введите координату Y первой точки:");
int z1 = DataEntryPoint("Введите координату Z первой точки:");

int x2 = DataEntryPoint("Введите координату X второй точки:");
int y2 = DataEntryPoint("Введите координату Y второй точки:");
int z2 = DataEntryPoint("Введите координату Z второй точки:");

FindDistance(x1,y1,z1,x2,y2,z2);