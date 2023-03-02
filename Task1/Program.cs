// возвращаемые

//getSum [возвращаемый тип] [имя метода]([параметры])

int GetSum(int a, int b)
{
    int result = a + b;

    return result;
}

int sum = GetSum(10,15);
Console.WriteLine(sum);