// Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.


//если указывать начала массива из консоли от 100 до 999, то подойдет этот способ
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

int hero(int[] arr){
    int y = 0;
    for(int i = 0; i < arr.Length; i++){
        if (arr[i] % 2  == 0) {
            y++;
        }
    }
    return y;
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

Console.Write($"итог: {hero(mass)}");




// 2 способ

// int[] ArrNums(int size){
//     int[] arr = new int[size];

//     for (int i = 0; i < size; i++){
//         arr[i] = new Random().Next(100, 1000);
//     }
//     return arr;
// }

// void print(int[] arr){
//     int size = arr.Length;
//     for (int i = 0; i < size; i++){
//         Console.Write($"{arr[i]} ");
//     }
//     Console.WriteLine();
// }

// int hero(int[] arr){
//     int y = 0;
//     for(int i = 0; i < arr.Length; i++){
//         if (arr[i] % 2  == 0) {
//             y++;
//         }
//     }
//     return y;
// }

// Console.WriteLine("Введите размер массива: ");
// int num = int.Parse(Console.ReadLine()!);
// int[] mass = ArrNums(num);

// Console.WriteLine("транслируем массив: ");
// print(mass);

// Console.Write($"итог: {hero(mass)}");