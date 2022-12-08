Console.Write("Введите число: ");

int a = int.Parse(Console.ReadLine());

int i = 1;

for (i = 1;i < a; i++)

{
 if ( i % 2 == 0) 
 {
    
	Console.WriteLine(i);
 }
}
Console.WriteLine($"Чётные до числа: {a}");
