double s = 0; 
int count = 0;
int count1 = 0;
int count2 = 0;
int n;
do
{
    n = int.Parse(Console.ReadLine());
    if (n ==0) break;//ввод чисел, пока не введется 0
    s += n;// сумма всех чисел
    count++;
    if(n>10)//количество чисел, больших 10
    count1++;
    if (n < -10)//количество чисел, меньших -10
    count2++;
} while (true);
Console.WriteLine("Сумма всех чисел =" + s); 
Console.WriteLine("Количество числел больше 10 =" + count1);
Console.WriteLine("Количество числел меньше -10 =" + count2);
Console.WriteLine($"Среднее арифметическое всех чисел ={(s / count):F2}");

