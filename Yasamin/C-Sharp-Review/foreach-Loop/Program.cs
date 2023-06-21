namespace foreach_Loop;

class Program
{
    static void Main(string[] args)
    {
        var names = new List<string>() { "John", "Tom", "Peter" };
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
}
