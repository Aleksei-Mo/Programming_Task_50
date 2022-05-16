// Task 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
//значение этого элемента или же указание, что такого элемента нет.
Console.Clear();
Console.WriteLine("This program ");
Console.Write("Enter number of columns: ");
int numberCol = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number of rows: ");
int numberRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter lower limit for random range: ");
int lowerLim = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter upper limit for random range: ");
int upperLim = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter precision for numbers: ");
int precision = Convert.ToInt32(Console.ReadLine());
double[,] randomArray = new double[numberCol, numberRow];
FillArray(randomArray,numberCol,numberRow,lowerLim,upperLim,precision);
PrintArray(randomArray);
Console.Write("Enter column index: ");
int indexCol = Convert.ToInt32(Console.ReadLine())-1;//make offset "-1" to start array indexes from 1
Console.Write("Enter row index: ");
int indexRow = Convert.ToInt32(Console.ReadLine())-1;//make offset "-1" to start array indexes from 1

if (indexCol < 0 ||
    indexCol > randomArray.GetLength(0) ||
    indexRow < 0 ||
    indexRow > randomArray.GetLength(1))
{
    Console.WriteLine("There is no any array element with the entered indexes. Try again!");
}
else
{
    Console.WriteLine(randomArray[indexCol, indexRow]);
}

void  FillArray (double [,] array,int numberCol, int numberRow, int lowerLim, int upperLim, int precision)
{
for (int i = 0; i < randomArray.GetLength(0); i++)
{
    for (int j = 0; j < randomArray.GetLength(1); j++)
    {
        double randomNum = new Random().NextDouble() * (upperLim - lowerLim);
        randomArray[i, j] = Math.Round(randomNum, precision);
    }
}
}
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
