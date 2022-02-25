using TriangleTypeLibrary;
using LinkedListLibrary;
using PrimeFactorizationLibrary;

namespace FormFreeCodingAssessment
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * TriangleTypeLibrary Usage:
             */
            Creator c = new Creator();
            ITriangle myTriangle = c.FactoryMethod(3, 3, 3);
            Console.WriteLine(myTriangle.GetTriangleType());

            /* 
             * LinkedListLibrary Usage:
             */
            int[] myIntList = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            string[] myStringList = new string[] { "a", "b", "c", "d", "e", "f" };
            LinkedListLibrary.LinkedList<int> myIntLinkedList = new LinkedListLibrary.LinkedList<int>(myIntList);
            LinkedListLibrary.LinkedList<string> myStringLinkedList = new LinkedListLibrary.LinkedList<string>(myStringList);

            Console.WriteLine(myIntLinkedList.GetFifthLastElement());
            Console.WriteLine(myStringLinkedList.GetFifthLastElement());
            
            /*
             * PrimeFactorizationLibrary Usage:
             */
            List<List<int>> myList = PrimeFactorDocumentUtils.GetFactorizations(@"data\FactorizeMe.txt");
            foreach(List<int> primeFactors in myList)
            {
                Console.WriteLine(string.Join(", ", primeFactors));
            }

        }

    }
}