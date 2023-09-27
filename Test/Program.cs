// -------------------1.委托---------------------------
Calc calc = new();

Action action = new Action(calc.Show);
calc.Show();
action.Invoke();
action();

Func<int, int, int> func = new Func<int, int, int>(calc.Mul);
int x = 20;
int y = 60;
Console.WriteLine(func.Invoke(x, y));
Console.WriteLine(func(x, y));
Console.WriteLine(calc.Mul(x, y));

class Calc
{
    public void Show()
    {
        Console.WriteLine("委托练习");
    }

    public int Mul(int x, int y)
    {
        return x * y;
    }
}