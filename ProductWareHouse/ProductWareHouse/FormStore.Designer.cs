namespace ProductWareHouse
{
    partial class FormStore
    {
 
        private System.ComponentModel.IContainer components = null;

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
            this.btnCheck = new System.Windows.Forms.Button();
            this.listBoxStored = new System.Windows.Forms.ListBox();
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(338, 163);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(87, 27);
            this.btnCheck.TabIndex = 8;
            this.btnCheck.Text = "проверка";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click_1);
            // 
            // listBoxStored
            // 
            this.listBoxStored.FormattingEnabled = true;
            this.listBoxStored.Location = new System.Drawing.Point(178, 220);
            this.listBoxStored.Name = "listBoxStored";
            this.listBoxStored.Size = new System.Drawing.Size(428, 95);
            this.listBoxStored.TabIndex = 7;
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.Location = new System.Drawing.Point(324, 39);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(120, 95);
            this.listBoxProducts.TabIndex = 6;
            this.listBoxProducts.DoubleClick += new System.EventHandler(this.listBoxProducts_SelectedIndexChanged);
            // 
            // FormStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.listBoxStored);
            this.Controls.Add(this.listBoxProducts);
            this.Name = "FormStore";
            this.Text = "Склад быстропортящейся продукции";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.ListBox listBoxStored;
        private System.Windows.Forms.ListBox listBoxProducts;
    }
}

