//print all odd numbers between 2 numbers inclusive - hackerrank from nexient test
        static List<int> oddNumbers(int l, int r)
        {
            List<int> oddNumbers = new List<int>();
            int i;
   
            if(l % 2 == 0)
            {
               for (i = l + 1; i <= r; i+= 2)
                {
                    Console.WriteLine(i);
                    oddNumbers.Add(i);
                }
            }

            else
            {
                for (i = l; i <= r; i+= 2)
                {
                    Console.WriteLine(i);
                    oddNumbers.Add(i);
                }
            }

            return oddNumbers;
        }