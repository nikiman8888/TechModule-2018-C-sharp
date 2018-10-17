using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Threading;
using System.Text.RegularExpressions;

namespace _11.ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split(' ');

                string commannd = tokens[0];

                switch (commannd)
                {
                    case "exchange":
                        int index = int.Parse(tokens[1]);
                        if (index < 0 || index > inputArray.Count - 1 ) // if index is out of the array continue..
                        {
                            Console.WriteLine("Invalid index");
                            input = Console.ReadLine();
                            continue;
                        }

                        inputArray = GetExchange(inputArray, index); //use metod for exchange
                        
                        break;
                    case "max":

                        string type = tokens[1];

                        int resultIndex = GetIndexMax(inputArray, type);//search the index in the method
                        if (resultIndex == -1)// if the returned index is -1 ,mean that we dont found index
                        {
                            Console.WriteLine("No matches");
                            input = Console.ReadLine();
                            continue;
                        }
                        Console.WriteLine(resultIndex);//if we have real result print it

                        break;
                    case "min":

                        string typeMin = tokens[1];

                        resultIndex = GetIndexMin(inputArray, typeMin);//search the index in the method
                        if (resultIndex == -1)  // if the returned index is -1 ,mean that we dont found index
                        {
                            Console.WriteLine("No matches");
                            input = Console.ReadLine();
                            continue;
                        }
                        Console.WriteLine(resultIndex); //if we have real result print it

                        break;
                    case "first":
                        int count = int.Parse(tokens[1]);
                        string typeFirst = tokens[2];
                         

                        if (count < 0 || count > inputArray.Count)//check the count,
                        {                                         // if is not in the array -its invalid
                            Console.WriteLine("Invalid count");
                            input = Console.ReadLine();
                            continue;
                        }

                        List<int> temp = new List<int>();//create temp list for the result

                        if (typeFirst == "odd")
                        {
                             temp = inputArray.Where(x => x % 2 != 0).Take(count).ToList();// we take needed elements
                                                                                           //with lambda function
                            Console.WriteLine("[{0}]",string.Join(", ",temp));
                        }
                        else if(typeFirst == "even")
                        {
                            temp = inputArray.Where(x => x % 2 == 0).Take(count).ToList();// we take needed elements
                                                                                          //with lambda function
                            Console.WriteLine("[{0}]", string.Join(", ", temp));              
                        }
                        
                        break;
                    case "last":
                        count = int.Parse(tokens[1]);

                        string typeLast = tokens[2];

                        if (count < 0 || count >inputArray.Count)   //check the count,
                        {                                           // if is not in the array -its invalid
                            Console.WriteLine("Invalid count");
                            input = Console.ReadLine();
                            continue;
                        }
                        temp = new List<int>();   //create temp list for the result

                        if (typeLast == "odd")
                        {
                            temp = inputArray.Where(x => x % 2 != 0).ToList();// we take needed odd elements with lambda

                            int elementsToSkip = temp.Count - count; 

                            if (elementsToSkip < 0) // if is negative we skip 0 elements
                            {
                                elementsToSkip = 0;
                            }
                            temp = temp.Skip(elementsToSkip).Take(count).ToList();// skip elements and take
                                                                                   // count elemets with lambda
                            Console.WriteLine("[{0}]",string.Join(", ",temp));
                        }
                        else
                        {
                            temp = inputArray.Where(x => x % 2 == 0).ToList();// we take needed even elements with lambda

                            int elementsToSkip = temp.Count - count;

                            if (elementsToSkip < 0) //if is negative we skip 0 elements
                            {
                                elementsToSkip = 0;
                            }
                            temp = temp.Skip(elementsToSkip).Take(count).ToList();// skip elements and take
                                                                                  // count elemets with lambda
                            Console.WriteLine("[{0}]", string.Join(", ", temp));
                        }
                        break;                       
                }

                input = Console.ReadLine();
            }
            Console.WriteLine("[{0}]",string.Join(", ",inputArray));

        }
        private static int GetIndexMin(List<int> inputArray, string typeMin)
        {
            int indexTemp = 0;

            if (typeMin == "odd")
            {
                int check = inputArray.Where(x => x % 2 != 0).Count();// we check ,do we have an odd elemets 
                if (check == 0)
                {
                    indexTemp = -1; // if not we return -1
                    return indexTemp;
                }
                int minNumber = inputArray.Where(x => x % 2 != 0).Min(); //we take by lambda min number in the sequence

                for (int i = inputArray.Count -1; i >= 0; i--) //start to reverse from the end 
                {
                    if (inputArray[i] == minNumber) //when we found the min number we return the index,
                    {                                    //because is the most right one
                        indexTemp = i;
                        return indexTemp;
                    }
                }

            }
            else
            {
                int check = inputArray.Where(x => x % 2 == 0).Count();// we check ,do we have an odd elemets
                if (check == 0)
                {
                    indexTemp = -1;    // if not we return -1
                    return indexTemp;
                }
                int minNumber = inputArray.Where(x => x % 2 == 0).Min(); //we take by lambda min number in the sequence

                for (int i = inputArray.Count - 1; i >= 0; i--)  //start to reverse from the end
                {
                    if (inputArray[i] == minNumber) //when we found the min number we return the index,
                    {                                        //because is the most right one
                        indexTemp = i;
                        return indexTemp;
                    }
                }
            }
            return indexTemp;
        }
        private static int GetIndexMax(List<int> inputArray, string type)
        {
           int indexTemp = 0;

           if (type == "odd")
            {
                int check = inputArray.Where(x => x % 2 != 0).Count();  // we check ,do we have an odd elemets
                if (check == 0)
                {
                    indexTemp = -1;    // if not we return -1
                    return indexTemp;
                }
                int max = inputArray.Where(x => x % 2 != 0).Max(); //we take by lambda max number in the sequence

                for (int i = inputArray.Count - 1; i >= 0; i--) //start to reverse from the end
                {
                    if (inputArray[i] == max)  //when we found the max number we return the index,
                    {                                  //because is the most right one
                        indexTemp = i;       
                        return indexTemp;
                    }
                }
            }
            else
            {
                int check = inputArray.Where(x => x % 2 == 0).Count();  // we check ,do we have an odd elemets
                if (check == 0)
                {
                    indexTemp = -1;   // if not we return -1
                    return indexTemp;
                }
                int max = inputArray.Where(x => x % 2 == 0).Max();  //we take by lambda max number in the sequence

                for (int i = inputArray.Count - 1; i >= 0; i--)   //start to reverse from the end
                {
                    if (inputArray[i] == max)     //when we found the max number we return the index,
                    {                                     //because is the most right one
                        indexTemp = i;
                        return indexTemp;
                    }
                }
            }
            return indexTemp;
        }
        private static List<int> GetExchange(List<int> inputArray, int index)
        {
            var temp = new List<int>();

            if (index + 1 <=  inputArray.Count-1)    //check for index + 1 ,if is out of array we dont change nothing
            {
                temp = inputArray.Skip(index + 1).Take(inputArray.Count - index + 1).ToList();
                //up we get the elements ,we need to insert of front of the array in new List

                inputArray.RemoveRange(index + 1, temp.Count);  //remove the part from the back

                inputArray.InsertRange(0, temp);           //put the last part to the front 
            }
            return inputArray;                       
        }
    }
}
