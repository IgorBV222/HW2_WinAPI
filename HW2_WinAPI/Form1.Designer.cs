namespace HW2_WinAPI
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
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.btn_Info = new System.Windows.Forms.Button();
            this.tb_profession = new System.Windows.Forms.TextBox();
            this.tb_age = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_location = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_NameWindow = new System.Windows.Forms.TextBox();
            this.btn_NameWindow = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_NewNameWindow = new System.Windows.Forms.TextBox();
            this.btn_NewNameWindow = new System.Windows.Forms.Button();
            this.btn_CloseWindow = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_SoundSignal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(15, 48);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(147, 20);
            this.tb_Name.TabIndex = 1;
            // 
            // btn_Info
            // 
            this.btn_Info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Info.Location = new System.Drawing.Point(15, 191);
            this.btn_Info.Name = "btn_Info";
            this.btn_Info.Size = new System.Drawing.Size(147, 23);
            this.btn_Info.TabIndex = 2;
            this.btn_Info.Text = "Вывести информацию";
            this.btn_Info.UseVisualStyleBackColor = false;
            this.btn_Info.Click += new System.EventHandler(this.btn_Info_Click);
            // 
            // tb_profession
            // 
            this.tb_profession.Location = new System.Drawing.Point(15, 126);
            this.tb_profession.Name = "tb_profession";
            this.tb_profession.Size = new System.Drawing.Size(147, 20);
            this.tb_profession.TabIndex = 1;
            // 
            // tb_age
            // 
            this.tb_age.Location = new System.Drawing.Point(15, 87);
            this.tb_age.Name = "tb_age";
            this.tb_age.Size = new System.Drawing.Size(147, 20);
            this.tb_age.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Задача 1";
            // 
            // tb_location
            // 
            this.tb_location.Location = new System.Drawing.Point(15, 165);
            this.tb_location.Name = "tb_location";
            this.tb_location.Size = new System.Drawing.Size(147, 20);
            this.tb_location.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Введите возвраст";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Введите профессию";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Введите место проживания";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(223, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Задача 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(223, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Введите заголовок окна";
            // 
            // tb_NameWindow
            // 
            this.tb_NameWindow.Location = new System.Drawing.Point(226, 48);
            this.tb_NameWindow.Name = "tb_NameWindow";
            this.tb_NameWindow.Size = new System.Drawing.Size(147, 20);
            this.tb_NameWindow.TabIndex = 1;
            // 
            // btn_NameWindow
            // 
            this.btn_NameWindow.Location = new System.Drawing.Point(388, 45);
            this.btn_NameWindow.Name = "btn_NameWindow";
            this.btn_NameWindow.Size = new System.Drawing.Size(179, 23);
            this.btn_NameWindow.TabIndex = 7;
            this.btn_NameWindow.Text = "Проверить существование окна";
            this.btn_NameWindow.UseVisualStyleBackColor = true;
            this.btn_NameWindow.Click += new System.EventHandler(this.btn_NameWindow_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(223, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Новый заголовок окна";
            // 
            // tb_NewNameWindow
            // 
            this.tb_NewNameWindow.Location = new System.Drawing.Point(226, 87);
            this.tb_NewNameWindow.Name = "tb_NewNameWindow";
            this.tb_NewNameWindow.Size = new System.Drawing.Size(147, 20);
            this.tb_NewNameWindow.TabIndex = 1;
            // 
            // btn_NewNameWindow
            // 
            this.btn_NewNameWindow.Location = new System.Drawing.Point(388, 84);
            this.btn_NewNameWindow.Name = "btn_NewNameWindow";
            this.btn_NewNameWindow.Size = new System.Drawing.Size(179, 23);
            this.btn_NewNameWindow.TabIndex = 7;
            this.btn_NewNameWindow.Text = "Изменить заголовок окна";
            this.btn_NewNameWindow.UseVisualStyleBackColor = true;
            this.btn_NewNameWindow.Click += new System.EventHandler(this.btn_NewNameWindow_Click);
            // 
            // btn_CloseWindow
            // 
            this.btn_CloseWindow.Location = new System.Drawing.Point(388, 123);
            this.btn_CloseWindow.Name = "btn_CloseWindow";
            this.btn_CloseWindow.Size = new System.Drawing.Size(179, 23);
            this.btn_CloseWindow.TabIndex = 7;
            this.btn_CloseWindow.Text = "Закрыть окно";
            this.btn_CloseWindow.UseVisualStyleBackColor = true;
            this.btn_CloseWindow.Click += new System.EventHandler(this.btn_CloseWindow_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(635, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Задача 3";
            // 
            // btn_SoundSignal
            // 
            this.btn_SoundSignal.BackColor = System.Drawing.Color.Cyan;
            this.btn_SoundSignal.Location = new System.Drawing.Point(638, 45);
            this.btn_SoundSignal.Name = "btn_SoundSignal";
            this.btn_SoundSignal.Size = new System.Drawing.Size(121, 23);
            this.btn_SoundSignal.TabIndex = 8;
            this.btn_SoundSignal.Text = "Звуковой сигнал";
            this.btn_SoundSignal.UseVisualStyleBackColor = false;
            this.btn_SoundSignal.Click += new System.EventHandler(this.btn_SoundSignal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 636);
            this.Controls.Add(this.btn_SoundSignal);
            this.Controls.Add(this.btn_CloseWindow);
            this.Controls.Add(this.btn_NewNameWindow);
            this.Controls.Add(this.btn_NameWindow);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Info);
            this.Controls.Add(this.tb_age);
            this.Controls.Add(this.tb_location);
            this.Controls.Add(this.tb_profession);
            this.Controls.Add(this.tb_NewNameWindow);
            this.Controls.Add(this.tb_NameWindow);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Button btn_Info;
        private System.Windows.Forms.TextBox tb_profession;
        private System.Windows.Forms.TextBox tb_age;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_location;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_NameWindow;
        private System.Windows.Forms.Button btn_NameWindow;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_NewNameWindow;
        private System.Windows.Forms.Button btn_NewNameWindow;
        private System.Windows.Forms.Button btn_CloseWindow;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_SoundSignal;
    }
}

