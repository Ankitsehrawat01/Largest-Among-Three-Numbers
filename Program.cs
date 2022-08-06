Console.WriteLine("Largest Number Among Three Numbers");
Console.Write("Enter the value of num1 : ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the value of num2 : ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the value of num3 : ");
int num3 = Convert.ToInt32(Console.ReadLine());
if ( num1 > num2 && num1 > num3)
{
    Console.WriteLine("Num1 is the largest");
}
else if (num2 > num3)
{
    Console.WriteLine("Num2 is the largest");
}
else
{
    Console.WriteLine("Num3 is the largest");
}