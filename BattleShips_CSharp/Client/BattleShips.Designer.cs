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
            this.btnStartReset = new System.Windows.Forms.Button();
            this.lbxShotsFired = new System.Windows.Forms.ListBox();
            this.tbxMisses = new System.Windows.Forms.TextBox();
            this.lblMisses = new System.Windows.Forms.Label();
            this.tbxHits = new System.Windows.Forms.TextBox();
            this.lblHits = new System.Windows.Forms.Label();
            this.lblShipOne = new System.Windows.Forms.Label();
            this.lblShipTwo = new System.Windows.Forms.Label();
            this.rtbShips = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tbxY
            // 
            this.tbxY.Enabled = false;
            this.tbxY.Location = new System.Drawing.Point(169, 59);
            this.tbxY.Name = "tbxY";
            this.tbxY.Size = new System.Drawing.Size(75, 20);
            this.tbxY.TabIndex = 1;
            this.tbxY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxX
            // 
            this.tbxX.Enabled = false;
            this.tbxX.Location = new System.Drawing.Point(169, 33);
            this.tbxX.Name = "tbxX";
            this.tbxX.Size = new System.Drawing.Size(75, 20);
            this.tbxX.TabIndex = 0;
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
            this.btnFire.Enabled = false;
            this.btnFire.Location = new System.Drawing.Point(169, 89);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(75, 23);
            this.btnFire.TabIndex = 4;
            this.btnFire.Text = "FIRE!";
            this.btnFire.UseVisualStyleBackColor = true;
            this.btnFire.Click += new System.EventHandler(this.btnFire_Click);
            // 
            // btnStartReset
            // 
            this.btnStartReset.Location = new System.Drawing.Point(27, 232);
            this.btnStartReset.Name = "btnStartReset";
            this.btnStartReset.Size = new System.Drawing.Size(117, 23);
            this.btnStartReset.TabIndex = 5;
            this.btnStartReset.Text = "Start / Reset";
            this.btnStartReset.UseVisualStyleBackColor = true;
            this.btnStartReset.Click += new System.EventHandler(this.btnStartReset_Click);
            // 
            // lbxShotsFired
            // 
            this.lbxShotsFired.Enabled = false;
            this.lbxShotsFired.FormattingEnabled = true;
            this.lbxShotsFired.Location = new System.Drawing.Point(27, 131);
            this.lbxShotsFired.Name = "lbxShotsFired";
            this.lbxShotsFired.ScrollAlwaysVisible = true;
            this.lbxShotsFired.Size = new System.Drawing.Size(370, 95);
            this.lbxShotsFired.TabIndex = 6;
            // 
            // tbxMisses
            // 
            this.tbxMisses.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMisses.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbxMisses.Location = new System.Drawing.Point(411, 30);
            this.tbxMisses.Name = "tbxMisses";
            this.tbxMisses.Size = new System.Drawing.Size(80, 29);
            this.tbxMisses.TabIndex = 7;
            this.tbxMisses.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMisses
            // 
            this.lblMisses.AutoSize = true;
            this.lblMisses.ForeColor = System.Drawing.Color.Blue;
            this.lblMisses.Location = new System.Drawing.Point(411, 13);
            this.lblMisses.Name = "lblMisses";
            this.lblMisses.Size = new System.Drawing.Size(39, 13);
            this.lblMisses.TabIndex = 8;
            this.lblMisses.Text = "Misses";
            // 
            // tbxHits
            // 
            this.tbxHits.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxHits.ForeColor = System.Drawing.Color.Red;
            this.tbxHits.Location = new System.Drawing.Point(517, 30);
            this.tbxHits.Name = "tbxHits";
            this.tbxHits.Size = new System.Drawing.Size(80, 29);
            this.tbxHits.TabIndex = 9;
            this.tbxHits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblHits
            // 
            this.lblHits.AutoSize = true;
            this.lblHits.ForeColor = System.Drawing.Color.Red;
            this.lblHits.Location = new System.Drawing.Point(514, 13);
            this.lblHits.Name = "lblHits";
            this.lblHits.Size = new System.Drawing.Size(25, 13);
            this.lblHits.TabIndex = 10;
            this.lblHits.Text = "Hits";
            // 
            // lblShipOne
            // 
            this.lblShipOne.AutoSize = true;
            this.lblShipOne.Location = new System.Drawing.Point(455, 131);
            this.lblShipOne.Name = "lblShipOne";
            this.lblShipOne.Size = new System.Drawing.Size(0, 13);
            this.lblShipOne.TabIndex = 11;
            // 
            // lblShipTwo
            // 
            this.lblShipTwo.AutoSize = true;
            this.lblShipTwo.Location = new System.Drawing.Point(455, 156);
            this.lblShipTwo.Name = "lblShipTwo";
            this.lblShipTwo.Size = new System.Drawing.Size(0, 13);
            this.lblShipTwo.TabIndex = 12;
            // 
            // rtbShips
            // 
            this.rtbShips.Location = new System.Drawing.Point(443, 131);
            this.rtbShips.Name = "rtbShips";
            this.rtbShips.Size = new System.Drawing.Size(301, 96);
            this.rtbShips.TabIndex = 13;
            this.rtbShips.Text = "";
            // 
            // BattleShips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbShips);
            this.Controls.Add(this.lblShipTwo);
            this.Controls.Add(this.lblShipOne);
            this.Controls.Add(this.lblHits);
            this.Controls.Add(this.tbxHits);
            this.Controls.Add(this.lblMisses);
            this.Controls.Add(this.tbxMisses);
            this.Controls.Add(this.lbxShotsFired);
            this.Controls.Add(this.btnStartReset);
            this.Controls.Add(this.btnFire);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.tbxX);
            this.Controls.Add(this.tbxY);
            this.Name = "BattleShips";
            this.Text = "Nathan Ratley - C# Battleships - Technical Challenge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxY;
        private System.Windows.Forms.TextBox tbxX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFire;
        private System.Windows.Forms.Button btnStartReset;
        private System.Windows.Forms.ListBox lbxShotsFired;
        private System.Windows.Forms.TextBox tbxMisses;
        private System.Windows.Forms.Label lblMisses;
        private System.Windows.Forms.TextBox tbxHits;
        private System.Windows.Forms.Label lblHits;
        private System.Windows.Forms.Label lblShipOne;
        private System.Windows.Forms.Label lblShipTwo;
        private System.Windows.Forms.RichTextBox rtbShips;
    }
}

