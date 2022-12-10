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
			this.ExtrasLabel = new System.Windows.Forms.Label();
			this.ComputeHalfMinButton = new System.Windows.Forms.Button();
			this.ComputeMaxButton = new System.Windows.Forms.Button();
			this.OverrideLabel2 = new System.Windows.Forms.Label();
			this.OverrideCheckBox2 = new System.Windows.Forms.CheckBox();
			this.OverrideTextBox2 = new System.Windows.Forms.TextBox();
			this.OverrideTextBox1 = new System.Windows.Forms.TextBox();
			this.OverrideLabel1 = new System.Windows.Forms.Label();
			this.OverrideCheckBox1 = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// NumberInput
			// 
			this.NumberInput.Font = new System.Drawing.Font("Times New Roman", 15F);
			this.NumberInput.Location = new System.Drawing.Point(298, 126);
			this.NumberInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.NumberInput.Name = "NumberInput";
			this.NumberInput.Size = new System.Drawing.Size(152, 36);
			this.NumberInput.TabIndex = 0;
			this.NumberInput.TextChanged += new System.EventHandler(this.NumberInput_TextChanged);
			this.NumberInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberInput_KeyPress);
			// 
			// IterationButton
			// 
			this.IterationButton.Font = new System.Drawing.Font("黑体", 11F);
			this.IterationButton.Location = new System.Drawing.Point(331, 181);
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
			this.label1.Size = new System.Drawing.Size(121, 21);
			this.label1.TabIndex = 2;
			this.label1.Text = "请输入n的值";
			// 
			// RecursionButton
			// 
			this.RecursionButton.Font = new System.Drawing.Font("黑体", 11F);
			this.RecursionButton.Location = new System.Drawing.Point(144, 181);
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
			this.Tip.Location = new System.Drawing.Point(12, 25);
			this.Tip.Name = "Tip";
			this.Tip.Size = new System.Drawing.Size(109, 20);
			this.Tip.TabIndex = 4;
			this.Tip.Text = "正在计算中";
			this.Tip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ExtrasLabel
			// 
			this.ExtrasLabel.AutoSize = true;
			this.ExtrasLabel.Font = new System.Drawing.Font("等线", 12F);
			this.ExtrasLabel.Location = new System.Drawing.Point(216, 254);
			this.ExtrasLabel.Name = "ExtrasLabel";
			this.ExtrasLabel.Size = new System.Drawing.Size(150, 21);
			this.ExtrasLabel.TabIndex = 5;
			this.ExtrasLabel.Text = "实验二扩展内容";
			// 
			// ComputeHalfMinButton
			// 
			this.ComputeHalfMinButton.Font = new System.Drawing.Font("黑体", 11F);
			this.ComputeHalfMinButton.Location = new System.Drawing.Point(144, 357);
			this.ComputeHalfMinButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.ComputeHalfMinButton.Name = "ComputeHalfMinButton";
			this.ComputeHalfMinButton.Size = new System.Drawing.Size(294, 60);
			this.ComputeHalfMinButton.TabIndex = 6;
			this.ComputeHalfMinButton.Text = "计算本机30秒内可计算的最大斐波那契数(递归)";
			this.ComputeHalfMinButton.UseVisualStyleBackColor = true;
			this.ComputeHalfMinButton.Click += new System.EventHandler(this.ComputeHalfMinButton_Click);
			// 
			// ComputeMaxButton
			// 
			this.ComputeMaxButton.Font = new System.Drawing.Font("黑体", 11F);
			this.ComputeMaxButton.Location = new System.Drawing.Point(144, 289);
			this.ComputeMaxButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.ComputeMaxButton.Name = "ComputeMaxButton";
			this.ComputeMaxButton.Size = new System.Drawing.Size(294, 60);
			this.ComputeMaxButton.TabIndex = 7;
			this.ComputeMaxButton.Text = "检测60秒内能否计算本机支持的最大斐波那契数列(递归)";
			this.ComputeMaxButton.UseVisualStyleBackColor = true;
			this.ComputeMaxButton.Click += new System.EventHandler(this.ComputeMaxButton_Click);
			// 
			// OverrideLabel2
			// 
			this.OverrideLabel2.AutoSize = true;
			this.OverrideLabel2.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.OverrideLabel2.Location = new System.Drawing.Point(441, 390);
			this.OverrideLabel2.Name = "OverrideLabel2";
			this.OverrideLabel2.Size = new System.Drawing.Size(71, 15);
			this.OverrideLabel2.TabIndex = 9;
			this.OverrideLabel2.Text = "最大时间";
			this.OverrideLabel2.Visible = false;
			// 
			// OverrideCheckBox2
			// 
			this.OverrideCheckBox2.AutoSize = true;
			this.OverrideCheckBox2.Location = new System.Drawing.Point(444, 357);
			this.OverrideCheckBox2.Name = "OverrideCheckBox2";
			this.OverrideCheckBox2.Size = new System.Drawing.Size(157, 19);
			this.OverrideCheckBox2.TabIndex = 8;
			this.OverrideCheckBox2.Tag = "2";
			this.OverrideCheckBox2.Text = "重载最大时间参数";
			this.OverrideCheckBox2.UseVisualStyleBackColor = true;
			// 
			// OverrideTextBox2
			// 
			this.OverrideTextBox2.Font = new System.Drawing.Font("Times New Roman", 15F);
			this.OverrideTextBox2.Location = new System.Drawing.Point(513, 378);
			this.OverrideTextBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.OverrideTextBox2.Name = "OverrideTextBox2";
			this.OverrideTextBox2.Size = new System.Drawing.Size(93, 36);
			this.OverrideTextBox2.TabIndex = 10;
			this.OverrideTextBox2.Visible = false;
			// 
			// OverrideTextBox1
			// 
			this.OverrideTextBox1.Font = new System.Drawing.Font("Times New Roman", 15F);
			this.OverrideTextBox1.Location = new System.Drawing.Point(513, 310);
			this.OverrideTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.OverrideTextBox1.Name = "OverrideTextBox1";
			this.OverrideTextBox1.Size = new System.Drawing.Size(93, 36);
			this.OverrideTextBox1.TabIndex = 13;
			this.OverrideTextBox1.Visible = false;
			// 
			// OverrideLabel1
			// 
			this.OverrideLabel1.AutoSize = true;
			this.OverrideLabel1.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.OverrideLabel1.Location = new System.Drawing.Point(441, 322);
			this.OverrideLabel1.Name = "OverrideLabel1";
			this.OverrideLabel1.Size = new System.Drawing.Size(71, 15);
			this.OverrideLabel1.TabIndex = 12;
			this.OverrideLabel1.Text = "最大时间";
			this.OverrideLabel1.Visible = false;
			// 
			// OverrideCheckBox1
			// 
			this.OverrideCheckBox1.AutoSize = true;
			this.OverrideCheckBox1.Location = new System.Drawing.Point(444, 289);
			this.OverrideCheckBox1.Name = "OverrideCheckBox1";
			this.OverrideCheckBox1.Size = new System.Drawing.Size(157, 19);
			this.OverrideCheckBox1.TabIndex = 11;
			this.OverrideCheckBox1.Tag = "1";
			this.OverrideCheckBox1.Text = "重载最大时间参数";
			this.OverrideCheckBox1.UseVisualStyleBackColor = true;
			// 
			// Lab_Fib
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(618, 431);
			this.Controls.Add(this.OverrideTextBox1);
			this.Controls.Add(this.OverrideLabel1);
			this.Controls.Add(this.OverrideCheckBox1);
			this.Controls.Add(this.OverrideTextBox2);
			this.Controls.Add(this.OverrideLabel2);
			this.Controls.Add(this.OverrideCheckBox2);
			this.Controls.Add(this.ComputeMaxButton);
			this.Controls.Add(this.ComputeHalfMinButton);
			this.Controls.Add(this.ExtrasLabel);
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
        private System.Windows.Forms.Label ExtrasLabel;
		private System.Windows.Forms.Button ComputeHalfMinButton;
		private System.Windows.Forms.Button ComputeMaxButton;
		private System.Windows.Forms.Label OverrideLabel2;
		private System.Windows.Forms.CheckBox OverrideCheckBox2;
		private System.Windows.Forms.TextBox OverrideTextBox2;
		private System.Windows.Forms.TextBox OverrideTextBox1;
		private System.Windows.Forms.Label OverrideLabel1;
		private System.Windows.Forms.CheckBox OverrideCheckBox1;
	}
}