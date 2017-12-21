namespace Part2
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
            this.dataGridView_mainTable = new System.Windows.Forms.DataGridView();
            this.confNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.param1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.param2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.param3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.param4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_computeConfScores = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_clearTable = new System.Windows.Forms.Button();
            this.button_saveToFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_mainTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_mainTable
            // 
            this.dataGridView_mainTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_mainTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_mainTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_mainTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.confNum,
            this.param1,
            this.param2,
            this.param3,
            this.param4});
            this.dataGridView_mainTable.Location = new System.Drawing.Point(12, 143);
            this.dataGridView_mainTable.Name = "dataGridView_mainTable";
            this.dataGridView_mainTable.Size = new System.Drawing.Size(682, 503);
            this.dataGridView_mainTable.TabIndex = 0;
            this.dataGridView_mainTable.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView_mainTable_UserAddedRow);
            // 
            // confNum
            // 
            this.confNum.HeaderText = "Конфигурация №";
            this.confNum.Name = "confNum";
            this.confNum.ReadOnly = true;
            // 
            // param1
            // 
            this.param1.HeaderText = "P1";
            this.param1.Name = "param1";
            // 
            // param2
            // 
            this.param2.HeaderText = "P2";
            this.param2.Name = "param2";
            // 
            // param3
            // 
            this.param3.HeaderText = "P3";
            this.param3.Name = "param3";
            // 
            // param4
            // 
            this.param4.HeaderText = "P4";
            this.param4.Name = "param4";
            // 
            // button_computeConfScores
            // 
            this.button_computeConfScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_computeConfScores.Location = new System.Drawing.Point(12, 12);
            this.button_computeConfScores.Name = "button_computeConfScores";
            this.button_computeConfScores.Size = new System.Drawing.Size(151, 103);
            this.button_computeConfScores.TabIndex = 1;
            this.button_computeConfScores.Text = "Найти лучшие конфигурации";
            this.button_computeConfScores.UseVisualStyleBackColor = true;
            this.button_computeConfScores.Click += new System.EventHandler(this.button_computeConfScores_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(186, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 103);
            this.button1.TabIndex = 2;
            this.button1.Text = "Загрузить контрольный пример";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_clearTable
            // 
            this.button_clearTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_clearTable.Location = new System.Drawing.Point(362, 12);
            this.button_clearTable.Name = "button_clearTable";
            this.button_clearTable.Size = new System.Drawing.Size(151, 103);
            this.button_clearTable.TabIndex = 3;
            this.button_clearTable.Text = "Очистить таблицу";
            this.button_clearTable.UseVisualStyleBackColor = true;
            this.button_clearTable.Click += new System.EventHandler(this.button_clearTable_Click);
            // 
            // button_saveToFile
            // 
            this.button_saveToFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_saveToFile.Location = new System.Drawing.Point(543, 12);
            this.button_saveToFile.Name = "button_saveToFile";
            this.button_saveToFile.Size = new System.Drawing.Size(151, 103);
            this.button_saveToFile.TabIndex = 4;
            this.button_saveToFile.Text = "Сохранить результаты в файл";
            this.button_saveToFile.UseVisualStyleBackColor = true;
            this.button_saveToFile.Click += new System.EventHandler(this.button_saveToFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 681);
            this.Controls.Add(this.button_saveToFile);
            this.Controls.Add(this.button_clearTable);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_computeConfScores);
            this.Controls.Add(this.dataGridView_mainTable);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_mainTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_mainTable;
        private System.Windows.Forms.Button button_computeConfScores;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_clearTable;
        private System.Windows.Forms.Button button_saveToFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn confNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn param1;
        private System.Windows.Forms.DataGridViewTextBoxColumn param2;
        private System.Windows.Forms.DataGridViewTextBoxColumn param3;
        private System.Windows.Forms.DataGridViewTextBoxColumn param4;
    }
}

