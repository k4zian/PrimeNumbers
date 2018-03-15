# PrimeNumbers
Tiny app checking whether the given input is a prime number or not.

```
 static void Main(string[] args)
        {
            int n;
            string yes = "TAK";
            string no = "NIE";

            Console.WriteLine("Input integers to check if they're prime numbers. Give 0 to exit.");

            while (true)
            {
                n = int.Parse(Console.ReadLine());

                if (n == 0)
                {
                    break;
                }

                if (n <= 3)
                {
                    Console.WriteLine(yes);
                }

                for(int i = 3; i < n; i++)
                {
                    if(n % i == 0)
                    {
                        Console.WriteLine(no);
                        break;
                    }

                    if (i == n - 1)
                    {
                        Console.WriteLine(yes);
                        break;
                    }
                }
            }
        }
```

