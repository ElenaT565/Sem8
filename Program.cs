// Задача 56

Console.WriteLine("Колличество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Колличество столбцов: ");
int colums = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, colums, 1, 9);
PrintArray(array);


int summ = 0;
int min = 0;
int ID = 0;
for (int i = 0; i < array.GetLength(0) ; i++){
    for(int j = 0; j < array.GetLength(1); j++){
               summ += array[i,j];
     }
     if (i == 0) min = summ;
     if (summ < min) {
     min = summ;
     ID = i;
     }
      summ = 0;
   }
Console.WriteLine($"Мин сумма = {min}, строка {ID}");




int[,] GetArray(int m, int n, int minValue, int maxValue){
    int [,] result = new int[m,n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            result[i,j] = new Random().Next(minValue, maxValue +1);
        }
    }
    return result;
}

 void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
 }

