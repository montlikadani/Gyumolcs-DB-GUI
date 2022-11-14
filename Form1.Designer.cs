namespace FormsGyumolcs {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.gyumolcsList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.nevBox = new System.Windows.Forms.TextBox();
            this.amountBox = new System.Windows.Forms.NumericUpDown();
            this.egysegAr = new System.Windows.Forms.NumericUpDown();
            this.newVegButton = new System.Windows.Forms.Button();
            this.removeVeg = new System.Windows.Forms.Button();
            this.updateFruitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.amountBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.egysegAr)).BeginInit();
            this.SuspendLayout();
            // 
            // gyumolcsList
            // 
            this.gyumolcsList.Dock = System.Windows.Forms.DockStyle.Left;
            this.gyumolcsList.FormattingEnabled = true;
            this.gyumolcsList.ItemHeight = 16;
            this.gyumolcsList.Location = new System.Drawing.Point(0, 0);
            this.gyumolcsList.Name = "gyumolcsList";
            this.gyumolcsList.Size = new System.Drawing.Size(120, 554);
            this.gyumolcsList.TabIndex = 0;
            this.gyumolcsList.SelectedIndexChanged += new System.EventHandler(this.gyumolcsList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Név";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Egységár";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mennyiség";
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(223, 16);
            this.idBox.Name = "idBox";
            this.idBox.ReadOnly = true;
            this.idBox.Size = new System.Drawing.Size(100, 22);
            this.idBox.TabIndex = 5;
            this.idBox.WordWrap = false;
            // 
            // nevBox
            // 
            this.nevBox.Location = new System.Drawing.Point(223, 54);
            this.nevBox.Name = "nevBox";
            this.nevBox.Size = new System.Drawing.Size(100, 22);
            this.nevBox.TabIndex = 6;
            this.nevBox.WordWrap = false;
            // 
            // amountBox
            // 
            this.amountBox.Location = new System.Drawing.Point(223, 139);
            this.amountBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.amountBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(120, 22);
            this.amountBox.TabIndex = 9;
            this.amountBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // egysegAr
            // 
            this.egysegAr.Location = new System.Drawing.Point(223, 93);
            this.egysegAr.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.egysegAr.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.egysegAr.Name = "egysegAr";
            this.egysegAr.Size = new System.Drawing.Size(120, 22);
            this.egysegAr.TabIndex = 10;
            this.egysegAr.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // newVegButton
            // 
            this.newVegButton.Location = new System.Drawing.Point(129, 194);
            this.newVegButton.Name = "newVegButton";
            this.newVegButton.Size = new System.Drawing.Size(214, 45);
            this.newVegButton.TabIndex = 11;
            this.newVegButton.Text = "Új gyümölcs hozzáadása";
            this.newVegButton.UseVisualStyleBackColor = true;
            this.newVegButton.Click += new System.EventHandler(this.newVegButton_Click);
            // 
            // removeVeg
            // 
            this.removeVeg.Enabled = false;
            this.removeVeg.Location = new System.Drawing.Point(129, 246);
            this.removeVeg.Name = "removeVeg";
            this.removeVeg.Size = new System.Drawing.Size(214, 43);
            this.removeVeg.TabIndex = 12;
            this.removeVeg.Text = "Gyümölcs eltávolítása";
            this.removeVeg.UseVisualStyleBackColor = true;
            this.removeVeg.Click += new System.EventHandler(this.removeVeg_Click);
            // 
            // updateFruitButton
            // 
            this.updateFruitButton.Enabled = false;
            this.updateFruitButton.Location = new System.Drawing.Point(129, 296);
            this.updateFruitButton.Name = "updateFruitButton";
            this.updateFruitButton.Size = new System.Drawing.Size(214, 43);
            this.updateFruitButton.TabIndex = 13;
            this.updateFruitButton.Text = "Kiválasztott gyümölcs frissítése";
            this.updateFruitButton.UseVisualStyleBackColor = true;
            this.updateFruitButton.Click += new System.EventHandler(this.updateFruitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 554);
            this.Controls.Add(this.updateFruitButton);
            this.Controls.Add(this.removeVeg);
            this.Controls.Add(this.newVegButton);
            this.Controls.Add(this.egysegAr);
            this.Controls.Add(this.amountBox);
            this.Controls.Add(this.nevBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gyumolcsList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gyümölcsök";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.amountBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.egysegAr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox gyumolcsList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.TextBox nevBox;
        private System.Windows.Forms.NumericUpDown amountBox;
        private System.Windows.Forms.NumericUpDown egysegAr;
        private System.Windows.Forms.Button newVegButton;
        private System.Windows.Forms.Button removeVeg;
        private System.Windows.Forms.Button updateFruitButton;
    }
}

