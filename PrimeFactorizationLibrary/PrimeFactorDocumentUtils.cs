namespace PrimeFactorizationLibrary
{
    /// <summary>
    /// Utility class for specially formatted text files containing
    /// one integer value on each line with the purpose of 
    /// outputting a list of each value's prime factors to the console.
    /// </summary>
    /// <remarks>
    /// Adopted and modified the approach from: 
    /// https://www.geeksforgeeks.org/print-all-prime-factors-of-a-given-number/.
    /// Originally attempted to use sieve of eratosthenes approach by
    /// precomputing all smallest prime factors for all numbers up to
    /// a threshold, but ran into memory issues for large input.
    /// </remarks>
    public static class PrimeFactorDocumentUtils
    {

        /// <summary>
        /// Checks if the filepath is not null, the file exists on disk, and if it has a ".txt" extension.
        /// </summary>
        /// <param name="filePath">Path to file containing one integer value per line.</param>
        /// <returns>True if file is valid.</returns>
        /// <exception cref="ArgumentNullException">Thrown when filePath is null.</exception>
        /// <exception cref="FileNotFoundException">Thrown when file does not exist on disk.</exception>
        /// <exception cref="ArgumentException">Thrown when file does not have a ".txt" extension.</exception>
        private static bool IsValidFile(string filePath)
        {
            if (filePath == null)
            {
                throw new ArgumentNullException("Argument is null.");
            }
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("File not found.");
            }
            if (Path.GetExtension(filePath) != ".txt")
            {
                throw new ArgumentException("Invalid file extension - .txt expected.");
            }
            return true;
        }

        /// <summary>
        /// Computes a list of lists of prime factors of each number in filepath.
        /// </summary>
        /// <param name="filePath">Path to file containing one integer per line.</param>
        /// <remarks>
        /// Will ignore lines in file that do not parse into an integer value.
        /// </remarks>
        /// <returns>
        /// A list of integer lists each representing the prime factors of the associated
        /// number from filepath
        /// </returns>  
        public static List<List<int>> GetFactorizations(string filePath)
        {
            List<List<int>> result = new List<List<int>>();
            if (IsValidFile(filePath))
            {
                List<int> nums = new List<int>();
                StreamReader reader = new StreamReader(filePath);
                reader.BaseStream.Seek(0, SeekOrigin.Begin);

                string line;
                // consume each line from the file until the end is reached
                while((line = reader.ReadLine()) != null)
                {
                    int num;
                    if (int.TryParse(line, out num))
                    {
                        nums.Add(num);
                        List<int> primeFactors = PrimeFactorization(num);
                        result.Add(primeFactors);
                    }
                }

            }
            return result;
        }

        /// <summary>
        /// Computes the prime factors of the argument value.
        /// </summary>
        /// <param name="num">integer value to compute list of prime factors for.</param>
        /// <returns>The list containing all prime factors of num.</returns>
        private static List<int> PrimeFactorization(int num)
        {
            List<int> result = new List<int>();

            if(num < 0)
            {
                throw new ArgumentException("Input file contains a negative number.");
            }

            // While num is still even, the smallest prime factor is 2.
            while(num % 2 == 0)
            {
                result.Add(2);
                num /= 2;
            }

            // At this point, all remaining prime factors are odd,
            // so we can increment by 2 every iteration.

            // Proof for stopping at sqrt(num):
            // 1) assume a * b = num -> a, b are prime factors of num.
            // 2) if a and b are greater than sqrt(num), then a * b > sqrt(num)^2
            // 3) -> contradiction.
            for(int i = 3; i <= Math.Sqrt(num); i+= 2)
            {
                while(num % i == 0)
                {
                    result.Add(i);
                    num /= i;
                }
            }

            // At this point, num is either 1 or a prime number.

            if(num > 2)
            {
                result.Add(num);
            }
            return result;
        }
        
    }
}