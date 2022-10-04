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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab_Fib));
			this.NumberInput = new System.Windows.Forms.TextBox();
			this.IterationButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.RecursionButton = new System.Windows.Forms.Button();
			this.Tip = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// NumberInput
			// 
			this.NumberInput.Font = new System.Drawing.Font("Times New Roman", 15F);
			this.NumberInput.Location = new System.Drawing.Point(298, 126);
			this.NumberInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.NumberInput.Name = "NumberInput";
			this.NumberInput.Size = new System.Drawing.Size(152, 42);
			this.NumberInput.TabIndex = 0;
			this.NumberInput.TextChanged += new System.EventHandler(this.NumberInput_TextChanged);
			this.NumberInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberInput_KeyPress);
			// 
			// IterationButton
			// 
			this.IterationButton.Font = new System.Drawing.Font("黑体", 11F);
			this.IterationButton.Location = new System.Drawing.Point(331, 298);
			this.IterationButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.IterationButton.Name = "IterationButton";
			this.IterationButton.Size = new System.Drawing.Size(107, 46);
			this.IterationButton.TabIndex = 1;
			this.IterationButton.Text = "迭代";
			this.IterationButton.UseVisualStyleBackColor = true;
			this.IterationButton.Click += new System.EventHandler(this.IterationButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("等线", 12F);
			this.label1.Location = new System.Drawing.Point(130, 138);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(145, 25);
			this.label1.TabIndex = 2;
			this.label1.Text = "请输入n的值";
			// 
			// RecursionButton
			// 
			this.RecursionButton.Font = new System.Drawing.Font("黑体", 11F);
			this.RecursionButton.Location = new System.Drawing.Point(144, 298);
			this.RecursionButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.RecursionButton.Name = "RecursionButton";
			this.RecursionButton.Size = new System.Drawing.Size(107, 46);
			this.RecursionButton.TabIndex = 3;
			this.RecursionButton.Text = "递归";
			this.RecursionButton.UseVisualStyleBackColor = true;
			this.RecursionButton.Click += new System.EventHandler(this.RecursionButton_Click);
			// 
			// Tip
			// 
			this.Tip.AutoSize = true;
			this.Tip.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Tip.Location = new System.Drawing.Point(228, 221);
			this.Tip.Name = "Tip";
			this.Tip.Size = new System.Drawing.Size(130, 24);
			this.Tip.TabIndex = 4;
			this.Tip.Text = "正在计算中";
			this.Tip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Tip.Visible = false;
			// 
			// Lab_Fib
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(618, 394);
			this.Controls.Add(this.Tip);
			this.Controls.Add(this.RecursionButton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.IterationButton);
			this.Controls.Add(this.NumberInput);
			this.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "Lab_Fib";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "斐波那契的折磨";
			this.Load += new System.EventHandler(this.Lab_Fib_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox NumberInput;
		private System.Windows.Forms.Button IterationButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button RecursionButton;
		private System.Windows.Forms.Label Tip;
	}
}