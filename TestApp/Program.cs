// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
public class Calculator()
{
    public int Add(int a, int b)
    {
        return a + b;
    }
    public int Sub(int a, int b)
    {
        return a - b;
    }
    public IEnumerable<int> GetOddNumbers(int limit)
    {
        for (var i = 0; i <= limit; i++)
            if (i%2 !=0) 
                    yield return i;
    }
}