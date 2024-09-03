namespace CodeWalker.Project.Panels
{
    partial class EditYnvPolyPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditYnvPolyPanel));
            AreaIDUpDown = new System.Windows.Forms.NumericUpDown();
            label92 = new System.Windows.Forms.Label();
            PartIDUpDown = new System.Windows.Forms.NumericUpDown();
            label1 = new System.Windows.Forms.Label();
            PortalIDUpDown = new System.Windows.Forms.NumericUpDown();
            label2 = new System.Windows.Forms.Label();
            FlagsCheckedListBox1 = new System.Windows.Forms.CheckedListBox();
            FlagsCheckedListBox2 = new System.Windows.Forms.CheckedListBox();
            FlagsCheckedListBox3 = new System.Windows.Forms.CheckedListBox();
            label5 = new System.Windows.Forms.Label();
            FlagsCheckedListBox4 = new System.Windows.Forms.CheckedListBox();
            UnkXUpDown = new System.Windows.Forms.NumericUpDown();
            label3 = new System.Windows.Forms.Label();
            UnkYUpDown = new System.Windows.Forms.NumericUpDown();
            label4 = new System.Windows.Forms.Label();
            DeletePolyButton = new System.Windows.Forms.Button();
            AddToProjectButton = new System.Windows.Forms.Button();
            PortalCountUpDown = new System.Windows.Forms.NumericUpDown();
            label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)AreaIDUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PartIDUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PortalIDUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UnkXUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UnkYUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PortalCountUpDown).BeginInit();
            SuspendLayout();
            // 
            // AreaIDUpDown
            // 
            AreaIDUpDown.Location = new System.Drawing.Point(69, 14);
            AreaIDUpDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            AreaIDUpDown.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            AreaIDUpDown.Name = "AreaIDUpDown";
            AreaIDUpDown.Size = new System.Drawing.Size(83, 23);
            AreaIDUpDown.TabIndex = 2;
            AreaIDUpDown.ValueChanged += AreaIDUpDown_ValueChanged;
            // 
            // label92
            // 
            label92.AutoSize = true;
            label92.Location = new System.Drawing.Point(8, 16);
            label92.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label92.Name = "label92";
            label92.Size = new System.Drawing.Size(48, 15);
            label92.TabIndex = 1;
            label92.Text = "Area ID:";
            // 
            // PartIDUpDown
            // 
            PartIDUpDown.Location = new System.Drawing.Point(225, 14);
            PartIDUpDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            PartIDUpDown.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            PartIDUpDown.Name = "PartIDUpDown";
            PartIDUpDown.Size = new System.Drawing.Size(83, 23);
            PartIDUpDown.TabIndex = 4;
            PartIDUpDown.ValueChanged += PartIDUpDown_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(168, 16);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(45, 15);
            label1.TabIndex = 3;
            label1.Text = "Part ID:";
            // 
            // PortalIDUpDown
            // 
            PortalIDUpDown.Location = new System.Drawing.Point(404, 14);
            PortalIDUpDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            PortalIDUpDown.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            PortalIDUpDown.Name = "PortalIDUpDown";
            PortalIDUpDown.Size = new System.Drawing.Size(83, 23);
            PortalIDUpDown.TabIndex = 6;
            PortalIDUpDown.ValueChanged += PortalIDUpDown_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(327, 16);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(66, 15);
            label2.TabIndex = 5;
            label2.Text = "Portal Link:";
            // 
            // FlagsCheckedListBox1
            // 
            FlagsCheckedListBox1.CheckOnClick = true;
            FlagsCheckedListBox1.FormattingEnabled = true;
            FlagsCheckedListBox1.Items.AddRange(new object[] { "0 - Small Poly", "1 - Large Poly", "2 - Is Pavement", "3 - Is Underground", "4 - [Not used]", "5 - [Not used]", "6 - Is Too Steep To Walk", "7 - Is Water" });
            FlagsCheckedListBox1.Location = new System.Drawing.Point(12, 78);
            FlagsCheckedListBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            FlagsCheckedListBox1.Name = "FlagsCheckedListBox1";
            FlagsCheckedListBox1.Size = new System.Drawing.Size(152, 130);
            FlagsCheckedListBox1.TabIndex = 10;
            FlagsCheckedListBox1.ItemCheck += FlagsCheckedListBox1_ItemCheck;
            // 
            // FlagsCheckedListBox2
            // 
            FlagsCheckedListBox2.CheckOnClick = true;
            FlagsCheckedListBox2.FormattingEnabled = true;
            FlagsCheckedListBox2.Items.AddRange(new object[] { "0 - AudioProperties1", "1 - AudioProperties2", "2 - AudioProperties3", "3 - AudioProperties4", "4 - [Not used]", "5 - Near Car Node", "6 - Is Interior", "7 - Is Isolated" });
            FlagsCheckedListBox2.Location = new System.Drawing.Point(172, 78);
            FlagsCheckedListBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            FlagsCheckedListBox2.Name = "FlagsCheckedListBox2";
            FlagsCheckedListBox2.Size = new System.Drawing.Size(152, 130);
            FlagsCheckedListBox2.TabIndex = 11;
            FlagsCheckedListBox2.ItemCheck += FlagsCheckedListBox2_ItemCheck;
            // 
            // FlagsCheckedListBox3
            // 
            FlagsCheckedListBox3.CheckOnClick = true;
            FlagsCheckedListBox3.FormattingEnabled = true;
            FlagsCheckedListBox3.Items.AddRange(new object[] { "1 - Network Spawn Candidate", "2 - Is Road", "3 - Lies Along Edge of Mesh", "4 - Is Train Track", "5 - Is Shallow Water", "6 - Ped Density1", "7 - Ped Density2", "8 - Ped Density3" });
            FlagsCheckedListBox3.Location = new System.Drawing.Point(331, 78);
            FlagsCheckedListBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            FlagsCheckedListBox3.Name = "FlagsCheckedListBox3";
            FlagsCheckedListBox3.Size = new System.Drawing.Size(152, 130);
            FlagsCheckedListBox3.TabIndex = 12;
            FlagsCheckedListBox3.ItemCheck += FlagsCheckedListBox3_ItemCheck;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(8, 60);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(37, 15);
            label5.TabIndex = 9;
            label5.Text = "Flags:";
            // 
            // FlagsCheckedListBox4
            // 
            FlagsCheckedListBox4.CheckOnClick = true;
            FlagsCheckedListBox4.FormattingEnabled = true;
            FlagsCheckedListBox4.Items.AddRange(new object[] { "0 - SlopeSouth", "1 - SlopeSouthEast", "2 - SlopeEast", "3 - SlopeNorthEast", "4 - SlopeNorth", "5 - SlopeNorthWest", "6 - SlopeWest", "7 - SlopeSouthWest" });
            FlagsCheckedListBox4.Location = new System.Drawing.Point(491, 78);
            FlagsCheckedListBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            FlagsCheckedListBox4.Name = "FlagsCheckedListBox4";
            FlagsCheckedListBox4.Size = new System.Drawing.Size(152, 130);
            FlagsCheckedListBox4.TabIndex = 13;
            FlagsCheckedListBox4.ItemCheck += FlagsCheckedListBox4_ItemCheck;
            // 
            // UnkXUpDown
            // 
            UnkXUpDown.Location = new System.Drawing.Point(96, 246);
            UnkXUpDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            UnkXUpDown.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            UnkXUpDown.Name = "UnkXUpDown";
            UnkXUpDown.Size = new System.Drawing.Size(69, 23);
            UnkXUpDown.TabIndex = 15;
            UnkXUpDown.ValueChanged += UnkXUpDown_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(15, 248);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(68, 15);
            label3.TabIndex = 14;
            label3.Text = "UnknownX:";
            // 
            // UnkYUpDown
            // 
            UnkYUpDown.Location = new System.Drawing.Point(255, 246);
            UnkYUpDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            UnkYUpDown.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            UnkYUpDown.Name = "UnkYUpDown";
            UnkYUpDown.Size = new System.Drawing.Size(69, 23);
            UnkYUpDown.TabIndex = 17;
            UnkYUpDown.ValueChanged += UnkYUpDown_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(175, 248);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(68, 15);
            label4.TabIndex = 16;
            label4.Text = "UnknownY:";
            // 
            // DeletePolyButton
            // 
            DeletePolyButton.Enabled = false;
            DeletePolyButton.Location = new System.Drawing.Point(144, 303);
            DeletePolyButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            DeletePolyButton.Name = "DeletePolyButton";
            DeletePolyButton.Size = new System.Drawing.Size(105, 27);
            DeletePolyButton.TabIndex = 19;
            DeletePolyButton.Text = "Delete Polygon";
            DeletePolyButton.UseVisualStyleBackColor = true;
            DeletePolyButton.Click += DeletePolyButton_Click;
            // 
            // AddToProjectButton
            // 
            AddToProjectButton.Enabled = false;
            AddToProjectButton.Location = new System.Drawing.Point(31, 303);
            AddToProjectButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            AddToProjectButton.Name = "AddToProjectButton";
            AddToProjectButton.Size = new System.Drawing.Size(105, 27);
            AddToProjectButton.TabIndex = 18;
            AddToProjectButton.Text = "Add to Project";
            AddToProjectButton.UseVisualStyleBackColor = true;
            AddToProjectButton.Click += AddToProjectButton_Click;
            // 
            // PortalCountUpDown
            // 
            PortalCountUpDown.Location = new System.Drawing.Point(578, 14);
            PortalCountUpDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            PortalCountUpDown.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            PortalCountUpDown.Name = "PortalCountUpDown";
            PortalCountUpDown.Size = new System.Drawing.Size(66, 23);
            PortalCountUpDown.TabIndex = 8;
            PortalCountUpDown.ValueChanged += PortalCountUpDown_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(495, 16);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(75, 15);
            label6.TabIndex = 7;
            label6.Text = "Portal count:";
            // 
            // EditYnvPolyPanel
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(656, 466);
            Controls.Add(PortalCountUpDown);
            Controls.Add(label6);
            Controls.Add(DeletePolyButton);
            Controls.Add(AddToProjectButton);
            Controls.Add(UnkYUpDown);
            Controls.Add(label4);
            Controls.Add(UnkXUpDown);
            Controls.Add(label3);
            Controls.Add(FlagsCheckedListBox4);
            Controls.Add(label5);
            Controls.Add(FlagsCheckedListBox3);
            Controls.Add(FlagsCheckedListBox2);
            Controls.Add(FlagsCheckedListBox1);
            Controls.Add(PortalIDUpDown);
            Controls.Add(label2);
            Controls.Add(PartIDUpDown);
            Controls.Add(label1);
            Controls.Add(AreaIDUpDown);
            Controls.Add(label92);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "EditYnvPolyPanel";
            Text = "Edit Ynv Poly";
            ((System.ComponentModel.ISupportInitialize)AreaIDUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)PartIDUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)PortalIDUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)UnkXUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)UnkYUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)PortalCountUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.NumericUpDown AreaIDUpDown;
        private System.Windows.Forms.Label label92;
        private System.Windows.Forms.NumericUpDown PartIDUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown PortalIDUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox FlagsCheckedListBox1;
        private System.Windows.Forms.CheckedListBox FlagsCheckedListBox2;
        private System.Windows.Forms.CheckedListBox FlagsCheckedListBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox FlagsCheckedListBox4;
        private System.Windows.Forms.NumericUpDown UnkXUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown UnkYUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DeletePolyButton;
        private System.Windows.Forms.Button AddToProjectButton;
        private System.Windows.Forms.NumericUpDown PortalCountUpDown;
        private System.Windows.Forms.Label label6;
    }
}