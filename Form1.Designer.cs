namespace Analitik
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.view = new System.Windows.Forms.TextBox();
            this.outputdir = new System.Windows.Forms.TextBox();
            this.inputdir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_start = new System.Windows.Forms.Button();
            this.button_open_dir = new System.Windows.Forms.Button();
            this.button_save_dir = new System.Windows.Forms.Button();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // view
            // 
            this.view.Location = new System.Drawing.Point(12, 80);
            this.view.Multiline = true;
            this.view.Name = "view";
            this.view.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.view.Size = new System.Drawing.Size(524, 470);
            this.view.TabIndex = 0;
            // 
            // outputdir
            // 
            this.outputdir.Location = new System.Drawing.Point(12, 598);
            this.outputdir.Name = "outputdir";
            this.outputdir.Size = new System.Drawing.Size(524, 26);
            this.outputdir.TabIndex = 1;
            // 
            // inputdir
            // 
            this.inputdir.Location = new System.Drawing.Point(12, 48);
            this.inputdir.Name = "inputdir";
            this.inputdir.Size = new System.Drawing.Size(524, 26);
            this.inputdir.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Расположение папки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 563);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Сохранить файл";
            // 
            // button_start
            // 
            this.button_start.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_start.Location = new System.Drawing.Point(542, 558);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(572, 66);
            this.button_start.TabIndex = 5;
            this.button_start.Text = "Пуск";
            this.button_start.UseVisualStyleBackColor = false;
            this.button_start.Click += new System.EventHandler(this.Button_start_Click);
            // 
            // button_open_dir
            // 
            this.button_open_dir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_open_dir.Location = new System.Drawing.Point(450, 12);
            this.button_open_dir.Name = "button_open_dir";
            this.button_open_dir.Size = new System.Drawing.Size(86, 30);
            this.button_open_dir.TabIndex = 8;
            this.button_open_dir.Text = "обзор";
            this.button_open_dir.UseVisualStyleBackColor = true;
            this.button_open_dir.Click += new System.EventHandler(this.Button_open_dir_Click);
            // 
            // button_save_dir
            // 
            this.button_save_dir.Location = new System.Drawing.Point(450, 559);
            this.button_save_dir.Name = "button_save_dir";
            this.button_save_dir.Size = new System.Drawing.Size(86, 33);
            this.button_save_dir.TabIndex = 9;
            this.button_save_dir.Text = "обзор";
            this.button_save_dir.UseVisualStyleBackColor = true;
            this.button_save_dir.Click += new System.EventHandler(this.Button_save_dir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(542, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(572, 467);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(542, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(572, 64);
            this.listBox1.TabIndex = 11;
            this.listBox1.Visible = false;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1126, 636);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_save_dir);
            this.Controls.Add(this.button_open_dir);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputdir);
            this.Controls.Add(this.outputdir);
            this.Controls.Add(this.view);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "analytics";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox view;
        private System.Windows.Forms.TextBox outputdir;
        private System.Windows.Forms.TextBox inputdir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_open_dir;
        private System.Windows.Forms.Button button_save_dir;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

