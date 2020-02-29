using System;

namespace CA2Prac
{
    class Program
    {




        // just 1 arrays to store amount of specific grade and 2nd array to just store chars for simpler output
        static double[] grades = new double[6] { 0, 0, 0, 0, 0, 0 };  //keeps a record of each grade 
        static char[] letters = new char[6] { 'A', 'B', 'C', 'D', 'E', 'F' };


        static void Main(string[] args)
        {
            int studentAmount = 0; //student amount pool
            double totalMarks = 0; //total marks pool
            double average = 0; //average
            int i = 0; //loop
            double mark; //mark



            while (i == 0) //just looping 
            {

                mark = GetMark(); //calls method and gets mark
                if (mark != -999)//checks if -999
                {
                    studentAmount++;//if not student ++
                    DetermainGrade(mark); //callsmethod to determain grade

                    totalMarks = mark + totalMarks;  //adds mark to total pool
                }
                else  //else breaks
                    break;
            }
            average = GetAverage(studentAmount, totalMarks); //if breaks it calculates average
            OutputResults(average, totalMarks, studentAmount);  //then outputs results

        }





        static double GetMark()//inputs mark
        {
            double mark;
            Console.WriteLine("Enter mark: ");
            mark = double.Parse(Console.ReadLine());

            return mark;
        }





        static void DetermainGrade(double mark)//determains what grade student gets
        {
            if (mark < 40)
                grades[0] = grades[0] + 1;
            else if (mark > 39 && mark < 50)
                grades[1] = grades[1] + 1;
            else if (mark > 49 && mark < 60)
                grades[2] = grades[2] + 1;
            else if (mark > 59 && mark < 70)
                grades[3] = grades[3] + 1;
            else if (mark > 69 && mark < 80)
                grades[4] = grades[4] + 1;
            else
                grades[5] = grades[5] + 1;
        }


        static double GetAverage(int studentAmount, double totalMarks)//calculates average
        {
            double average;
            average = totalMarks / studentAmount;
            return average;
        }


        static void OutputResults(double average, double totalMarks, int studentAmount)//putputs result
        {
            Console.WriteLine("Total marks: {0}", totalMarks);

            Console.WriteLine("Average marks: {0}", average);

            Console.WriteLine("Student amount: {0}", studentAmount);

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("{0}: {1}", letters[i], grades[i]);
            }

        }

    }
}
