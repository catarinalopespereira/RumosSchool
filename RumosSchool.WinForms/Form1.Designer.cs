namespace RumosSchool.WinForms
{
    partial class Form1
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
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.unitPriceTxt = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.nomeLbl = new System.Windows.Forms.Label();
            this.uniiPriceLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(368, 90);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(256, 26);
            this.nameTxt.TabIndex = 0;
            // 
            // unitPriceTxt
            // 
            this.unitPriceTxt.Location = new System.Drawing.Point(368, 177);
            this.unitPriceTxt.Name = "unitPriceTxt";
            this.unitPriceTxt.Size = new System.Drawing.Size(252, 26);
            this.unitPriceTxt.TabIndex = 1;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(491, 288);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(129, 68);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "Gravar";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // nomeLbl
            // 
            this.nomeLbl.AutoSize = true;
            this.nomeLbl.Location = new System.Drawing.Point(222, 96);
            this.nomeLbl.Name = "nomeLbl";
            this.nomeLbl.Size = new System.Drawing.Size(51, 20);
            this.nomeLbl.TabIndex = 3;
            this.nomeLbl.Text = "label1";
            // 
            // uniiPriceLbl
            // 
            this.uniiPriceLbl.AutoSize = true;
            this.uniiPriceLbl.Location = new System.Drawing.Point(222, 183);
            this.uniiPriceLbl.Name = "uniiPriceLbl";
            this.uniiPriceLbl.Size = new System.Drawing.Size(51, 20);
            this.uniiPriceLbl.TabIndex = 4;
            this.uniiPriceLbl.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uniiPriceLbl);
            this.Controls.Add(this.nomeLbl);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.unitPriceTxt);
            this.Controls.Add(this.nameTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox unitPriceTxt;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label nomeLbl;
        private System.Windows.Forms.Label uniiPriceLbl;
    }
}

