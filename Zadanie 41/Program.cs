// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


System.Console.Write("Введите числа с пробелами: ");

string str = Console.ReadLine();
string[] array = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);


var num = FillNum(array);
System.Console.WriteLine(CountPositivNum(num));



int[] FillNum(string[] array)
{

    int[] numbers = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        numbers[i] = int.Parse/*Convert.ToInt32*/(array[i]);
    }
    return numbers;
}

int CountPositivNum(int[] array)
{
    int count = 0;
    foreach (int item in array)
    {
        if (item > 0)
        {
            count++;
        }
    }
    return count;
}

