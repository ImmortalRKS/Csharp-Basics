//Loigcal Operaters
// && (and) , || (or), its basically and, or from python which is used in true and false

Console.Write("What temperature is outside? (C) : ");
double a = Convert.ToDouble(Console.ReadLine());

if (a >= 10 && a <= 25)
{
    Console.WriteLine("Its warm outside");
}

else if (a <= -50 || a >= 50)
{
    Console.WriteLine("Dont go outside man, you gonna die ahhh");
}

Console.WriteLine("You bro wassup");
