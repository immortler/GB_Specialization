/* Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами. */

int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while (!isCorrect)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Error: wrong entry.");
        }
    }
    return result;
}

string[] GetArray(int lenghtOfEnteredArray)
{
    string[] enteredStirngArray = new string[lenghtOfEnteredArray];
    for (int i = 0; i < enteredStirngArray.Length; i++)
    {
        bool isCorrect = false;
        while (!isCorrect)
        {
            Console.WriteLine($"Enter element {i + 1}:");
            enteredStirngArray[i] = Console.ReadLine();
            if (String.IsNullOrEmpty(enteredStirngArray[i]))
            {
                Console.WriteLine("Error: you have not entered any data.");
            }
            else
            {
                isCorrect = true;
                Console.WriteLine();
            }
        }
    }
    return enteredStirngArray;
}

void PrintArray(string[] array, string message)
{
    Console.Write($"{message} [");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.WriteLine($"{array[i]}]");
            Console.WriteLine();
        }
    }
}

int lenghtOfEnteredArray = GetNumber("Enter lenght of your array:");
string[] enteredStirngArray = GetArray(lenghtOfEnteredArray);

string[] ResultArray(string[] enteredStirngArray, int lengthOfResultArray)
{
    string[] resultArray = new string[lengthOfResultArray];
    int j = 0;
    for (int i = 0; i < enteredStirngArray.Length; i++)
    {
        if (enteredStirngArray[i].Length <= 3)
        {
            resultArray[j] = enteredStirngArray[i];
            j++;
        }
    }
    return resultArray;
}

int LengthOfResultArray(string[] enteredStirngArray)
{
    int count = 0;

    for (int i = 0; i < enteredStirngArray.Length; i++)
    {
        if (enteredStirngArray[i].Length <= 3)
        {
            count++;
        }
    }

    return count;
}

PrintArray(enteredStirngArray, "Original array:");
int lengthOfResultArray = LengthOfResultArray(enteredStirngArray);
if (lengthOfResultArray > 0)
{
    string[] resultArray = ResultArray(enteredStirngArray, lengthOfResultArray);
    PrintArray(resultArray, "Next element(s) of original array contain 3 or less characters:");
}
else
{
    Console.WriteLine("Original array does not contain elements with 3 or less characters.");
}