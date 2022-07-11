//Задача 1: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[] GenerateArray(int length)
{
    int[] newArray = new int[length];

    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = Prompt($"Введите {i+1} число > ");
    }
    return newArray;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    System.Console.Write(array[0]);
    for (int i = 1; i < array.Length; i++)
    {
        System.Console.Write(", " + array[i]);
    }
    System.Console.WriteLine("]");
}


int quantityNumbers = Prompt("Введите общее количество чисел > ");
int[] numbArray = GenerateArray(quantityNumbers);
int countPositiveNumbers = 0;
PrintArray(numbArray);

for (int j = 0; j < numbArray.Length; j++)
{
    if (numbArray[j] > 0) countPositiveNumbers++;
}
System.Console.WriteLine("Количество положительных элементов : " + countPositiveNumbers);
