Console.Write(":یک عدد از 1 تا 15 وارد نمایید");
int n = int.Parse(Console.ReadLine());
if (n < 1 || n > 15)
{
    Console.WriteLine(".عدد وارد شده در بازه بالا نیست");
}
else
{
    int factorial = 1;
    for (int i = 1; i <= n; i++)
    {
        factorial = factorial * i;
    }
    Console.WriteLine("{1} فاکتوریل عدد {0}برابر است با ", n, factorial);
}
//امیر حسین جورابچی
//5.فاکتوریل عدد n تا ۱۵ یا ۲۰