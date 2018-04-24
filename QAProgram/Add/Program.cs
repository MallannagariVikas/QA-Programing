using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add
{
    class Program
    {
        static void Main(string[] args)
        
    {
                //Declared Array Size
                int[] SubjectMarks = new int[6];

            //calling the function:
            string Result = ReturnPassOrFail(SubjectMarks);

                Console.WriteLine(Result);
                Console.ReadKey();
                Console.ReadKey();
            }

        public static string ReturnPassOrFail(int[] SubjectMarks)
        {


            //Declaring the variable
            bool IsPass = false;

            //Assiging the values to SubjectMarks and verifying the pass or fail
            for (int i = 0; i < SubjectMarks.Length; i++)
            {
                Console.WriteLine("Enter the {0} subject Marks of a Subject.", i);
                SubjectMarks[i] = Convert.ToInt32(Console.ReadLine());
                if (SubjectMarks[i] >= 1 && SubjectMarks[i] <= 100)
                {
                    if (SubjectMarks[i] > 35)
                    {
                        IsPass = true;
                    }
                    else
                    {
                        IsPass = false;
                        break;
                    }
                }
            }
            var PassOrFailed = IsPass ? "Student Passed" : "Student Failed";
            return PassOrFailed;

        }
    }
        }
    
