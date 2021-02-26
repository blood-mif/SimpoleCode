using System;

namespace ДЗ_5_2_Метод_добавления_или_удаления_элемента_массива_по_указоному_индексу
{
    class Program
    {

        static void Resize(ref int[] arr)
        {
            Console.WriteLine("Введите '+' если хотите добавить элемент или '-' если удалить");
            string symbol = Console.ReadLine();

            if (symbol == "+")
            {
                Console.WriteLine("Введите '+' если хотите добавить элемент в начало массива, '-' если в конец, если хотите заменить существующий элемент введите индекс элемента от 0 до " + (arr.Length - 1) + "Или другой индекс, если хотите добавить элементов");
                string indexElement = Console.ReadLine();
                Console.WriteLine("Введите значение нового элемента");
                int newElement = int.Parse(Console.ReadLine());

                if (indexElement == "+")
                {
                    int[] newArray = new int[arr.Length + 1];
                    newArray[0] = newElement;
                    for (int i = 0; i < arr.Length; i++)
                    {
                        newArray[i + 1] = arr[i];
                    }
                    arr = newArray;
                }
                else if (indexElement == "-")
                {
                    int[] newArray = new int[arr.Length + 1];
                    newArray[newArray.Length - 1] = newElement;
                    for (int i = 0; i < arr.Length; i++)
                    {
                        newArray[i] = arr[i];
                    }
                    arr = newArray;
                }
                else if (indexElement != "+" && indexElement != "-")
                {
                    int indexElementValue = Convert.ToInt32(indexElement);

 

                    if (indexElementValue < arr.Length-1)
                    {
                        int[] newArray = new int[arr.Length + 1];
                        newArray[indexElementValue] = newElement;
                        for (int i = 0; i < indexElementValue; i++)
                        {
                            newArray[i] = arr[i];
                        }
                        for (int i = indexElementValue; i < arr.Length; i++)
                        {
                            newArray[i + 1] = arr[i];
                        }
                        arr = newArray;
                    }
                    else
                    {
                    int[] newArray = new int[indexElementValue+1];
                        newArray[indexElementValue] = newElement;
                        for (int i = 0; i < arr.Length; i++)
                        {
                            newArray[i] = arr[i];
                        }

                        arr = newArray;
                    }
                  
                    
                }
                
            }
            else if (symbol=="-")
            {
                Console.WriteLine("Введите '+' если хотите удалить первый элемент массива, '-' если послежний или введите индекс элемента от 0 до " + (arr.Length - 1) + " для его удаления");
                string indexElement = Console.ReadLine();
                if (indexElement == "+")
                {
                    int[] newArray = new int[arr.Length - 1];

                    for (int i = 0; i < newArray.Length; i++)
                    {
                        newArray[i] = arr[i + 1];
                    }
                    arr = newArray;
                }
                else if (indexElement == "-")
                {
                    int[] newArray = new int[arr.Length - 1];

                    for (int i = 0; i < newArray.Length; i++)
                    {
                        newArray[i] = arr[i];
                    }
                    arr = newArray;
                }
                else if (indexElement != "+" && indexElement != "-")
                {
                    int indexElementValue = Convert.ToInt32(indexElement);
                    int[] newArray = new int[arr.Length - 1];
                    for (int i = 0; i < newArray.Length; i++)
                    {
                        if (indexElementValue==i)
                        {
                            
                            for (int j = i; j < newArray.Length; j++)
                            {
                                newArray[i] = arr[i+1];
                                i++;
                            }
                            break; 
                        }
                        newArray[i] = arr[i];
                    }
                    arr = newArray;
                }    

                }




        }



        static void Main(string[] args)
        {
            int[] myArray = { 2, 54, 43, 1, 7 };

            Resize(ref myArray);
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + "  ");
            }
            Console.ReadKey();

        }
    }
}
