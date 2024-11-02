namespace pag39_ex13
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtLitros = new System.Windows.Forms.TextBox();
            this.btnBrinde = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBrinde = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantidade de litros de combustível colocados:";
            // 
            // txtLitros
            // 
            this.txtLitros.Location = new System.Drawing.Point(353, 60);
            this.txtLitros.Name = "txtLitros";
            this.txtLitros.Size = new System.Drawing.Size(164, 20);
            this.txtLitros.TabIndex = 1;
            // 
            // btnBrinde
            // 
            this.btnBrinde.Location = new System.Drawing.Point(272, 159);
            this.btnBrinde.Name = "btnBrinde";
            this.btnBrinde.Size = new System.Drawing.Size(75, 23);
            this.btnBrinde.TabIndex = 2;
            this.btnBrinde.Text = "...";
            this.btnBrinde.UseVisualStyleBackColor = true;
            this.btnBrinde.Click += new System.EventHandler(this.btnBrinde_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(215, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seu brinde é:";
            // 
            // txtBrinde
            // 
            this.txtBrinde.Location = new System.Drawing.Point(307, 101);
            this.txtBrinde.Name = "txtBrinde";
            this.txtBrinde.Size = new System.Drawing.Size(210, 20);
            this.txtBrinde.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBrinde);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBrinde);
            this.Controls.Add(this.txtLitros);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLitros;
        private System.Windows.Forms.Button btnBrinde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBrinde;
    }
}

