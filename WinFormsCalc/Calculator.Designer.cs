namespace WinFormsCalc
{
    partial class Calculator
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
            this.tbResult = new System.Windows.Forms.TextBox();
            this.btnMem = new System.Windows.Forms.Button();
            this.btnRecallMem = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btnClearMem = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.tbHistory = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbResult
            // 
            this.tbResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.tbResult.Location = new System.Drawing.Point(12, 36);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(200, 37);
            this.tbResult.TabIndex = 0;
            this.tbResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbResult.TextChanged += new System.EventHandler(this.tbResult_TextChanged);
            this.tbResult.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbResult_KeyUp);
            // 
            // btnMem
            // 
            this.btnMem.Location = new System.Drawing.Point(12, 80);
            this.btnMem.Name = "btnMem";
            this.btnMem.Size = new System.Drawing.Size(45, 45);
            this.btnMem.TabIndex = 1;
            this.btnMem.Text = "Mem";
            this.btnMem.UseVisualStyleBackColor = true;
            this.btnMem.Click += new System.EventHandler(this.btnMem_Click);
            // 
            // btnRecallMem
            // 
            this.btnRecallMem.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRecallMem.Location = new System.Drawing.Point(64, 80);
            this.btnRecallMem.Name = "btnRecallMem";
            this.btnRecallMem.Size = new System.Drawing.Size(45, 45);
            this.btnRecallMem.TabIndex = 2;
            this.btnRecallMem.Text = "RMem";
            this.btnRecallMem.UseVisualStyleBackColor = true;
            this.btnRecallMem.Click += new System.EventHandler(this.btnRecallMem_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Location = new System.Drawing.Point(166, 131);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(45, 45);
            this.btnSubtract.TabIndex = 3;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(13, 131);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(45, 45);
            this.btnUndo.TabIndex = 4;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(64, 131);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(45, 45);
            this.btnDivide.TabIndex = 5;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(115, 131);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(45, 45);
            this.btnMultiply.TabIndex = 6;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(13, 182);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(45, 45);
            this.btn1.TabIndex = 7;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(64, 182);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(45, 45);
            this.btn2.TabIndex = 8;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(117, 182);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(45, 45);
            this.btn3.TabIndex = 9;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(64, 233);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(45, 45);
            this.btn5.TabIndex = 10;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btnClearMem
            // 
            this.btnClearMem.Location = new System.Drawing.Point(118, 79);
            this.btnClearMem.Name = "btnClearMem";
            this.btnClearMem.Size = new System.Drawing.Size(94, 45);
            this.btnClearMem.TabIndex = 11;
            this.btnClearMem.Text = "CMem";
            this.btnClearMem.UseVisualStyleBackColor = true;
            this.btnClearMem.Click += new System.EventHandler(this.btnClearMem_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(13, 233);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(45, 45);
            this.btn4.TabIndex = 12;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(117, 233);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(45, 45);
            this.btn6.TabIndex = 13;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(13, 284);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(45, 45);
            this.btn7.TabIndex = 14;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(64, 284);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(45, 45);
            this.btn8.TabIndex = 15;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(115, 284);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(45, 45);
            this.btn9.TabIndex = 16;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(13, 335);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(96, 45);
            this.btn0.TabIndex = 18;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Location = new System.Drawing.Point(115, 335);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(45, 45);
            this.btnDecimal.TabIndex = 19;
            this.btnDecimal.Text = ",";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.btnDecimal_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(167, 182);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(45, 96);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.Location = new System.Drawing.Point(166, 284);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(45, 96);
            this.btnEquals.TabIndex = 21;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // tbHistory
            // 
            this.tbHistory.BackColor = System.Drawing.SystemColors.Window;
            this.tbHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.tbHistory.Location = new System.Drawing.Point(13, 12);
            this.tbHistory.Name = "tbHistory";
            this.tbHistory.ReadOnly = true;
            this.tbHistory.Size = new System.Drawing.Size(200, 25);
            this.tbHistory.TabIndex = 22;
            this.tbHistory.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 391);
            this.Controls.Add(this.tbHistory);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnClearMem);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnRecallMem);
            this.Controls.Add(this.btnMem);
            this.Controls.Add(this.tbResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Button btnMem;
        private System.Windows.Forms.Button btnRecallMem;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btnClearMem;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.TextBox tbHistory;
    }
}

