namespace AlgProject.LabForms
{
	partial class Lab_Matrix
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
			this.GenerateButton = new System.Windows.Forms.Button();
			this.NDomain = new System.Windows.Forms.DomainUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.ShowAButton = new System.Windows.Forms.Button();
			this.ShowBButton = new System.Windows.Forms.Button();
			this.ForceButton = new System.Windows.Forms.Button();
			this.StrassenButton = new System.Windows.Forms.Button();
			this.ForceLabel = new System.Windows.Forms.Label();
			this.StrassenLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// GenerateButton
			// 
			this.GenerateButton.Font = new System.Drawing.Font("黑体", 18F);
			this.GenerateButton.Location = new System.Drawing.Point(187, 27);
			this.GenerateButton.Name = "GenerateButton";
			this.GenerateButton.Size = new System.Drawing.Size(405, 107);
			this.GenerateButton.TabIndex = 0;
			this.GenerateButton.Text = "生成矩阵";
			this.GenerateButton.UseVisualStyleBackColor = true;
			this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
			// 
			// NDomain
			// 
			this.NDomain.Font = new System.Drawing.Font("黑体", 15F);
			this.NDomain.Items.Add("256");
			this.NDomain.Items.Add("128");
			this.NDomain.Items.Add("64");
			this.NDomain.Items.Add("32");
			this.NDomain.Items.Add("16");
			this.NDomain.Items.Add("8");
			this.NDomain.Items.Add("4");
			this.NDomain.Items.Add("2");
			this.NDomain.Items.Add("1");
			this.NDomain.Location = new System.Drawing.Point(50, 92);
			this.NDomain.Name = "NDomain";
			this.NDomain.Size = new System.Drawing.Size(98, 42);
			this.NDomain.TabIndex = 1;
			this.NDomain.Text = "8";
			this.NDomain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("黑体", 14F);
			this.label1.Location = new System.Drawing.Point(57, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 28);
			this.label1.TabIndex = 2;
			this.label1.Text = "维度";
			// 
			// ShowAButton
			// 
			this.ShowAButton.Font = new System.Drawing.Font("黑体", 12F);
			this.ShowAButton.Location = new System.Drawing.Point(617, 29);
			this.ShowAButton.Name = "ShowAButton";
			this.ShowAButton.Size = new System.Drawing.Size(148, 48);
			this.ShowAButton.TabIndex = 3;
			this.ShowAButton.Text = "查看矩阵A";
			this.ShowAButton.UseVisualStyleBackColor = true;
			this.ShowAButton.Click += new System.EventHandler(this.ShowAButton_Click);
			// 
			// ShowBButton
			// 
			this.ShowBButton.Font = new System.Drawing.Font("黑体", 12F);
			this.ShowBButton.Location = new System.Drawing.Point(617, 86);
			this.ShowBButton.Name = "ShowBButton";
			this.ShowBButton.Size = new System.Drawing.Size(148, 48);
			this.ShowBButton.TabIndex = 4;
			this.ShowBButton.Text = "查看矩阵B";
			this.ShowBButton.UseVisualStyleBackColor = true;
			this.ShowBButton.Click += new System.EventHandler(this.ShowBButton_Click);
			// 
			// ForceButton
			// 
			this.ForceButton.Font = new System.Drawing.Font("黑体", 18F);
			this.ForceButton.Location = new System.Drawing.Point(62, 303);
			this.ForceButton.Name = "ForceButton";
			this.ForceButton.Size = new System.Drawing.Size(306, 107);
			this.ForceButton.TabIndex = 5;
			this.ForceButton.Text = "蛮力法";
			this.ForceButton.UseVisualStyleBackColor = true;
			this.ForceButton.Click += new System.EventHandler(this.ForceButton_Click);
			// 
			// StrassenButton
			// 
			this.StrassenButton.Font = new System.Drawing.Font("黑体", 18F);
			this.StrassenButton.Location = new System.Drawing.Point(421, 303);
			this.StrassenButton.Name = "StrassenButton";
			this.StrassenButton.Size = new System.Drawing.Size(306, 107);
			this.StrassenButton.TabIndex = 6;
			this.StrassenButton.Text = "斯特拉森算法";
			this.StrassenButton.UseVisualStyleBackColor = true;
			this.StrassenButton.Click += new System.EventHandler(this.StrassenButton_Click);
			// 
			// ForceLabel
			// 
			this.ForceLabel.AutoSize = true;
			this.ForceLabel.Font = new System.Drawing.Font("黑体", 14F);
			this.ForceLabel.Location = new System.Drawing.Point(146, 250);
			this.ForceLabel.Name = "ForceLabel";
			this.ForceLabel.Size = new System.Drawing.Size(138, 28);
			this.ForceLabel.TabIndex = 7;
			this.ForceLabel.Text = "用时：0ms";
			this.ForceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// StrassenLabel
			// 
			this.StrassenLabel.AutoSize = true;
			this.StrassenLabel.Font = new System.Drawing.Font("黑体", 14F);
			this.StrassenLabel.Location = new System.Drawing.Point(502, 250);
			this.StrassenLabel.Name = "StrassenLabel";
			this.StrassenLabel.Size = new System.Drawing.Size(138, 28);
			this.StrassenLabel.TabIndex = 8;
			this.StrassenLabel.Text = "用时：0ms";
			this.StrassenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Lab_Matrix
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.StrassenLabel);
			this.Controls.Add(this.ForceLabel);
			this.Controls.Add(this.StrassenButton);
			this.Controls.Add(this.ForceButton);
			this.Controls.Add(this.ShowBButton);
			this.Controls.Add(this.ShowAButton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.NDomain);
			this.Controls.Add(this.GenerateButton);
			this.Name = "Lab_Matrix";
			this.Text = "Lab_Matrix";
			this.Load += new System.EventHandler(this.Lab_Matrix_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button GenerateButton;
		private System.Windows.Forms.DomainUpDown NDomain;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button ShowAButton;
		private System.Windows.Forms.Button ShowBButton;
		private System.Windows.Forms.Button ForceButton;
		private System.Windows.Forms.Button StrassenButton;
		private System.Windows.Forms.Label ForceLabel;
		private System.Windows.Forms.Label StrassenLabel;
	}
}