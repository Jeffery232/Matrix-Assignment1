namespace Matrix_Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,,] threeDimensionalArray = new int[3, 3, 3]

        {
                { { 1,0,2}, { 1,2,0},{ 2,1,1 } },
                { { 1,0,1}, { 1,0,1},{ 1,1,4 } },
                { { 1,0,1}, { 2,2,1},{ 2,1,3 } }
        };

            int[,,] threeDimensionalArray2 = new int[3, 3, 3]
             {
                  { { 2,0,3}, { 2,2,0},{ 2,1,1 } },
                 { { 1,0,2}, { 2,2,0},{ 2,1,1 } },
                { { 2,2,1}, { 1,1,1},{ 1,0,1 } }
        };
            int[,,] result = new int[3, 3, 3];


            for (int a = 0; a < threeDimensionalArray.GetLength(0); a++)
            {
                for (int b = 0; b < threeDimensionalArray.GetLength(0); b++)
                {
                    for (int c = 0; c < threeDimensionalArray.GetLength(0); c++)
                    {
                        result[a, b, c] += threeDimensionalArray2[a, b, c] * threeDimensionalArray[a, b, c];
                        Console.WriteLine(result[a, b, c]);
                    }
                }

            }

        }
    }
    }
    
