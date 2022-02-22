using TriangleTypeLibrary;

namespace FormFreeCodingAssessment
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator c = new Creator();
            try
            {
                ITriangle myTriangle = c.FactoryMethod(2,2,2);
                Console.WriteLine(myTriangle.GetTriangleType());
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}