using System;

/*
break: 
1. It is used to terminate the enclosing loop like while, do-while, for, 
    or switch statement where it is declared.
2. It resumes control over the program until the end of the loop.
3. It also helps with the flow of control outside the loop.
4. It is used with ‘switch’ and ‘label’ since it is compatible.
  
continue:
1. It helps skip the remaining part of the loop.
2. It continues to execute the next iteration.
3. It causes early execution of the next iteration of the enclosing loop.
4. It can’t be used with ‘switch’ and ‘label’ since it is not compatible.
*/

namespace BreakAndContinue
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int i;
            for (i = 0; i <= 10; i++)
            {
                if (i == 5)
                    continue;
                if (i == 8)
                    break;
                Console.WriteLine("value is "  +i);
            }
            Console.ReadLine();
        }
    }
}
