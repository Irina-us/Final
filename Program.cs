Console.Clear();

// Написать программу, которая из имеющегося массива строкформирует
// новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.


// int[] FillArray()
// {
//     int[] array = new int[8];
//     Random random = new Random();
//     for (int i = 0; i < 8; i++)
//     {
//         array[i] = random.Next(2);
//     }
//     return array;
// }
// int[] array = FillArray();
// System.Console.WriteLine(string.Join(", ", array));

// string.Join(", ",  соединяет через запятую в строку

Commands();
string[] array = new string[] {};

string fromUser = ReadInput("Введите команду: ");
switch (fromUser)
{
    case "1":
        array = new string[] { "Hello", "2", "world", ":-)" };
        break;
    case "2":
        array = new string[] { "1234", "1567", "-2", "computer science" };
        break;
    case "3":
        array = new string[] { "Russia", "Denmark", "Kazan" };
        break;
    default:
        Console.WriteLine($"{fromUser} - Такой команды нет");
        break;
}
