// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
//длина которых не превышает 3 символа

string[] arrStrings = new string[]  {};
int n = InputNumbers("Введите количество строк: ");
  arrStrings = new string[n];
  for (int i = 0; i < arrStrings.Length; i++)
  {
    Console.Write($" Введите {i+1} строку: ");
    arrStrings[i] = Console.ReadLine();
  }
  void FillNewArray(string[] array, string[] newArray, int length)
{
  int temp = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i].Length <= length)
    {
      newArray[temp] = array[i];
      temp++;
    }
  }
}

int CheckArray(string[] array, int length)
{
  int result = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i].Length <= length) result++;
  }
  return result;
}

string PrintArray(string[] array)
{ 
  string result = string.Empty;
   for (int i = 0; i < array.Length; i++)
  {
    result += $"{array[i],1}";
    if (i < array.Length - 1) result += ", ";
  }
    return result;
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
int length = 3;
int items = CheckArray(arrStrings, length);
string[] finalArray = new string[items];
FillNewArray(arrStrings, finalArray, length);
Console.WriteLine("Получаем следующий массив: " + $"{PrintArray(finalArray)}");