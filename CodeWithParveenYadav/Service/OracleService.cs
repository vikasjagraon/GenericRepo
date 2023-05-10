using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWithParveenYadav.Service
{
    internal class OracleService
    {
        public IEnumerable<int> GetDataFromOracle()
        {

            //Loop on list of data
            for (int j = 0; j <= 2; j++)
            {

                // Lets say there are 2cr records in one table
                // Add Logic here for Per page, Fetch 50,0000 rows from Oracle 
                // Run loop on those 50,0000 records here
                Console.WriteLine($"Oracle : Get data from table_{j}");

                //stateful iteration
                 yield return j;

                if (j == 1)
                {
                    Console.WriteLine("If it is last item then terminate the loop, I don't want to perform any further operation");
                    yield break;
                }

                Console.WriteLine("Clean up memory done");
                // We will take advantage of yield return here
                // So Here, we will clean up the all the memory
            }

        }
    }
}
