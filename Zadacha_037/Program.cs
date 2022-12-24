// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

System.Console.WriteLine("Укажите размер массива: ");
int SIZE = int.Parse(Console.ReadLine());

System.Console.WriteLine("Укажите левую границу цифр: ");
int LEFT_RANGE = int.Parse(Console.ReadLine());

System.Console.WriteLine("Укажите правую границу цифр: ");
int RIGHT_RANGE = int.Parse(Console.ReadLine());

int[] array = new int[SIZE];

int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1); // [-9; 10)
    }
    return arr;
}

int[] Mult(int[] arr)
{
    int size = arr.Length;
    int[] newArray = new int[size/2 +size%2];
    for (int i = 0; i < size/2; i++)
    {
        newArray[i] = arr[i] * arr[size - 1 - i];
    }
    if(size%2 != 0) 
    {
        newArray[size/2] = arr[size/2];
    }
    return newArray;

}

array = FillArrayWithRandomNumbers(SIZE, LEFT_RANGE, RIGHT_RANGE);
Console.WriteLine('[' + string.Join(", ", array) + ']');

int[] newArray = Mult(array);
Console.WriteLine('[' + string.Join(", ", newArray) + ']');