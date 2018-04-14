using static System.Console;

namespace Task_6
{
    #region Задание №6
    //Переписать программу алгоритма Дейкстры на свой язык программирования.
    #endregion
    class Program
    {
      static MyGraph randomGraph = new MyGraph(5);
        static AlgorithmDijkstra algorithm;

        static void Main(string[] args)
        {
            randomGraph.ViewGraph();

            WriteLine("\n");

            algorithm = new AlgorithmDijkstra(randomGraph.Graph, 0);

            algorithm.ViewGraph();

            ReadKey();
        }
    }
}
