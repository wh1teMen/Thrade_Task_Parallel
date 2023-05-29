namespace HomeWork
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
            this.button_open = new System.Windows.Forms.Button();
            this.textBox_path = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_saveCopy = new System.Windows.Forms.Button();
            this.textBox_pathSave = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button_Task = new System.Windows.Forms.Button();
            this.button_Thrade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_open
            // 
            this.button_open.Location = new System.Drawing.Point(12, 27);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(75, 23);
            this.button_open.TabIndex = 0;
            this.button_open.Text = "Выбрать";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_open_MouseClick);
            // 
            // textBox_path
            // 
            this.textBox_path.Location = new System.Drawing.Point(93, 30);
            this.textBox_path.Name = "textBox_path";
            this.textBox_path.Size = new System.Drawing.Size(294, 20);
            this.textBox_path.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выбирите путь к картинкам";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Выбирите путь для сохранения";
            // 
            // button_saveCopy
            // 
            this.button_saveCopy.Location = new System.Drawing.Point(12, 79);
            this.button_saveCopy.Name = "button_saveCopy";
            this.button_saveCopy.Size = new System.Drawing.Size(75, 23);
            this.button_saveCopy.TabIndex = 4;
            this.button_saveCopy.Text = "Выбрать";
            this.button_saveCopy.UseVisualStyleBackColor = true;
            this.button_saveCopy.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_saveCopy_MouseClick);
            // 
            // textBox_pathSave
            // 
            this.textBox_pathSave.Location = new System.Drawing.Point(93, 82);
            this.textBox_pathSave.Name = "textBox_pathSave";
            this.textBox_pathSave.Size = new System.Drawing.Size(294, 20);
            this.textBox_pathSave.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 80);
            this.button1.TabIndex = 6;
            this.button1.Text = "PARALLEL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // button_Task
            // 
            this.button_Task.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Task.Location = new System.Drawing.Point(138, 118);
            this.button_Task.Name = "button_Task";
            this.button_Task.Size = new System.Drawing.Size(110, 80);
            this.button_Task.TabIndex = 7;
            this.button_Task.Text = "TASK";
            this.button_Task.UseVisualStyleBackColor = true;
            this.button_Task.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_Task_MouseClick);
            // 
            // button_Thrade
            // 
            this.button_Thrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Thrade.Location = new System.Drawing.Point(277, 118);
            this.button_Thrade.Name = "button_Thrade";
            this.button_Thrade.Size = new System.Drawing.Size(110, 80);
            this.button_Thrade.TabIndex = 8;
            this.button_Thrade.Text = "THRADE";
            this.button_Thrade.UseVisualStyleBackColor = true;
            this.button_Thrade.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_Thrade_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 221);
            this.Controls.Add(this.button_Thrade);
            this.Controls.Add(this.button_Task);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_pathSave);
            this.Controls.Add(this.button_saveCopy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_path);
            this.Controls.Add(this.button_open);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Потоки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.TextBox textBox_path;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_saveCopy;
        private System.Windows.Forms.TextBox textBox_pathSave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_Task;
        private System.Windows.Forms.Button button_Thrade;
    }
}

