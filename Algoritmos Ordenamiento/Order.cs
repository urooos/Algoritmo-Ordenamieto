using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos_Ordenamiento
{
    internal class Order
    {

        public static long SwapCount = 0;
        public static long ComparisonCount = 0;

        public static void QuickSort(int[] array, int leftIndex, int rightIndex)
        {
            var i = leftIndex;
            var j = rightIndex;


            var pivot = array[leftIndex + (rightIndex - leftIndex) / 2];

            while (i <= j)
            {

                ComparisonCount++;
                while (array[i] < pivot)
                {
                    i++;
                    ComparisonCount++;
                }

                ComparisonCount++;
                while (array[j] > pivot)
                {
                    j--;
                    ComparisonCount++;
                }

                if (i <= j)
                {

                    QuickExchange(array, i, j);
                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (leftIndex < j)
                QuickSort(array, leftIndex, j);

            if (i < rightIndex)
                QuickSort(array, i, rightIndex);
        }
        private static void QuickExchange(int[] array, int index1, int index2)
        {
            if (index1 == index2) return;

            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;

            SwapCount++;
        }

        public static void InsertSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int actual = array[i];
                int j = i - 1;

                while (j >= 0)
                {
                    ComparisonCount++;
                    if (array[j] > actual)
                    {
                        array[j + 1] = array[j];
                        SwapCount++;
                        j--;
                    }
                    else
                    {
                        break;
                    }
                }
                array[j + 1] = actual;
            }
        }

        public static void BubbleSort(int[] array)
        {
            int n = array.Length;
            bool swapped;

            for (int i = 0; i < n - 1; i++) // controla las pasadas
            {
                swapped = false; // bandera para detectar si hubo intercambios

                for (int j = 0; j < n - i - 1; j++)
                {
                    ComparisonCount++;
                    if (array[j] > array[j + 1])
                    {
                        BubbleSortCocktailExchange(array, j, j + 1);
                        swapped = true;
                    }
                }
                if (!swapped) break;
            }
        }

        public static void CocktailSort(int[] array)
        {
            bool swapped = true;
            int start = 0;
            int end = array.Length;

            while (swapped)
            {
                swapped = false;

                // --- IDA (Izquierda -> Derecha) ---
                // Lleva el más grande al final
                for (int i = start; i < end - 1; i++)
                {
                    ComparisonCount++;
                    if (array[i] > array[i + 1])
                    {
                        BubbleSortCocktailExchange(array, i, i + 1);
                        swapped = true;
                    }
                }

                if (!swapped) break; // Si no hubo cambios, terminamos

                swapped = false;
                end = end - 1; // "Protegemos" la última posición que ya tiene al mayor

                // --- VUELTA (Derecha -> Izquierda) ---
                for (int i = end - 2; i >= start; i--)
                {
                    ComparisonCount++;
                    if (array[i] > array[i + 1])
                    {
                        BubbleSortCocktailExchange(array, i, i + 1);
                        swapped = true;
                    }
                }

                start = start + 1; // "Protegemos" la primera posición
            }
        }
        /// Helper method to swap two elements in an array.
        private static void BubbleSortCocktailExchange(int[] array, int index1, int index2)
        {
            if (index1 == index2) return;
            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
            SwapCount++;
        }

        public static void SelectionSort(List<int> arr)
        {
            
            int n = arr.Count;
            for (int i = 0; i < n - 1; i++)
            {
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                {
                    ComparisonCount++;
                    if (arr[j] < arr[min_idx])
                    {
                        min_idx = j;
                    }
                }
                if (min_idx != i)
                {
                    int temp = arr[min_idx];
                    arr[min_idx] = arr[i];
                    arr[i] = temp;
                    SwapCount++;
                }
            }
        }

        private static void Heapify(int[] arr, int n, int i)
        {
            // El mayor es la raíz del subárbol
            int largest = i;
            int l = 2 * i + 1;
            int r = 2 * i + 2;

            if (l < n)
            {
                ComparisonCount++;
                if (arr[l] > arr[largest])
                    largest = l;
            }

            if (r < n)
            {
                ComparisonCount++;
                if (arr[r] > arr[largest])
                    largest = r;
            }

            // Intercambia elementos
            if (largest != i)
            {
                SwapCount++;
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;
                Heapify(arr, n, largest);
            }
        }
        public static void HeapSort(int[] arr)
        {
            int n = arr.Length;

            // Construir Max-Heap. Desde el último nodo padre hacia la raíz
            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(arr, n, i);

            // Extraer elementos.
            for (int i = n - 1; i > 0; i--)
            {
                SwapCount++;
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;
                // Reparar el heap reducido
                Heapify(arr, i, 0);
            }
        }

        public static void ShellSort(int[] arr ,ref long comparisons, ref long swaps)
        {
            int n = arr.Length;

            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i++)
                {
                    int temp = arr[i];
                    int j = i;
                    bool moved = false;
                    // Desplazar elementos mayores que temp
                    while (j >= gap)
                    {
                        comparisons++; // contamos la comparación real
                        if (arr[j - gap] > temp)
                        {
                            arr[j] = arr[j - gap]; // mover elemento
                            swaps++;               // contar movimiento
                            j -= gap;
                            moved = true;
                        }
                        else
                        {
                            break; // si no es mayor, se sale
                        }
                    }

                    if (moved) // solo si hubo desplazamiento
                    {
                        arr[j] = temp; // colocar temp en su posición
                        swaps++;       // contar colocación final
                    }
                }
            }
        }
        public static void GnomeSort(int[] array)
        {
            int index = 0;

            while (index < array.Length)
            {
                ComparisonCount++; 
                if (index == 0)
                {
                    index++;
                    continue;
                }

                ComparisonCount++;
                if (array[index] >= array[index - 1])
                {
                    
                    index++;
                }
                else
                {
                    Exchange(array, index, index - 1);
                    index--;
                }
            }
        }

        private static void Exchange(int[] array, int index1, int index2)
        {
            if (index1 == index2) return;

            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;

            SwapCount++;
        }



    }
}



