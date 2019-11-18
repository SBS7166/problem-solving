namespace InterestCalculator
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
            this.solveForLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inputLabel1 = new System.Windows.Forms.Label();
            this.inputLabel2 = new System.Windows.Forms.Label();
            this.inputLabel3 = new System.Windows.Forms.Label();
            this.inputTextBox1 = new System.Windows.Forms.TextBox();
            this.inputTextBox2 = new System.Windows.Forms.TextBox();
            this.inputTextBox3 = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.formulaLabel = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.equationLabel = new System.Windows.Forms.Label();
            this.showAnswerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // solveForLabel
            // 
            this.solveForLabel.AutoSize = true;
            this.solveForLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solveForLabel.Location = new System.Drawing.Point(58, 96);
            this.solveForLabel.Name = "solveForLabel";
            this.solveForLabel.Size = new System.Drawing.Size(65, 17);
            this.solveForLabel.TabIndex = 0;
            this.solveForLabel.Text = "Solve for";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(135, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Simple Interest Calculator";
            // 
            // inputLabel1
            // 
            this.inputLabel1.AutoSize = true;
            this.inputLabel1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputLabel1.Location = new System.Drawing.Point(58, 211);
            this.inputLabel1.Name = "inputLabel1";
            this.inputLabel1.Size = new System.Drawing.Size(112, 17);
            this.inputLabel1.TabIndex = 2;
            this.inputLabel1.Text = "Principal (P): TK";
            // 
            // inputLabel2
            // 
            this.inputLabel2.AutoSize = true;
            this.inputLabel2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputLabel2.Location = new System.Drawing.Point(58, 250);
            this.inputLabel2.Name = "inputLabel2";
            this.inputLabel2.Size = new System.Drawing.Size(80, 17);
            this.inputLabel2.TabIndex = 3;
            this.inputLabel2.Text = "Rate (R): %";
            // 
            // inputLabel3
            // 
            this.inputLabel3.AutoSize = true;
            this.inputLabel3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputLabel3.Location = new System.Drawing.Point(58, 291);
            this.inputLabel3.Name = "inputLabel3";
            this.inputLabel3.Size = new System.Drawing.Size(63, 17);
            this.inputLabel3.TabIndex = 4;
            this.inputLabel3.Text = "Time (t):";
            // 
            // inputTextBox1
            // 
            this.inputTextBox1.Location = new System.Drawing.Point(227, 211);
            this.inputTextBox1.Name = "inputTextBox1";
            this.inputTextBox1.Size = new System.Drawing.Size(143, 20);
            this.inputTextBox1.TabIndex = 5;
            this.inputTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputTextBox1_KeyPress);
            // 
            // inputTextBox2
            // 
            this.inputTextBox2.Location = new System.Drawing.Point(227, 247);
            this.inputTextBox2.Name = "inputTextBox2";
            this.inputTextBox2.Size = new System.Drawing.Size(143, 20);
            this.inputTextBox2.TabIndex = 6;
            // 
            // inputTextBox3
            // 
            this.inputTextBox3.Location = new System.Drawing.Point(227, 288);
            this.inputTextBox3.Name = "inputTextBox3";
            this.inputTextBox3.Size = new System.Drawing.Size(143, 20);
            this.inputTextBox3.TabIndex = 7;
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Khaki;
            this.clearButton.Font = new System.Drawing.Font("Lato Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.clearButton.Location = new System.Drawing.Point(61, 418);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(80, 36);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.Khaki;
            this.calculateButton.Font = new System.Drawing.Font("Lato Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.calculateButton.Location = new System.Drawing.Point(306, 418);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(89, 36);
            this.calculateButton.TabIndex = 10;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(227, 96);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(143, 24);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // formulaLabel
            // 
            this.formulaLabel.AutoSize = true;
            this.formulaLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formulaLabel.Location = new System.Drawing.Point(151, 154);
            this.formulaLabel.Name = "formulaLabel";
            this.formulaLabel.Size = new System.Drawing.Size(136, 19);
            this.formulaLabel.TabIndex = 12;
            this.formulaLabel.Text = "Where: Select one";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(227, 314);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 13;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(186, 460);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = " Answer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(186, 499);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 15;
            // 
            // equationLabel
            // 
            this.equationLabel.AutoSize = true;
            this.equationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equationLabel.Location = new System.Drawing.Point(186, 499);
            this.equationLabel.Name = "equationLabel";
            this.equationLabel.Size = new System.Drawing.Size(0, 17);
            this.equationLabel.TabIndex = 16;
            this.equationLabel.Click += new System.EventHandler(this.equationLabel_Click);
            // 
            // showAnswerLabel
            // 
            this.showAnswerLabel.AutoSize = true;
            this.showAnswerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAnswerLabel.Location = new System.Drawing.Point(186, 564);
            this.showAnswerLabel.Name = "showAnswerLabel";
            this.showAnswerLabel.Size = new System.Drawing.Size(0, 17);
            this.showAnswerLabel.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 641);
            this.Controls.Add(this.showAnswerLabel);
            this.Controls.Add(this.equationLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.formulaLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.inputTextBox3);
            this.Controls.Add(this.inputTextBox2);
            this.Controls.Add(this.inputTextBox1);
            this.Controls.Add(this.inputLabel3);
            this.Controls.Add(this.inputLabel2);
            this.Controls.Add(this.inputLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.solveForLabel);
            this.Name = "Form1";
            this.Text = "Interest Calculator";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label solveForLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label inputLabel1;
        private System.Windows.Forms.Label inputLabel2;
        private System.Windows.Forms.Label inputLabel3;
        private System.Windows.Forms.TextBox inputTextBox1;
        private System.Windows.Forms.TextBox inputTextBox2;
        private System.Windows.Forms.TextBox inputTextBox3;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label formulaLabel;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label equationLabel;
        private System.Windows.Forms.Label showAnswerLabel;
    }
}

