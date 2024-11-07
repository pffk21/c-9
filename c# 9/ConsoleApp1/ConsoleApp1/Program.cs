using System;
//задание 1
// namespace practica
// {
//     internal interface IOutput
//     {
//         void Show();
//         void Show(string info);
//     }
//
//     internal interface ICalc
//     {
//         int Less(int valueToCompare);
//         int Greater(int valueToCompare);
//     }
//     internal class Array : IOutput, ICalc
//     {
//         private int[] elements;
//
//         public Array(int[] elements)
//         {
//             this.elements = elements;
//         }
//
//         public void Show()
//         {
//             Console.WriteLine("Массив: ");
//             foreach (var element in elements)
//             {
//                 Console.Write(element + " ");
//             }
//             Console.WriteLine();
//         }
//
//         public void Show(string info)
//         {
//             Console.WriteLine(info);
//             Show();
//         }
//
//         public int Less(int valueToCompare)
//         {
//             int count = 0;
//             foreach (var element in elements)
//             {
//                 if (element < valueToCompare)
//                     count++;
//             }
//             return count;
//         }
//
//         public int Greater(int valueToCompare)
//         {
//             int count = 0;
//             foreach (var element in elements)
//             {
//                 if (element > valueToCompare)
//                     count++;
//             }
//             return count;
//         }
//     }
//
//     internal class Program
//     {
//         public static void Main()
//         {
//             int[] numbers = { 1, 2, 3, 4, 5 };
//             Array array = new Array(numbers);
//
//             array.Show();
//             array.Show("Info: ");
//             
//             Console.WriteLine("Количество элементов меньше 3: " + array.Less(3));
//             Console.WriteLine("Количество элементов больше 3: " + array.Greater(3));
//         }
//     }
// }



//задание 2
// using System;
//
// namespace practica
// {
//     internal interface IOutput
//     {
//         void Show();
//         void Show(string info);
//     }
//
//     internal interface IOutput2
//     {
//         void ShowEven();
//         void ShowOdd(); 
//     }
//
//     internal class Array : IOutput, IOutput2
//     {
//         private int[] elements;
//
//         public Array(int[] elements)
//         {
//             this.elements = elements;
//         }
//
//         public void Show()
//         {
//             Console.WriteLine("Массив: ");
//             foreach (var element in elements)
//             {
//                 Console.Write(element + " ");
//             }
//
//             Console.WriteLine();
//         }
//
//         public void Show(string info)
//         {
//             Console.WriteLine(info);
//             Show();
//         }
//
//         public void ShowEven()
//         {
//             Console.WriteLine("Четные значения: ");
//             foreach (var element in elements)
//             {
//                 if (element % 2 == 0)
//                     Console.Write(element + " ");
//
//             }
//
//             Console.WriteLine();
//         }
//
//         public void ShowOdd()
//         {
//             Console.WriteLine("Не четные значения: ");
//             foreach (var element in elements)
//             {
//                 if (element % 2 != 0)
//                     Console.Write(element + " ");
//
//             }
//
//             Console.WriteLine();
//         }
//
//     }
//
//     internal class Program
//     {
//         public static void Main()
//         {
//             int[] numbers = { 1, 2, 3, 4, 5 };
//             Array array = new Array(numbers);
//
//             array.Show();
//             array.Show("Info: ");
//             
//             array.ShowEven();
//             array.ShowOdd();
//
//         }
//     }
// }




//задание 3
// using System;
//
// namespace practica
// {
//     internal interface IOutput
//     {
//         void Show();
//         void Show(string info);
//     }
//
//     internal interface ICalc2
//     {
//         int CountDistinct();
//         int EqualToValue(int valueToCompare);
//     }
//
//     internal class Array : IOutput, ICalc2
//     {
//         private int[] elements;
//
//         public Array(int[] elements)
//         {
//             this.elements = elements;
//         }
//
//         public void Show()
//         {
//             Console.WriteLine("Массив: ");
//             foreach (var element in elements)
//             {
//                 Console.Write(element + " ");
//             }
//
//             Console.WriteLine();
//         }
//
//         public void Show(string info)
//         {
//             Console.WriteLine(info);
//             Show();
//         }
//
//         public int CountDistinct()
//         {
//             int count = 0;
//             for (int i = 0; i < elements.Length; i++)
//             {
//                 bool unikalen = true;
//                 for (int j = 0; j < i; j++)
//                 {
//                     if (elements[i] == elements[j])
//                     {
//                         unikalen = false;
//                         break;
//                     }
//                 }
//
//                 if (unikalen)
//                     count++;
//             }
//
//             return count;
//         }
//
//         public int EqualToValue(int valueToCompare)
//         {
//             int count = 0;
//             foreach (var element in elements)
//             {
//                 if (element == valueToCompare)
//                     count++;
//             }
//
//             return count;
//         }
//     }
//
//
//
//
// internal class Program
//     {
//         public static void Main()
//         {
//             int[] numbers = { 1, 2, 3, 4, 5 };
//             Array array = new Array(numbers);
//
//             array.Show();
//             array.Show("Info: ");
//             int valueToCompare = 3;
//             Console.WriteLine($"Количество уникальных значений в массиве: {array.CountDistinct()}");
//             Console.WriteLine($"Количество равных значений {valueToCompare}: {array.EqualToValue(valueToCompare)}");
//
//         }
//     }
// }
//
