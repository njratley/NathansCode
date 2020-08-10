namespace Client
{
    partial class BattleShips
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
            this.tbxY = new System.Windows.Forms.TextBox();
            this.tbxX = new System.Windows.Forms.TextBox();
            this.lblY = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFire = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxY
            // 
            this.tbxY.Location = new System.Drawing.Point(169, 59);
            this.tbxY.Name = "tbxY";
            this.tbxY.Size = new System.Drawing.Size(75, 20);
            this.tbxY.TabIndex = 0;
            this.tbxY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxX
            // 
            this.tbxX.Location = new System.Drawing.Point(169, 33);
            this.tbxX.Name = "tbxX";
            this.tbxX.Size = new System.Drawing.Size(75, 20);
            this.tbxX.TabIndex = 1;
            this.tbxX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(24, 63);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(134, 13);
            this.lblY.TabIndex = 2;
            this.lblY.Text = "Enter Y Co-ordinates (1-10)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Y Co-ordinates (A-J)";
            // 
            // btnFire
            // 
            this.btnFire.Location = new System.Drawing.Point(169, 89);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(75, 23);
            this.btnFire.TabIndex = 4;
            this.btnFire.Text = "FIRE!";
            this.btnFire.UseVisualStyleBackColor = true;
            this.btnFire.Click += new System.EventHandler(this.btnFire_Click);
            // 
            // BattleShips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFire);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.tbxX);
            this.Controls.Add(this.tbxY);
            this.Name = "BattleShips";
            this.Text = "Nathan Ratley - C# Battleships";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxY;
        private System.Windows.Forms.TextBox tbxX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFire;
    }
}

