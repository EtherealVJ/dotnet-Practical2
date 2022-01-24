using System;
namespace  BranchesLoops
{
    class BL {

        public static void Ifstmt(){

                Console.WriteLine("\nMAKE DECISIONS USING THE IF STATEMENT!\n");
                int a = 5;
                int b = 6;
                if (a + b > 10)
                Console.WriteLine("THE ANSWER IS GREATER THAN 10.");

                int c = 5;
                int d = 3;
                if (c + d > 10)
                Console.WriteLine("THE ANSWER IS GREATER THAN 10.");

        }

        public static void Ifelsestmt(){

            Console.WriteLine("\nMAKE IF & ELSE WORK TOGETHER!\n");
            int a = 5;
            int b = 3;
            int c = 4;
            if (a + b > 10)
                Console.WriteLine("THE ANSWER IS GREATER THAN 10");
            else
                Console.WriteLine("THE ANSWER IS NOT GREATER THAN 10");


            if (a + b > 10)
            {
                Console.WriteLine("THE ANSWER IS GREATER THAN 10");
            }
            else
            {
                Console.WriteLine("THE ANSWER IS NOT GREATER THAN 10");
            }



            if ((a + b + c > 10) && (a == b))
            {
                Console.WriteLine("THE ANSWER IS GREATER THAN 10");
                Console.WriteLine("AND THE FIRST NUMBER IS EQUAL TO THE SECOND");
            }
            else
            {
                Console.WriteLine("THE ANSWER IS NOT GREATER THAN 10");
                Console.WriteLine("OR THE FIRST NUMBER IS NOT EQUAL TO THE SECOND");
            }


            if ((a + b + c > 10) || (a == b))
            {
                Console.WriteLine("THE ANSWER IS GREATER THAN 10");
                Console.WriteLine("OR THE FIRST NUMBER IS EQUAL TO THE SECOND");
            }
            else
            {
                Console.WriteLine("THE ANSWER IS NOT GREATER THAN 10");
                Console.WriteLine("AND THE FIRST NUMBER IS NOT EQUAL TO THE SECOND");
            }

        }

        public static void loopsR(){
            Console.WriteLine("\nUSE LOOPS TO REPEAT OPERATIONS!\n");
            int counter = 0;
            while (counter < 10)
            {
            Console.WriteLine($"[While Loop]VRAJ THE COUNTER IS : {counter}");
            counter++;
            }

            int cnter = 0;
            do
            {
            Console.WriteLine($"[Do While Loop]VJ THE COUNTER IS : {cnter}");
            cnter++;
            } while (cnter < 10);

        }

        public static void forL(){
            Console.WriteLine("\nWORK WITH FOR LOOP!\n");
            for(int counter = 0; counter < 10; counter++)
            {
            Console.WriteLine($"[For Loop]VRAJ THE COUNTER IS : {counter}");
            }
        }

        public static void Nloops(){
             Console.WriteLine("\nCREATE NESTED LOOPS!\n");

            for (int row = 1; row < 11; row++)
            {
            Console.WriteLine($"THE ROWS IS {row}");
            }

            for (char column = 'a'; column < 'k'; column++)
            {
            Console.WriteLine($"THE COLUMN IS {column}");
            }

            for (int row = 1; row < 11; row++)
            {
            for (char column = 'a'; column < 'k'; column++)
            {
                Console.WriteLine($"THE CELL IS ({row}, {column})");
            }
            }
        }
        
        public static void BrLp(){
            Console.WriteLine("\nCOMBINING BRANCHES WITH LOOPS!\n");
            int sum = 0;
            for (int number = 1; number < 21; number++)
            {
             if (number % 3 == 0)
              {
                sum = sum + number;
              }
              }
               Console.WriteLine($"SUM = {sum}");
        }
        }
        
  }
