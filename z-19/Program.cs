Console.WriteLine("Введите пятизначное число:");
var number = Convert.ToInt32(Console.ReadLine());
if (number > 9999 && number < 100000) 
{
    var sum = 0;    
    sum = (number%10)*10000;
    sum = ((number%100-number%10)*100)+sum;
    sum = (number%1000-number%100)+sum;
    sum = ((number%10000-number%1000)/100)+sum;
    sum = ((number%100000-number%10000)/10000)+sum;
    if(sum == number)//
    {
        Console.WriteLine("Число полиндром");
    }
    else
    {
    Console.WriteLine("Число не полиндром");
    }
}
else
    {
    Console.WriteLine("Число не пятизначное");
    }