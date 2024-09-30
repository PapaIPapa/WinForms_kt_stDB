namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataBase10DataSet1 = new WindowsFormsApp1.DataBase10DataSet();
            this.экзаменыTableAdapter1 = new WindowsFormsApp1.DataBase10DataSetTableAdapters.ЭкзаменыTableAdapter();
            this.tableAdapterManager1 = new WindowsFormsApp1.DataBase10DataSetTableAdapters.TableAdapterManager();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.экзаменыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фиоАбитуриентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.годРожденияАбитуриентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.паспортАбитуриентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фиоЭкзаменатораDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.размерОплатыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаСдачиЭкзаменаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеЭкзаменаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.оценкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.оплатаЗаПриемDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBase10DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.экзаменыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.фиоАбитуриентаDataGridViewTextBoxColumn,
            this.адресDataGridViewTextBoxColumn,
            this.годРожденияАбитуриентаDataGridViewTextBoxColumn,
            this.паспортАбитуриентаDataGridViewTextBoxColumn,
            this.фиоЭкзаменатораDataGridViewTextBoxColumn,
            this.размерОплатыDataGridViewTextBoxColumn,
            this.датаСдачиЭкзаменаDataGridViewTextBoxColumn,
            this.названиеЭкзаменаDataGridViewTextBoxColumn,
            this.оценкаDataGridViewTextBoxColumn,
            this.оплатаЗаПриемDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.экзаменыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1145, 310);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(222, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 119);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(371, 382);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 119);
            this.button2.TabIndex = 2;
            this.button2.Text = "Редактировать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(523, 382);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 119);
            this.button3.TabIndex = 3;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(677, 382);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 119);
            this.button4.TabIndex = 4;
            this.button4.Text = "Обновить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(824, 382);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(131, 119);
            this.button5.TabIndex = 5;
            this.button5.Text = "Таблицы";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataBase10DataSet1
            // 
            this.dataBase10DataSet1.DataSetName = "DataBase10DataSet";
            this.dataBase10DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // экзаменыTableAdapter1
            // 
            this.экзаменыTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.UpdateOrder = WindowsFormsApp1.DataBase10DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.ЭкзаменыTableAdapter = this.экзаменыTableAdapter1;
            // 
            // экзаменыBindingSource
            // 
            this.экзаменыBindingSource.DataMember = "Экзамены";
            this.экзаменыBindingSource.DataSource = this.dataBase10DataSet1;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            // 
            // фиоАбитуриентаDataGridViewTextBoxColumn
            // 
            this.фиоАбитуриентаDataGridViewTextBoxColumn.DataPropertyName = "Фио абитуриента";
            this.фиоАбитуриентаDataGridViewTextBoxColumn.HeaderText = "Фио абитуриента";
            this.фиоАбитуриентаDataGridViewTextBoxColumn.Name = "фиоАбитуриентаDataGridViewTextBoxColumn";
            // 
            // адресDataGridViewTextBoxColumn
            // 
            this.адресDataGridViewTextBoxColumn.DataPropertyName = "Адрес";
            this.адресDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.адресDataGridViewTextBoxColumn.Name = "адресDataGridViewTextBoxColumn";
            // 
            // годРожденияАбитуриентаDataGridViewTextBoxColumn
            // 
            this.годРожденияАбитуриентаDataGridViewTextBoxColumn.DataPropertyName = "Год рождения абитуриента";
            this.годРожденияАбитуриентаDataGridViewTextBoxColumn.HeaderText = "Год рождения абитуриента";
            this.годРожденияАбитуриентаDataGridViewTextBoxColumn.Name = "годРожденияАбитуриентаDataGridViewTextBoxColumn";
            // 
            // паспортАбитуриентаDataGridViewTextBoxColumn
            // 
            this.паспортАбитуриентаDataGridViewTextBoxColumn.DataPropertyName = "Паспорт абитуриента";
            this.паспортАбитуриентаDataGridViewTextBoxColumn.HeaderText = "Паспорт абитуриента";
            this.паспортАбитуриентаDataGridViewTextBoxColumn.Name = "паспортАбитуриентаDataGridViewTextBoxColumn";
            // 
            // фиоЭкзаменатораDataGridViewTextBoxColumn
            // 
            this.фиоЭкзаменатораDataGridViewTextBoxColumn.DataPropertyName = "Фио экзаменатора";
            this.фиоЭкзаменатораDataGridViewTextBoxColumn.HeaderText = "Фио экзаменатора";
            this.фиоЭкзаменатораDataGridViewTextBoxColumn.Name = "фиоЭкзаменатораDataGridViewTextBoxColumn";
            // 
            // размерОплатыDataGridViewTextBoxColumn
            // 
            this.размерОплатыDataGridViewTextBoxColumn.DataPropertyName = "Размер оплаты";
            this.размерОплатыDataGridViewTextBoxColumn.HeaderText = "Размер оплаты";
            this.размерОплатыDataGridViewTextBoxColumn.Name = "размерОплатыDataGridViewTextBoxColumn";
            // 
            // датаСдачиЭкзаменаDataGridViewTextBoxColumn
            // 
            this.датаСдачиЭкзаменаDataGridViewTextBoxColumn.DataPropertyName = "Дата сдачи экзамена";
            this.датаСдачиЭкзаменаDataGridViewTextBoxColumn.HeaderText = "Дата сдачи экзамена";
            this.датаСдачиЭкзаменаDataGridViewTextBoxColumn.Name = "датаСдачиЭкзаменаDataGridViewTextBoxColumn";
            // 
            // названиеЭкзаменаDataGridViewTextBoxColumn
            // 
            this.названиеЭкзаменаDataGridViewTextBoxColumn.DataPropertyName = "Название экзамена";
            this.названиеЭкзаменаDataGridViewTextBoxColumn.HeaderText = "Название экзамена";
            this.названиеЭкзаменаDataGridViewTextBoxColumn.Name = "названиеЭкзаменаDataGridViewTextBoxColumn";
            // 
            // оценкаDataGridViewTextBoxColumn
            // 
            this.оценкаDataGridViewTextBoxColumn.DataPropertyName = "Оценка";
            this.оценкаDataGridViewTextBoxColumn.HeaderText = "Оценка";
            this.оценкаDataGridViewTextBoxColumn.Name = "оценкаDataGridViewTextBoxColumn";
            // 
            // оплатаЗаПриемDataGridViewTextBoxColumn
            // 
            this.оплатаЗаПриемDataGridViewTextBoxColumn.DataPropertyName = "Оплата за прием";
            this.оплатаЗаПриемDataGridViewTextBoxColumn.HeaderText = "Оплата за прием";
            this.оплатаЗаПриемDataGridViewTextBoxColumn.Name = "оплатаЗаПриемDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 559);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBase10DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.экзаменыBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фиоАбитуриентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn годРожденияАбитуриентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn паспортАбитуриентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фиоЭкзаменатораDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn размерОплатыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаСдачиЭкзаменаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеЭкзаменаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn оценкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn оплатаЗаПриемDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource экзаменыBindingSource;
        private DataBase10DataSet dataBase10DataSet1;
        private DataBase10DataSetTableAdapters.ЭкзаменыTableAdapter экзаменыTableAdapter1;
        private DataBase10DataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

