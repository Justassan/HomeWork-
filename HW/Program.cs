Console.Clear(); 

Console.WriteLine("Введите первое число ");
int NumA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число ");
int NumB = Convert.ToInt32(Console.ReadLine());

if(NumA > NumB)
{
    Console.Write("Максимальное число: ");
    Console.WriteLine(NumA);
    Console.Write("Минимальное число: ");
    Console.WriteLine(NumB);

}

else
 {
    Console.Write("Максимальное число: ");
    Console.WriteLine(NumB);
    Console.Write("Минимальное число: ");
    Console.WriteLine(NumA);
 }

