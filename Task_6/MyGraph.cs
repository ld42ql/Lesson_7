using static System.Console;

namespace Task_6
{
    /// <summary>
    /// Генерация матрицы смежности
    /// </summary>
    public class MyGraph
    {
        System.Random random = new System.Random();

        /// <summary>
        /// Матрица смежности
        /// </summary>
        public Unit[,] Graph;

        /// <summary>
        /// Сгенерировать матрицу смежности
        /// </summary>
        /// <param name="count">Количество вершин в графе</param>
        public MyGraph(int count)
        {
            Graph = GreatGraph(count);
        }

        Unit[,] GreatGraph(int count)
        {
            Unit[,] units = new Unit[count, count];

            for (int i = 0; i < count; i++)
            {
                    for (int j = i + 1; j < count; j++)
                    {
                        int way = random.Next(0, 2) == 1 ? random.Next(1, 50) : int.MaxValue;

                        units[i, j] = new Unit(way, (int)StatusUnit.NotFound);
                        units[j, i] = new Unit(way, (int)StatusUnit.NotFound);
                    }
            }
            return units;
        }

        /// <summary>
        /// Ввывести матрицу смежности в консоль
        /// </summary>
        public void ViewGraph()
        {
            for (int i = 0; i < Graph.GetLength(0); i++)
            {
                for (int j = 0; j < Graph.GetLength(1); j++)
                {
                    ResetColor();
                    if (Graph[i, j].weight != int.MaxValue)
                    {
                        #region Подкрасить вершины в консоле; 
                        //Белый - не обнаруженна;
                        //Желтый - обнруженна;
                        //Зеленый - обработана;
                        switch (Graph[i, j].status)
                        {
                            case 0: ForegroundColor = System.ConsoleColor.White; break;
                            case 1: ForegroundColor = System.ConsoleColor.Yellow; break;
                            case 2: ForegroundColor = System.ConsoleColor.Green; break;
                            default:
                                break;
                        }
                        #endregion
                        Write($"{Graph[i, j].weight:D2} ");
                    }
                    else
                    {
                        Write($" - ");
                    }
                }
                Write("\n");
            }
        }
    }
}