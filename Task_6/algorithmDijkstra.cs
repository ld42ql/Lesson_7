using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Task_6
{
    class AlgorithmDijkstra
    {
        /// <summary>
        /// Матрица смежности для алгоритма
        /// </summary>
        Unit[,] graph;

        /// <summary>
        /// Кратчайший путь
        /// </summary>
        int[] resGraph;

        Queue<int> queue = new Queue<int>();

        public AlgorithmDijkstra(Unit[,] graph, int point)
        {
            this.graph = graph;
            resGraph = Metod(point);
        }

        int[] Metod(int point)
        {
            int[] resArray = new int[graph.GetLength(0)];

            for (int i = 0; i < graph.GetLength(0); i++)
            {
                if (graph[point, i].weight != int.MaxValue)
                {

                    resArray[i] = graph[point, i].weight;

                    queue.Enqueue(i);
                }
                else
                {
                    resArray[i] = int.MaxValue;
                }

            }
            while (queue.Count != 0)
            {
                point = queue.Dequeue();

                for (int i = 0; i < graph.GetLength(0); i++)
                {
                    if (resArray[point] != int.MaxValue && graph[point, i].weight != int.MaxValue)
                    {
                        if (resArray[point] + graph[point, i].weight < resArray[i])
                        {
                            resArray[i] = resArray[point] + graph[point, i].weight;
                            queue.Enqueue(i);
                        }
                    }
                }
            }
            return resArray;
        }

        /// <summary>
        /// Ввывести матрицу смежности в консоль
        /// </summary>
        public void ViewGraph()
        {
            for (int i = 0; i < resGraph.GetLength(0); i++)
            {
                if (resGraph[i] != int.MaxValue)
                {
                    Write($"{resGraph[i]} ");
                }
                else
                {
                    Write("- ");
                }
            }
        }
    }
}