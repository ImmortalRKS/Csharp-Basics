//trying to make pyramid pattern on my own
//god knows will it even or not fahh


Console.Write(" Enter Height : ");
int h = Convert.ToInt32(Console.ReadLine());

for (int a = 1; a <= h; a++)
{
    for ( int b = 1; b <= a; b++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}