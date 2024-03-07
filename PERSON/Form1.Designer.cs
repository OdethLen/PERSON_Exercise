namespace PERSON
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
            txtName = new TextBox();
            txtFLastName = new TextBox();
            txtMLastName = new TextBox();
            dateTimePicker = new DateTimePicker();
            label4 = new Label();
            txtMatricula = new TextBox();
            label5 = new Label();
            txtCareer = new TextBox();
            label6 = new Label();
            btnCreate = new Button();
            lblcreatePerson = new Label();
            numericUpDown1 = new NumericUpDown();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 52);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(171, 52);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 1;
            label2.Text = "Father Last Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(397, 52);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 2;
            label3.Text = "Mother Last Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(60, 44);
            txtName.Name = "txtName";
            txtName.Size = new Size(102, 23);
            txtName.TabIndex = 3;
            // 
            // txtFLastName
            // 
            txtFLastName.Location = new Point(279, 44);
            txtFLastName.Name = "txtFLastName";
            txtFLastName.Size = new Size(100, 23);
            txtFLastName.TabIndex = 4;
            // 
            // txtMLastName
            // 
            txtMLastName.Location = new Point(511, 44);
            txtMLastName.Name = "txtMLastName";
            txtMLastName.Size = new Size(100, 23);
            txtMLastName.TabIndex = 5;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Format = DateTimePickerFormat.Short;
            dateTimePicker.Location = new Point(80, 87);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(200, 23);
            dateTimePicker.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(315, 92);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 7;
            label4.Text = "Matricula:";
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(381, 87);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(120, 23);
            txtMatricula.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 135);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 9;
            label5.Text = "Career:";
            // 
            // txtCareer
            // 
            txtCareer.Location = new Point(62, 127);
            txtCareer.Name = "txtCareer";
            txtCareer.Size = new Size(100, 23);
            txtCareer.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(249, 130);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 11;
            label6.Text = "Average:";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(466, 135);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(112, 28);
            btnCreate.TabIndex = 13;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // lblcreatePerson
            // 
            lblcreatePerson.AutoSize = true;
            lblcreatePerson.Location = new Point(79, 201);
            lblcreatePerson.Name = "lblcreatePerson";
            lblcreatePerson.Size = new Size(16, 15);
            lblcreatePerson.TabIndex = 14;
            lblcreatePerson.Text = "...";
            lblcreatePerson.Click += lblcreatePerson_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(315, 130);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 92);
            label7.Name = "label7";
            label7.Size = new Size(62, 15);
            label7.TabIndex = 16;
            label7.Text = "Born Date:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 291);
            Controls.Add(label7);
            Controls.Add(numericUpDown1);
            Controls.Add(lblcreatePerson);
            Controls.Add(btnCreate);
            Controls.Add(label6);
            Controls.Add(txtCareer);
            Controls.Add(label5);
            Controls.Add(txtMatricula);
            Controls.Add(label4);
            Controls.Add(dateTimePicker);
            Controls.Add(txtMLastName);
            Controls.Add(txtFLastName);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtName;
        private TextBox txtFLastName;
        private TextBox txtMLastName;
        private DateTimePicker dateTimePicker;
        private Label label4;
        private TextBox txtMatricula;
        private Label label5;
        private TextBox txtCareer;
        private Label label6;
        private Button btnCreate;
        private Label lblcreatePerson;
        private NumericUpDown numericUpDown1;
        private Label label7;
    }
}
