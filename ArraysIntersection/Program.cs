using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArraysIntersection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Даны два неубывающих массива x и y. Найти их пересечение, то есть неубывающий массив z, содержащий их общие элементы, 
            //причем кратность каждого элемента в массиве z равна минимуму его кратностей  в массивах x и y.

            string array1;                                      //the string will be used as the first array
            string array2;                                      //the string will be used as the second array
            int lengthInsideArray1;
            int lengthInsideArray2;
            ArrayList intersectionList = new ArrayList();       //will be used to show intersection
            ArrayList list1 = new ArrayList();                  //will be used to know how many the same particular elements are inside the first array
            ArrayList list2 = new ArrayList();                  //will be used to know how many the same particular elements are inside the second array

            Console.Write("Enter an integer number for the FIRST array (numbers will be used as elements of the first array): ");
            array1 = Console.ReadLine();

            Console.Write("Enter an integer number for the SECOND array (numbers will be used as elements of the first array): ");
            array2 = Console.ReadLine();

            for (int i = 0; i < array1.Length; i++)           //look through elements of the first array1
            {
                if (intersectionList.Contains(array1[i]))    //check whether the list, which shows intersection, has such kind of an element or not
                {
                    continue;
                }
                else
                {
                    for (int j = 0; j < array2.Length; j++)  //look through elements of the second array2
                    {
                        if (intersectionList.Contains(array2[j]))    //check whether the list, which shows intersection, has such kind of an element or not
                        {
                            continue;
                        }
                        else if (array1[i] == array2[j])          //if the first and the second arrays have the same element than let's count how many such elements they have in each array
                        {
                            for (int k = 0; k < array1.Length; k++) //looking for amount of array1[i] in the FIRST array (array1)
                            {
                                if (array1[k] == array1[j])
                                {
                                    list1.Add(array1[k]);
                                }
                            }
                            lengthInsideArray1 = list1.Count;  //it shows how many array1[i] are inside array1
                            list1.Clear();

                            for (int l = 0; l < array2.Length; l++) ////looking for amount of array[i] in the SECOND array (array2)
                            {
                                if (array2[l] == array1[j])
                                {
                                    list2.Add(array2[l]);
                                }
                            }
                            lengthInsideArray2 = list2.Count;  //it shows how many array1[i] are inside array2
                            list2.Clear();

                            if (lengthInsideArray1 <= lengthInsideArray2) //we need to understand which amount is less
                            {
                                for (int m = 0; m < lengthInsideArray1; m++) //Then we'll add array1[i] element
                                {
                                    intersectionList.Add(array1[i]);
                                }
                            }
                            else
                            {
                                for (int m = 0; m < lengthInsideArray2; m++) //Then we'll add array1[i] element 
                                {
                                    intersectionList.Add(array1[i]);
                                }
                            }

                            for (int n = 0; n < intersectionList.Count; n++)
                            {
                                Console.Write(" " + intersectionList[n]);
                            }
                            Console.ReadKey();
                        }
                    }
                }
            }
        }
    }
}