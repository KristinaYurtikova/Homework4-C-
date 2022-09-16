// Пользователь вводит 8 чисел. Поместите их в массив и распечатайте.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] InputArray()
{
Console.WriteLine("Введите 8 целых чисел");
string abcdefgh = Console.ReadLine()!;
string [] parts = abcdefgh.Split("");
int[] array = new int [parts.Length];

for (int i=0; i < parts.Length; i++ )
{
    array[i] = int.Parse(parts[i]);
}
return array;
}

void PrintArray(int[] array)

{
    Console.Write("Ваш массив : ");
    foreach (int a in array)
    {
        Console.Write($"[{a}]");
    }
}

int[] arrayTest = InputArray();
PrintArray(arrayTest);

