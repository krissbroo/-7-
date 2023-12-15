// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 

int ReadInt(string text)
{
System.Console.Write(text);
return Convert.ToInt32(Console.ReadLine());
}

int[] GenerateArray(int size, int leftRange, int rightRange)
{
int[] tempArray = new int[size];
Random rand = new Random();


for (int i = 0; i < size; i++)
{
tempArray[i] = rand.Next(leftRange, rightRange + 1);
}
return tempArray;
}

void PrintArray(int[] array)
{
System.Console.WriteLine($"[{string.Join(", ", array)}]");
}

int RightArray(int [] array, int i = 0)
{
    if(i < array.Length / 2 && i >= 0)
    System.Console.WriteLine(array[i], i++);
   return  RightArray(array.Lenght - 1 - i);
    
}


//---------------

int size = ReadInt("Введите размер массива: ");
int[] myArray = GenerateArray(size, 1, 10);
PrintArray(myArray);
RightArray(array);