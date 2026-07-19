using System.ComponentModel;

Console.Write("Enter Total Number Of Rows : ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Total Number Of Coloumns : ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter which symbol to use : ");
char symbol = Convert.ToChar(Console.ReadLine())!;


for (int i = 0; i<rows ; i++)
{
    for (int j = 0; j<columns ;j++)
    {
        Console.Write(symbol);
    }
    Console.WriteLine();
}

//this although just make something like rectangle