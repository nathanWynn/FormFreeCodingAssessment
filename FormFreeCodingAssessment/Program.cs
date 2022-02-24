using TriangleTypeLibrary;
using LinkedListLibrary;

namespace FormFreeCodingAssessment
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] longList = new int[10000];
            for (int i = 0; i < 10000; i++)
            {
                longList[i] = i;
            }
            LinkedListLibrary.LinkedList<int> myIntLinkedList = new LinkedListLibrary.LinkedList<int>(longList);
            Console.WriteLine(myIntLinkedList.GetFifthLastElement());

            Creator c = new Creator();
            ITriangle myTriangle = c.FactoryMethod(3, 3, 3);
            Console.WriteLine(myTriangle.GetTriangleType());

        }

    }
}