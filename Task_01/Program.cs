// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

int[] GenerateArray(int size, int leftRange, int rightRange)
{
    int[] tempArray = new int[size];
    Random rand = new Random();

    for(int i = 0; i < size; i++)
    {
        tempArray[i] = rand.Next(leftRange, rightRange + 1);
    }

    return tempArray;
}

void PrintArrayAndCount(int[] array, int count)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "] => " + count);
}

int size = 10;
int[] myArray = GenerateArray(size, 1, 100); 

int count = 0;
for(int i = 0; i < size; i++) {
    if (myArray[i]>= 20 && myArray[i]<=90) {
        count++;
    }
}
PrintArrayAndCount(myArray, count);

