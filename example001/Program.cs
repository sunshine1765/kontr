// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


Console.Clear();

string[] DeletedString(string[] array)
{
   string[] arr = new string [0];
   for (int i = 0; i < array.Length; i++)
   {
        if(array[i].Length <= 3)
        {
           arr = Append(arr, array[i]);
        }
   }
   return arr;
}

string[] Append(string[] array, string element)
{
    string[] arr = new string[array.Length + 1];
    for (int i = 0; i < array.Length; i++)
    {
        arr[i] = array[i];
    }
    arr[arr.Length - 1] = element;
    return arr;
}

void PrintArray(string[] arr) 
{ 
    for (int i = 0; i < arr.Length; i++) 
    { 
        if(i == arr.Length - 1)
        {
            Console.Write(arr[i] + " "); 
        }
        else
        {
            Console.Write(arr[i] + ", "); 
        }
    } 
    Console.WriteLine(); 
} 


string[] array = new string []{"1234", "1567", "-2", "computer science"};

string[] res = DeletedString(array);
PrintArray(res);



