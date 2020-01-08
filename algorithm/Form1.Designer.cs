namespace ContainerShip
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ShipMakerBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.VerticalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.HorizontalUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ContainerList = new System.Windows.Forms.ListBox();
            this.BtnCreateContainer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TypeofContainerComboBox = new System.Windows.Forms.ComboBox();
            this.WeightContainer = new System.Windows.Forms.NumericUpDown();
            this.BtnPlaceAll = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbColumn = new System.Windows.Forms.ListBox();
            this.cbHorizontal = new System.Windows.Forms.ComboBox();
            this.cbVertical = new System.Windows.Forms.ComboBox();
            this.Horizontaal = new System.Windows.Forms.Label();
            this.Verticaal = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VerticalNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HorizontalUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WeightContainer)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ShipMakerBtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.VerticalNumericUpDown);
            this.groupBox1.Controls.Add(this.HorizontalUpDown);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ship";
            // 
            // ShipMakerBtn
            // 
            this.ShipMakerBtn.Location = new System.Drawing.Point(48, 152);
            this.ShipMakerBtn.Name = "ShipMakerBtn";
            this.ShipMakerBtn.Size = new System.Drawing.Size(118, 28);
            this.ShipMakerBtn.TabIndex = 4;
            this.ShipMakerBtn.Text = "make a ship";
            this.ShipMakerBtn.UseVisualStyleBackColor = true;
            this.ShipMakerBtn.Click += new System.EventHandler(this.ShipMakerBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vertical";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Horizontal";
            // 
            // VerticalNumericUpDown
            // 
            this.VerticalNumericUpDown.Location = new System.Drawing.Point(124, 89);
            this.VerticalNumericUpDown.Name = "VerticalNumericUpDown";
            this.VerticalNumericUpDown.Size = new System.Drawing.Size(120, 26);
            this.VerticalNumericUpDown.TabIndex = 1;
            this.VerticalNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // HorizontalUpDown
            // 
            this.HorizontalUpDown.Location = new System.Drawing.Point(124, 45);
            this.HorizontalUpDown.Name = "HorizontalUpDown";
            this.HorizontalUpDown.Size = new System.Drawing.Size(120, 26);
            this.HorizontalUpDown.TabIndex = 0;
            this.HorizontalUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ContainerList);
            this.groupBox2.Controls.Add(this.BtnCreateContainer);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TypeofContainerComboBox);
            this.groupBox2.Controls.Add(this.WeightContainer);
            this.groupBox2.Location = new System.Drawing.Point(465, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(580, 336);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Container";
            // 
            // ContainerList
            // 
            this.ContainerList.FormattingEnabled = true;
            this.ContainerList.ItemHeight = 20;
            this.ContainerList.Location = new System.Drawing.Point(340, 0);
            this.ContainerList.Name = "ContainerList";
            this.ContainerList.Size = new System.Drawing.Size(234, 284);
            this.ContainerList.TabIndex = 5;
            // 
            // BtnCreateContainer
            // 
            this.BtnCreateContainer.Location = new System.Drawing.Point(90, 210);
            this.BtnCreateContainer.Name = "BtnCreateContainer";
            this.BtnCreateContainer.Size = new System.Drawing.Size(138, 51);
            this.BtnCreateContainer.TabIndex = 4;
            this.BtnCreateContainer.Text = "Create Container";
            this.BtnCreateContainer.UseVisualStyleBackColor = true;
            this.BtnCreateContainer.Click += new System.EventHandler(this.BtnCreateContainer_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Type of Container";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Weight";
            // 
            // TypeofContainerComboBox
            // 
            this.TypeofContainerComboBox.FormattingEnabled = true;
            this.TypeofContainerComboBox.Location = new System.Drawing.Point(165, 111);
            this.TypeofContainerComboBox.Name = "TypeofContainerComboBox";
            this.TypeofContainerComboBox.Size = new System.Drawing.Size(121, 28);
            this.TypeofContainerComboBox.TabIndex = 1;
            // 
            // WeightContainer
            // 
            this.WeightContainer.Location = new System.Drawing.Point(165, 54);
            this.WeightContainer.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.WeightContainer.Minimum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.WeightContainer.Name = "WeightContainer";
            this.WeightContainer.Size = new System.Drawing.Size(120, 26);
            this.WeightContainer.TabIndex = 0;
            this.WeightContainer.Value = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            // 
            // BtnPlaceAll
            // 
            this.BtnPlaceAll.Location = new System.Drawing.Point(32, 472);
            this.BtnPlaceAll.Name = "BtnPlaceAll";
            this.BtnPlaceAll.Size = new System.Drawing.Size(293, 216);
            this.BtnPlaceAll.TabIndex = 2;
            this.BtnPlaceAll.Text = "Place all containers";
            this.BtnPlaceAll.UseVisualStyleBackColor = true;
            this.BtnPlaceAll.Click += new System.EventHandler(this.BtnPlaceAll_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbColumn);
            this.groupBox3.Controls.Add(this.cbHorizontal);
            this.groupBox3.Controls.Add(this.cbVertical);
            this.groupBox3.Controls.Add(this.Horizontaal);
            this.groupBox3.Controls.Add(this.Verticaal);
            this.groupBox3.Location = new System.Drawing.Point(369, 384);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1051, 358);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ship";
            // 
            // lbColumn
            // 
            this.lbColumn.FormattingEnabled = true;
            this.lbColumn.ItemHeight = 20;
            this.lbColumn.Location = new System.Drawing.Point(322, 18);
            this.lbColumn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbColumn.Name = "lbColumn";
            this.lbColumn.Size = new System.Drawing.Size(637, 304);
            this.lbColumn.TabIndex = 7;
            // 
            // cbHorizontal
            // 
            this.cbHorizontal.FormattingEnabled = true;
            this.cbHorizontal.Location = new System.Drawing.Point(117, 98);
            this.cbHorizontal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbHorizontal.Name = "cbHorizontal";
            this.cbHorizontal.Size = new System.Drawing.Size(180, 28);
            this.cbHorizontal.TabIndex = 6;
            this.cbHorizontal.SelectedIndexChanged += new System.EventHandler(this.cbHorizontal_SelectedIndexChanged_1);
            // 
            // cbVertical
            // 
            this.cbVertical.FormattingEnabled = true;
            this.cbVertical.Location = new System.Drawing.Point(117, 48);
            this.cbVertical.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbVertical.Name = "cbVertical";
            this.cbVertical.Size = new System.Drawing.Size(180, 28);
            this.cbVertical.TabIndex = 5;
            // 
            // Horizontaal
            // 
            this.Horizontaal.AutoSize = true;
            this.Horizontaal.Location = new System.Drawing.Point(22, 106);
            this.Horizontaal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Horizontaal.Name = "Horizontaal";
            this.Horizontaal.Size = new System.Drawing.Size(81, 20);
            this.Horizontaal.TabIndex = 4;
            this.Horizontaal.Text = "Horizontal";
            // 
            // Verticaal
            // 
            this.Verticaal.AutoSize = true;
            this.Verticaal.Location = new System.Drawing.Point(22, 48);
            this.Verticaal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Verticaal.Name = "Verticaal";
            this.Verticaal.Size = new System.Drawing.Size(62, 20);
            this.Verticaal.TabIndex = 3;
            this.Verticaal.Text = "Vertical";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1579, 818);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.BtnPlaceAll);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VerticalNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HorizontalUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WeightContainer)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown VerticalNumericUpDown;
        private System.Windows.Forms.NumericUpDown HorizontalUpDown;
        private System.Windows.Forms.Button ShipMakerBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox TypeofContainerComboBox;
        private System.Windows.Forms.NumericUpDown WeightContainer;
        private System.Windows.Forms.ListBox ContainerList;
        private System.Windows.Forms.Button BtnCreateContainer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnPlaceAll;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbColumn;
        private System.Windows.Forms.ComboBox cbHorizontal;
        private System.Windows.Forms.ComboBox cbVertical;
        private System.Windows.Forms.Label Horizontaal;
        private System.Windows.Forms.Label Verticaal;
    }
}

