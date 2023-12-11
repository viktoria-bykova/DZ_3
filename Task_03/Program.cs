//Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. 
//Найдите разницу между максимальным и минимальным элементов массива.

double[] GenerateArray(int size)
{
    double[] tempArray = new double[size];
    Random rand = new Random();

    for(int i = 0; i < size; i++)
    {
        //+0.1 потому что в условии стоит, что элементы массива должны иметь ненулевую дробную часть, а rand.NextDouble() может вернуть 0.0
        tempArray[i] = Math.Round(rand.Next(0, 10) + rand.NextDouble() + 0.1, 2);
    }

    return tempArray;
}

void PrintArrayAndCount(double[] array, double min, double max)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "] => Min: " + min + ", Max: " + max + ", Difference: " + Math.Round(max-min, 2));
}

int size = 10;
double[] myArray = GenerateArray(size); 

double min = myArray[0];
double max = myArray[0];
for(int i = 0; i < size; i++) {
    if (myArray[i] > max) {
        max = myArray[i];
    }
    if (myArray[i] < min) {
        min = myArray[i];
    }
}
PrintArrayAndCount(myArray, min, max);