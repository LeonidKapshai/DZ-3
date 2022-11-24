// Console.WriteLine("Введите число:");
// var num = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i <= num; i=++)
// {
//     Console.WriteLine(Math.Pow(i,3));
// }
Console.WriteLine("Введите число:");
var num = Convert.ToInt32(Console.ReadLine());
int num2 = 1;

while (num2 <= num)
{
    Console.WriteLine(num2*num2*num2);
    num2++;
}