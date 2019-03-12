namespace OOP_Lab01_2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.inputField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnSortDown = new System.Windows.Forms.Button();
            this.btnSortUp = new System.Windows.Forms.Button();
            this.btnRequest3 = new System.Windows.Forms.Button();
            this.btnRequest2 = new System.Windows.Forms.Button();
            this.btnRequest1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // inputField
            // 
            this.inputField.Location = new System.Drawing.Point(322, 46);
            this.inputField.Name = "inputField";
            this.inputField.Size = new System.Drawing.Size(153, 20);
            this.inputField.TabIndex = 0;
            this.inputField.TextChanged += new System.EventHandler(this.inputField_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(341, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Размер коллекции";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.Red;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGenerate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGenerate.Location = new System.Drawing.Point(272, 84);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(250, 70);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Сгенерировать";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnSortDown
            // 
            this.btnSortDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSortDown.Location = new System.Drawing.Point(562, 84);
            this.btnSortDown.Name = "btnSortDown";
            this.btnSortDown.Size = new System.Drawing.Size(150, 70);
            this.btnSortDown.TabIndex = 3;
            this.btnSortDown.Text = "Сортировать по убыванию";
            this.btnSortDown.UseVisualStyleBackColor = true;
            this.btnSortDown.Click += new System.EventHandler(this.btnSortDown_Click);
            // 
            // btnSortUp
            // 
            this.btnSortUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSortUp.Location = new System.Drawing.Point(78, 84);
            this.btnSortUp.Name = "btnSortUp";
            this.btnSortUp.Size = new System.Drawing.Size(150, 70);
            this.btnSortUp.TabIndex = 4;
            this.btnSortUp.Text = "Сортировать по возрастанию";
            this.btnSortUp.UseVisualStyleBackColor = true;
            this.btnSortUp.Click += new System.EventHandler(this.btnSortUp_Click);
            // 
            // btnRequest3
            // 
            this.btnRequest3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRequest3.Location = new System.Drawing.Point(117, 237);
            this.btnRequest3.Name = "btnRequest3";
            this.btnRequest3.Size = new System.Drawing.Size(75, 23);
            this.btnRequest3.TabIndex = 5;
            this.btnRequest3.Text = "Запрос 3";
            this.btnRequest3.UseVisualStyleBackColor = true;
            this.btnRequest3.Click += new System.EventHandler(this.btnRequest3_Click);
            // 
            // btnRequest2
            // 
            this.btnRequest2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRequest2.Location = new System.Drawing.Point(117, 208);
            this.btnRequest2.Name = "btnRequest2";
            this.btnRequest2.Size = new System.Drawing.Size(75, 23);
            this.btnRequest2.TabIndex = 6;
            this.btnRequest2.Text = "Запрос 2";
            this.btnRequest2.UseVisualStyleBackColor = true;
            this.btnRequest2.Click += new System.EventHandler(this.btnRequest2_Click);
            // 
            // btnRequest1
            // 
            this.btnRequest1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRequest1.Location = new System.Drawing.Point(117, 179);
            this.btnRequest1.Name = "btnRequest1";
            this.btnRequest1.Size = new System.Drawing.Size(75, 23);
            this.btnRequest1.TabIndex = 7;
            this.btnRequest1.Text = "Запрос 1";
            this.btnRequest1.UseVisualStyleBackColor = true;
            this.btnRequest1.Click += new System.EventHandler(this.btnRequest1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(272, 179);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(250, 82);
            this.listBox1.TabIndex = 8;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(800, 312);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnRequest1);
            this.Controls.Add(this.btnRequest2);
            this.Controls.Add(this.btnRequest3);
            this.Controls.Add(this.btnSortUp);
            this.Controls.Add(this.btnSortDown);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnSortDown;
        private System.Windows.Forms.Button btnSortUp;
        private System.Windows.Forms.Button btnRequest3;
        private System.Windows.Forms.Button btnRequest2;
        private System.Windows.Forms.Button btnRequest1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

