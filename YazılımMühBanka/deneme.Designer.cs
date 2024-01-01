namespace YazılımMühBanka
{
    partial class deneme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.aragir = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ara = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // aragir
            // 
            this.aragir.Location = new System.Drawing.Point(32, 53);
            this.aragir.Name = "aragir";
            this.aragir.Size = new System.Drawing.Size(350, 26);
            this.aragir.TabIndex = 0;
            this.aragir.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(567, 314);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ara
            // 
            this.ara.Location = new System.Drawing.Point(414, 45);
            this.ara.Name = "ara";
            this.ara.Size = new System.Drawing.Size(75, 43);
            this.ara.TabIndex = 2;
            this.ara.Text = "ara";
            this.ara.UseVisualStyleBackColor = true;
            this.ara.Click += new System.EventHandler(this.button1_Click);
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(524, 45);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(75, 43);
            this.sil.TabIndex = 3;
            this.sil.Text = "sil";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // deneme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 450);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.ara);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.aragir);
            this.Name = "deneme";
            this.Text = "deneme";
            this.Load += new System.EventHandler(this.deneme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox aragir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ara;
        private System.Windows.Forms.Button sil;
    }
}