// Task 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
//значение этого элемента или же указание, что такого элемента нет.
Console.Clear();
Console.WriteLine("This program find array element by the entered indexes.");
int numberRow = EnterUserData("Enter number of rows:");
int numberCol = EnterUserData("Enter number of columns:");
int lowerLim = EnterUserData("Enter lower limit for random range:");
int upperLim = EnterUserData("Enter upper limit for random range:");
int precision = EnterUserData("Enter precision for numbers: ");
double[,] randomArray = new double[numberRow, numberCol];

FillArray(randomArray, numberRow, numberCol, lowerLim, upperLim, precision);
PrintArray(randomArray);
int indexRow = EnterUserData("Enter row index:") - 1;//make offset "-1" to start array indexes from 1
int indexCol = EnterUserData("Enter column index:") - 1;//make offset "-1" to start array indexes from 1

if (indexRow < 0 ||
    indexRow > randomArray.GetLength(0) ||
    indexCol < 0 ||
    indexCol > randomArray.GetLength(1))
{
    Console.WriteLine("There is no any array element with the entered indexes. Try again!");
}
else
{
    Console.WriteLine(randomArray[indexRow, indexCol]);
}

double [,] FillArray(double[,] array, int numberRow, int numberCol, int lowerLim, int upperLim, int precision)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            double randomNum = new Random().NextDouble() * (upperLim - lowerLim);
            array[i, j] = Math.Round(randomNum, precision);
        }
    }
    return array;
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

int EnterUserData(string nameUserData)
{
    Console.Write($"{nameUserData}");
    return Convert.ToInt32(Console.ReadLine());
}