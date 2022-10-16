//Задание 34
//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] array = AddArray(6, 100, 999);
Console.WriteLine("Заданный массив: " + String.Join(" ", array));
int Count = Counter(array);
Console.WriteLine($"Четных чисел в массиве = {Count}");

int Counter(int[] array){
    int count = 0;
    for (int i = 0; i < array.Length; i++){
        if (array[i] % 2 == 0){
            count++;
        }
    }
    return count;
}
*/
//Задание 36
//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] array = AddArray(8, 0, 100);
Console.WriteLine("Заданный массив: " + String.Join(" ", array));
int result = Sum(array);
Console.WriteLine($"Сумма чисел, стоящих на нечетных позициях = {result}");

int Sum(int[] array){
    int sum = 0;
    for (int i = 0; i < array.Length; i++){
        if (i % 2 == 1){
            sum+=array[i];
        }
    }
    return sum;
}
*/
//Задание 38
//Задайте массив вещественных чисел(просто от минус бесконечности, до плюс бесконечности, с дробными не работаем). 
//Найдите разницу между максимальным и минимальным элементов массива.
/*
int[] array = AddArray(5, -10000000, 10000000);
Console.WriteLine("Заданный массив: " + String.Join(" ", array));
int result = Difference(array);
Console.WriteLine($"Разница между максимальным и минимальным значением = {result}");

int Difference(int[] array){
    int min = array[0];
    int max = array[0];
    int difference = 0;
    for(int i = 0; i < array.Length; i++){
        if (min > array[i]) min = array[i];
        if (max < array[i]) max = array[i];
    }
    difference = max - min;
    return difference;
}
*/


int[] AddArray(int size, int lowerlimit, int upperlimit){
    int[] res = new int[size];
    for (int i = 0; i < size; i++){
        res[i] = new Random().Next(lowerlimit, upperlimit + 1);
    }
    return res;
}