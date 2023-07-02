double [] NewArray (float size_array)
{
    double [] array1 = new double [(int)size_array];
    for (int i = 0; i < size_array; i ++)
    {
        array1 [i] = new Random().NextDouble() * 100;
    }
    return array1;
} 
int size = 5;
double [] MyArray = NewArray (size);
double MaxEl = MyArray[0];
double MinEl = MyArray[0];
for (int i = 0; i < size; i++)
{
    if (MyArray[i] > MaxEl)
    {
        MaxEl = MyArray[i];
    }
    else if (MyArray[i] < MinEl)
    {
        MinEl = MyArray [i];
    }
    //Console.WriteLine(MyArray[i]);
}
double sum = MaxEl - MinEl;

//Console.WriteLine(MyArray[0 , 1, 2, 3.]);
Console.WriteLine($"The minimum value is: {MinEl:f3}");
Console.WriteLine($"The maximum value is: {MaxEl:f3}");
Console.WriteLine($"The difference between maximum and minimum is: {sum:f3}");

