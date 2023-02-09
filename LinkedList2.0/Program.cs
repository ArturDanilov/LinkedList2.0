namespace LinkedList2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new Model.LinkedList<int>(); //Model?

            Console.WriteLine("Add elements 1,2,3,4,5,6,7,8,9,10 to the list:");

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.Add(9);
            list.Add(10);

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");

            Console.WriteLine("Delete elements 3,1,7 from the list:");

            list.Delete(3);
            list.Delete(1);
            list.Delete(7);

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");

            Console.WriteLine("Add element 7 to the head:");

            list.AppendHead(7);

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");

            Console.WriteLine("Add element 8 after element 4:");

            list.InsertAfter(4, 8);

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");

            Console.WriteLine("\nThe end!");

            Console.ReadLine();
        }
    }
}