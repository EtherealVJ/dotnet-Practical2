using System;
namespace  ExploreNumbers
{
    class Numbers {
        public static void IntOp(){
            Console.WriteLine("\nEXPLORE INTEGER MATH!\n");
            int a = 10;
            int b = 2;
            int c = a + b;
            int d = a - b;
            int e = a * b;
            int f = a / b;
            Console.WriteLine("ADDITION = " + c);
            Console.WriteLine("SUBTRACTION = " +d);
            Console.WriteLine("MULTIPLICATION = " +e);
            Console.WriteLine("DIVISION = " +f);

        }

        public static void IntOrderOp(){
            Console.WriteLine("\nEXPLORE ORDER OF OPERATIONS!\n");
            int a = 5;
            int b = 4;
            int c = 2;
            Console.WriteLine("a=5 b=4 c=2");

            int d = a + b * c;
            Console.WriteLine("[a + b * c] ANSWER = " + d);

            int e = (a + b) * c;
            Console.WriteLine("[(a + b) * c] ANSWER = " + e);

            int f = (a + b) - 6 * c + (12 * 4) / 3 + 12;
            Console.WriteLine("[(a + b) - 6 * c + (12 * 4) / 3 + 12] ANSWER = " + f);

            int g = (a + b) / c;
            Console.WriteLine("[(a + b) / c] ANSWER = " + g);

        }

        public static void IntPreLi(){

        Console.WriteLine("\nEXPLORE INTEGER PRECISION & LIMITS!\n");
        int a = 7;
        int b = 4;
        int c = 3;
        int d = (a + b) / c;
        int e = (a + b) % c;
        Console.WriteLine("a=7 b=4 c=3");
        Console.WriteLine($"[(a + b) / c] QUOTIENT : {d}");
        Console.WriteLine($"[(a + b) % c] REMAINDER : {e}");

        int max = int.MaxValue;
        int min = int.MinValue;
        Console.WriteLine($"THE RANGE OF INTEGERS IS {min} TO {max}");

        int what = max + 3;
        Console.WriteLine($"AN EXAMPLE OF OVERFLOW : {what}");

        }

        public static void dblety(){
            Console.WriteLine("\nWORK WITH THE DOUBLE TYPE!\n");
            double a = 5;
            double b = 4;
            double c = 2;
            double d = (a + b) / c;
            Console.WriteLine("a=5 b=4 c=2");
            Console.WriteLine("[(a + b) / c] ANSWER = " + d);


            double max = double.MaxValue;
            double min = double.MinValue;
            Console.WriteLine($"THE RANGE OF DOUBLE IS {min} TO {max}");

            double third = 1.0 / 3.0;
            Console.WriteLine(third);

        }

        public static void DeciTy(){
                Console.WriteLine("\nWORK WITH DECIMAL TYPES!\n");
                decimal min = decimal.MinValue;
                decimal max = decimal.MaxValue;
                Console.WriteLine($"THE RANGE OF DECIMAL TYPE IS {min} TO {max}");

                double a = 1.0;
                double b = 3.0;
                Console.WriteLine("a=1.0 b=3.0");
                Console.WriteLine("[a / b] DOUBLE = " + a / b);

                decimal c = 1.0M;
                decimal d = 3.0M;
                Console.WriteLine("c=1.0M d=3.0M");
                Console.WriteLine("[c / d] DECIMAL = " + c / d);
        

        }

        public static void AreaC(){
            Console.WriteLine("\nCOMPLETE CHALLENGE!\n");
            double radius = 2.50;
            double area = Math.PI * radius * radius;
            Console.WriteLine("AREA = " + area);

        }
    
}
}
