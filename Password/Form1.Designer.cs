﻿namespace Password
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnEnterLength = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.numericUpDownLength = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.txtResult = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownLength)).BeginInit();
			this.SuspendLayout();
			// 
			// btnEnterLength
			// 
			this.btnEnterLength.Location = new System.Drawing.Point(243, 23);
			this.btnEnterLength.Name = "btnEnterLength";
			this.btnEnterLength.Size = new System.Drawing.Size(98, 23);
			this.btnEnterLength.TabIndex = 0;
			this.btnEnterLength.Text = "Create";
			this.btnEnterLength.UseVisualStyleBackColor = true;
			this.btnEnterLength.Click += new System.EventHandler(this.btnEnterLength_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Length:";
			// 
			// numericUpDownLength
			// 
			this.numericUpDownLength.Location = new System.Drawing.Point(103, 23);
			this.numericUpDownLength.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
			this.numericUpDownLength.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
			this.numericUpDownLength.Name = "numericUpDownLength";
			this.numericUpDownLength.Size = new System.Drawing.Size(120, 23);
			this.numericUpDownLength.TabIndex = 2;
			this.numericUpDownLength.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 15);
			this.label2.TabIndex = 3;
			this.label2.Text = "Result:";
			// 
			// txtResult
			// 
			this.txtResult.ForeColor = System.Drawing.Color.RosyBrown;
			this.txtResult.Location = new System.Drawing.Point(103, 64);
			this.txtResult.Name = "txtResult";
			this.txtResult.ReadOnly = true;
			this.txtResult.Size = new System.Drawing.Size(238, 23);
			this.txtResult.TabIndex = 4;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(365, 102);
			this.Controls.Add(this.txtResult);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.numericUpDownLength);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnEnterLength);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Hu Pass";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownLength)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Button btnEnterLength;
		private Label label1;
		private NumericUpDown numericUpDownLength;
		private Label label2;
		private TextBox txtResult;
	}
}