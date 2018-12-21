namespace TestConsoleApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Zdravo, svete!");
            ArrabicToRomanConverter arrabicToRomanConverter = new ArrabicToRomanConverter();
            
            System.Console.WriteLine(arrabicToRomanConverter.Convert(18));
            System.Console.ReadKey();
            //stuf stuf stuff
        }
    }
}
