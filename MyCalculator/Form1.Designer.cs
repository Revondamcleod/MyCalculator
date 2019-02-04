namespace MyCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.Operand2 = new System.Windows.Forms.Label();
            this.btnAddition = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnSubtraction = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.Operand1 = new System.Windows.Forms.TextBox();
            this.Oper2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labEqual = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(34, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operand 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Operand2
            // 
            this.Operand2.AutoSize = true;
            this.Operand2.ForeColor = System.Drawing.Color.Transparent;
            this.Operand2.Location = new System.Drawing.Point(203, 36);
            this.Operand2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Operand2.Name = "Operand2";
            this.Operand2.Size = new System.Drawing.Size(80, 17);
            this.Operand2.TabIndex = 1;
            this.Operand2.Text = "Operand 2";
            // 
            // btnAddition
            // 
            this.btnAddition.ForeColor = System.Drawing.Color.Maroon;
            this.btnAddition.Location = new System.Drawing.Point(14, 155);
            this.btnAddition.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(113, 47);
            this.btnAddition.TabIndex = 2;
            this.btnAddition.Text = "Addition";
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.Click += new System.EventHandler(this.btnAddition_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.BackColor = System.Drawing.Color.Transparent;
            this.btnDivision.ForeColor = System.Drawing.Color.Maroon;
            this.btnDivision.Location = new System.Drawing.Point(182, 240);
            this.btnDivision.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(113, 43);
            this.btnDivision.TabIndex = 3;
            this.btnDivision.Text = "Division";
            this.btnDivision.UseVisualStyleBackColor = false;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnSubtraction
            // 
            this.btnSubtraction.ForeColor = System.Drawing.Color.Maroon;
            this.btnSubtraction.Location = new System.Drawing.Point(182, 155);
            this.btnSubtraction.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSubtraction.Name = "btnSubtraction";
            this.btnSubtraction.Size = new System.Drawing.Size(113, 47);
            this.btnSubtraction.TabIndex = 4;
            this.btnSubtraction.Text = "Subtraction";
            this.btnSubtraction.UseVisualStyleBackColor = true;
            this.btnSubtraction.Click += new System.EventHandler(this.btnSubtraction_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.ForeColor = System.Drawing.Color.Maroon;
            this.btnMultiply.Location = new System.Drawing.Point(14, 240);
            this.btnMultiply.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(113, 43);
            this.btnMultiply.TabIndex = 5;
            this.btnMultiply.Text = "Multiply";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // Operand1
            // 
            this.Operand1.Location = new System.Drawing.Point(14, 56);
            this.Operand1.Name = "Operand1";
            this.Operand1.Size = new System.Drawing.Size(100, 25);
            this.Operand1.TabIndex = 8;
            this.Operand1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Oper2
            // 
            this.Oper2.Location = new System.Drawing.Point(195, 56);
            this.Oper2.Name = "Oper2";
            this.Oper2.Size = new System.Drawing.Size(100, 25);
            this.Oper2.TabIndex = 9;
            this.Oper2.TextChanged += new System.EventHandler(this.Oper2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 11;
            // 
            // labEqual
            // 
            this.labEqual.AutoSize = true;
            this.labEqual.Location = new System.Drawing.Point(143, 90);
            this.labEqual.Name = "labEqual";
            this.labEqual.Size = new System.Drawing.Size(17, 17);
            this.labEqual.TabIndex = 12;
            this.labEqual.Text = "=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "+";
            // 
            // labResult
            // 
            this.labResult.AutoSize = true;
            this.labResult.Enabled = false;
            this.labResult.Location = new System.Drawing.Point(143, 117);
            this.labResult.Name = "labResult";
            this.labResult.Size = new System.Drawing.Size(14, 17);
            this.labResult.TabIndex = 14;
            this.labResult.Text = "_";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(312, 293);
            this.Controls.Add(this.labResult);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labEqual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Oper2);
            this.Controls.Add(this.Operand1);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnSubtraction);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnAddition);
            this.Controls.Add(this.Operand2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "My Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Operand2;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnSubtraction;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.TextBox Operand1;
        private System.Windows.Forms.TextBox Oper2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labEqual;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labResult;
    }
}

