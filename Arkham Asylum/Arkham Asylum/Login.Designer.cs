﻿namespace Arkham_Asylum
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginUtb = new System.Windows.Forms.TextBox();
            this.LoginPtb = new System.Windows.Forms.TextBox();
            this.Signbt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // LoginUtb
            // 
            this.LoginUtb.Location = new System.Drawing.Point(123, 83);
            this.LoginUtb.Name = "LoginUtb";
            this.LoginUtb.Size = new System.Drawing.Size(76, 20);
            this.LoginUtb.TabIndex = 2;
            // 
            // LoginPtb
            // 
            this.LoginPtb.Location = new System.Drawing.Point(123, 122);
            this.LoginPtb.Name = "LoginPtb";
            this.LoginPtb.Size = new System.Drawing.Size(76, 20);
            this.LoginPtb.TabIndex = 3;
            // 
            // Signbt
            // 
            this.Signbt.Location = new System.Drawing.Point(123, 183);
            this.Signbt.Name = "Signbt";
            this.Signbt.Size = new System.Drawing.Size(75, 23);
            this.Signbt.TabIndex = 4;
            this.Signbt.Text = "Sign in";
            this.Signbt.UseVisualStyleBackColor = true;
            this.Signbt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Signbt_MouseClick);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(233, 261);
            this.Controls.Add(this.Signbt);
            this.Controls.Add(this.LoginPtb);
            this.Controls.Add(this.LoginUtb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LoginUtb;
        private System.Windows.Forms.TextBox LoginPtb;
        private System.Windows.Forms.Button Signbt;
    }
}

