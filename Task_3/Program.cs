using static System.Console;
using Task_6;

namespace Task_3
{
    #region Задание №3
    //Написать функцию обхода графа в ширину
    #endregion
    class Program
    {
       static int x = int.MaxValue;

        static int[,] graph = new int[7, 7]
        {
            {  0, 36,  x, 38,  x, 49, 45},
            { 36,  0,  x, 46,  x,  x,  x },
            {  x,  x,  0, 20, 44,  1, 32},
            { 38, 46, 20,  0,  x,  x,  x},
            {  x,  x, 44,  x,  0,  x,  x},
            { 49,  x,  1,  x,  x,  0,  x},
            { 45,  x, 32,  x,  x,  x,  0}
        };

        /// <summary>
        /// Написать рекурсивную функцию обхода графа в глубину
        /// </summary>
        static void RoundDepth(ref int[,] array, int start)
        {
            array[start, 0] += 1;
            array[start, 1] = 1;
            for (int i = 0; i < graph.GetLength(0); i++)
            {
                if (graph[start, i] != int.MaxValue && array[i, 1] == 0)
                {
                    array[i, 0] = array[start, 0];
                    RoundDepth(ref array, i);
                }
            }
        }

        /// <summary>
        /// Написать функцию обхода графа в ширину
        /// </summary>
        static void RoundWitch(ref int[,] array, int start)
        {
            array[start, 0] += 1;
            array[start, 1] = 1;
            for (int i = 0; i < graph.GetLength(0); i++)
            {
                if (graph[start, i] != int.MaxValue && array[i, 1] == 0)
                {
                    RoundDepth(ref array, i);
                }
            }
        }

        static void Main(string[] args)
        {
            int[,] array = new int[graph.GetLength(0), 2];
            int depth = int.MinValue;

            RoundDepth(ref array, 0);

            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (array[i, 0] > depth)
                {
                    depth = array[i, 0];
                }
            }

            WriteLine($"Глубина графа = {depth}");

            ReadKey();

            array = new int[graph.GetLength(0), 2];
            depth = int.MinValue;

            RoundWitch(ref array, 0);

            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (array[i, 0] > depth)
                {
                    depth = array[i, 0];
                }
            }

            WriteLine($"Ширина графа = {depth}");

            ReadKey();
        }
    }
}
