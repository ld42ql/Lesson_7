using static System.Console;

namespace Task_6
{
    #region Задание №6
    //Переписать программу алгоритма Дейкстры на свой язык программирования.
    #endregion
    class Program
    {
        static MyGraph randomGraph = new MyGraph(7);
        static Shortcut Way;

        static void Main(string[] args)
        {
            randomGraph.ViewGraph();

            WriteLine("\n");

            for (int i = 0; i < randomGraph.Graph.GetLength(0); i++)
            {
                Way = new Shortcut(randomGraph.Graph, i);
                Way.ViewAllWayOnePoint();
                WriteLine("\n");
            }
            ReadKey();
        }
    }
}