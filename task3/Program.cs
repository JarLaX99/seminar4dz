//Напишите прогрмамму, которая задает массив из 8 элементов и вывыдит их на экран

int Readint(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void Fullarray (int[] arr,int leftRange,int rightRange)
{
    Random rand = new Random() ;

    for(int i = 0;i<arr.Length;i++)
    {
        arr[i]= rand.Next(leftRange, rightRange);
    }
}
void PrintArray(int[] arr)
{
   System.Console.Write("[");
   System.Console.Write(string.Join("] [",arr));
   System.Console.WriteLine("]");
}

int sizeArray = Readint("Введите размер массива: ");
int[] array = new int[sizeArray];
int leftRangeArray = Readint("Введите диапозон генерируемых чисел от: ");
int rightRangeArray = Readint("Введите диапозон генерируемых чисел до: ");
Fullarray(array,leftRangeArray,rightRangeArray);
PrintArray(array);