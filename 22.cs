// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 9

int ReadInt(string str)
{
   Console.WriteLine(str);
   return Convert.ToInt32(Console.ReadLine());
}

int FuncAc(int m, int n)
{
    if(m == 0) 
    return (n + 1);

    else if(m > 0 && n == 0 )
    return FuncAc(m - 1, 1);

    else return FuncAc(m - 1, FuncAc(m, n - 1));
}

//--------------
int m = ReadInt("Введите m");
int n = ReadInt("Введите n");
int Akkerm = FuncAc(m,n);
System.Console.WriteLine($"  -> Akkerm(m,n) =  {Akkerm}  ");
