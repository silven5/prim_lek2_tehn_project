namespace prim6_lek2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.TextBox();
            this.Age = new System.Windows.Forms.TextBox();
            this.Salary = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Rezult = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "ПІБ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Вік";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Зарплатня";
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(274, 51);
            this.LastName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.LastName.MaximumSize = new System.Drawing.Size(314, 50);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(314, 44);
            this.LastName.TabIndex = 3;
            this.LastName.Text = "Іванов І.І.";
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(274, 119);
            this.Age.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(156, 44);
            this.Age.TabIndex = 4;
            this.Age.Text = "16";
            // 
            // Salary
            // 
            this.Salary.Location = new System.Drawing.Point(274, 194);
            this.Salary.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(156, 44);
            this.Salary.TabIndex = 5;
            this.Salary.Text = "20000";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(456, 113);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 62);
            this.button1.TabIndex = 6;
            this.button1.Text = "Розрахунок";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Rezult
            // 
            this.Rezult.AutoSize = true;
            this.Rezult.Location = new System.Drawing.Point(24, 266);
            this.Rezult.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Rezult.Name = "Rezult";
            this.Rezult.Size = new System.Drawing.Size(162, 37);
            this.Rezult.TabIndex = 7;
            this.Rezult.Text = "Результат";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 323);
            this.Controls.Add(this.Rezult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Salary);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Класи";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox Age;
        private System.Windows.Forms.TextBox Salary;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Rezult;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

