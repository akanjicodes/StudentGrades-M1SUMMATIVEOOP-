namespace StudentGradesBalicaco
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            studentId = new TextBox();
            studentName = new TextBox();
            formGrade = new TextBox();
            summGrade = new TextBox();
            extraCred = new TextBox();
            initialGr = new Label();
            finalGr = new Label();
            letterGr = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(210, 45);
            label1.Name = "label1";
            label1.Size = new Size(395, 45);
            label1.TabIndex = 0;
            label1.Text = "Student Grade Calculator";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(38, 130);
            label2.Name = "label2";
            label2.Size = new Size(119, 30);
            label2.TabIndex = 1;
            label2.Text = "Student ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(328, 130);
            label3.Name = "label3";
            label3.Size = new Size(156, 30);
            label3.TabIndex = 2;
            label3.Text = "Student Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(38, 203);
            label4.Name = "label4";
            label4.Size = new Size(180, 30);
            label4.TabIndex = 3;
            label4.Text = "Formative Grade:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(38, 242);
            label5.Name = "label5";
            label5.Size = new Size(191, 30);
            label5.TabIndex = 4;
            label5.Text = "Summative Grade:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(462, 223);
            label6.Name = "label6";
            label6.Size = new Size(130, 30);
            label6.TabIndex = 5;
            label6.Text = "Extra Credit:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(308, 307);
            button1.Name = "button1";
            button1.Size = new Size(148, 56);
            button1.TabIndex = 6;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.Location = new Point(38, 386);
            label7.Name = "label7";
            label7.Size = new Size(222, 30);
            label7.TabIndex = 7;
            label7.Text = "Initial Numeric Grade:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F);
            label8.Location = new Point(38, 425);
            label8.Name = "label8";
            label8.Size = new Size(215, 30);
            label8.TabIndex = 8;
            label8.Text = "Final Numeric Grade:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F);
            label9.Location = new Point(418, 405);
            label9.Name = "label9";
            label9.Size = new Size(244, 30);
            label9.TabIndex = 9;
            label9.Text = "Equivalent Letter Grade:";
            // 
            // studentId
            // 
            studentId.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            studentId.Location = new Point(163, 130);
            studentId.Name = "studentId";
            studentId.Size = new Size(143, 34);
            studentId.TabIndex = 10;
            // 
            // studentName
            // 
            studentName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            studentName.Location = new Point(490, 128);
            studentName.Name = "studentName";
            studentName.Size = new Size(258, 34);
            studentName.TabIndex = 11;
            // 
            // formGrade
            // 
            formGrade.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            formGrade.Location = new Point(224, 203);
            formGrade.Name = "formGrade";
            formGrade.Size = new Size(115, 34);
            formGrade.TabIndex = 12;
            formGrade.TextChanged += formGrade_TextChanged;
            // 
            // summGrade
            // 
            summGrade.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            summGrade.Location = new Point(235, 243);
            summGrade.Name = "summGrade";
            summGrade.Size = new Size(115, 34);
            summGrade.TabIndex = 13;
            // 
            // extraCred
            // 
            extraCred.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            extraCred.Location = new Point(588, 223);
            extraCred.Name = "extraCred";
            extraCred.Size = new Size(115, 34);
            extraCred.TabIndex = 14;
            // 
            // initialGr
            // 
            initialGr.AutoSize = true;
            initialGr.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            initialGr.Location = new Point(259, 386);
            initialGr.Name = "initialGr";
            initialGr.Size = new Size(71, 30);
            initialGr.TabIndex = 15;
            initialGr.Text = "initial";
            initialGr.Visible = false;
            // 
            // finalGr
            // 
            finalGr.AutoSize = true;
            finalGr.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            finalGr.Location = new Point(253, 425);
            finalGr.Name = "finalGr";
            finalGr.Size = new Size(58, 30);
            finalGr.TabIndex = 16;
            finalGr.Text = "final";
            finalGr.Visible = false;
            // 
            // letterGr
            // 
            letterGr.AutoSize = true;
            letterGr.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            letterGr.Location = new Point(661, 405);
            letterGr.Name = "letterGr";
            letterGr.Size = new Size(95, 30);
            letterGr.TabIndex = 17;
            letterGr.Text = "letterGr";
            letterGr.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 504);
            Controls.Add(letterGr);
            Controls.Add(finalGr);
            Controls.Add(initialGr);
            Controls.Add(extraCred);
            Controls.Add(summGrade);
            Controls.Add(formGrade);
            Controls.Add(studentName);
            Controls.Add(studentId);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Grade Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox studentId;
        private TextBox studentName;
        private TextBox formGrade;
        private TextBox summGrade;
        private TextBox extraCred;
        private Label initialGr;
        private Label finalGr;
        private Label letterGr;
    }
}
