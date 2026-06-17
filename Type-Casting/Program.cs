int a = 30;
double b = Convert.ToDouble(a);
Console.WriteLine(b); //will only show 30 not decimal
Console.WriteLine(b + 0.2); //then it will add 0.2
string c = Convert.ToString(a);
Console.WriteLine(c);
Console.WriteLine(c.GetType()+c);

string d = "Hello";
char e = Convert.ToChar(d);
Console.WriteLine(e); //in here it as you know that char can only store one value in it, so in this case, it wont show error in vscode
                      //but when you run it, the code will run till this code and then it will show "unhandled exception, string must be one command long"

string f = "fahh";
bool g = Convert.ToBoolean(f);
Console.WriteLine("g");  //it also shows same error like char, saying fahh was not a valid boolean, ofc the code wont run till here, unless u remove upper garbage



