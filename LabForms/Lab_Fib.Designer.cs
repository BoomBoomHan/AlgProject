namespace AlgProject.LabForms
{
	partial class Lab_Fib
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
			this.NumberInput = new System.Windows.Forms.TextBox();
			this.IterationButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.RecursionButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// NumberInput
			// 
			this.NumberInput.Font = new System.Drawing.Font("Times New Roman", 15F);
			this.NumberInput.Location = new System.Drawing.Point(265, 105);
			this.NumberInput.Name = "NumberInput";
			this.NumberInput.Size = new System.Drawing.Size(136, 36);
			this.NumberInput.TabIndex = 0;
			this.NumberInput.TextChanged += new System.EventHandler(this.NumberInput_TextChanged);
			this.NumberInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberInput_KeyPress);
			// 
			// IterationButton
			// 
			this.IterationButton.Font = new System.Drawing.Font("黑体", 11F);
			this.IterationButton.Location = new System.Drawing.Point(294, 248);
			this.IterationButton.Name = "IterationButton";
			this.IterationButton.Size = new System.Drawing.Size(95, 38);
			this.IterationButton.TabIndex = 1;
			this.IterationButton.Text = "迭代";
			this.IterationButton.UseVisualStyleBackColor = true;
			this.IterationButton.Click += new System.EventHandler(this.IterationButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("等线", 12F);
			this.label1.Location = new System.Drawing.Point(116, 115);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(121, 21);
			this.label1.TabIndex = 2;
			this.label1.Text = "请输入n的值";
			// 
			// RecursionButton
			// 
			this.RecursionButton.Font = new System.Drawing.Font("黑体", 11F);
			this.RecursionButton.Location = new System.Drawing.Point(128, 248);
			this.RecursionButton.Name = "RecursionButton";
			this.RecursionButton.Size = new System.Drawing.Size(95, 38);
			this.RecursionButton.TabIndex = 3;
			this.RecursionButton.Text = "递归";
			this.RecursionButton.UseVisualStyleBackColor = true;
			this.RecursionButton.Click += new System.EventHandler(this.RecursionButton_Click);
			// 
			// Lab_Fib
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(551, 367);
			this.Controls.Add(this.RecursionButton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.IterationButton);
			this.Controls.Add(this.NumberInput);
			this.Name = "Lab_Fib";
			this.Text = "Lab_Fib";
			this.Load += new System.EventHandler(this.Lab_Fib_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox NumberInput;
		private System.Windows.Forms.Button IterationButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button RecursionButton;
	}
}