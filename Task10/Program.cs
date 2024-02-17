
        
        int n = Convert.ToInt32(Console.ReadLine());

         int Fibonacci(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }

            for (int i = 0; i < n; i++)
            {
                Console.Write(Fibonacci(i) + " ");
            }



     