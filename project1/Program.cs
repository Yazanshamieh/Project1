class Program
{

    static int repeating_count(int[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {

            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] == array[j]) count++;

            }

        }
        return count;

    }
    public static int Recursive_count(int[] array)
    {


        if (array == null || array.Length == 0)
        {

            Console.WriteLine("Array is empty");
            return -1;
        }

        int count = 0;
        int length = array.Length;

        for (int i = length - 1; i >= 0; i--)
        {
            for (int j = i - 1; j >= 0; j--)
            {
                if (array[i] == array[j])
                {
                    count++;
                }
            }
        }

        return count;

    }
    private static void Main(string[] args)
    {
        int[] array = new int[10];
        Random n = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = n.Next(25, 75);
        }
        foreach (int i in array) { Console.WriteLine(i); }
        Console.WriteLine("The number of repetitions of the values is :" + repeating_count(array));
        Console.WriteLine("___________________________________________");
        Console.WriteLine("The number of repetitions of the values is :" + Recursive_count(array));


    }
}

