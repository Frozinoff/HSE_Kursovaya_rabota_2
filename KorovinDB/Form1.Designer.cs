namespace KorovinDB
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.номергруппыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.числостудентовDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.группыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSet = new KorovinDB.DBDataSet();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.номерГруппыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОобучаемогоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.предметDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номергруппыDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адрессDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.обучаемыеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.поискToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.поФИООбучаемогоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поНомеруГруппыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.адрессToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поНомеруГруппыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.поАдрессуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.фИОпреподователяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.предметDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адрессDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.преподавателиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.поискToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.фИОПреподователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.предметToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.телефонToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.адрессToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.группыTableAdapter = new KorovinDB.DBDataSetTableAdapters.ГруппыTableAdapter();
            this.обучаемыеTableAdapter = new KorovinDB.DBDataSetTableAdapters.ОбучаемыеTableAdapter();
            this.преподавателиTableAdapter = new KorovinDB.DBDataSetTableAdapters.ПреподавателиTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.группыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.обучаемыеBindingSource)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.преподавателиBindingSource)).BeginInit();
            this.menuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(694, 317);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.menuStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(686, 291);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Группы";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "Редактировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номергруппыDataGridViewTextBoxColumn,
            this.числостудентовDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.группыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(4, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(244, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // номергруппыDataGridViewTextBoxColumn
            // 
            this.номергруппыDataGridViewTextBoxColumn.DataPropertyName = "Номер_группы";
            this.номергруппыDataGridViewTextBoxColumn.HeaderText = "Номер_группы";
            this.номергруппыDataGridViewTextBoxColumn.Name = "номергруппыDataGridViewTextBoxColumn";
            // 
            // числостудентовDataGridViewTextBoxColumn
            // 
            this.числостудентовDataGridViewTextBoxColumn.DataPropertyName = "Число_студентов";
            this.числостудентовDataGridViewTextBoxColumn.HeaderText = "Число_студентов";
            this.числостудентовDataGridViewTextBoxColumn.Name = "числостудентовDataGridViewTextBoxColumn";
            // 
            // группыBindingSource
            // 
            this.группыBindingSource.DataMember = "Группы";
            this.группыBindingSource.DataSource = this.dBDataSet;
            // 
            // dBDataSet
            // 
            this.dBDataSet.DataSetName = "DBDataSet";
            this.dBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(680, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.номерГруппыToolStripMenuItem});
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.поискToolStripMenuItem.Text = "Поиск";
            // 
            // номерГруппыToolStripMenuItem
            // 
            this.номерГруппыToolStripMenuItem.Name = "номерГруппыToolStripMenuItem";
            this.номерГруппыToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.номерГруппыToolStripMenuItem.Text = "Номер группы";
            this.номерГруппыToolStripMenuItem.Click += new System.EventHandler(this.номерГруппыToolStripMenuItem_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.menuStrip2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(686, 291);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Обучаемые";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(274, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 54);
            this.button2.TabIndex = 2;
            this.button2.Text = "Редактировать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.фИОобучаемогоDataGridViewTextBoxColumn,
            this.предметDataGridViewTextBoxColumn,
            this.стоимостьDataGridViewTextBoxColumn,
            this.номергруппыDataGridViewTextBoxColumn1,
            this.адрессDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.обучаемыеBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(3, 30);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(680, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            // 
            // фИОобучаемогоDataGridViewTextBoxColumn
            // 
            this.фИОобучаемогоDataGridViewTextBoxColumn.DataPropertyName = "ФИО_обучаемого";
            this.фИОобучаемогоDataGridViewTextBoxColumn.HeaderText = "ФИО_обучаемого";
            this.фИОобучаемогоDataGridViewTextBoxColumn.Name = "фИОобучаемогоDataGridViewTextBoxColumn";
            // 
            // предметDataGridViewTextBoxColumn
            // 
            this.предметDataGridViewTextBoxColumn.DataPropertyName = "Предмет";
            this.предметDataGridViewTextBoxColumn.HeaderText = "Предмет";
            this.предметDataGridViewTextBoxColumn.Name = "предметDataGridViewTextBoxColumn";
            // 
            // стоимостьDataGridViewTextBoxColumn
            // 
            this.стоимостьDataGridViewTextBoxColumn.DataPropertyName = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.Name = "стоимостьDataGridViewTextBoxColumn";
            // 
            // номергруппыDataGridViewTextBoxColumn1
            // 
            this.номергруппыDataGridViewTextBoxColumn1.DataPropertyName = "Номер_группы";
            this.номергруппыDataGridViewTextBoxColumn1.HeaderText = "Номер_группы";
            this.номергруппыDataGridViewTextBoxColumn1.Name = "номергруппыDataGridViewTextBoxColumn1";
            // 
            // адрессDataGridViewTextBoxColumn
            // 
            this.адрессDataGridViewTextBoxColumn.DataPropertyName = "Адресс";
            this.адрессDataGridViewTextBoxColumn.HeaderText = "Адресс";
            this.адрессDataGridViewTextBoxColumn.Name = "адрессDataGridViewTextBoxColumn";
            // 
            // обучаемыеBindingSource
            // 
            this.обучаемыеBindingSource.DataMember = "Обучаемые";
            this.обучаемыеBindingSource.DataSource = this.dBDataSet;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискToolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(3, 3);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(680, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // поискToolStripMenuItem1
            // 
            this.поискToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поФИООбучаемогоToolStripMenuItem,
            this.поНомеруГруппыToolStripMenuItem,
            this.адрессToolStripMenuItem,
            this.поНомеруГруппыToolStripMenuItem1,
            this.поАдрессуToolStripMenuItem});
            this.поискToolStripMenuItem1.Name = "поискToolStripMenuItem1";
            this.поискToolStripMenuItem1.Size = new System.Drawing.Size(54, 20);
            this.поискToolStripMenuItem1.Text = "Поиск";
            // 
            // поФИООбучаемогоToolStripMenuItem
            // 
            this.поФИООбучаемогоToolStripMenuItem.Name = "поФИООбучаемогоToolStripMenuItem";
            this.поФИООбучаемогоToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.поФИООбучаемогоToolStripMenuItem.Text = "По ФИО обучаемого";
            this.поФИООбучаемогоToolStripMenuItem.Click += new System.EventHandler(this.поФИООбучаемогоToolStripMenuItem_Click);
            // 
            // поНомеруГруппыToolStripMenuItem
            // 
            this.поНомеруГруппыToolStripMenuItem.Name = "поНомеруГруппыToolStripMenuItem";
            this.поНомеруГруппыToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.поНомеруГруппыToolStripMenuItem.Text = "По Предмету";
            this.поНомеруГруппыToolStripMenuItem.Click += new System.EventHandler(this.поНомеруГруппыToolStripMenuItem_Click);
            // 
            // адрессToolStripMenuItem
            // 
            this.адрессToolStripMenuItem.Name = "адрессToolStripMenuItem";
            this.адрессToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.адрессToolStripMenuItem.Text = "По стоимости";
            this.адрессToolStripMenuItem.Click += new System.EventHandler(this.адрессToolStripMenuItem_Click);
            // 
            // поНомеруГруппыToolStripMenuItem1
            // 
            this.поНомеруГруппыToolStripMenuItem1.Name = "поНомеруГруппыToolStripMenuItem1";
            this.поНомеруГруппыToolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
            this.поНомеруГруппыToolStripMenuItem1.Text = "По номеру группы";
            this.поНомеруГруппыToolStripMenuItem1.Click += new System.EventHandler(this.поНомеруГруппыToolStripMenuItem1_Click);
            // 
            // поАдрессуToolStripMenuItem
            // 
            this.поАдрессуToolStripMenuItem.Name = "поАдрессуToolStripMenuItem";
            this.поАдрессуToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.поАдрессуToolStripMenuItem.Text = "По адрессу";
            this.поАдрессуToolStripMenuItem.Click += new System.EventHandler(this.поАдрессуToolStripMenuItem_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Controls.Add(this.menuStrip3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(686, 291);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Преподователи";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(525, 76);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 54);
            this.button3.TabIndex = 2;
            this.button3.Text = "Редактировать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.фИОпреподователяDataGridViewTextBoxColumn,
            this.предметDataGridViewTextBoxColumn1,
            this.телефонDataGridViewTextBoxColumn,
            this.адрессDataGridViewTextBoxColumn1});
            this.dataGridView3.DataSource = this.преподавателиBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(4, 28);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(487, 150);
            this.dataGridView3.TabIndex = 1;
            // 
            // фИОпреподователяDataGridViewTextBoxColumn
            // 
            this.фИОпреподователяDataGridViewTextBoxColumn.DataPropertyName = "ФИО_преподователя";
            this.фИОпреподователяDataGridViewTextBoxColumn.HeaderText = "ФИО_преподователя";
            this.фИОпреподователяDataGridViewTextBoxColumn.Name = "фИОпреподователяDataGridViewTextBoxColumn";
            // 
            // предметDataGridViewTextBoxColumn1
            // 
            this.предметDataGridViewTextBoxColumn1.DataPropertyName = "Предмет";
            this.предметDataGridViewTextBoxColumn1.HeaderText = "Предмет";
            this.предметDataGridViewTextBoxColumn1.Name = "предметDataGridViewTextBoxColumn1";
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            // 
            // адрессDataGridViewTextBoxColumn1
            // 
            this.адрессDataGridViewTextBoxColumn1.DataPropertyName = "Адресс";
            this.адрессDataGridViewTextBoxColumn1.HeaderText = "Адресс";
            this.адрессDataGridViewTextBoxColumn1.Name = "адрессDataGridViewTextBoxColumn1";
            // 
            // преподавателиBindingSource
            // 
            this.преподавателиBindingSource.DataMember = "Преподаватели";
            this.преподавателиBindingSource.DataSource = this.dBDataSet;
            // 
            // menuStrip3
            // 
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискToolStripMenuItem2});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(686, 24);
            this.menuStrip3.TabIndex = 0;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // поискToolStripMenuItem2
            // 
            this.поискToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.фИОПреподователяToolStripMenuItem,
            this.предметToolStripMenuItem,
            this.телефонToolStripMenuItem,
            this.адрессToolStripMenuItem1});
            this.поискToolStripMenuItem2.Name = "поискToolStripMenuItem2";
            this.поискToolStripMenuItem2.Size = new System.Drawing.Size(54, 20);
            this.поискToolStripMenuItem2.Text = "Поиск";
            // 
            // фИОПреподователяToolStripMenuItem
            // 
            this.фИОПреподователяToolStripMenuItem.Name = "фИОПреподователяToolStripMenuItem";
            this.фИОПреподователяToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.фИОПреподователяToolStripMenuItem.Text = "ФИО преподователя";
            this.фИОПреподователяToolStripMenuItem.Click += new System.EventHandler(this.фИОПреподователяToolStripMenuItem_Click);
            // 
            // предметToolStripMenuItem
            // 
            this.предметToolStripMenuItem.Name = "предметToolStripMenuItem";
            this.предметToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.предметToolStripMenuItem.Text = "Предмет";
            this.предметToolStripMenuItem.Click += new System.EventHandler(this.предметToolStripMenuItem_Click);
            // 
            // телефонToolStripMenuItem
            // 
            this.телефонToolStripMenuItem.Name = "телефонToolStripMenuItem";
            this.телефонToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.телефонToolStripMenuItem.Text = "Телефон";
            this.телефонToolStripMenuItem.Click += new System.EventHandler(this.телефонToolStripMenuItem_Click);
            // 
            // адрессToolStripMenuItem1
            // 
            this.адрессToolStripMenuItem1.Name = "адрессToolStripMenuItem1";
            this.адрессToolStripMenuItem1.Size = new System.Drawing.Size(187, 22);
            this.адрессToolStripMenuItem1.Text = "Адресс";
            this.адрессToolStripMenuItem1.Click += new System.EventHandler(this.адрессToolStripMenuItem1_Click);
            // 
            // группыTableAdapter
            // 
            this.группыTableAdapter.ClearBeforeFill = true;
            // 
            // обучаемыеTableAdapter
            // 
            this.обучаемыеTableAdapter.ClearBeforeFill = true;
            // 
            // преподавателиTableAdapter
            // 
            this.преподавателиTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(592, 324);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 40);
            this.button4.TabIndex = 2;
            this.button4.Text = "Выход";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 371);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.tabControl1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Подготовительные курсы БД";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.группыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.обучаемыеBindingSource)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.преподавателиBindingSource)).EndInit();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage3;
        private DBDataSet dBDataSet;
        private System.Windows.Forms.BindingSource группыBindingSource;
        private DBDataSetTableAdapters.ГруппыTableAdapter группыTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn номергруппыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn числостудентовDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem номерГруппыToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem поФИООбучаемогоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поНомеруГруппыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem адрессToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem фИОПреподователяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem предметToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem телефонToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem адрессToolStripMenuItem1;
        private System.Windows.Forms.BindingSource обучаемыеBindingSource;
        private DBDataSetTableAdapters.ОбучаемыеTableAdapter обучаемыеTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОобучаемогоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn предметDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номергруппыDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn адрессDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource преподавателиBindingSource;
        private DBDataSetTableAdapters.ПреподавателиTableAdapter преподавателиTableAdapter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОпреподователяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn предметDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адрессDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStripMenuItem поНомеруГруппыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem поАдрессуToolStripMenuItem;
    }
}

