// Двумерные массивы
string[,]table = new string[2, 5]; // задание прямоугольной таблицы чисел/матрицы.тип данных [,] - означает,что будет две размерности, будут две размерности строки(2) и столбцы(5)
//table [0,0] отсчет всегда от 0
// table[0,1 ] - 1 столбик
// table[0,2 ] - 2столбик
// table[1,0 ] - 1 строка

// table[1,2]=  "слово"; // наименовние массива, обращаемся к индексу строки-1 и столбцу2 ,"слово" -переменная
//  String.Empty - инициализация строк
// for (int rows = 0; rows < 2; rows++)  //строки
// {
//     for( int colums = 0; colums < 5; colums++) //столбцы
//     {
//         Console.WriteLine($"-{table[rows, colums]}-"); //обращаемся к индексу строки и ндексу столбца
//     }
// }


void PrintArray(int[,] matr)
{
for (int i = 0; i < matr.GetLenght(0); i++) // matr.GetLenght(0), где matr -имя массива, - GetLenght(0)-кол-во строк/столбцов,начинаем с 0
{
    for( int j = 0; j < matr.GetLenght(1); j++)
    {
Console.Write($"{matr[i, j]} ");
    }
    Console.WriteLine();// выводим отдельну строчку,чтобы была матрица
}
}
void FillArray [int [,] matr]  //заполнение матрицы случайными числами
{
    for(int i = 0; i < matr.GetLenght(0); i++)
    {
        for( int j = 0; j < matr.GetLenght(1); j++)
        {
            matr [i, j] = new Random().Next(1,10); //инетрвал от 1 до 10
        }
    }

}
int[,] matrix = new int[3, 4]; //определяем двумерный массив
PrintArray(matrix);
FillArray(matrix);
PrintArray(matrix);