using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _10.SoftUniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shedule = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input = Console.ReadLine();

            while (input != "course start")
            {

                string[] tokens = input.Split(':');

                string command = tokens[0];

                switch (command)
                {
                    case "Add":
                        string lessonaToAdd = tokens[1];

                        if (!shedule.Contains(lessonaToAdd))
                        {
                            shedule.Add(lessonaToAdd);
                        }
                        break;

                    case "Insert":

                        string lessonToInsert = tokens[1];
                        int index = int.Parse(tokens[2]);

                        if (index >= 0 && index < shedule.Count)
                        {
                            if(!shedule.Contains(lessonToInsert))
                            {
                                shedule.Insert(index, lessonToInsert);
                            }
                        }


                        break;
                    case "Remove":

                        string lessonToRemove = tokens[1];
                        string exerciseToRemove = lessonToRemove + "-Exercise";

                        if (shedule.Contains(lessonToRemove))
                        {
                            shedule.Remove(lessonToRemove);
                        }
                        if (shedule.Contains(exerciseToRemove))
                        {
                            shedule.Remove(exerciseToRemove);
                        }
                        break;
                    case "Swap":
                        string firstLessoon = tokens[1];
                        string secondLesson = tokens[2];

                        string firstLessonExercise = firstLessoon + "-Exercise";
                        string secondLessonExercise = secondLesson + "-Exercise";

                        if (shedule.Contains(firstLessoon) && shedule.Contains(secondLesson))
                        {
                            int indexFirst = shedule.IndexOf(firstLessoon);
                            int indexSecond = shedule.IndexOf(secondLesson);

                            string temp = firstLessoon;

                            shedule[indexFirst] = secondLesson;
                            shedule[indexSecond] = temp;

                            if (shedule.Contains(firstLessonExercise))
                            {
                                shedule.Remove(firstLessonExercise);

                                if (indexSecond < shedule.Count -1)
                                {
                                    shedule.Insert(indexSecond + 1, firstLessonExercise);
                                }
                                else
                                {
                                    shedule.Add(firstLessonExercise);
                                }
                            }
                            if (shedule.Contains(secondLessonExercise))
                            {
                                shedule.Remove(secondLessonExercise);

                                if (indexFirst < shedule.Count -1)
                                {
                                    shedule.Insert(indexFirst + 1, secondLessonExercise);
                                }
                                else
                                {
                                    shedule.Add(secondLessonExercise);
                                }
                            }
                        }

                        break;
                    case "Exercise":

                        string lessonToUpdate = tokens[1];
                        string lessonExercise = lessonToUpdate + "-Exercise";

                        if (shedule.Contains(lessonToUpdate))
                        {
                            if (!shedule.Contains(lessonExercise))
                            {
                                int indexCurrentLesson = shedule.IndexOf(lessonToUpdate);

                                if (indexCurrentLesson < shedule.Count - 1)
                                {
                                    shedule.Insert(indexCurrentLesson + 1, lessonExercise);
                                }
                                else
                                {
                                    shedule.Add(lessonExercise);
                                }
                            }
                        }
                        else
                        {
                            shedule.Add(lessonToUpdate);
                            shedule.Add(lessonExercise);
                        }
                        break;
                       
                }
                input = Console.ReadLine();
            }

            int position = 1;  
            
            foreach (var lesson  in shedule)
            {
                Console.WriteLine($"{position}.{lesson}");

                position++;
            }
        }
    }
}
