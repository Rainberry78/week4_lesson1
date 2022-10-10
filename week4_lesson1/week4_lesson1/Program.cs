using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4_lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Q1();

            //bool t = Q2();
            //Console.WriteLine(t);

            //Q3b();

            //Q4("kkkktttrrrrrrrrrr");

            //Q5();

            //int[] tab = { 5, 7, 5, 2, 2, 4, 5 };
            //Q6(tab);

            //int nb = Q7();
            //Console.WriteLine(nb);

            //Q8();

            

            Console.ReadKey();
        }

        static void Q1()
        {
            string word = "";
            word = Convert.ToString(Console.ReadLine());

            char[] word2 = new char[word.Length];
            char letter1 = word[0];
            char letter2 = word[word.Length - 1];

            word2[0] = letter2;
            word2[word.Length - 1] = letter1;

            for (int i = 1; i < word.Length - 1; i++)
            {
                word2[i] = word[i];
            }

            for (int i = 0; i < word.Length; i++)
            {
                Console.Write(word2[i]);
            }

        }


        static bool Q2()
        {
            int[] tab = { 1, 2, 3, 4, 5, 6, 7 };
            int[] sq = { 2, 3, 4 };

            if (sq.Length > tab.Length)
            {
                return false;
            }

            int cpt = 0;
            
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] == sq[cpt])
                {
                    cpt++;
                    if (cpt == sq.Length)
                    {
                        return true;
                    }
                }
                else
                {
                    cpt = 0;
                }
                

            }
            return false;
        }


        static void Q3()
        {
            Console.WriteLine("Give a char : ");

            char c = Convert.ToChar(Console.ReadLine());

            Console.WriteLine((int)c);
            
        }


        static char[] Q3b()
        {
            string word = "abcdefghijklmnopqrstuvwxyz";

            int[] tab = new int[word.Length];
            char[] tab2 = new char[word.Length];

            for(int i =0; i<tab.Length; i++)
            {
                tab[i] = (int)word[i];

            }

            int a = 0;

            for (int i = 0; i < tab2.Length; i++)
            {
                Console.Write(word[i] + " ");

            }
            Console.Write("\n ");

            while(tab[0]<tab[1])
            {
                for (int i = 0; i < tab.Length - 1; i++)
                {
                    if (tab[i] < tab[i + 1])
                    {
                        a = tab[i];
                        tab[i] = tab[i + 1];
                        tab[i + 1] = a;
                    }

                }
            }
            
            

            for (int i = 0; i < tab2.Length; i++)
            {
                tab2[i] = (char)tab[i];

            }

            for (int i = 0; i < tab2.Length; i++)
            {
                Console.Write(tab2[i]+ " ");

            }


            return tab2;
        }


        static void Q4(string s)
        {
            char[] sc = new char[s.Length];
            int x = 1;
            int j = 0;
            
            for(int i=0; i<s.Length-1; i++)
            {
                if(s[i] == s[i+1])
                {
                    x++;
                    sc[j] = s[i];
                    sc[j + 1] = (char)x;

                }
                else
                {
                    j += 2;
                    x = 1;
                }
                
            }

            for(int i =0; i<sc.Length; i++)
            {
                if(i%2==0)
                {
                    Console.Write(sc[i]);
                }
                else
                {
                    Console.Write((int)sc[i]);
                }

                if(sc[i]==0)
                {
                    break;
                }
            }

            
        }


        static void Q5()
        {
            for (int i = 0; i <= 999; i++) 
            {
                int a = 0, b = 0, c = 0;

                a = i / 100 - (i % 100 / 100); //the hundreds
                c = i % 100;
                b = (c - (c % 10)) / 10; // dozens 
                c = c % 10; //the units

                if (a * a * a + b * b * b + c * c * c == i) 
                {
                    Console.WriteLine("The number " + i + " is Armstrong");
                }
            }
        }


        static void Exercice5()//Version qui utilise un string
        {
            List<int> listOfArmstrongNumber = new List<int>();
            int sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                string numberInString = Convert.ToString(i);
                for (int y = 0; y < numberInString.Length; y++)
                {
                    sum += (Convert.ToInt32(numberInString[y]) - 48) * (Convert.ToInt32(numberInString[y]) - 48) * (Convert.ToInt32(numberInString[y]) - 48);
                }
                if (sum == i) Console.WriteLine(i + " is an Armstrong Number");
                sum = 0;
            }

        }



        static void Q6(int[] tab)
        {
            if (tab != null && tab.Length > 0)
            {
                int cpt = 0;
                int max=0;
                for (int i = 0; i < tab.Length; i++)
                {
                    if (max<tab[i])
                    {
                        max = tab[i];
                    }
                }


                for (int i = 0; i <= max; i++)
                {
                    for (int x = 0; x < tab.Length; x++)
                    {
                        if (i == tab[x])
                        {
                            cpt++;
                        }

                    }
                    if(cpt!=0)
                    {
                        Console.WriteLine(i + " is " + cpt + " times ");
                    }
                    
                    cpt = 0;
                }

            }
        }



        static int Q7()
        {
            int nb = int.Parse(Console.ReadLine());
            int fact = 1;

            for(int i =nb; i>1; i--)
            {
                fact = fact * i;
            }

            return fact;
        }

        
        static void Q8()
        {
            string s = "My Name is Dégot";
            Console.WriteLine(s);
            int c = 0;
            for(int i =0; i<s.Length; i++)
            {
                if(s[i]==' ')
                {
                    c++;
                }
            }
            Console.WriteLine(c);
        }


        /*
        static void TableOfPerson()
        {
            Person[] array = new Person[3];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Choose a name");
                array[i] = new Person(Console.ReadLine());
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i].ToString());
            }
        }
        */

    }
}
