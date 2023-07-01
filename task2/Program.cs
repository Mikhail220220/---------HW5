int [] NewArray (int size_array)
{
    int [] array1 = new int [size_array];
    for (int i = 0; i < size_array; i ++)
    {
        array1[i] = new Random().Next(10, 100);
    }
    return array1;
}

int sum = 0;
int size = 4;
int [] MyArray = NewArray(size);
for (int i =1; i < size; i += 2)
{
    int sum1 = MyArray[i];
    sum += sum1;
    Console.WriteLine(MyArray[i]);

}
Console.WriteLine(sum);