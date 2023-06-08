// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] StringArrayUserInput(int size)
{
  string[] array = new string[size];

  for (int i = 0; i < size; i++)
  {
    Console.Write($"Введите {i}-й элемент массива: ");
    array[i] = Console.ReadLine();
  }
  return array;
}

void displayArray(string[] arrayToDisplay)
{
  Console.Write("[ ");
  for (int i = 0; i < arrayToDisplay.Length - 1; i++)
  {
    Console.Write("\"" + arrayToDisplay[i] +"\"" + " , ");
  }
  Console.Write("\"" + arrayToDisplay[arrayToDisplay.Length - 1] + "\"" + " ]");
  Console.WriteLine();
}

string[] chooseElements(string[] array) 
{
  int size = array.Length;
  int newSize = 0;
  int n = 0;
  string[] newArray = new string[newSize];

  for (int i = 0; i < size; i++)
  {
    if (array[i].Length <= 3)
    {
      newSize++;
      Array.Resize(ref newArray, newSize);
      newArray[n] = array[i];
      n++;
    }
  }
  return newArray;
}

Console.Write("Введите колличество элементов массива(натуральное число): ");
int size = Convert.ToInt32(Console.ReadLine());
if (size > 0)
{
  string[]array = StringArrayUserInput(size);

  Console.Write("Первоначальный массив: ");
  displayArray(array);

  string[]newArray = chooseElements(array); 

  Console.Write("Массив строк, длина которых меньше, либо равна 3 символам: ");
  displayArray(newArray);
}
else
  Console.WriteLine("Введенное число не является натуральным.");
