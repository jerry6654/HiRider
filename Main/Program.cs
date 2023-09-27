
// -------1.引用项目依赖--------------

/*
using ClassCalc;

var result = Calc.Mul(152, 26);
Console.WriteLine(result);
*/


// ----------2.字符串相关操作-----------

/*
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
*/


// ----------3.日期时间操作-----------------

/*
DateTime currentDate = DateTime.Now;
DateTime fu = new DateTime(2023, 12, 22);
Console.WriteLine(fu - currentDate);
*/


// ------------4.StringBuilder--------------

/*
using System.Text;

StringBuilder sb = new StringBuilder("what?");
sb.Append("hello world!");
Console.WriteLine(sb);

string s = "what?";
s += "hello world";
Console.WriteLine(s + sb);
*/


// ---------------5.Array----------------------

/*
// 声明且初始化
int[] a = new int[5];
int[] b = new int[] { 1, 2, 3 };
int[] c = { 1, 2, 3 };
var d = new int[] { 1, 2, 3 };

// 先声明
int[] e;
e = new int[5];

// 打印输出各个元素
// foreach
foreach (var item in a)    
{
    Console.Write(item);
}
Console.WriteLine();

// for
for (int i = 0; i < b.Length; i++)
{
    Console.WriteLine(b[i]);
}

// LINQ
int[] l = { 458, 365, 56, 78, 85, 651 };
Console.WriteLine(l.Max());
Console.WriteLine(l.Min());
Console.WriteLine(l.Sum());
Console.WriteLine(l.Average());

Array.Sort(l);
Array.Reverse(l);
Console.WriteLine(l[0]);

Array.ForEach(l, i => Console.WriteLine(i));
Array.ForEach(l, Console.WriteLine);

// 数组作为参数
static void UpdateArray(int[] arr)
{
    for (int i = 0; i<arr.Length; i++)
    {
        arr[i] *= 5;
    }
}
UpdateArray(l);
Array.ForEach(l, Console.WriteLine);
*/


// ---------------6.关于修改值/引用-------------------
// 签名
// 声明
// 定义
// 初始化
// 赋值
// 修改

/*
// 值类型，复制，在栈上操作，彼此毫无关系
int a = 5;
int b = a;
a = 50;
b = 30;
Console.WriteLine(a);
Console.WriteLine(b);

// 字符串，引用但在堆上重建，其实结果上跟值没啥区别，只不过内部原理完全不同 ？
var s1 = "hello";
var s2 = s1;
s1 += s2;
s2 = "world";
var s3 = s1.Replace("h", "123");
Console.WriteLine(s1);
Console.WriteLine(s2);
Console.WriteLine(s3);

// 引用，修改，一同修改
int[] x = { 1, 2, 3 };
int[] y = x;
x[0] = 10;
Array.ForEach(x, Console.Write);
Console.WriteLine();
Array.ForEach(y, Console.Write);
*/



// --------------7.unsafe----------------------

/*
int a = 10;
string s = "hello";

unsafe
{
    int *p = &a; //建立指针P，指向变量ad
    Console.WriteLine((int)p); //ad的内存地址
    Console.WriteLine(*p); //引用p指向的数据，即ad

    // IntPtr op=new IntPtr((int)p);//构造c#类型的指针
    // Console.Write(Marshal.ReadInt32(op));//输出的是变量ad的值
}
*/

// --------------------8.重载-------------------------
// 概念：
// 运算符重载
// 索引器重载


// ---------------------9.Tuple, ValueTuple----------------------


/*
Tuple<int, string> p1 = new Tuple<int, string>(22, "jerry");
var p2 = Tuple.Create(55, "Tom");

var numbers = Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9, 10, 11, 12, 13));

Console.WriteLine(p2.Item1);
Console.WriteLine(numbers.Rest.Item1);

ValueTuple<int, string, string> x = (1, "Bill", "Gates");
(int, string, string) y = (1, "Bill", "Gates");
var m = (100, "hello", true);

(int ID, string Name, bool Sex) s1 = (12, "world", true);
Console.WriteLine(s1.ID);
var s2 = (ID: 12, Name: "张三", Age: 32);
Console.WriteLine(s2.Name);
*/


// ---------------------10.异常处理-------------------------

try
{
    Console.WriteLine("请输入一个数字：");
    var num = int.Parse(Console.ReadLine());
    Console.WriteLine($"{num}的平方为：{num * num}");
}
catch (Exception ex)
{
    Console.WriteLine("发生错误了" + ex.Message);
}
finally
{
    Console.WriteLine("试着重新输入一个数字");
}


// ---------------------11.lambda---------------------





