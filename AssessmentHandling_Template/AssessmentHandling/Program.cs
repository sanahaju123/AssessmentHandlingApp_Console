using System;
using System.Collections.Generic;
using System.Reflection;

namespace AssessmentHandling
{
    public class Program
    {
        public static List<Assessment> assessments = new List<Assessment>()
        {
            new Assessment { AssessmentId=1 ,AssessmentName="assignment1",AssessmentDate=DateTime.Now,AssessmentType="type1",track="track1" },
            new Assessment { AssessmentId=2 ,AssessmentName="assessment2",AssessmentDate=DateTime.Now,AssessmentType="type2",track="track2" }
        };

        public static void Main()
        {
            Console.WriteLine("--------------------Assessment Management Application--------------------");
            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\tA - Add New Assessment");
            Console.WriteLine("\tU - Update a Assessment");
            Console.WriteLine("\tL - Get All Assessments");
            Console.WriteLine("\tI - Get Assessment By Id");
            Console.WriteLine("\tD - Delete Assessment");
            Console.Write("Your option? ");

            switch (Console.ReadLine())
            {
                case "A":
                    for (int i = 1; i < 6; i++)
                    {
                        Console.Write("AssessmentId: ");
                        int Id = int.Parse(Console.ReadLine());

                        Console.Write("AssessmentName: ");
                        string name = Console.ReadLine();

                        Console.Write("AssessmentDuration: ");
                        DateTime duration = DateTime.Parse(Console.ReadLine());

                        Console.Write("AssessmentType: ");
                        string type = Console.ReadLine();

                        Console.Write("Track: ");
                        string track = Console.ReadLine();
                        Assessment _assessment = new Assessment(Id, name, type,duration,track);
                        AddAssessment(_assessment);
                    }
                    break;

                case "U":
                    for (int i = 1; i < 6; i++)
                    {
                        Console.Write("AssessmentId: ");
                        int Id = int.Parse(Console.ReadLine());

                        Console.Write("AssessmentName: ");
                        string name = Console.ReadLine();

                        Console.Write("AssessmentDuration: ");
                        DateTime duration = DateTime.Parse(Console.ReadLine());

                        Console.Write("AssessmentType: ");
                        string type = Console.ReadLine();

                        Console.Write("Track: ");
                        string track = Console.ReadLine();
                        Assessment _assessment = new Assessment(Id, name, type, duration, track);
                        AddAssessment(_assessment);
                    }
                    break;


                case "L":
                    ShowAllAssessments();
                    break;

                case "I":
                    Console.WriteLine("Enter Assessment Id:");
                    int id = int.Parse(Console.ReadLine());
                    GetAssessmentById(id);
                    break;

                case "D":
                    Console.WriteLine("Enter Assessment Id:");
                    int assessmentid = int.Parse(Console.ReadLine());
                    RemoveAssessmentById(assessmentid);
                    break;
            }
            // Wait for the user to respond before closing.
            Console.Write("Press any key to close the console app...");
            Console.ReadKey();
        }

        /// <summary>
        /// Add a assessment
        /// </summary>
        /// <param name="assessment"></param>
        /// <returns></returns>
        public static IEnumerable<Object> AddAssessment(Assessment assessment)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Update a assessment
        /// </summary>
        /// <param name="assessment"></param>
        /// <returns></returns>
        public static IEnumerable<Object> UpdateAssessment(Assessment assessment)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Show all assessments
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<Object> ShowAllAssessments()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get assessment by id
        /// </summary>
        /// <param name="AssessmentId"></param>
        /// <returns></returns>
        public static IEnumerable<Object> GetAssessmentById(int AssessmentId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Delete assessment from list
        /// </summary>
        /// <param name="AssessmentId"></param>
        /// <returns></returns>
        public static IEnumerable<Assessment> RemoveAssessmentById(int AssessmentId)
        {
            throw new NotImplementedException();
        }
    }
}

