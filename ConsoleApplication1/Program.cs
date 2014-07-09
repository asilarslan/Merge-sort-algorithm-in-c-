//////////////////////
//                  //
//   Asil ARSLAN    //
//   111180006      //
//                  //
//////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int array_size;
            int[] array;
            string x;
            Program program = new Program();
            while (true)
            {

                Console.WriteLine("10 için 10 a\n100 için 100 e\n1000 için 1000 e basin");
                x = Console.ReadLine();
                if (x == "10")
                {
                    array_size = 10;
                    array = new int[array_size];
                    Random r = new Random();
                    for (int i = 0; i < array_size; i++)
                    {
                        array[i] = r.Next(1, 10000);
                        Console.WriteLine(array[i]);
                    }
                    program.Merge(array, 0, array_size-1);
                    Console.WriteLine();
                    
                    for (int i = 0; i < array_size; i++)
                    {
                        Console.WriteLine(array[i]);
                    }


                }

                else if (x == "100")
                {
                    array_size = 100;
                    array = new int[array_size];
                    Random r = new Random();
                    for (int i = 0; i < array_size; i++)
                    {
                        array[i] = r.Next(1, 10000);
                        Console.WriteLine(array[i]);
                    }
                    program.Merge(array, 0, array_size-1);
                    Console.WriteLine();
                    
                    for (int i = 0; i < array_size; i++)
                    {
                        Console.WriteLine(array[i]);
                    }
                }

                else if (x == "1000")
                {
                    array_size = 1000;
                    array = new int[array_size];
                    Random r = new Random();
                    for (int i = 0; i < array_size; i++)
                    {
                        array[i] = r.Next(1, 10000);
                        Console.WriteLine(array[i]);
                    }
                    program.Merge(array, 0, array_size-1);
                    Console.WriteLine();
                    
                    for (int i = 0; i < array_size; i++)
                    {
                        Console.WriteLine(array[i]);
                    }
                }

            }



        }

        public void mergeSort(int[] array, int first,int middle,int last )
        {
            int[] temp ;
            int counter = 0;

            int i, first_end, num_elements, tmp_pos;

            if (last == 9)
                temp = new int[10];
            else if (last == 99)
                temp = new int[100];
            else
                temp = new int[1000];



            first_end = (middle - 1);

            tmp_pos = first;

            num_elements = (last - first + 1);



            while ((first <= first_end) && (middle <= last))
            {

                if (array[first] <= array[middle])
                {

                    temp[tmp_pos++] = array[first++];
                    counter++;
                }

                else
                {

                    temp[tmp_pos++] = array[middle++];
                    counter++;
                }

            }

            counter += counter;

            while (first <= first_end)
            {

                temp[tmp_pos++] = array[first++];
                counter++;
            }

            counter += counter;

            while (middle <= last)
            {
                temp[tmp_pos++] = array[middle++];
                counter++;
            }

            counter += counter;

            for (i = 0; i < num_elements; i++)
            {

                array[last] = temp[last];

                last--;
                counter++;
                

            }

            counter += counter;

            
                Console.WriteLine("counter = " + counter);

        }

        public void Merge(int[] array, int first, int last)
        {

            int middle;



            if (last > first)
            {

                middle = (last + first) / 2;

                Merge(array, first, middle);

                Merge(array, (middle + 1), last);


                
                mergeSort(array, first, (middle + 1), last);



            }

        }

    }
}