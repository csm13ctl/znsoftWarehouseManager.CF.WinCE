﻿namespace СкладскойУчет
{
    partial class ОкноВыбораЗаданийНаПодбор
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс  следует удалить; иначе ложно.</param>
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Инструкция = new System.Windows.Forms.Label();
            this.Далее = new System.Windows.Forms.Button();
            this.Назад = new System.Windows.Forms.Button();
            this.Количество = new System.Windows.Forms.ColumnHeader();
            this.СписокВыбора = new System.Windows.Forms.ListView();
            this.Отбор = new System.Windows.Forms.ColumnHeader();
            this.Объем = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // Инструкция
            // 
            this.Инструкция.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Инструкция.Location = new System.Drawing.Point(2, 2);
            this.Инструкция.Name = "Инструкция";
            this.Инструкция.Size = new System.Drawing.Size(236, 20);
            this.Инструкция.Text = "Инструкция";
            // 
            // Далее
            // 
            this.Далее.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.Далее.Location = new System.Drawing.Point(133, 296);
            this.Далее.Name = "Далее";
            this.Далее.Size = new System.Drawing.Size(105, 22);
            this.Далее.TabIndex = 8;
            this.Далее.Text = "Далее";
            this.Далее.Click += new System.EventHandler(this.Далее_Click);
            // 
            // Назад
            // 
            this.Назад.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.Назад.Location = new System.Drawing.Point(2, 296);
            this.Назад.Name = "Назад";
            this.Назад.Size = new System.Drawing.Size(105, 22);
            this.Назад.TabIndex = 6;
            this.Назад.Text = "Назад";
            this.Назад.Click += new System.EventHandler(this.Назад_Click);
            // 
            // Количество
            // 
            this.Количество.Text = "Кол.";
            this.Количество.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Количество.Width = 40;
            // 
            // СписокВыбора
            // 
            this.СписокВыбора.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.СписокВыбора.Columns.Add(this.Отбор);
            this.СписокВыбора.Columns.Add(this.Объем);
            this.СписокВыбора.Columns.Add(this.Количество);
            this.СписокВыбора.FullRowSelect = true;
            this.СписокВыбора.Location = new System.Drawing.Point(2, 25);
            this.СписокВыбора.Name = "СписокВыбора";
            this.СписокВыбора.Size = new System.Drawing.Size(236, 269);
            this.СписокВыбора.TabIndex = 4;
            this.СписокВыбора.Tag = "Таблица";
            this.СписокВыбора.View = System.Windows.Forms.View.Details;
            this.СписокВыбора.ItemActivate += new System.EventHandler(this.СписокВыбора_ItemActivate);
            // 
            // Отбор
            // 
            this.Отбор.Text = "Отбор";
            this.Отбор.Width = 128;
            // 
            // Объем
            // 
            this.Объем.Text = "V, л.";
            this.Объем.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Объем.Width = 40;
            // 
            // ОкноВыбораЗаданийНаПодбор
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(240, 320);
            this.ControlBox = false;
            this.Controls.Add(this.Инструкция);
            this.Controls.Add(this.Далее);
            this.Controls.Add(this.Назад);
            this.Controls.Add(this.СписокВыбора);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "ОкноВыбораЗаданийНаПодбор";
            this.Text = "Выбор заданий";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ОкноВыбораЗаданий_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ОкноВыбораЗаданий_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Далее;
        private System.Windows.Forms.Button Назад;
        private System.Windows.Forms.ColumnHeader Количество;
        public System.Windows.Forms.ListView СписокВыбора;
        private System.Windows.Forms.ColumnHeader Отбор;
        private System.Windows.Forms.ColumnHeader Объем;
        private System.Windows.Forms.Label Инструкция;

    }
}