namespace AlgProject.LabForms
{
	partial class Lab_Backpack
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab_Backpack));
			this.GenerateStaffCsvButton = new System.Windows.Forms.Button();
			this.TipLabel = new System.Windows.Forms.Label();
			this.BackpackToleranceTextBox = new System.Windows.Forms.TextBox();
			this.ComputeButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// GenerateStaffCsvButton
			// 
			this.GenerateStaffCsvButton.Font = new System.Drawing.Font("黑体", 12F);
			this.GenerateStaffCsvButton.Location = new System.Drawing.Point(73, 28);
			this.GenerateStaffCsvButton.Name = "GenerateStaffCsvButton";
			this.GenerateStaffCsvButton.Size = new System.Drawing.Size(474, 46);
			this.GenerateStaffCsvButton.TabIndex = 0;
			this.GenerateStaffCsvButton.Text = "生成物品表格";
			this.GenerateStaffCsvButton.UseVisualStyleBackColor = true;
			this.GenerateStaffCsvButton.Click += new System.EventHandler(this.GenerateStaffCsvButton_Click);
			// 
			// TipLabel
			// 
			this.TipLabel.AutoSize = true;
			this.TipLabel.Font = new System.Drawing.Font("黑体", 16F);
			this.TipLabel.Location = new System.Drawing.Point(170, 108);
			this.TipLabel.Name = "TipLabel";
			this.TipLabel.Size = new System.Drawing.Size(124, 27);
			this.TipLabel.TabIndex = 1;
			this.TipLabel.Text = "背包负重";
			// 
			// BackpackToleranceTextBox
			// 
			this.BackpackToleranceTextBox.Font = new System.Drawing.Font("黑体", 14F);
			this.BackpackToleranceTextBox.Location = new System.Drawing.Point(330, 101);
			this.BackpackToleranceTextBox.Name = "BackpackToleranceTextBox";
			this.BackpackToleranceTextBox.Size = new System.Drawing.Size(95, 34);
			this.BackpackToleranceTextBox.TabIndex = 2;
			this.BackpackToleranceTextBox.Text = "50";
			// 
			// ComputeButton
			// 
			this.ComputeButton.Font = new System.Drawing.Font("黑体", 12F);
			this.ComputeButton.Location = new System.Drawing.Point(226, 220);
			this.ComputeButton.Name = "ComputeButton";
			this.ComputeButton.Size = new System.Drawing.Size(181, 46);
			this.ComputeButton.TabIndex = 3;
			this.ComputeButton.Text = "计算";
			this.ComputeButton.UseVisualStyleBackColor = true;
			this.ComputeButton.Click += new System.EventHandler(this.ComputeButton_Click);
			// 
			// Lab_Backpack
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(640, 300);
			this.Controls.Add(this.ComputeButton);
			this.Controls.Add(this.BackpackToleranceTextBox);
			this.Controls.Add(this.TipLabel);
			this.Controls.Add(this.GenerateStaffCsvButton);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Lab_Backpack";
			this.Text = "为什么不多来几个背包呢？";
			this.Load += new System.EventHandler(this.Lab_Backpack_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button GenerateStaffCsvButton;
		private System.Windows.Forms.Label TipLabel;
		private System.Windows.Forms.TextBox BackpackToleranceTextBox;
		private System.Windows.Forms.Button ComputeButton;
	}
}