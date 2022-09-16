// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите первое целое число");
int numberA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе целое число");
int numberB = int.Parse(Console.ReadLine()!);

double Pow = 1;
for (int i = 0; i < numberB; i++) 
{ 
    Pow *= numberA;
}
Console.WriteLine($"Натуральная степень числа {numberA} в степени {numberB} равна {Pow} ");  
return; 

Console.WriteLine();
Console.WriteLine("Enter, чтобы продолжить / q, чтобы выйти");
ConsoleKeyInfo quite = Console.ReadKey();
Console.WriteLine();
if(quite.KeyChar == 'q') break;
 




