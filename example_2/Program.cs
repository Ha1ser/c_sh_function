// Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)


int[] ArrNums(int size, int from, int to){
    int[] arr = new int[size];

    for (int i = 0; i < size; i++){
        arr[i] = new Random().Next(from, to + 1); 
    }
    return arr;
}

void print(int[] arr){
    int size = arr.Length;
    for (int i = 0; i < size; i++){
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

void Per(int[] arr){
    int size = arr.Length;
    int k = size - 1;
    int temp;
    for(int i = 0; i < size / 2; i++){
        temp = arr[i];
        arr[i] = arr[k];
        arr[k] = temp;
        k--;
    }
}

Console.WriteLine("Введите размер массива: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Минемальное значение случайного числа: ");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Максимальное значение случайного числа: ");
int stop = int.Parse(Console.ReadLine()!);
int[] mass = ArrNums(num, start, stop);

Console.WriteLine("транслируем массив: ");
print(mass);

Per(mass);
Console.WriteLine("итог: ");
print(mass);
