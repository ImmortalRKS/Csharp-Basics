//For loops repeat a code for a finite amount of time

for (int i= 3; i >= 1; i--)
{
    Console.WriteLine(i);
}


Console.WriteLine("code is starting...");
Console.Write("Enter which number table u want ?(<=10) : ");
int a = Convert.ToInt32(Console.ReadLine());
if (a<=10 && a >= 1)
{
    for (int b = 1; b < 11; b++)
    {
        Console.WriteLine(a*b);
    }
    Console.WriteLine("Printed the multiplication table");
}

else
{
    Console.WriteLine("The number you entered is not under 1 and 10, sorry nga");
}
