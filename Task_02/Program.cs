// Задача 2: Задайте массив на 10 целых чисел. 
// Напишите программу, которая определяет количество чётных чисел в массиве.

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
    if (myArray[i] % 2 == 0) {
        count++;
    }
}
PrintArrayAndCount(myArray, count);