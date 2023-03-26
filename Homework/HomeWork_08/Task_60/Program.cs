// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] Create3DArray(int m, int n, int l)
{
    return new int[m, n, l];
}

int[] CreateUniqueNumArray()
{
    int[] tempArr = new int[90];
    Random rand = new Random();
    for (int i = 0; i < tempArr.Length; i++)
    {
        int num;
        bool exist;
        do
        {
            num = rand.Next(10, 100);
            exist = false;

            for (int j = 0; j < i; j++)
                if (tempArr[j] == num)
                {
                    exist = true;
                    break;
                }
        } while (exist);

        tempArr[i] = num;
    }

    return tempArr;
}
void Fill3DArray(int[,,] array3D)
{
    int[] tempArr = CreateUniqueNumArray();

    // for (int i = 0; i < tempArr.Length; i++)
    // {
    //     Console.Write($"{tempArr[i],3}");
    // }
    // Console.WriteLine();

    int n = 0;

    for (int i = 0; i < array3D.GetLength(0); i++)
        for (int j = 0; j < array3D.GetLength(1); j++)
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                array3D[i, j, k] = tempArr[n % tempArr.Length];
                n++;
            }
}

void Output3DArray(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"{array3D[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
}

void Output(string msg)
{
    Console.WriteLine(msg);
}

int m = 4, n = 2, l = 3;
int[,,] array3D = Create3DArray(m, n, l);
Fill3DArray(array3D);
Output("Сгенерированный 3D массив: ");
Output3DArray(array3D);
