using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace LinkedList2._0.Model
{
    /// <summary>
    /// Односвязный список
    /// </summary>
    public class LinkedList<T> : IEnumerable
    {
        /// <summary>
        /// Первый эллемент списка
        /// </summary>
        public Item<T> Head { get; private set; }

        /// <summary>
        /// Последний эллемент списка
        /// </summary>
        public Item<T> Tail { get; private set; }

        /// <summary>
        /// Колличество эллементов в списке
        /// </summary>
        public int Count { get; private set; }

        /// <summary>
        /// Создать пустой список
        /// </summary>
        public LinkedList()
        {
            Clear();
        }

        /// <summary>
        /// Создать список с начальным эллементом
        /// </summary>
        public LinkedList(T data)
        {
            var item = new Item<T>(data);
            SetHeadAndTail(data);
        }

        /// <summary>
        /// Добавить данные в конец списка
        /// </summary>
        public void Add(T data)
        {
            //есть ли в списке что то, проверяем хвост
            if (Tail != null)
            {
                var item = new Item<T>(data);
                Tail.Next = item; //цепляемся к хвосту?
                Tail = item;
                Count++;
            }
            else
            {
                SetHeadAndTail(data);
            }
        }

        /// <summary>
        /// Удалить первое вхождение данных в список
        /// </summary>
        public void Delete(T data)
        {
            if (Head != null)
            {
                //если искомый элемент это head, то присваеваем head следующему эллементу
                if (Head.Data.Equals(data))
                {
                    Head = Head.Next;
                    Count--;
                    return;
                }

                var curent = Head.Next;
                var previos = Head;

                while (curent != null)
                {
                    if (curent.Data.Equals(data))
                    {
                        previos.Next = curent.Next;
                        Count--;
                        return;
                    }

                    previos = curent;
                    curent = curent.Next;
                }
            }
            else
            {
                //mach nix
            }
        }

        /// <summary>
        /// Добавить элемент в начало списка (в Head)
        /// </summary>
        public void AppendHead(T data)
        {
            var item = new Item<T>(data)
            {
                Next = Head
            };

            Head = item;
            Count++;
        }

        /// <summary>
        /// Вставить данные после искомого значения
        /// </summary>
        /// <param name="target"></param>
        /// <param name="data"></param>
        public void InsertAfter(T target, T data)
        {
            if (Head != null)
            {
                var curent = Head;
                while (curent != null)
                {
                    if (curent.Data.Equals(target))
                    {
                        var item = new Item<T>(data);
                        item.Next = curent.Next;
                        curent.Next = item;
                        Count++;
                        return;
                    }
                    else
                    {
                        curent = curent.Next;
                    }
                }
            }
            else
            {
                SetHeadAndTail(target);
                Add(data);
            }
        }

        /// <summary>
        /// Очистка списка
        /// </summary>
        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }
        private void SetHeadAndTail(T data)
        {
            var item = new Item<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }

        /// <summary>
        /// Получить перечисление всех эллементов списка
        /// </summary>
        public IEnumerator GetEnumerator()
        {
            var curent = Head;
            while (curent != null)
            {
                yield return curent.Data;
                curent = curent.Next;
            }
        }

        public override string ToString()
        {
            return "Linked List " + Count + " элементов";
        }
    }
}
