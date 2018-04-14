

namespace Task_6
{
    /// <summary>
    /// Список статуса
    /// </summary>
    public enum StatusUnit { NotFound, Found, Cheked}

    /// <summary>
    /// Вершина
    /// </summary>
   public struct Unit
    {
        /// <summary>
        /// Вес вершины
        /// </summary>
        public int weight;

        /// <summary>
        /// Статус вершины
        /// 0 - не обнаруженна;
        /// 1 - обнруженна;
        /// 2 - обработана;
        /// </summary>
        public int status;

        /// <summary>
        /// Вершина
        /// </summary>
        /// <param name="weight">Вес ребра</param>
        /// <param name="status">Статус обработки</param>
        public Unit(int weight, int status)
        {
            this.weight = weight;
            this.status = status;
        }
    }
}
