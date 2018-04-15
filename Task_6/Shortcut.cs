using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Task_6
{
    /// <summary>
    /// Класс с алгоритмами обхода графа и поиска коротких путей
    /// </summary>
    class Shortcut
    {
        /// <summary>
        /// Матрица смежности для алгоритма
        /// </summary>
        Unit[,] graph;

        /// <summary>
        /// Массив с данными с весом путей
        /// </summary>
        public int[] result;

        Queue<int> queue;

        int start;
        int end;

        private Shortcut() { }

        /// <summary>
        /// Все короткие путь от одной вершины
        /// </summary>
        /// <param name="graph">Граф</param>
        /// <param name="start">Вершина</param>
        public Shortcut(Unit[,] graph, int start)
        {
            this.graph = graph;
            this.start = start;
            AllWayOnePoint(start);
        }

        public Shortcut(Unit[,] graph, int start, int finish)
        {
            this.graph = graph;
        }

        /// <summary>
        /// Нахожденние самых коротких путей от одной вершины до всех вершин
        /// </summary>
        /// <param name="point">Начальная вершина</param>
        /// <returns></returns>
        void AllWayOnePoint(int point)
        {
            result = new int[graph.GetLength(0)];

            queue = new Queue<int>();

            for (int i = 0; i < graph.GetLength(0); i++)
            {
                if (graph[point, i].weight != int.MaxValue)
                {
                    result[i] = graph[point, i].weight;

                    queue.Enqueue(i);
                }
                else
                {
                    result[i] = int.MaxValue;
                }
            }

            while (queue.Count != 0)
            {
                point = queue.Dequeue();

                for (int i = 0; i < graph.GetLength(0); i++)
                {
                    if (result[point] != int.MaxValue && graph[point, i].weight != int.MaxValue)
                    {
                        if (result[point] + graph[point, i].weight < result[i])
                        {
                            result[i] = result[point] + graph[point, i].weight;
                            queue.Enqueue(i);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Ввывести данные о всех коротких путях для одной точки
        /// </summary>
        public void ViewAllWayOnePoint()
        {
            for (int i = 0; i < result.Length; i++)
            {
                if (i != start)
                {
                    if (result[i] != int.MaxValue)
                    {
                        WriteLine($"Путь от вершины {start} до вершины {i} = {result[i]}");
                    }
                    else
                    {
                        WriteLine($"Путь от вершины {start} до вершины {i} - нет пути");
                    }
                }
            }
        }
    }
}