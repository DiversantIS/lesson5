/* Задача 34: Задайте массив заполненный случайными положительными трехзначными числами.
Напишите программу, которая покажет количество четных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
Console.Clear();
Console.WriteLine($"Задача 34. Количество четных чисел в массиве:\n");
int[] num = new int[10];

void FillArray(int[] array, int min, int max){
  for (int i = 0; i<array.Length; i++ ){
    array[i] = new Random().Next(min, max);
  }
}

void WriteArray(int[] array){
    for (int i = 0; i<array.Length; i++ ){
    Console.Write(array[i] + " ");
  }
  Console.WriteLine();
}

int numIsEvenPositive(int[] array){
    int numIsEven = 0;
    for (int i = 0; i<array.Length; i++ ){
    if (array[i] % 2 == 1)
    {
      numIsEven++;
    }
  }
  return numIsEven;
}

FillArray(num, 100, 1000);
WriteArray(num);
Console.WriteLine();

int numIsEven = numIsEvenPositive(num);
Console.WriteLine($"Количество четных чисел в массиве: {numIsEven}\n");


/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/



Console.WriteLine($"\nЗадача 36. Сумма элементов, стоящих на нечетных позициях:\n");
Console.Write($"Введите количество элементов массива: ");
int numElements = Convert.ToInt32(Console.ReadLine()); 

int RandomNum(int numElements, int min, int max)
  {
  int[] randomNum = new int[numElements];
  int sumElements = 0;
  Console.Write("Получившийся массив: ");

    for (int i = 0; i <randomNum.Length; i++ ){
      randomNum[i] = new Random().Next(min, max);

      Console.Write(randomNum[i] + " ");

      if (i % 2 != 1)
      {
        sumElements = sumElements + randomNum[i];
      }
    }
  return sumElements;
  }

int randomNum =  RandomNum(numElements, 1, 10);

Console.WriteLine($"\nСумма элементов, стоящих на нечетных позициях: {randomNum}");


/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
 [3 7 22 2 78] -> 76
*/
//Console.Clear();
Console.WriteLine($"\nЗадача 38. Найдите разницу между максимальным и минимальным элементов массива из вещественных чисел:\n");

double[] arrayRealNum= new double[10];
  for (int i = 0; i < arrayRealNum.Length; i++ )
  {
    arrayRealNum[i] = new Random().Next(1, 10);
    Console.Write(arrayRealNum[i] + " ");
  }

double maxNum = arrayRealNum[0];
double minNum = arrayRealNum[0];

  for (int i = 1; i < arrayRealNum.Length; i++)
  {
    if (maxNum < arrayRealNum[i])
    {
      maxNum = arrayRealNum[i];
    }
        if (minNum > arrayRealNum[i])
    {
      minNum = arrayRealNum[i];
    }
  }

  double answer = maxNum - minNum;

  Console.WriteLine($"\nРазница между максимальными ({maxNum}) и минимальными({minNum}) элементами: {answer}");