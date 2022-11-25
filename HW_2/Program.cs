Console.Clear();

Console.WriteLine("Введите первое число");
int NumA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int NumB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число");
int NumC = Convert.ToInt32(Console.ReadLine());

int max = NumA;

if (NumA>max) max = NumA;
if (NumB>max) max = NumB;
if (NumC>max) max = NumC;

Console.Write("max = ");
Console.WriteLine(max);