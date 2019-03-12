namespace OOP_Lab01
{
    partial class Calculator
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        enum Operations
        {
            Null = 0,
            Plus = 1,
            Minus,
            Div,
            Multi,
            Result
        }

        private double tmp = 0;
        private Operations operation = 0;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClear = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnReverse = new System.Windows.Forms.Button();
            this.bnt9 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.inputField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(12, 76);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 47);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn7.Location = new System.Drawing.Point(12, 129);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 47);
            this.btn7.TabIndex = 1;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn4.Location = new System.Drawing.Point(12, 182);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 47);
            this.btn4.TabIndex = 1;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn1.Location = new System.Drawing.Point(12, 235);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 47);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn0.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn0.Location = new System.Drawing.Point(12, 288);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(75, 47);
            this.btn0.TabIndex = 1;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDel.Location = new System.Drawing.Point(93, 76);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 47);
            this.btnDel.TabIndex = 1;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn8.Location = new System.Drawing.Point(93, 129);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 47);
            this.btn8.TabIndex = 1;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn5.Location = new System.Drawing.Point(93, 182);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 47);
            this.btn5.TabIndex = 1;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn2.Location = new System.Drawing.Point(93, 235);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 47);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btnDot
            // 
            this.btnDot.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDot.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDot.Location = new System.Drawing.Point(93, 288);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(75, 47);
            this.btnDot.TabIndex = 1;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = false;
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // btnReverse
            // 
            this.btnReverse.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReverse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReverse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReverse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReverse.Location = new System.Drawing.Point(174, 76);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(75, 47);
            this.btnReverse.TabIndex = 1;
            this.btnReverse.Text = "+/-";
            this.btnReverse.UseVisualStyleBackColor = false;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // bnt9
            // 
            this.bnt9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bnt9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnt9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bnt9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bnt9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bnt9.Location = new System.Drawing.Point(174, 129);
            this.bnt9.Name = "bnt9";
            this.bnt9.Size = new System.Drawing.Size(75, 47);
            this.bnt9.TabIndex = 1;
            this.bnt9.Text = "9";
            this.bnt9.UseVisualStyleBackColor = false;
            this.bnt9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn6.Location = new System.Drawing.Point(174, 182);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 47);
            this.btn6.TabIndex = 1;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn3.Location = new System.Drawing.Point(174, 235);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 47);
            this.btn3.TabIndex = 1;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btnResult
            // 
            this.btnResult.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResult.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnResult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnResult.Location = new System.Drawing.Point(174, 288);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(154, 47);
            this.btnResult.TabIndex = 1;
            this.btnResult.Text = "=";
            this.btnResult.UseVisualStyleBackColor = false;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPlus.Location = new System.Drawing.Point(253, 76);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 47);
            this.btnPlus.TabIndex = 1;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMinus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMinus.Location = new System.Drawing.Point(253, 129);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(75, 47);
            this.btnMinus.TabIndex = 1;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMulti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMulti.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMulti.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMulti.Location = new System.Drawing.Point(253, 182);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(75, 47);
            this.btnMulti.TabIndex = 1;
            this.btnMulti.Text = "*";
            this.btnMulti.UseVisualStyleBackColor = false;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDiv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDiv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDiv.Location = new System.Drawing.Point(253, 235);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(75, 47);
            this.btnDiv.TabIndex = 1;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // inputField
            // 
            this.inputField.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputField.Location = new System.Drawing.Point(12, 12);
            this.inputField.MaxLength = 9;
            this.inputField.Name = "inputField";
            this.inputField.ReadOnly = true;
            this.inputField.Size = new System.Drawing.Size(316, 45);
            this.inputField.TabIndex = 2;
            this.inputField.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.inputField.TextChanged += new System.EventHandler(this.inputField_TextChanged);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(341, 348);
            this.Controls.Add(this.inputField);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.bnt9);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnClear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Calculator";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Button bnt9;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.TextBox inputField;
    }
}

