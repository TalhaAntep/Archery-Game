using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archery_Map_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Enter the locaiton of A:");
                Console.WriteLine("AX and AY must be between -10 and 10.");
                Console.Write("AX:  ");
                double AX = Convert.ToDouble(Console.ReadLine());
                Console.Write("AY:  ");
                double AY = Convert.ToDouble(Console.ReadLine());
                Random rd = new Random();
                double BX = rd.Next(-10, 11);
                double BY = rd.Next(-10, 11);
                double CX = rd.Next(-10, 11);
                double CY = rd.Next(-10, 11);
                if ((AX > 10 || AX < -10) || (AY > 10 || AY < -10))
                {
                    Console.WriteLine("GAME OVER!!");
                }
                else
                {
                    int x = rd.Next(0, 6);
                    string set1, set2, set3;
                    if (x == 0)
                    {
                        set1 = "Iron-Head Arrow(IA) - Celtic Shield";
                        set2 = "Poison Arrow(PA) - Wankel Shield";
                        set3 = "Fire Arrow(FA) - Heater Shield";
                    }
                    else if (x == 1)
                    {
                        set1 = "Poison Arrow(PA) - Wankel Shield";
                        set2 = "Iron-Head Arrow(IA) - Celtic Shield";
                        set3 = "Fire Arrow(FA) - Heater Shield";
                    }
                    else if (x == 2)
                    {
                        set1 = "Fire Arrow(FA) - Heater Shield";
                        set2 = "Iron-Head Arrow(IA) - Celtic Shield";
                        set3 = "Poison Arrow(PA) - Wankel Shield";
                    }
                    else if (x == 3)
                    {
                        set1 = "Iron-Head Arrow(IA) - Celtic Shield";
                        set2 = "Fire Arrow(FA) - Heater Shield";
                        set3 = "Poison Arrow(PA) - Wankel Shield";
                    }
                    else if (x == 4)
                    {
                        set1 = "Poison Arrow(PA) - Wankel Shield";
                        set2 = "Fire Arrow(FA) - Heater Shield";
                        set3 = "Iron-Head Arrow(IA) - Celtic Shield";
                    }
                    else
                    {
                        set1 = "Fire Arrow(FA) - Heater Shield";
                        set2 = "Poison Arrow(PA) - Wankel Shield";
                        set3 = "Iron-Head Arrow(IA) - Celtic Shield";
                    }
                    int y = rd.Next(0, 6);
                    double hp1, hp2, hp3;
                    if (y == 0)
                    {
                        hp1 = 100;
                        hp2 = 80;
                        hp3 = 60;
                    }
                    else if (y == 1)
                    {
                        hp1 = 100;
                        hp2 = 60;
                        hp3 = 80;
                    }
                    else if (y == 2)
                    {
                        hp1 = 80;
                        hp2 = 100;
                        hp3 = 60;
                    }
                    else if (y == 3)
                    {
                        hp1 = 80;
                        hp2 = 60;
                        hp3 = 100;
                    }
                    else if (y == 4)
                    {
                        hp1 = 60;
                        hp2 = 80;
                        hp3 = 100;
                    }
                    else
                    {
                        hp1 = 60;
                        hp2 = 100;
                        hp3 = 80;
                    }
                    Console.WriteLine("A:  " + "(" + AX + "," + AY + ")  " + set1 + "     Health: " + hp1);
                    Console.WriteLine("B:  " + "(" + BX + "," + BY + ")  " + set2 + "     Health: " + hp2);
                    Console.WriteLine("C:  " + "(" + CX + "," + CY + ")  " + set3 + "     Health: " + hp3);

                    Console.WriteLine("   + - - - - - - - - - - ^ - - - - - - - - - - +");
                    Console.WriteLine(" 10| . . . . . . . . . . | . . . . . . . . . . |");
                    Console.WriteLine("  9| . . . . . . . . . . | . . . . . . . . . . |");
                    Console.WriteLine("  8| . . . . . . . . . . | . . . . . . . . . . |");
                    Console.WriteLine("  7| . . . . . . . . . . | . . . . . . . . . . |");
                    Console.WriteLine("  6| . . . . . . . . . . | . . . . . . . . . . |");
                    Console.WriteLine("  5| . . . . . . . . . . | . . . . . . . . . . |");
                    Console.WriteLine("  4| . . . . . . . . . . | . . . . . . . . . . |");
                    Console.WriteLine("  3| . . . . . . . . . . | . . . . . . . . . . |");
                    Console.WriteLine("  2| . . . . . . . . . . | . . . . . . . . . . |");
                    Console.WriteLine("  1| . . . . . . . . . . | . . . . . . . . . . |");
                    Console.WriteLine("  0| - - - - - - - - - - + - - - - - - - - - - >");
                    Console.WriteLine(" -1| . . . . . . . . . . | . . . . . . . . . . |");
                    Console.WriteLine(" -2| . . . . . . . . . . | . . . . . . . . . . |");
                    Console.WriteLine(" -3| . . . . . . . . . . | . . . . . . . . . . |");
                    Console.WriteLine(" -4| . . . . . . . . . . | . . . . . . . . . . |");
                    Console.WriteLine(" -5| . . . . . . . . . . | . . . . . . . . . . |");
                    Console.WriteLine(" -6| . . . . . . . . . . | . . . . . . . . . . |");
                    Console.WriteLine(" -7| . . . . . . . . . . | . . . . . . . . . . |");
                    Console.WriteLine(" -8| . . . . . . . . . . | . . . . . . . . . . |");
                    Console.WriteLine(" -9| . . . . . . . . . . | . . . . . . . . . . |");
                    Console.WriteLine("-10| . . . . . . . . . . | . . . . . . . . . . |");
                    Console.WriteLine("   + - - - - - - - - - - - - - - - - - - - - - +");
                    Console.WriteLine("   -10 9 8 7 6 5 4 3 2 1 0 1 2 3 4 5 6 7 8 9 10");
                    Console.SetCursorPosition((int)(25 + (AX * 2)), (int)(18 + (AY * -1)));
                    Console.WriteLine("A");
                    Console.SetCursorPosition((int)(25 + (BX * 2)), (int)(18 + (BY * -1)));
                    Console.WriteLine("B");
                    Console.SetCursorPosition((int)(25 + (CX * 2)), (int)(18 + (CY * -1)));
                    Console.WriteLine("C");
                    Console.SetCursorPosition(2, 32);
                    Console.ReadLine();
                    double AB, AC, BC;
                    AB = Math.Sqrt(Math.Pow((AX - BX), 2) + Math.Pow((AY - BY), 2));
                    AC = Math.Sqrt(Math.Pow((AX - CX), 2) + Math.Pow((AY - CY), 2));
                    BC = Math.Sqrt(Math.Pow((BX - CX), 2) + Math.Pow((BY - CY), 2));
                    double DisAB, DisAC, DisBC;
                    DisAB = Math.Abs(BX - AX) + Math.Abs(BY - AY);
                    DisBC = Math.Abs(BX - CX) + Math.Abs(BY - CY);
                    DisAC = Math.Abs(AX - CX) + Math.Abs(AY - CY);
                    double AS1, AS2, AS3;// AS=Attack Score = 10 * Manhattan_distance_between_archers + (100 - Archer's_health)
                    double AS4, AS5, AS6;//2.Rounddaki AS 
                    AS1 = 0;
                    AS2 = 0;
                    AS3 = 0;
                    AS4 = 0;
                    AS5 = 0;
                    AS6 = 0;
                    if (AC > AB && BC > AB)
                    {
                        if (AB <= 15)
                        {
                            Console.WriteLine("Round 1:  A-B");
                            if (x == 0 || x == 2 || x == 4)
                            {/*B kazanacak.Attack Score = 10 * Manhattan_distance_between_archers + (100 - Archer's_health)*/
                                hp2 = hp2 - 25;
                                AS2 = 10 * DisAB + (100 - hp2);
                                Console.WriteLine("A : " + "Defeated       " + "Health: 0 " + "  Score: 0");
                                Console.WriteLine("B : " + "Survivor       " + "Health: " + hp2 + "  Score: " + AS2);
                                Console.WriteLine("C : " + "Non - fighter  " + "Health: " + hp3 + "  Score: 0");
                                Console.SetCursorPosition(2, 37);
                                Console.ReadLine();
                                Console.WriteLine("Round 2: B-C");
                                if (BC <= 15)
                                {
                                    hp3 = hp3 - 25;
                                    AS6 = 10 * DisBC + (100 - hp3);
                                    Console.WriteLine("A : " + "Defeated       " + "Health: 0" + "  Score: 0");
                                    Console.WriteLine("B : " + "Defeated       " + "Health: 0 " + "  Score: " + AS2);
                                    Console.WriteLine("C : " + "Survivor       " + "Health: " + hp3 + "  Score: " + AS6);
                                    Console.SetCursorPosition(2, 43);
                                    Console.ReadLine();

                                }
                                else
                                {
                                    Console.WriteLine("Too distant, no attack");
                                    Console.SetCursorPosition(2, 40);
                                    Console.ReadLine();
                                }

                            }
                            else
                            {/*A kazanacak.Attack Score = 10 * Manhattan_distance_between_archers + (100 - Archer's_health)*/
                                hp1 = hp1 - 25;
                                AS1 = 10 * DisAB + (100 - hp1);
                                Console.WriteLine("A : " + "Survivor       " + "Health: " + hp1 + "  Score: " + AS1);
                                Console.WriteLine("B : " + "Defeated       " + "Health: 0 " + "  Score: 0");
                                Console.WriteLine("C : " + "Non - fighter  " + "Health: " + hp3 + "  Score: 0");
                                Console.SetCursorPosition(2, 37);
                                Console.ReadLine();
                                Console.WriteLine("Round 2: A-C");
                                

                                if (AC <= 15)
                                {
                                    hp3 = hp3 - 25;
                                    AS6 = 10 * DisAC + (100 - hp3);
                                    Console.WriteLine("A : " + "Defeated       " + "Health: 0" + "  Score: " + AS1);
                                    Console.WriteLine("B : " + "Defeated       " + "Health: 0" + "  Score: 0");
                                    Console.WriteLine("C : " + "Survivor       " + "Health: " + hp3 + "  Score: " + AS6);
                                    Console.SetCursorPosition(2, 43);
                                    Console.ReadLine();

                                }
                                else
                                {
                                    Console.WriteLine("Too distant, no attack");
                                    Console.SetCursorPosition(2, 40);
                                    Console.ReadLine();
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Round 1:  A-B");
                            Console.WriteLine("Too distant, no attack");
                            Console.SetCursorPosition(2, 47);
                            Console.ReadLine();
                        }

                    }
                    else if (AC > BC)
                    {
                        if (BC <= 15)
                        {
                            Console.WriteLine("Round 1: B-C");
                            if (x == 0 || x == 2 || x == 4)
                            {
                                hp3 = hp3 - 25;
                                AS3 = 10 * DisBC + (100 - hp3);
                                Console.WriteLine("A : " + "Non - fighter  " + "Health: " + hp1 + "  Score: 0");
                                Console.WriteLine("B : " + "Defeated       " + "Health: 0 " + "  Score: 0");
                                Console.WriteLine("C : " + "Survivor       " + "Health: " + hp3 + "  Score: " + AS3);
                                Console.SetCursorPosition(2, 37);
                                Console.ReadLine();
                                Console.WriteLine("Round 2: A-C");
                                if (AC <= 15)
                                {
                                    hp1 = hp1 - 25;
                                    AS4 = 10 * DisAC + (100 - hp1);
                                    Console.WriteLine("A : " + "Survivor       " + "Health: " + hp1 + "  Score: " + AS4);
                                    Console.WriteLine("B : " + "Defeated       " + "Health: 0" + "  Score: 0");
                                    Console.WriteLine("C : " + "Defeated       " + "Health: 0" + "  Score: " + AS3);
                                    Console.SetCursorPosition(2, 43);
                                    Console.ReadLine();

                                }
                                else
                                {
                                    Console.WriteLine("Too distant, no attack");
                                    Console.SetCursorPosition(2, 40);
                                    Console.ReadLine();
                                }
                            }
                            else
                            {
                                hp2 = hp2 - 25;
                                AS2 = 10 * DisBC + (100 - hp2);
                                Console.WriteLine("A : " + "Non - fighter  " + "Health: " + hp1 + "  Score: 0");
                                Console.WriteLine("B : " + "Survivor       " + "Health: " + hp2 + "  Score: " + AS2);
                                Console.WriteLine("C : " + "Defeated       " + "Health: 0" + "  Score: 0");
                                Console.SetCursorPosition(2, 37);
                                Console.ReadLine();
                                Console.WriteLine("Round 2: A-B");
                                if (AB <= 15)
                                {
                                    hp1 = hp1 - 25;
                                    AS4 = 10 * DisAB + (100 - hp1);
                                    Console.WriteLine("A : " + "Survivor       " + "Health: " + hp1 + "  Score: " + AS4);
                                    Console.WriteLine("B : " + "Defeated       " + "Health: 0" + "  Score: " + AS2);
                                    Console.WriteLine("C : " + "Defeated       " + "Health: 0" + "  Score: 0");
                                    Console.SetCursorPosition(2, 43);
                                    Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("Too distant, no attack");
                                    Console.SetCursorPosition(2, 40);
                                    Console.ReadLine();
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Round 1:  B-C");
                            Console.WriteLine("Too distant, no attack");
                            Console.SetCursorPosition(2, 47);
                            Console.ReadLine();
                        }


                    }
                    else
                    {
                        if (AC <= 15)
                        {
                            Console.WriteLine("Round 1: A-C");
                            if (x == 0 || x == 2 || x == 4)
                            {
                                hp1 = hp1 - 25;
                                AS1 = 10 * DisAC + (100 - hp1);
                                Console.WriteLine("A : " + "Survivor       " + "Health: " + hp1 + "  Score: " + AS1);
                                Console.WriteLine("B : " + "Non - fighter  " + "Health: " + hp2 + "  Score: 0");
                                Console.WriteLine("C : " + "Defeated       " + "Health: 0" + "  Score: 0");
                                Console.SetCursorPosition(2, 37);
                                Console.ReadLine();
                                Console.WriteLine("Round 2: A-B");
                                if (AB <= 15)
                                {
                                    hp2 = hp2 - 25;
                                    AS5 = 10 * DisAB + (100 - hp2);
                                    Console.WriteLine("A : " + "Defeated       " + "Health: 0 " + "  Score: " + AS1);
                                    Console.WriteLine("B : " + "Survivor       " + "Health: " + hp2 + "  Score: " + AS5);
                                    Console.WriteLine("C : " + "Defeated       " + "Health 0: " + "  Score: 0");
                                    Console.SetCursorPosition(2, 43);
                                    Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("Too distant, no attack");
                                    Console.SetCursorPosition(2, 40);
                                    Console.ReadLine();
                                }
                            }
                            else
                            {
                                hp3 = hp3 - 25;
                                AS3 = 10 * DisAC + (100 - hp3);
                                Console.WriteLine("A : " + "Defeated       " + "Health: 0" + "  Score: 0");
                                Console.WriteLine("B : " + "Non - fighter  " + "Health: " + hp2 + "  Score: 0");
                                Console.WriteLine("C : " + "Survivor       " + "Health: " + hp3 + "  Score: " + AS3);

                                Console.SetCursorPosition(2, 37);
                                Console.ReadLine();
                                Console.WriteLine("Round 2: B-C");
                                if (BC <= 15)
                                {
                                    hp2 = hp2 - 25;
                                    AS5 = 10 * DisBC + (100 - hp2);
                                    Console.WriteLine("A : " + "Defeated       " + "Health: 0 " + "  Score: 0");
                                    Console.WriteLine("B : " + "Survivor       " + "Health: " + hp2 + "  Score: " + AS5);
                                    Console.WriteLine("C : " + "Defeated       " + "Health 0: " + "  Score: " + AS3);
                                    Console.SetCursorPosition(2, 43);
                                    Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("Too distant, no attack");
                                    Console.SetCursorPosition(2, 40);
                                    Console.ReadLine();

                                }
                            }
                            


                        }
                        else
                        {
                            Console.WriteLine("Round 1:  A-C");
                            Console.WriteLine("Too distant, no attack");
                            Console.SetCursorPosition(2, 47);
                            Console.ReadLine();
                        }

                    }
                    if ((AS1 + AS4) > (AS2 + AS5) && (AS1 + AS4) > (AS3 + AS6))
                    {
                        Console.WriteLine("A has the maximum score  " + "(" + (AS1 + AS4) + ")");
                    }
                    else if ((AS2 + AS5) > (AS3 + AS6))
                    {
                        Console.WriteLine("B has the maximum score  " + "(" + (AS2 + AS5) + ")");
                    }
                    else
                    {
                        Console.WriteLine("C has the maximum score  " + "(" + (AS3 + AS6) + ")");
                    }
                    Console.ReadLine();

                }












            }
































         }
    }    }
