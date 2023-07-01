internal class Program
{
    private static void Main(string[] args)
    {
        int[] NewArray(int size_array)
        {
            int[] array1 = new int[size_array];
            for (int i = 0; i < size_array; i++)
            {
                array1[i] = new Random().Next(100, 1000);

            }
            return array1;
        }

        int size = 3;
        int[] MyArray = NewArray(size);
        int sum = 0;
        int sum1 = 0;
        for (int i = 0; i < size; i++)
        {
            //int sum = 0;
            //sum += i;
            if (MyArray[i] % 2 == 0)
            {
                //int sum = 0;
                sum++;
                Console.WriteLine(MyArray[i]);
                //return;
            }
            else if (MyArray[i] % 2 != 0)
            {
                sum1++;
                //Console.WriteLine("no");
            }
            
            //Console.WriteLine(sum);
        }
        Console.WriteLine($"sum of positive numberssum: {sum}");
        Console.WriteLine($"Sum of negative numbers: {sum1}");
        
    }
}