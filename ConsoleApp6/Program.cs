// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Enter your number to know if you are to be bomb");
int a = int.Parse(Console.ReadLine());

Console.WriteLine($"Dear {a} am soory to inform you that you shall be bombed and execution starts immidiately");
for(int i = 0; i < a; i++)
{
    Console.WriteLine(a);
    Console.Beep();
}

