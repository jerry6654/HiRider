
/*
using ClassCalc;

var result = Calc.Mul(152, 26);
Console.WriteLine(result);
*/

string firstFriend = "Jerry";
string secondFriend = "西门吹雪";
var hello = "         hello            ";
var hello1 = "-------hello---------";

Console.WriteLine($"我有两个朋友，他们是{firstFriend}，还有{secondFriend}");
Console.WriteLine($"{secondFriend}含有{secondFriend.Length}个字符");
Console.WriteLine($"{firstFriend}含有{firstFriend.Length}个字符");

Console.WriteLine($"{hello}");
Console.WriteLine($"{hello1}");


Console.WriteLine($"{hello.TrimStart()}");
Console.WriteLine($"{hello.TrimEnd()}");
Console.WriteLine($"{hello.Trim()}");

hello1 = hello1.Replace("hello", "你好");
Console.WriteLine(hello1);

Console.WriteLine(hello.ToUpper().TrimStart());
Console.WriteLine(hello.TrimStart().ToUpper());


string s = "you say goodbye, and i say hello";
Console.WriteLine(s);
Console.WriteLine(s.Contains("goodbey"));
Console.WriteLine(s.Contains("goodbye"));






