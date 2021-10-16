namespace Phone
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
            this.Base = new System.Windows.Forms.TextBox();
            this.Otchet = new System.Windows.Forms.Button();
            this.textb_DataBegin = new System.Windows.Forms.TextBox();
            this.label_DataBegin = new System.Windows.Forms.Label();
            this.label_DataEnd = new System.Windows.Forms.Label();
            this.textb_DataEnd = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Base
            // 
            this.Base.Location = new System.Drawing.Point(42, 107);
            this.Base.Multiline = true;
            this.Base.Name = "Base";
            this.Base.Size = new System.Drawing.Size(523, 199);
            this.Base.TabIndex = 0;
            // 
            // Otchet
            // 
            this.Otchet.Location = new System.Drawing.Point(603, 343);
            this.Otchet.Name = "Otchet";
            this.Otchet.Size = new System.Drawing.Size(97, 47);
            this.Otchet.TabIndex = 1;
            this.Otchet.Text = "Сформировать отчет";
            this.Otchet.UseVisualStyleBackColor = true;
            // 
            // textb_DataBegin
            // 
            this.textb_DataBegin.Location = new System.Drawing.Point(174, 53);
            this.textb_DataBegin.Name = "textb_DataBegin";
            this.textb_DataBegin.Size = new System.Drawing.Size(121, 20);
            this.textb_DataBegin.TabIndex = 2;
            // 
            // label_DataBegin
            // 
            this.label_DataBegin.AutoSize = true;
            this.label_DataBegin.Location = new System.Drawing.Point(39, 56);
            this.label_DataBegin.Name = "label_DataBegin";
            this.label_DataBegin.Size = new System.Drawing.Size(116, 13);
            this.label_DataBegin.TabIndex = 3;
            this.label_DataBegin.Text = "Дата начала периода";
            // 
            // label_DataEnd
            // 
            this.label_DataEnd.AutoSize = true;
            this.label_DataEnd.Location = new System.Drawing.Point(314, 56);
            this.label_DataEnd.Name = "label_DataEnd";
            this.label_DataEnd.Size = new System.Drawing.Size(134, 13);
            this.label_DataEnd.TabIndex = 4;
            this.label_DataEnd.Text = "Дата окончания периода";
            // 
            // textb_DataEnd
            // 
            this.textb_DataEnd.Location = new System.Drawing.Point(465, 53);
            this.textb_DataEnd.Name = "textb_DataEnd";
            this.textb_DataEnd.Size = new System.Drawing.Size(100, 20);
            this.textb_DataEnd.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textb_DataEnd);
            this.Controls.Add(this.label_DataEnd);
            this.Controls.Add(this.label_DataBegin);
            this.Controls.Add(this.textb_DataBegin);
            this.Controls.Add(this.Otchet);
            this.Controls.Add(this.Base);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Base;
        private System.Windows.Forms.Button Otchet;
        private System.Windows.Forms.TextBox textb_DataBegin;
        private System.Windows.Forms.Label label_DataBegin;
        private System.Windows.Forms.Label label_DataEnd;
        private System.Windows.Forms.TextBox textb_DataEnd;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
    }
}

