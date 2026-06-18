Console.Write("Enter your name : ");
string a = Console.ReadLine()!;
Console.WriteLine("Hello "+ a);


//this is pretty basic and if you have to change the data type for eg taking age of someone from user,
//then inspite of making another line for it to convert and to save it in a new var, you can do this instead :-

Console.Write("Enter Your Age : ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Your age is " + b);

//this might be a bit better since now u dont need to add another var while you can get the job done in one var

Console.Write("Enter your symbol : ");
char c = Convert.ToChar(Console.ReadLine()!);

//char just stores only one value and is stored under ''