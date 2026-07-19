Console.Write(" Enter Height : ");
int h = Convert.ToInt32(Console.ReadLine());

for (int a = 1; a <= h; a++)
{
    for ( int b = 1; b <= a; b++)
    {
        for ( int c = 1; c <= b; c++)
        {
            Console.Write("*");
        }
    }
    Console.WriteLine();
}
// god knows yeh kya baaan gaya