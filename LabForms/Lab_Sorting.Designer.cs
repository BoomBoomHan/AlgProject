namespace AlgProject.LabForms
{
	partial class Lab_Sorting
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab_Sorting));
			this.PathDisplay = new System.Windows.Forms.TextBox();
			this.LoadFromFileButton = new System.Windows.Forms.Button();
			this.ShowButton = new System.Windows.Forms.Button();
			this.GenerateButton = new System.Windows.Forms.Button();
			this.MinLabel = new System.Windows.Forms.Label();
			this.MinTextBox = new System.Windows.Forms.TextBox();
			this.MaxTextBox = new System.Windows.Forms.TextBox();
			this.MaxLabel = new System.Windows.Forms.Label();
			this.LengthTextBox = new System.Windows.Forms.TextBox();
			this.LengthLabel = new System.Windows.Forms.Label();
			this.OpenFileButton = new System.Windows.Forms.Button();
			this.ToolBox = new System.Windows.Forms.GroupBox();
			this.OutputSortStatusButton = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.ParasLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SortingMethodComboBox = new System.Windows.Forms.ComboBox();
			this.ToolBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// PathDisplay
			// 
			this.PathDisplay.Enabled = false;
			this.PathDisplay.Font = new System.Drawing.Font("黑体", 12F);
			this.PathDisplay.Location = new System.Drawing.Point(34, 23);
			this.PathDisplay.Name = "PathDisplay";
			this.PathDisplay.Size = new System.Drawing.Size(515, 30);
			this.PathDisplay.TabIndex = 0;
			this.PathDisplay.TextChanged += new System.EventHandler(this.PathDisplay_TextChanged);
			// 
			// LoadFromFileButton
			// 
			this.LoadFromFileButton.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.LoadFromFileButton.Location = new System.Drawing.Point(679, 23);
			this.LoadFromFileButton.Name = "LoadFromFileButton";
			this.LoadFromFileButton.Size = new System.Drawing.Size(118, 30);
			this.LoadFromFileButton.TabIndex = 1;
			this.LoadFromFileButton.Text = "输入数组";
			this.LoadFromFileButton.UseVisualStyleBackColor = true;
			this.LoadFromFileButton.Click += new System.EventHandler(this.LoadFromFileButton_Click);
			// 
			// ShowButton
			// 
			this.ShowButton.Font = new System.Drawing.Font("黑体", 12F);
			this.ShowButton.Location = new System.Drawing.Point(6, 35);
			this.ShowButton.Name = "ShowButton";
			this.ShowButton.Size = new System.Drawing.Size(213, 44);
			this.ShowButton.TabIndex = 2;
			this.ShowButton.Text = "显示数组";
			this.ShowButton.UseVisualStyleBackColor = true;
			this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
			// 
			// GenerateButton
			// 
			this.GenerateButton.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.GenerateButton.Location = new System.Drawing.Point(679, 59);
			this.GenerateButton.Name = "GenerateButton";
			this.GenerateButton.Size = new System.Drawing.Size(118, 30);
			this.GenerateButton.TabIndex = 3;
			this.GenerateButton.Text = "生成数组";
			this.GenerateButton.UseVisualStyleBackColor = true;
			this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
			// 
			// MinLabel
			// 
			this.MinLabel.AutoSize = true;
			this.MinLabel.Font = new System.Drawing.Font("黑体", 12F);
			this.MinLabel.Location = new System.Drawing.Point(30, 63);
			this.MinLabel.Name = "MinLabel";
			this.MinLabel.Size = new System.Drawing.Size(69, 20);
			this.MinLabel.TabIndex = 4;
			this.MinLabel.Text = "最小值";
			// 
			// MinTextBox
			// 
			this.MinTextBox.Font = new System.Drawing.Font("黑体", 12F);
			this.MinTextBox.Location = new System.Drawing.Point(105, 58);
			this.MinTextBox.Name = "MinTextBox";
			this.MinTextBox.Size = new System.Drawing.Size(126, 30);
			this.MinTextBox.TabIndex = 5;
			this.MinTextBox.Text = "1";
			this.MinTextBox.TextChanged += new System.EventHandler(this.MinTextBox_TextChanged);
			// 
			// MaxTextBox
			// 
			this.MaxTextBox.Font = new System.Drawing.Font("黑体", 12F);
			this.MaxTextBox.Location = new System.Drawing.Point(337, 58);
			this.MaxTextBox.Name = "MaxTextBox";
			this.MaxTextBox.Size = new System.Drawing.Size(126, 30);
			this.MaxTextBox.TabIndex = 7;
			this.MaxTextBox.Text = "15";
			this.MaxTextBox.TextChanged += new System.EventHandler(this.MaxTextBox_TextChanged);
			// 
			// MaxLabel
			// 
			this.MaxLabel.AutoSize = true;
			this.MaxLabel.Font = new System.Drawing.Font("黑体", 12F);
			this.MaxLabel.Location = new System.Drawing.Point(262, 63);
			this.MaxLabel.Name = "MaxLabel";
			this.MaxLabel.Size = new System.Drawing.Size(69, 20);
			this.MaxLabel.TabIndex = 6;
			this.MaxLabel.Text = "最大值";
			// 
			// LengthTextBox
			// 
			this.LengthTextBox.Font = new System.Drawing.Font("黑体", 12F);
			this.LengthTextBox.Location = new System.Drawing.Point(547, 59);
			this.LengthTextBox.Name = "LengthTextBox";
			this.LengthTextBox.Size = new System.Drawing.Size(126, 30);
			this.LengthTextBox.TabIndex = 9;
			this.LengthTextBox.TextChanged += new System.EventHandler(this.LengthTextBox_TextChanged);
			// 
			// LengthLabel
			// 
			this.LengthLabel.AutoSize = true;
			this.LengthLabel.Font = new System.Drawing.Font("黑体", 12F);
			this.LengthLabel.Location = new System.Drawing.Point(492, 63);
			this.LengthLabel.Name = "LengthLabel";
			this.LengthLabel.Size = new System.Drawing.Size(49, 20);
			this.LengthLabel.TabIndex = 8;
			this.LengthLabel.Text = "长度";
			// 
			// OpenFileButton
			// 
			this.OpenFileButton.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.OpenFileButton.Location = new System.Drawing.Point(555, 23);
			this.OpenFileButton.Name = "OpenFileButton";
			this.OpenFileButton.Size = new System.Drawing.Size(118, 30);
			this.OpenFileButton.TabIndex = 10;
			this.OpenFileButton.Text = "选择文件";
			this.OpenFileButton.UseVisualStyleBackColor = true;
			this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
			// 
			// ToolBox
			// 
			this.ToolBox.Controls.Add(this.SortingMethodComboBox);
			this.ToolBox.Controls.Add(this.label2);
			this.ToolBox.Controls.Add(this.textBox1);
			this.ToolBox.Controls.Add(this.label1);
			this.ToolBox.Controls.Add(this.ParasLabel);
			this.ToolBox.Controls.Add(this.button10);
			this.ToolBox.Controls.Add(this.button9);
			this.ToolBox.Controls.Add(this.button8);
			this.ToolBox.Controls.Add(this.button7);
			this.ToolBox.Controls.Add(this.button6);
			this.ToolBox.Controls.Add(this.button5);
			this.ToolBox.Controls.Add(this.button4);
			this.ToolBox.Controls.Add(this.button3);
			this.ToolBox.Controls.Add(this.button2);
			this.ToolBox.Controls.Add(this.OutputSortStatusButton);
			this.ToolBox.Controls.Add(this.ShowButton);
			this.ToolBox.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Bold);
			this.ToolBox.Location = new System.Drawing.Point(34, 122);
			this.ToolBox.Name = "ToolBox";
			this.ToolBox.Size = new System.Drawing.Size(731, 307);
			this.ToolBox.TabIndex = 11;
			this.ToolBox.TabStop = false;
			this.ToolBox.Text = "工具栏";
			// 
			// OutputSortStatusButton
			// 
			this.OutputSortStatusButton.Font = new System.Drawing.Font("黑体", 12F);
			this.OutputSortStatusButton.Location = new System.Drawing.Point(6, 94);
			this.OutputSortStatusButton.Name = "OutputSortStatusButton";
			this.OutputSortStatusButton.Size = new System.Drawing.Size(213, 44);
			this.OutputSortStatusButton.TabIndex = 3;
			this.OutputSortStatusButton.Text = "输出排序状态";
			this.OutputSortStatusButton.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("黑体", 12F);
			this.button2.Location = new System.Drawing.Point(267, 139);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(213, 44);
			this.button2.TabIndex = 4;
			this.button2.Text = "显示数组";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("黑体", 12F);
			this.button3.Location = new System.Drawing.Point(275, 147);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(213, 44);
			this.button3.TabIndex = 5;
			this.button3.Text = "显示数组";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("黑体", 12F);
			this.button4.Location = new System.Drawing.Point(283, 155);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(213, 44);
			this.button4.TabIndex = 6;
			this.button4.Text = "显示数组";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.Font = new System.Drawing.Font("黑体", 12F);
			this.button5.Location = new System.Drawing.Point(291, 163);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(213, 44);
			this.button5.TabIndex = 7;
			this.button5.Text = "显示数组";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// button6
			// 
			this.button6.Font = new System.Drawing.Font("黑体", 12F);
			this.button6.Location = new System.Drawing.Point(299, 171);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(213, 44);
			this.button6.TabIndex = 8;
			this.button6.Text = "显示数组";
			this.button6.UseVisualStyleBackColor = true;
			// 
			// button7
			// 
			this.button7.Font = new System.Drawing.Font("黑体", 12F);
			this.button7.Location = new System.Drawing.Point(307, 179);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(213, 44);
			this.button7.TabIndex = 9;
			this.button7.Text = "显示数组";
			this.button7.UseVisualStyleBackColor = true;
			// 
			// button8
			// 
			this.button8.Font = new System.Drawing.Font("黑体", 12F);
			this.button8.Location = new System.Drawing.Point(315, 187);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(213, 44);
			this.button8.TabIndex = 10;
			this.button8.Text = "显示数组";
			this.button8.UseVisualStyleBackColor = true;
			// 
			// button9
			// 
			this.button9.Font = new System.Drawing.Font("黑体", 12F);
			this.button9.Location = new System.Drawing.Point(323, 195);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(213, 44);
			this.button9.TabIndex = 11;
			this.button9.Text = "显示数组";
			this.button9.UseVisualStyleBackColor = true;
			// 
			// button10
			// 
			this.button10.Font = new System.Drawing.Font("黑体", 12F);
			this.button10.Location = new System.Drawing.Point(512, 35);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(213, 44);
			this.button10.TabIndex = 12;
			this.button10.Text = "显示数组";
			this.button10.UseVisualStyleBackColor = true;
			// 
			// ParasLabel
			// 
			this.ParasLabel.AutoSize = true;
			this.ParasLabel.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Bold);
			this.ParasLabel.Location = new System.Drawing.Point(6, 214);
			this.ParasLabel.Name = "ParasLabel";
			this.ParasLabel.Size = new System.Drawing.Size(66, 25);
			this.ParasLabel.TabIndex = 13;
			this.ParasLabel.Text = "参数";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("黑体", 12F);
			this.label1.Location = new System.Drawing.Point(6, 262);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 20);
			this.label1.TabIndex = 14;
			this.label1.Text = "查找元素";
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("黑体", 12F);
			this.textBox1.Location = new System.Drawing.Point(101, 256);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(78, 30);
			this.textBox1.TabIndex = 12;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("黑体", 12F);
			this.label2.Location = new System.Drawing.Point(208, 262);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 20);
			this.label2.TabIndex = 15;
			this.label2.Text = "排序方式";
			// 
			// SortingMethodComboBox
			// 
			this.SortingMethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.SortingMethodComboBox.Font = new System.Drawing.Font("黑体", 12F);
			this.SortingMethodComboBox.FormattingEnabled = true;
			this.SortingMethodComboBox.Items.AddRange(new object[] {
            "升序",
            "降序"});
			this.SortingMethodComboBox.Location = new System.Drawing.Point(307, 257);
			this.SortingMethodComboBox.Name = "SortingMethodComboBox";
			this.SortingMethodComboBox.Size = new System.Drawing.Size(121, 28);
			this.SortingMethodComboBox.TabIndex = 16;
			// 
			// Lab_Sorting
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.ToolBox);
			this.Controls.Add(this.OpenFileButton);
			this.Controls.Add(this.LengthTextBox);
			this.Controls.Add(this.LengthLabel);
			this.Controls.Add(this.MaxTextBox);
			this.Controls.Add(this.MaxLabel);
			this.Controls.Add(this.MinTextBox);
			this.Controls.Add(this.MinLabel);
			this.Controls.Add(this.GenerateButton);
			this.Controls.Add(this.LoadFromFileButton);
			this.Controls.Add(this.PathDisplay);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Lab_Sorting";
			this.Text = "混乱滋生于秩序";
			this.Load += new System.EventHandler(this.Lab_Sorting_Load);
			this.ToolBox.ResumeLayout(false);
			this.ToolBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox PathDisplay;
		private System.Windows.Forms.Button LoadFromFileButton;
		private System.Windows.Forms.Button ShowButton;
		private System.Windows.Forms.Button GenerateButton;
		private System.Windows.Forms.Label MinLabel;
		private System.Windows.Forms.TextBox MinTextBox;
		private System.Windows.Forms.TextBox MaxTextBox;
		private System.Windows.Forms.Label MaxLabel;
		private System.Windows.Forms.TextBox LengthTextBox;
		private System.Windows.Forms.Label LengthLabel;
		private System.Windows.Forms.Button OpenFileButton;
		private System.Windows.Forms.GroupBox ToolBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label ParasLabel;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button OutputSortStatusButton;
		private System.Windows.Forms.ComboBox SortingMethodComboBox;
	}
}