namespace Arkham_Asylum
{
    partial class AdminForm
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
            this.BadguysDGV = new System.Windows.Forms.DataGridView();
            this.DoctorDGV = new System.Windows.Forms.DataGridView();
            this.DrugsDGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addVibt = new System.Windows.Forms.Button();
            this.addDobt = new System.Windows.Forms.Button();
            this.addDrbt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BadguysDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrugsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // BadguysDGV
            // 
            this.BadguysDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BadguysDGV.Location = new System.Drawing.Point(204, 32);
            this.BadguysDGV.Name = "BadguysDGV";
            this.BadguysDGV.Size = new System.Drawing.Size(198, 134);
            this.BadguysDGV.TabIndex = 0;
            // 
            // DoctorDGV
            // 
            this.DoctorDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DoctorDGV.Location = new System.Drawing.Point(421, 32);
            this.DoctorDGV.Name = "DoctorDGV";
            this.DoctorDGV.Size = new System.Drawing.Size(193, 134);
            this.DoctorDGV.TabIndex = 1;
            // 
            // DrugsDGV
            // 
            this.DrugsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DrugsDGV.Location = new System.Drawing.Point(638, 32);
            this.DrugsDGV.Name = "DrugsDGV";
            this.DrugsDGV.Size = new System.Drawing.Size(193, 134);
            this.DrugsDGV.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Villians";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(483, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Doctors";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(710, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Drugs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "What do you want to add?";
            // 
            // addVibt
            // 
            this.addVibt.Location = new System.Drawing.Point(16, 62);
            this.addVibt.Name = "addVibt";
            this.addVibt.Size = new System.Drawing.Size(75, 23);
            this.addVibt.TabIndex = 7;
            this.addVibt.Text = "Villian";
            this.addVibt.UseVisualStyleBackColor = true;
            this.addVibt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.addVibt_MouseClick);
            // 
            // addDobt
            // 
            this.addDobt.Location = new System.Drawing.Point(16, 103);
            this.addDobt.Name = "addDobt";
            this.addDobt.Size = new System.Drawing.Size(75, 23);
            this.addDobt.TabIndex = 8;
            this.addDobt.Text = "Doctor";
            this.addDobt.UseVisualStyleBackColor = true;
            this.addDobt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.addDobt_MouseClick);
            // 
            // addDrbt
            // 
            this.addDrbt.Location = new System.Drawing.Point(16, 142);
            this.addDrbt.Name = "addDrbt";
            this.addDrbt.Size = new System.Drawing.Size(75, 23);
            this.addDrbt.TabIndex = 9;
            this.addDrbt.Text = "Drug";
            this.addDrbt.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 206);
            this.Controls.Add(this.addDrbt);
            this.Controls.Add(this.addDobt);
            this.Controls.Add(this.addVibt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DrugsDGV);
            this.Controls.Add(this.DoctorDGV);
            this.Controls.Add(this.BadguysDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdminForm";
            this.Text = "Admin menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.BadguysDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrugsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView BadguysDGV;
        private System.Windows.Forms.DataGridView DoctorDGV;
        private System.Windows.Forms.DataGridView DrugsDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addVibt;
        private System.Windows.Forms.Button addDobt;
        private System.Windows.Forms.Button addDrbt;
    }
}