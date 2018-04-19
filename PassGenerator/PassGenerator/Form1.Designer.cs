namespace PassGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checknummer = new System.Windows.Forms.CheckBox();
            this.checkversal = new System.Windows.Forms.CheckBox();
            this.checkgemen = new System.Windows.Forms.CheckBox();
            this.checktecken = new System.Windows.Forms.CheckBox();
            this.buttongenerate = new System.Windows.Forms.Button();
            this.txtboxlösen = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textboxsign = new System.Windows.Forms.ToolStripTextBox();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passantal = new System.Windows.Forms.NumericUpDown();
            this.passlängd = new System.Windows.Forms.NumericUpDown();
            this.buttonclear = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.checkall = new System.Windows.Forms.Button();
            this.showHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passantal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passlängd)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Passwords:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Length:";
            // 
            // checknummer
            // 
            this.checknummer.AutoSize = true;
            this.checknummer.Checked = true;
            this.checknummer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checknummer.Location = new System.Drawing.Point(15, 189);
            this.checknummer.Name = "checknummer";
            this.checknummer.Size = new System.Drawing.Size(68, 17);
            this.checknummer.TabIndex = 4;
            this.checknummer.Text = "Numbers";
            this.checknummer.UseVisualStyleBackColor = true;
            // 
            // checkversal
            // 
            this.checkversal.AutoSize = true;
            this.checkversal.Checked = true;
            this.checkversal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkversal.Location = new System.Drawing.Point(15, 212);
            this.checkversal.Name = "checkversal";
            this.checkversal.Size = new System.Drawing.Size(112, 17);
            this.checkversal.TabIndex = 5;
            this.checkversal.Text = "Upper-case letters";
            this.checkversal.UseVisualStyleBackColor = true;
            // 
            // checkgemen
            // 
            this.checkgemen.AutoSize = true;
            this.checkgemen.Checked = true;
            this.checkgemen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkgemen.Location = new System.Drawing.Point(15, 235);
            this.checkgemen.Name = "checkgemen";
            this.checkgemen.Size = new System.Drawing.Size(112, 17);
            this.checkgemen.TabIndex = 6;
            this.checkgemen.Text = "Lower-case letters";
            this.checkgemen.UseVisualStyleBackColor = true;
            // 
            // checktecken
            // 
            this.checktecken.AutoSize = true;
            this.checktecken.Checked = true;
            this.checktecken.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checktecken.Location = new System.Drawing.Point(15, 258);
            this.checktecken.Name = "checktecken";
            this.checktecken.Size = new System.Drawing.Size(52, 17);
            this.checktecken.TabIndex = 7;
            this.checktecken.Text = "Signs";
            this.checktecken.UseVisualStyleBackColor = true;
            // 
            // buttongenerate
            // 
            this.buttongenerate.Location = new System.Drawing.Point(264, 281);
            this.buttongenerate.Name = "buttongenerate";
            this.buttongenerate.Size = new System.Drawing.Size(114, 23);
            this.buttongenerate.TabIndex = 8;
            this.buttongenerate.Text = "Generate password";
            this.buttongenerate.UseVisualStyleBackColor = true;
            this.buttongenerate.Click += new System.EventHandler(this.buttongenerate_Click);
            // 
            // txtboxlösen
            // 
            this.txtboxlösen.Location = new System.Drawing.Point(195, 36);
            this.txtboxlösen.Multiline = true;
            this.txtboxlösen.Name = "txtboxlösen";
            this.txtboxlösen.ReadOnly = true;
            this.txtboxlösen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtboxlösen.Size = new System.Drawing.Size(183, 239);
            this.txtboxlösen.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(407, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // signsToolStripMenuItem
            // 
            this.signsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultToolStripMenuItem,
            this.textboxsign});
            this.signsToolStripMenuItem.Name = "signsToolStripMenuItem";
            this.signsToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.signsToolStripMenuItem.Text = "Signs used";
            // 
            // defaultToolStripMenuItem
            // 
            this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            this.defaultToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.defaultToolStripMenuItem.Text = "Default";
            this.defaultToolStripMenuItem.Click += new System.EventHandler(this.defaultToolStripMenuItem_Click);
            // 
            // textboxsign
            // 
            this.textboxsign.AcceptsReturn = true;
            this.textboxsign.Name = "textboxsign";
            this.textboxsign.Size = new System.Drawing.Size(100, 23);
            this.textboxsign.Text = "!&/()?<>";
            this.textboxsign.Enter += new System.EventHandler(this.textboxsign_Click);
            this.textboxsign.Click += new System.EventHandler(this.textboxsign_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showHelpToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // passantal
            // 
            this.passantal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.passantal.Location = new System.Drawing.Point(95, 76);
            this.passantal.Name = "passantal";
            this.passantal.ReadOnly = true;
            this.passantal.Size = new System.Drawing.Size(54, 20);
            this.passantal.TabIndex = 11;
            this.passantal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.passantal.ValueChanged += new System.EventHandler(this.passantal_ValueChanged);
            // 
            // passlängd
            // 
            this.passlängd.Location = new System.Drawing.Point(95, 117);
            this.passlängd.Name = "passlängd";
            this.passlängd.ReadOnly = true;
            this.passlängd.Size = new System.Drawing.Size(54, 20);
            this.passlängd.TabIndex = 12;
            this.passlängd.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.passlängd.ValueChanged += new System.EventHandler(this.passlängd_ValueChanged);
            // 
            // buttonclear
            // 
            this.buttonclear.Location = new System.Drawing.Point(195, 281);
            this.buttonclear.Name = "buttonclear";
            this.buttonclear.Size = new System.Drawing.Size(52, 23);
            this.buttonclear.TabIndex = 13;
            this.buttonclear.Text = "Clear";
            this.buttonclear.UseVisualStyleBackColor = true;
            this.buttonclear.Click += new System.EventHandler(this.buttonclear_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Text document |*.txt";
            // 
            // checkall
            // 
            this.checkall.Location = new System.Drawing.Point(15, 160);
            this.checkall.Name = "checkall";
            this.checkall.Size = new System.Drawing.Size(75, 23);
            this.checkall.TabIndex = 14;
            this.checkall.Text = "Uncheck All";
            this.checkall.UseVisualStyleBackColor = true;
            this.checkall.Click += new System.EventHandler(this.checkall_Click);
            // 
            // showHelpToolStripMenuItem
            // 
            this.showHelpToolStripMenuItem.Name = "showHelpToolStripMenuItem";
            this.showHelpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.showHelpToolStripMenuItem.Text = "Show Help";
            this.showHelpToolStripMenuItem.Click += new System.EventHandler(this.showHelpToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.buttongenerate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 316);
            this.Controls.Add(this.checkall);
            this.Controls.Add(this.buttonclear);
            this.Controls.Add(this.passlängd);
            this.Controls.Add(this.passantal);
            this.Controls.Add(this.txtboxlösen);
            this.Controls.Add(this.buttongenerate);
            this.Controls.Add(this.checktecken);
            this.Controls.Add(this.checkgemen);
            this.Controls.Add(this.checkversal);
            this.Controls.Add(this.checknummer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "PassGen 1.0";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passantal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passlängd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checknummer;
        private System.Windows.Forms.CheckBox checkversal;
        private System.Windows.Forms.CheckBox checkgemen;
        private System.Windows.Forms.CheckBox checktecken;
        private System.Windows.Forms.Button buttongenerate;
        private System.Windows.Forms.TextBox txtboxlösen;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown passantal;
        private System.Windows.Forms.NumericUpDown passlängd;
        private System.Windows.Forms.Button buttonclear;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button checkall;
        private System.Windows.Forms.ToolStripMenuItem signsToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox textboxsign;
        private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showHelpToolStripMenuItem;
    }
}

