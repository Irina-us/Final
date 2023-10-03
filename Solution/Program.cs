Console.Clear();

// Написать программу, которая из имеющегося массива строк формирует
// новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


Console.WriteLine("Формируем новый массив из строк, длина которых меньше, либо равна 3 символам");

Commands();
string[] array = new string[] {};

string fromUser = ReadInput("Выберите массив для проверки алгоритма и введите его номер: ");

switch (fromUser)
{
    case "1":
        array = new string[] { "Hello", "2", "world", ":-)" };
        break;
    case "2":
        array = new string[] { "1234", "1567", "-2", "computer science" };
        break;
    case "3":
        array = new string[] { "England", "Denmark", "Sweden", "Wales", "France", "Spain", "USA"};
        break;
    default:
        Console.WriteLine($"{fromUser} - Такой команды нет");
        break;
}


int lenNewArray = 0;
for (int i = 0; i <= array.Length - 1; i++)
{
    if (array[i].Length <= 3) lenNewArray++;
}

string[] newArray = new string[lenNewArray];
int idx = 0;

for (int i = 0; i <= array.Length - 1; i++)
{
    if (array[i].Length <= 3)
    {
        newArray[idx] = array[i];
        idx++;
    }
}

PrintArray(array);
Console.Write("→ ");
PrintArray(newArray);

void Commands()
{
    Console.WriteLine();
    Console.WriteLine("Массивы данных:");
    Console.WriteLine("1 - [“Hello”, “2”, “world”, “:-)”]");
    Console.WriteLine("2 – [“1234”, “1567”, “-2”, “computer science”]");
    Console.WriteLine("3 – [“England”, “Denmark”, “Sweden”, ”Wales, ”France”, ”Spain”, ”USA”]");
    Console.WriteLine();
}

string ReadInput(string msg)
{
    Console.Write(msg);
    return Console.ReadLine();
}

void PrintArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"“{array[i]}”, ");
    }
    Console.Write("] ");
}

