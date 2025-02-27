// See https://aka.ms/new-console-template for more information

 static void task1()
{
    Console.WriteLine("Task 1");
double r = a / Math.Sqrt(3);
Console.WriteLine(r);
}
public static void task2 (int a, int b, int c)
{
    Console.WriteLine("Task 2");
    int max = Math.Max(a, Math.Max(b, c));
    int x, y;

    if (max == a) { x = b; y = c; }
    else if (max == b) { x = a; y = c; }
    else { x = a; y = b; }

    bool isRightTriangle = max * max == x * x + y * y;
    Console.WriteLine(isRightTriangle ? "Трикутник прямокутний" : "Трикутник не прямокутний");

}
public static void task3(int x, int y)
{
    bool isInside = (y < 5) && (y > 0) && (x < 10) && (x > 0);
    bool isOnBorder = (y == 5) && ((x < 10) && (x > 0)) || (x == 10) && ((y < 5) && (x > 0));
    bool isOutside = !isInside;

    if (isInside)
    {
        Console.WriteLine("Точка знаходиться всередині фігури");
    }else if (isOnBorder) { Console.WriteLine("Точка знаходиться на межі");
    }else if (isOutside) { Console.WriteLine("Точка знаходиться поза фігурою");
    }else { Console.WriteLine("Eror"); };
    



}
public static void task4(int a)
{
    string[] first_channel = { "Мастер Шеф", "Супер Мама", "Вагітна в 16" };
    string[] second_channel = { "ТСН", "Танці з зірками", "Сніданок з 1+1" };
    string[] third_channel = { "Квартирне питання", "Ревізор", "Кухня" };

    switch (a)
    {
        case 0:
            {
                Console.WriteLine(" найпопулярніше шоу: "+first_channel[1]);break;
            }
        case 1:
            {
                Console.WriteLine(" найпопулярніше шоу: " + second_channel[0]); break;
            }
        case 2:
            {
                Console.WriteLine(" найпопулярніше шоу: " + third_channel[2]); break;
            }
        default: { Console.WriteLine("ERORR"); break; }
    }
}
public static int task5(int a, int b)
{
    int sum = a + b;
    return sum * sum * sum; // Піднесення в куб
}
public static void task6()
{
    Console.WriteLine("Введіть параметри N та M");
    Console.Write("N = ");
    int n = int.Parse(Console.ReadLine());
    Console.Write("M = ");
    int m = int.Parse(Console.ReadLine());

    if ((((n * n) + (m * m) + 1) == 0) || ((m + 1) == 0) || ((n + 1) == 0))
    {
        Console.WriteLine("Неправильно обрані числа");
    }
    else
    {
        
        double fraction1 = (double)(n + 1) / (n * n) + (m * m) + 1;

        double fraction2 = 1.0 / ((m + 1) * (n + 1));

        double result = fraction1 - fraction2;
        Console.WriteLine("Результат "+result);

    }

Console.WriteLine("Lab 1 !");
task1();
task2(5, 4, 3);
task3(3,5);
task4(0);
Console.WriteLine(task5(12,4));
task6();

