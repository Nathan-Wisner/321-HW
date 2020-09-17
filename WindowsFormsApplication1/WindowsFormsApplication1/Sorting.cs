using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Sorting
    {
        private DateTime startTime;
        private DateTime endTime;
        private static List<List<int>> currentList;
        private static Random random = new Random();
        Thread thread = new Thread(new ThreadStart(sortLists));

        public void createList()
        {
            currentList = new List<List<int>>();

            for (int a = 0; a < 8; a++)
            {
                currentList.Add(new List<int> { 100 });
            }

            foreach (List<int> subList in currentList)
            {
                for (int j = 0; j < 1000000; j++)
                {
                    subList.Add(random.Next(0, j));
                }
            }
        }

        public static void sortLists()
        {
            foreach (List<int> subList in currentList)
            {
                subList.Sort();
            }
        }

        public TimeSpan executeOneThread()
        {
            createList();
            startTime = DateTime.Now;
            thread.Start();
            thread.Join();
            endTime = DateTime.Now;

            return endTime - startTime;
        }

        public TimeSpan executeAsNoraml()
        {
            createList();
            startTime = DateTime.Now;
            sortLists();
            endTime = DateTime.Now;
            return endTime - startTime;
        }

    }
}
