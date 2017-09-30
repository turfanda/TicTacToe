namespace TicTacToe
{
    partial class TTT1
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
            this.A1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.againstComputerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.againstHumanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetCounterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abouToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.xwc = new System.Windows.Forms.Label();
            this.dwc = new System.Windows.Forms.Label();
            this.owc = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // A1
            // 
            this.A1.Font = new System.Drawing.Font("Open Sans", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.A1.Location = new System.Drawing.Point(13, 43);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(80, 80);
            this.A1.TabIndex = 0;
            this.A1.UseVisualStyleBackColor = true;
            this.A1.Click += new System.EventHandler(this.btn_Click);
            this.A1.MouseEnter += new System.EventHandler(this.button_enter);
            this.A1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.abouToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(275, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.resetCounterToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.againstComputerToolStripMenuItem,
            this.againstHumanToolStripMenuItem});
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            // 
            // againstComputerToolStripMenuItem
            // 
            this.againstComputerToolStripMenuItem.Name = "againstComputerToolStripMenuItem";
            this.againstComputerToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.againstComputerToolStripMenuItem.Text = "Against Computer";
            // 
            // againstHumanToolStripMenuItem
            // 
            this.againstHumanToolStripMenuItem.Name = "againstHumanToolStripMenuItem";
            this.againstHumanToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.againstHumanToolStripMenuItem.Text = "Against Human";
            this.againstHumanToolStripMenuItem.Click += new System.EventHandler(this.againstHumanToolStripMenuItem_Click);
            // 
            // resetCounterToolStripMenuItem
            // 
            this.resetCounterToolStripMenuItem.Name = "resetCounterToolStripMenuItem";
            this.resetCounterToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.resetCounterToolStripMenuItem.Text = "Reset Counter";
            this.resetCounterToolStripMenuItem.Click += new System.EventHandler(this.resetCounterToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // abouToolStripMenuItem
            // 
            this.abouToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.abouToolStripMenuItem.Name = "abouToolStripMenuItem";
            this.abouToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.abouToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // A2
            // 
            this.A2.Font = new System.Drawing.Font("Open Sans", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.A2.Location = new System.Drawing.Point(99, 43);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(80, 80);
            this.A2.TabIndex = 2;
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.btn_Click);
            this.A2.MouseEnter += new System.EventHandler(this.button_enter);
            this.A2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // A3
            // 
            this.A3.Font = new System.Drawing.Font("Open Sans", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.A3.Location = new System.Drawing.Point(185, 43);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(80, 80);
            this.A3.TabIndex = 3;
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.btn_Click);
            this.A3.MouseEnter += new System.EventHandler(this.button_enter);
            this.A3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B1
            // 
            this.B1.Font = new System.Drawing.Font("Open Sans", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.B1.Location = new System.Drawing.Point(13, 129);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(80, 80);
            this.B1.TabIndex = 4;
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.btn_Click);
            this.B1.MouseEnter += new System.EventHandler(this.button_enter);
            this.B1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B2
            // 
            this.B2.Font = new System.Drawing.Font("Open Sans", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.B2.Location = new System.Drawing.Point(99, 129);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(80, 80);
            this.B2.TabIndex = 5;
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.btn_Click);
            this.B2.MouseEnter += new System.EventHandler(this.button_enter);
            this.B2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B3
            // 
            this.B3.Font = new System.Drawing.Font("Open Sans", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.B3.Location = new System.Drawing.Point(185, 129);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(80, 80);
            this.B3.TabIndex = 6;
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.btn_Click);
            this.B3.MouseEnter += new System.EventHandler(this.button_enter);
            this.B3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // C1
            // 
            this.C1.Font = new System.Drawing.Font("Open Sans", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.C1.Location = new System.Drawing.Point(13, 215);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(80, 80);
            this.C1.TabIndex = 7;
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Click += new System.EventHandler(this.btn_Click);
            this.C1.MouseEnter += new System.EventHandler(this.button_enter);
            this.C1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // C2
            // 
            this.C2.Font = new System.Drawing.Font("Open Sans", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.C2.Location = new System.Drawing.Point(99, 215);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(80, 80);
            this.C2.TabIndex = 8;
            this.C2.UseVisualStyleBackColor = true;
            this.C2.Click += new System.EventHandler(this.btn_Click);
            this.C2.MouseEnter += new System.EventHandler(this.button_enter);
            this.C2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // C3
            // 
            this.C3.Font = new System.Drawing.Font("Open Sans", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.C3.Location = new System.Drawing.Point(185, 215);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(80, 80);
            this.C3.TabIndex = 9;
            this.C3.UseVisualStyleBackColor = true;
            this.C3.Click += new System.EventHandler(this.btn_Click);
            this.C3.MouseEnter += new System.EventHandler(this.button_enter);
            this.C3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 307);
            this.label1.MaximumSize = new System.Drawing.Size(76, 13);
            this.label1.MinimumSize = new System.Drawing.Size(76, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "X Win Counter";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 307);
            this.label2.MaximumSize = new System.Drawing.Size(76, 13);
            this.label2.MinimumSize = new System.Drawing.Size(76, 13);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Draw Counter";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 307);
            this.label3.MaximumSize = new System.Drawing.Size(77, 13);
            this.label3.MinimumSize = new System.Drawing.Size(77, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "O Win Counter";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xwc
            // 
            this.xwc.AutoSize = true;
            this.xwc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xwc.Location = new System.Drawing.Point(48, 324);
            this.xwc.Name = "xwc";
            this.xwc.Size = new System.Drawing.Size(15, 15);
            this.xwc.TabIndex = 13;
            this.xwc.Text = "0";
            // 
            // dwc
            // 
            this.dwc.AutoSize = true;
            this.dwc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dwc.Cursor = System.Windows.Forms.Cursors.Default;
            this.dwc.Location = new System.Drawing.Point(130, 324);
            this.dwc.Name = "dwc";
            this.dwc.Size = new System.Drawing.Size(15, 15);
            this.dwc.TabIndex = 14;
            this.dwc.Text = "0";
            // 
            // owc
            // 
            this.owc.AutoSize = true;
            this.owc.BackColor = System.Drawing.SystemColors.Control;
            this.owc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.owc.Location = new System.Drawing.Point(218, 324);
            this.owc.Name = "owc";
            this.owc.Size = new System.Drawing.Size(15, 15);
            this.owc.TabIndex = 15;
            this.owc.Text = "0";
            // 
            // TTT1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 357);
            this.Controls.Add(this.owc);
            this.Controls.Add(this.dwc);
            this.Controls.Add(this.xwc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "TTT1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe";
            this.Load += new System.EventHandler(this.TTT1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem againstComputerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem againstHumanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.ToolStripMenuItem abouToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label xwc;
        private System.Windows.Forms.Label dwc;
        private System.Windows.Forms.Label owc;
        private System.Windows.Forms.ToolStripMenuItem resetCounterToolStripMenuItem;
    }
}

