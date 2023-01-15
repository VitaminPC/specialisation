internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите массив строк через пробел");
        string proposal = Console.ReadLine();
        if (string.IsNullOrEmpty(proposal))
        {
            Console.WriteLine("Массив не введен. Будет использован тестовый массив");
            proposal = "Hello 2 World :-)";
        }

        string[] array = proposal.Split(' ');
        int size = array.Length;

        PrintArray(array);

        string[] result = new string[0];

        for (int i = 0; i < size; i++)
            if (array[i].Length <= 3)
            {
                Array.Resize(ref result, result.Length + 1);
                result[result.Length - 1] = array[i];
            }

        PrintArray(result);

    }

    static void PrintArray(string[] array)
    {
        Console.WriteLine();
        Console.Write("[ ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"\"{array[i]}\"{(i == array.Length - 1 ? " " : ", ")}");
        }
        Console.Write("]");
        Console.WriteLine();

    }
}