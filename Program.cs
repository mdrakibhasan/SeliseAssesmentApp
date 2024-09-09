using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int casenumber = 1;
            Console.WriteLine("Please Input Test Case Number");
            casenumber = Convert.ToInt32(Console.ReadLine());
            switch (casenumber)
            {
                case (1):
                    int[,,,] C1array1 = new int[2, 2, 2, 2]  {
                 {
                 {{1, 2}, {3, 4}},
                 {{5, 6}, {7, 8}}
                 },
                 {
                 {{9, 10}, {11, 12}},
                 {{13, 14}, {15, 16}}
                 }
                };
                    int[,,,] C1array2 = new int[2, 2, 2, 2] {
                 {
                 {{5, 2}, {13, 14}},
                 {{9, 6}, {20, 8}}
                 },
                 {
                 {{3, 10}, {21, 4}},
                 {{25, 16}, {7, 1}}
                 }
                };
                    
                    FindMatchingElements(C1array1, C1array2);
                    break;

                case (2):
                    int[,,,] C2array1 = new  int[1, 1, 1, 3] { { { { 1, 2, 3 } } } };
                    int[,,,] C2array2 = new int[1, 1, 1, 3] { { { { 4, 5, 6 } } } };

                    FindMatchingElements(C2array1, C2array2);
                    break;

                case (3):
                    int[,,,] C3array1 = new int[2, 2, 2, 1] {
 {
 {{1}, {2}},
 {{3}, {4}}
 },
 {
 {{5}, {6}},
 {{7}, {8}}
 }
};

                    int[,,,] C3array2 = new int[2, 2, 2, 1] {
 {
 {{1}, {2}},
 {{3}, {4}}
 },
 {
 {{5}, {6}},
 {{7}, {8}}
 }
};

                    FindMatchingElements(C3array1, C3array2);
                    break;

                case (4):
                    int[,,,] C4array1 = new int[0, 0, 0, 0];
                    int[,,,] C4array2 = new int[0, 0, 0, 0];

                    FindMatchingElements(C4array1, C4array2);
                    break;

                case (5):
                    int[,,,] C5array1 = new int[2, 2, 1, 2] {
                         {
                         {{1, 2}},
                         {{3, 4}}
                         },
                         {
                         {{5, 6}},
                         {{7, 8}}
                         }
                        };
                    int[,,,] C5array2 = new int[3, 2, 1, 2] {
                        {
                            { { 5, 9} },
                             { { 3, 6} }},
                             { { { 7, 2} },
                             { { 8, 4} } },
                             { { { 10, 11} },
                             { { 1, 12} }
                        }
                    };


                    FindMatchingElements(C5array1, C5array2);
                    break;

                case (6):
                    int[,,,] C6array1 = new int[1, 1, 1, 5] { { { { 1, 2, 3, 4, 5 } } } };
                    int[,,,] C6array2 = new int[1, 1, 1, 6] { { { { 5, 4, 3, 2, 1, 0 } } } };


                    FindMatchingElements(C6array1, C6array2);
                    break;


                case (7):
                    int[,,,] C7array1 =  new int[3, 3, 3, 3];
                    int[,,,] C7array2 = new int[3, 3, 3, 3];
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            for (int k = 0; k < 3; k++)
                                for (int l = 0; l < 3; l++)
                                {
                                    C7array1[i, j, k, l] = i * j * k * l;
                                    C7array2[i, j, k, l] = i * j * k * l;
                                }
                    


                    FindMatchingElements(C7array1, C7array2);
                    break;
                default:
                    Console.WriteLine("Out of the Case Number");
                    break;
            }
           
            Console.ReadKey();
        }
        static void FindMatchingElements(int [,,,] array1 , int [,,,] array2)
        {
           
            int i = 0;
            int[] mactching=new int[array1.Length];
            if (array1 != null)
            {
                foreach (int a in array1)
                {
                    foreach (int b in array2)
                    {
                        if (a == b)
                        {
                            mactching[i] = a;
                            i++;
                            break;
                        }

                    }
                }
            }
            
            if (i > 0)
            {
                for (int j = i; j < array1.Length; j++)
                {
                    mactching[j] = -1;
                }

                foreach (int c in mactching)
                {

                    if ( c != null && c>=0)
                    {
                        Console.WriteLine(c);
                    }

                }
            }
            else
            {
                Console.WriteLine(" No elements to match");
            }
            
            
        }
    }
}
