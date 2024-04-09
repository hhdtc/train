// See https://aka.ms/new-console-template for more information


using ConsoleApp2;

int[] GenerateNumbers()
{
    return new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
}
void Reverse( int[] numbers)
{
    int tmp = 0;
    for (int i = 0; i < numbers.Length/2; i++)
    {
        tmp = numbers[i];
        numbers[i] = numbers[9 - i];
        numbers[9 - i] = tmp;
    }
}

void PrintNumbers(int[] numbers)
{
    Console.WriteLine(string.Join(", ", numbers));
}



int Fib(int n) {
    if (n<=2)
    {
        return 1;
    }
    else {
        return Fib(n - 1) + Fib(n - 2);
    }
}




int[] numbers = GenerateNumbers();
Reverse(numbers);
PrintNumbers(numbers);

for (int i = 1; i <= 10; i++) { 
    Console.WriteLine(Fib(i));
}



Color c = new Color(10, 10, 10, 10);
Ball b = new Ball(c, 10);
b.Throw();
b.Throw();
Console.WriteLine(b.ThrowCount());

b.Pop();

b.Throw();
Console.WriteLine(b.ThrowCount());
b.Size = 10;
b.Throw();
b.Throw();
Console.WriteLine(b.ThrowCount());



