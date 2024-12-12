namespace Practic
{
    partial class CatalogForm
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
            this.treeViewProducts = new System.Windows.Forms.TreeView();
            this.buttonAddToCart = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonViewCart1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonViewCart1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeViewProducts
            // 
            this.treeViewProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.treeViewProducts.Location = new System.Drawing.Point(12, 74);
            this.treeViewProducts.Name = "treeViewProducts";
            this.treeViewProducts.Size = new System.Drawing.Size(776, 317);
            this.treeViewProducts.TabIndex = 1;
            // 
            // buttonAddToCart
            // 
            this.buttonAddToCart.BackColor = System.Drawing.Color.White;
            this.buttonAddToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddToCart.Location = new System.Drawing.Point(660, 406);
            this.buttonAddToCart.Name = "buttonAddToCart";
            this.buttonAddToCart.Size = new System.Drawing.Size(128, 32);
            this.buttonAddToCart.TabIndex = 2;
            this.buttonAddToCart.Text = "ДОБАВИТЬ";
            this.buttonAddToCart.UseVisualStyleBackColor = false;
            this.buttonAddToCart.Click += new System.EventHandler(this.buttonAddToCart_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Practic.Properties.Resources.ЛОГО1;
            this.pictureBox1.Location = new System.Drawing.Point(346, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // buttonViewCart1
            // 
            this.buttonViewCart1.Image = global::Practic.Properties.Resources.корзина;
            this.buttonViewCart1.Location = new System.Drawing.Point(752, 15);
            this.buttonViewCart1.Name = "buttonViewCart1";
            this.buttonViewCart1.Size = new System.Drawing.Size(36, 36);
            this.buttonViewCart1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonViewCart1.TabIndex = 4;
            this.buttonViewCart1.TabStop = false;
            this.buttonViewCart1.Click += new System.EventHandler(this.buttonViewCart1_Click);
            // 
            // CatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 451);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonViewCart1);
            this.Controls.Add(this.buttonAddToCart);
            this.Controls.Add(this.treeViewProducts);
            this.Name = "CatalogForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonViewCart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView treeViewProducts;
        private System.Windows.Forms.Button buttonAddToCart;
        private System.Windows.Forms.PictureBox buttonViewCart1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

