Console.Clear();

Console.WriteLine("Введите число");
int x = Convert.ToInt32(Console.ReadLine());

int z = 0 ;

while(z <= x ) 
{
    Console.Write($"{z} ");
    z+=2;
}