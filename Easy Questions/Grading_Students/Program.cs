using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grading_Students
{
    class Program
    {
        static int[] gradingStudents(int[] grades)
        {
            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i] >= 38 && (grades[i] % 5) >= 3)
                {
                    for (; ; )
                    {
                        grades[i]++;
                        if (grades[i] % 5 == 0)
                        {
                            break;
                        }
                    }
                }
            }
            return grades;
        }

        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());

            int[] grades = new int[n];

            for (int gradesItr = 0; gradesItr < n; gradesItr++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine());
                grades[gradesItr] = gradesItem;
            }

            int[] result = gradingStudents(grades);

            Console.WriteLine(string.Join("\n", result));
            Console.ReadKey();
            #region OtherSolutions
            #region 1
            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int a0 = 0; a0 < n; a0++)
            //{
            //    int grade = Convert.ToInt32(Console.ReadLine());
            //    int finalGrade = grade;
            //    // your code goes here
            //    if (grade >= 38)
            //    {
            //        if (grade % 5 == 3)
            //        {
            //            finalGrade += 2;
            //        }
            //        else if (grade % 5 == 4)
            //        {
            //            finalGrade += 1;
            //        }
            //    }

            //    Console.WriteLine(finalGrade);
            //}
            #endregion
            #region 2
            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int a0 = 0; a0 < n; a0++)
            //{
            //    int grade = Convert.ToInt32(Console.ReadLine());
            //    if (grade < 38)
            //    {
            //        Console.WriteLine(grade);
            //    }
            //    else
            //    {
            //        for (int j = 0; j < 5; j++)
            //        {
            //            if (((grade + j) % 5 == 0))
            //            {
            //                if ((j < 3))
            //                {
            //                    Console.WriteLine(grade + j);
            //                }
            //                else
            //                {
            //                    Console.WriteLine(grade);
            //                }
            //            }
            //        }
            //    }

                // your code goes here
            // }
        #endregion
        #region 3
        //int n = Convert.ToInt32(Console.ReadLine());
        //int[] grades = new int[n];
        //for(int a0 = 0; a0<n; a0++){
        //    int grade = Convert.ToInt32(Console.ReadLine());
        //int mod = grade % 5;
            
        //    if((((grade - mod) + 5) - grade) < 3)
        //    {
        //        if(grade< 38){
        //            grades[a0] = grade;
        //        }
        //        else{
        //            grades[a0] = (grade - mod) + 5;
        //        }
        //    }else{
        //        grades[a0] = grade;
        //    }
        //}

        //for(int i=0; i<n ; i++){
        //    Console.WriteLine(grades[i]);
        //}
        #endregion
        #endregion

    }
    }
}
