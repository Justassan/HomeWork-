Console.Clear();

Console.WriteLine("Введите число");
int Num = Convert.ToInt32(Console.ReadLine());

if(Num % 2 == 0) 
{
    Console.Write("Четное число " );
    
    Console.WriteLine(Num/2);

}
else
{
   Console.Write("Нечетное число ");
 
}

