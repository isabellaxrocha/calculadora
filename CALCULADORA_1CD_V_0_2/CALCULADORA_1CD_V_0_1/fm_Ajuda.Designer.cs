namespace CALCULADORA_1CD_V_0_1
{
    partial class fm_Ajuda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fm_Ajuda));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bt_fechar_ajuda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 68);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(377, 216);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // bt_fechar_ajuda
            // 
            this.bt_fechar_ajuda.Location = new System.Drawing.Point(135, 23);
            this.bt_fechar_ajuda.Name = "bt_fechar_ajuda";
            this.bt_fechar_ajuda.Size = new System.Drawing.Size(141, 23);
            this.bt_fechar_ajuda.TabIndex = 1;
            this.bt_fechar_ajuda.Text = "Fechar Ajuda";
            this.bt_fechar_ajuda.UseVisualStyleBackColor = true;
            this.bt_fechar_ajuda.Click += new System.EventHandler(this.bt_fechar_ajuda_Click);
            // 
            // fm_Ajuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 296);
            this.Controls.Add(this.bt_fechar_ajuda);
            this.Controls.Add(this.textBox1);
            this.Name = "fm_Ajuda";
            this.Text = "Ajuda da Calculadora";
            this.Load += new System.EventHandler(this.fm_Ajuda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bt_fechar_ajuda;
    }
}