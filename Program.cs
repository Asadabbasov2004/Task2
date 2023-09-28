//1.Verilmiş müsbət tam n ədədinin 2-nin qüvvəti olub-olmamasını tapın.
//int num = 256;
//if (Math.Log(num, 2) % 2 == 0)
//{
//    Console.WriteLine("This number is power of 2");
//}
//else
//{
//    Console.WriteLine("This number is not power of 2");
//}


//int num1 = 256;
//for (double i = num1; i >= 1; i /= 2)
//{
//    if (i == 2)
//    {
//        Console.WriteLine("This number is power of 2");
//        break;
//    }
//    if (i % 2 != 0)
//    {
//        Console.WriteLine("This number :" + num1 + "is not power of 2");
//        break;
//    }
//}


//Verilmiş n tam ədədinin sadə və ya mürəkkəb ədəd olduğunu tapın.

int num2 =2;
if (num2 > 0 && num2 == 1)
{
    Console.WriteLine(num2 + " is not prime number");
}
else
{
    for (var i = 2; i <= num2 / 2; i++)
    {
        if (num2 % i == 0 )
        {
            Console.WriteLine(num2 + " is not prime number");
            break;
        }
        if (num2 % i != 0)
        {
          Console.WriteLine(num2 + "  ");
            break;
            
        }
    }
    if(num2==2 || num2 == 3)
    {
        Console.WriteLine(num2 + " is a prime number");

    }
}