using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_Very_Easy
{
    class Program
    {
        static void Main(string[] args)
        {
            //This program finds a unique number for each of the 9 declared variables such that they solve the equation: This + Is + Very = Easy
            //The program achieves this by randomly selecting numbers until the condition is met

            int A, E, H, I, R, S, T, V, Y = 0;
            int This, Is, Very, Easy;
            int count = 1;

            Random rnd = new Random();

            //An infinite loop is created until the solution is found
            while (1 == 1)
            {
                //Variables are given a random number from 1-9
                A = rnd.Next(0, 9);
                E = rnd.Next(0, 9);
                H = rnd.Next(0, 9);
                I = rnd.Next(0, 9);
                R = rnd.Next(0, 9);
                S = rnd.Next(0, 9);
                T = rnd.Next(0, 9);
                V = rnd.Next(0, 9);
                Y = rnd.Next(0, 9);

                //The equation at hand
                This = (1000 * T) + (100 * H) + (10 * I) + S;
                Is = (10 * I) + S;
                Very = (1000 * V) + (100 * E) + (10 * R) + Y;
                Easy = (1000 * E) + (100 * A) + (10 * S) + Y;

                //The testing condition, loop breaks when a solution is obtained
                if ((This + Is + Very == Easy)
                    && (A != E) && (A != H) && (A != I) && (A != R) && (A != S) && (A != T) && (A != V) && (A != Y)
                                && (E != H) && (E != I) && (E != R) && (E != S) && (E != T) && (E != V) && (E != Y)
                                            && (H != I) && (H != R) && (H != S) && (H != T) && (H != V) && (H != Y)
                                                        && (I != R) && (I != S) && (I != T) && (I != V) && (I != Y)
                                                                    && (R != S) && (R != T) && (R != V) && (R != Y)
                                                                                && (S != T) && (S != V) && (S != Y)
                                                                                            && (T != V) && (T != Y)
                                                                                                        && (V != Y))
                {
                    //Answers to the variables are printed
                    Console.WriteLine("A: " + A);
                    Console.WriteLine("E: " + E);
                    Console.WriteLine("H: " + H);
                    Console.WriteLine("I: " + I);
                    Console.WriteLine("R: " + R);
                    Console.WriteLine("S: " + S);
                    Console.WriteLine("T: " + T);
                    Console.WriteLine("V: " + V);
                    Console.WriteLine("Y: " + Y);
                    Console.WriteLine(This + " + " + Is + " + " + Very + " = " + Easy);
                    Console.WriteLine("Solved in " + count + " instances, press any key to dismiss");
                    Console.ReadKey(true);
                    break;
                }
                count = count + 1;
            }
        }
    }
}
