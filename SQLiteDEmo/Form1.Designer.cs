namespace SQLiteDEmo
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
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.tBInput = new System.Windows.Forms.TextBox();
            this.dGCategory = new System.Windows.Forms.DataGridView();
            this.btnRefreshDG = new System.Windows.Forms.Button();
            this.bntSave = new System.Windows.Forms.Button();
            this.tBQuery = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // tbOutput
            // 
            this.tbOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOutput.Location = new System.Drawing.Point(37, 55);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(501, 150);
            this.tbOutput.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRefresh.Location = new System.Drawing.Point(574, 55);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(185, 70);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Обновить";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddCategory.Location = new System.Drawing.Point(574, 252);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(185, 70);
            this.btnAddCategory.TabIndex = 2;
            this.btnAddCategory.Text = "Добавить категорию";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // tBInput
            // 
            this.tBInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBInput.Location = new System.Drawing.Point(37, 252);
            this.tBInput.Multiline = true;
            this.tBInput.Name = "tBInput";
            this.tBInput.Size = new System.Drawing.Size(501, 70);
            this.tBInput.TabIndex = 3;
            // 
            // dGCategory
            // 
            this.dGCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGCategory.Location = new System.Drawing.Point(37, 363);
            this.dGCategory.Name = "dGCategory";
            this.dGCategory.Size = new System.Drawing.Size(501, 205);
            this.dGCategory.TabIndex = 4;
            // 
            // btnRefreshDG
            // 
            this.btnRefreshDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRefreshDG.Location = new System.Drawing.Point(574, 363);
            this.btnRefreshDG.Name = "btnRefreshDG";
            this.btnRefreshDG.Size = new System.Drawing.Size(185, 48);
            this.btnRefreshDG.TabIndex = 5;
            this.btnRefreshDG.Text = "Обновить";
            this.btnRefreshDG.UseVisualStyleBackColor = true;
            this.btnRefreshDG.Click += new System.EventHandler(this.btnRefreshDG_Click);
            // 
            // bntSave
            // 
            this.bntSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bntSave.Location = new System.Drawing.Point(574, 427);
            this.bntSave.Name = "bntSave";
            this.bntSave.Size = new System.Drawing.Size(185, 66);
            this.bntSave.TabIndex = 6;
            this.bntSave.Text = "Записать изменения";
            this.bntSave.UseVisualStyleBackColor = true;
            this.bntSave.Click += new System.EventHandler(this.bntSave_Click);
            // 
            // tBQuery
            // 
            this.tBQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBQuery.Location = new System.Drawing.Point(37, 586);
            this.tBQuery.Multiline = true;
            this.tBQuery.Name = "tBQuery";
            this.tBQuery.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tBQuery.Size = new System.Drawing.Size(501, 70);
            this.tBQuery.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 677);
            this.Controls.Add(this.tBQuery);
            this.Controls.Add(this.bntSave);
            this.Controls.Add(this.btnRefreshDG);
            this.Controls.Add(this.dGCategory);
            this.Controls.Add(this.tBInput);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.tbOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dGCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.TextBox tBInput;
        private System.Windows.Forms.DataGridView dGCategory;
        private System.Windows.Forms.Button btnRefreshDG;
        private System.Windows.Forms.Button bntSave;
        private System.Windows.Forms.TextBox tBQuery;
    }
}

