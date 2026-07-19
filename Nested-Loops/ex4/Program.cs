Console.Write("Enter height: ");
int height = Convert.ToInt32(Console.ReadLine());

for (int row = 1; row <= height; row++)
{
    // Print spaces
    for (int space = 1; space <= height - row; space++)
    {
        Console.Write(" ");
    }

    // Print stars
    for (int star = 1; star <= row * 2 - 1; star++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}

//although i havent wrote this, its from chatgpt, i was still able to understand it better
