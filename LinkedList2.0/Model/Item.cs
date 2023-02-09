using System.Collections;

namespace LinkedList2._0.Model
{
    //чтобы список был строготипизированным, чтобы данные были одного, строгозаданного типа
    public class Item<T>
    {
        private T data = default(T);

        /// <summary>
        /// Данные хранимые в ячейке списка
        /// </summary>
        public T Data
        {
            get { return data; }
            set
            {
                if (value != null)
                    data = value;
                else
                    throw new ArgumentNullException(nameof(value));
            }
        }

        /// <summary>
        /// Следующая ячейка списка
        /// </summary>
        public Item<T> Next { get; set; }

        //konstruktor
        public Item(T data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
