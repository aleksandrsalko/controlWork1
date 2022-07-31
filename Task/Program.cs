string[] firstArray = new string[4] {"1234", "1567", "-2", "computer science"};
string[] secondArray = new string[firstArray.Length];
int count = 0;

FillArray(firstArray, secondArray);
PrintArray(secondArray);


void FillArray(string[] firstArray, string[] secondArray)
{
  for (int i = 0; i < firstArray.GetLength(0); i++)
  {
  if(firstArray[i].Length <= 3)
    {
    secondArray[count] = firstArray[i];
    count++;
    }
  }
}

void PrintArray(string[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write($"{array[i]} ");
  }
  Console.WriteLine();
}
