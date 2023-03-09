
int[] array = { 10, 4, 6, 5, 20, 36, 40 };
int index;
int[] newArray = new int[array.Length];
int newIndex = 0;

for (index = 0; index < array.Length; index++)
{
    if (array[index] % 5 == 0)
    {
        newArray[newIndex] = array[index];
        newIndex++;
    }
}

for (newIndex = 0; newIndex < newArray.Length; newIndex++)
{
    Console.Write(newArray[newIndex] + " ");
}
