using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradesBalicaco
{
    public partial class Component1 : Component
    {
        public Component1()
        {
            InitializeComponent();
        }

        public Component1(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
namespace StudentGrades
{
    abstract class StudentNumericGrade
    {
        private int student_id;
        private string student_name;
        private double formative_grade;
        private double summative_grade;
        protected double initial_grade;

        public StudentNumericGrade(int student_id, string student_name, double formative_grade, double summative_grade)
        {
            this.student_id = student_id;
            this.student_name = student_name;
            this.formative_grade = formative_grade;
            this.summative_grade = summative_grade;
        }

        public double GetInitialGrade()
        {
            initial_grade = (this.formative_grade * 0.3) + (this.summative_grade * 0.7);
            return initial_grade;
        }

        abstract public double GetFinalGrade();

        abstract public string GetLetterGrade();
    }

        class StudentLetterGrade : StudentNumericGrade
    {
        private int extra_credit;
        private double final_grade;
        private string letter_grade;

        public StudentLetterGrade(int student_id, string student_name, double formative_grade, double summative_grade, int extra_credit) : base(student_id, student_name, formative_grade, summative_grade)
        {
            this.extra_credit = extra_credit;  
        }

        public override double GetFinalGrade()
        {
            final_grade = GetInitialGrade() + this.extra_credit;
            return final_grade;
        }

        public override string GetLetterGrade()
        {
            if (final_grade >= 96) letter_grade = "1.00";
            else if ((final_grade >= 91.51) && (final_grade <= 96)) letter_grade = "1.25";
            else if ((final_grade >= 87.01) && (final_grade <= 91.50)) letter_grade = "1.50";
            else if ((final_grade >= 82.51) && (final_grade <= 87.00)) letter_grade = "1.75";
            else if ((final_grade >= 78.01) && (final_grade <= 82.50)) letter_grade = "2.00";
            else if ((final_grade >= 73.51) && (final_grade <= 78.00)) letter_grade = "2.25";
            else if ((final_grade >= 69.01) && (final_grade <= 73.50)) letter_grade = "2.50";
            else if ((final_grade >= 64.51) && (final_grade <= 69.00)) letter_grade = "2.75";
            else if ((final_grade >= 60.01) && (final_grade <= 64.50)) letter_grade = "3.00";
            else if (final_grade <= 60) letter_grade = "IP";

            return letter_grade;
        }

    }

}