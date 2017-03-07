using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8Bonus
{
    class Program
    {
        static void Main(string[] args)
        {
            Half();
            Console.WriteLine("\n");
            Full();
        }
        static void Half()
        {
            int midNum = 1;
            for (int i = 0; i < 5; i++)
            {
                int k = i;
                for (int j = 0; j < 9; j++)
                {
                    if ((j == 4) && (i == 0))
                    {
                        Console.Write(midNum);
                        midNum++;
                    }
                    else if ((j > 2 && j < 6) && (i == 1))
                    {
                        if (j == 4)
                            Console.Write(midNum);
                        else if (j == 5)
                        {
                            Console.Write(midNum - 1);
                            midNum++;
                        }
                        else
                            Console.Write(midNum - 1);

                    }
                    else if ((j > 1 && j < 7) && (i == 2))
                    {

                        if (j == 4)
                        {
                            Console.Write(midNum);
                            ++k;
                        }

                        else if (j == 6)
                        {
                            Console.Write(midNum - k);
                            midNum++;
                        }
                        else
                        {
                            Console.Write(midNum - k);
                            if (j < 4)
                                --k;
                            else
                                ++k;
                        }
                    }
                    else if ((j > 0 && j < 8) && (i == 3))
                    {
                        if (j == 4)
                        {
                            Console.Write(midNum);
                            ++k;
                        }

                        else if (j == 7)
                        {
                            Console.Write(midNum - k);
                            midNum++;
                        }
                        else
                        {
                            Console.Write(midNum - k);
                            if (j < 4)
                                --k;
                            else
                                ++k;
                        }
                    }
                    else if ((j > -1 && j < 9) && (i == 4))
                    {
                        if (j == 4)
                        {
                            Console.Write(midNum);
                            ++k;
                        }

                        else if (j == 8)
                        {
                            Console.Write(midNum - k);
                            midNum--;
                        }
                        else
                        {
                            Console.Write(midNum - k);
                            if (j < 4)
                                --k;
                            else
                                ++k;
                        }
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void Full()
        {
            int midNum = 1;
            for (int i = 0; i < 9; i++)
            {
                int k = i;
                int x = 3;
                int y = 2;
                for (int j = 0; j < 9; j++)
                {
                    if ((j == 4) && (i == 0))
                    {
                        Console.Write(midNum);
                        midNum++;
                    }
                    else if ((j > 2 && j < 6) && (i == 1))
                    {
                        if (j == 4)
                            Console.Write(midNum);
                        else if (j == 5)
                        {
                            Console.Write(midNum - 1);
                            midNum++;
                        }
                        else
                            Console.Write(midNum - 1);

                    }
                    else if ((j > 1 && j < 7) && (i == 2))
                    {

                        if (j == 4)
                        {
                            Console.Write(midNum);
                            ++k;
                        }

                        else if (j == 6)
                        {
                            Console.Write(midNum - k);
                            midNum++;
                        }
                        else
                        {
                            Console.Write(midNum - k);
                            if (j < 4)
                                --k;
                            else
                                ++k;
                        }
                    }
                    else if ((j > 0 && j < 8) && (i == 3))
                    {
                        if (j == 4)
                        {
                            Console.Write(midNum);
                            ++k;
                        }

                        else if (j == 7)
                        {
                            Console.Write(midNum - k);
                            midNum++;
                        }
                        else
                        {
                            Console.Write(midNum - k);
                            if (j < 4)
                                --k;
                            else
                                ++k;
                        }
                    }
                    else if ((j > -1 && j < 9) && (i == 4))
                    {
                        if (j == 4)
                        {
                            Console.Write(midNum);
                            ++k;
                        }

                        else if (j == 8)
                        {
                            Console.Write(midNum - k);
                            midNum--;
                        }
                        else
                        {
                            Console.Write(midNum - k);
                            if (j < 4)
                                --k;
                            else
                                ++k;
                        }
                    }
                    else if ((j > 0 && j < 8) && (i == 5))
                    {
                        if (j == 4)
                        {
                            Console.Write(midNum);
                            ++x;
                        }

                        else if (j == 7)
                        {
                            Console.Write(midNum - x);
                            midNum--;
                        }
                        else
                        {
                            Console.Write(midNum - x);
                            if (j < 4)
                                --x;
                            else
                                ++x;
                        }
                    }
                    else if ((j > 1 && j < 7) && (i == 6))
                    {

                        if (j == 4)
                        {
                            Console.Write(midNum);
                            ++y;
                        }

                        else if (j == 6)
                        {
                            Console.Write(midNum - y);
                            midNum--;
                        }
                        else
                        {
                            Console.Write(midNum - y);
                            if (j < 4)
                                --y;
                            else
                                ++y;
                        }
                    }
                    else if ((j > 2 && j < 6) && (i == 7))
                    {
                        if (j == 4)
                            Console.Write(midNum);
                        else if (j == 5)
                        {
                            Console.Write(midNum - 1);
                            midNum--;
                        }
                        else
                            Console.Write(midNum - 1);

                    }
                    else if ((j == 4) && (i == 8))
                    {
                        Console.Write(midNum);
                        midNum--;
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
