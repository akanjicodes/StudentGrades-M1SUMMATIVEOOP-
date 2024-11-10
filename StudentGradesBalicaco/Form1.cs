using StudentGrades;

namespace StudentGradesBalicaco
{
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            InitializeComponent();
        }

        private void formGrade_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          

            int student_id = Convert.ToInt32 (studentId.Text.Trim());
            string student_name = studentName.Text.Trim();
            double formative_grade = Convert.ToDouble (formGrade.Text.Trim()); 
            double summative_grade = Convert.ToDouble(summGrade.Text.Trim());
            int extra_credit = Convert.ToInt32 (extraCred.Text.Trim());
            
            StudentLetterGrade StudentLetterGrade = new StudentLetterGrade(student_id, student_name, formative_grade, summative_grade, extra_credit);
            initialGr.Text = Convert.ToString(StudentLetterGrade.GetInitialGrade());
            finalGr.Text = Convert.ToString(StudentLetterGrade.GetFinalGrade());
            letterGr.Text = Convert.ToString(StudentLetterGrade.GetLetterGrade());

            if (initialGr.Visible == false) initialGr.Visible = true;
            if (finalGr.Visible == false) finalGr.Visible = true;
            if (letterGr.Visible == false) letterGr.Visible = true;

        }
    }
}
