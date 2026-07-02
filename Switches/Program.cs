// To take user input what day is today

Console.Write("What day is today son ? :");
string a = Console.ReadLine()!;
a = a.Trim().ToLower();  //trim() remvoes extra spaces from the output
switch (a) //a is the variable which we will be examining
{
    case "monday":
        Console.WriteLine("Ah nah i dont want to goo college");
        break;

    case "tuesday":
        Console.WriteLine("Man when will sunday comee");
        break;

    case "wednusday":
        Console.WriteLine("Nah dude i cant take it anymore");
        break;

    case "thrusday":
        Console.WriteLine("I am going after lunch");
        break;

    case "friday":
        Console.WriteLine("Nah dude not going today, three day holiday");
        break;

    case "saturday":
        Console.WriteLine("Will play game whole dayyyyyyy");
        break;

    case "sunday":
        Console.WriteLine("I will play my whole ass of cuz from tommorow again college fahh");
        break;
    default:
        Console.WriteLine("Man atleast type a day so that i can know whats my schedule");
        break;    


}

