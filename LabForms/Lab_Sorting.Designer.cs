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
			this.SearchingMethodComboBox = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.TargetTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.ParasLabel = new System.Windows.Forms.Label();
			this.ThreePointSearchButton = new System.Windows.Forms.Button();
			this.SortButton = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.SearchButton = new System.Windows.Forms.Button();
			this.OutputSortStatusButton = new System.Windows.Forms.Button();
			this.SortingMethodComboBox = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.ToolBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// PathDisplay
			// 
			this.PathDisplay.Enabled = false;
			this.PathDisplay.Font = new System.Drawing.Font("黑体", 12F);
			this.PathDisplay.Location = new System.Drawing.Point(38, 28);
			this.PathDisplay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.PathDisplay.Name = "PathDisplay";
			this.PathDisplay.Size = new System.Drawing.Size(579, 35);
			this.PathDisplay.TabIndex = 0;
			this.PathDisplay.TextChanged += new System.EventHandler(this.PathDisplay_TextChanged);
			// 
			// LoadFromFileButton
			// 
			this.LoadFromFileButton.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.LoadFromFileButton.Location = new System.Drawing.Point(764, 28);
			this.LoadFromFileButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.LoadFromFileButton.Name = "LoadFromFileButton";
			this.LoadFromFileButton.Size = new System.Drawing.Size(133, 36);
			this.LoadFromFileButton.TabIndex = 1;
			this.LoadFromFileButton.Text = "输入数组";
			this.LoadFromFileButton.UseVisualStyleBackColor = true;
			this.LoadFromFileButton.Click += new System.EventHandler(this.LoadFromFileButton_Click);
			// 
			// ShowButton
			// 
			this.ShowButton.Font = new System.Drawing.Font("黑体", 12F);
			this.ShowButton.Location = new System.Drawing.Point(7, 42);
			this.ShowButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.ShowButton.Name = "ShowButton";
			this.ShowButton.Size = new System.Drawing.Size(240, 53);
			this.ShowButton.TabIndex = 2;
			this.ShowButton.Text = "显示数组";
			this.ShowButton.UseVisualStyleBackColor = true;
			this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
			// 
			// GenerateButton
			// 
			this.GenerateButton.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.GenerateButton.Location = new System.Drawing.Point(764, 71);
			this.GenerateButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.GenerateButton.Name = "GenerateButton";
			this.GenerateButton.Size = new System.Drawing.Size(133, 36);
			this.GenerateButton.TabIndex = 3;
			this.GenerateButton.Text = "生成数组";
			this.GenerateButton.UseVisualStyleBackColor = true;
			this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
			// 
			// MinLabel
			// 
			this.MinLabel.AutoSize = true;
			this.MinLabel.Font = new System.Drawing.Font("黑体", 12F);
			this.MinLabel.Location = new System.Drawing.Point(34, 76);
			this.MinLabel.Name = "MinLabel";
			this.MinLabel.Size = new System.Drawing.Size(82, 24);
			this.MinLabel.TabIndex = 4;
			this.MinLabel.Text = "最小值";
			// 
			// MinTextBox
			// 
			this.MinTextBox.Font = new System.Drawing.Font("黑体", 12F);
			this.MinTextBox.Location = new System.Drawing.Point(118, 70);
			this.MinTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MinTextBox.Name = "MinTextBox";
			this.MinTextBox.Size = new System.Drawing.Size(141, 35);
			this.MinTextBox.TabIndex = 5;
			this.MinTextBox.Text = "1";
			this.MinTextBox.TextChanged += new System.EventHandler(this.MinTextBox_TextChanged);
			// 
			// MaxTextBox
			// 
			this.MaxTextBox.Font = new System.Drawing.Font("黑体", 12F);
			this.MaxTextBox.Location = new System.Drawing.Point(379, 70);
			this.MaxTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaxTextBox.Name = "MaxTextBox";
			this.MaxTextBox.Size = new System.Drawing.Size(141, 35);
			this.MaxTextBox.TabIndex = 7;
			this.MaxTextBox.Text = "15";
			this.MaxTextBox.TextChanged += new System.EventHandler(this.MaxTextBox_TextChanged);
			// 
			// MaxLabel
			// 
			this.MaxLabel.AutoSize = true;
			this.MaxLabel.Font = new System.Drawing.Font("黑体", 12F);
			this.MaxLabel.Location = new System.Drawing.Point(295, 76);
			this.MaxLabel.Name = "MaxLabel";
			this.MaxLabel.Size = new System.Drawing.Size(82, 24);
			this.MaxLabel.TabIndex = 6;
			this.MaxLabel.Text = "最大值";
			// 
			// LengthTextBox
			// 
			this.LengthTextBox.Font = new System.Drawing.Font("黑体", 12F);
			this.LengthTextBox.Location = new System.Drawing.Point(615, 71);
			this.LengthTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.LengthTextBox.Name = "LengthTextBox";
			this.LengthTextBox.Size = new System.Drawing.Size(141, 35);
			this.LengthTextBox.TabIndex = 9;
			this.LengthTextBox.TextChanged += new System.EventHandler(this.LengthTextBox_TextChanged);
			// 
			// LengthLabel
			// 
			this.LengthLabel.AutoSize = true;
			this.LengthLabel.Font = new System.Drawing.Font("黑体", 12F);
			this.LengthLabel.Location = new System.Drawing.Point(554, 76);
			this.LengthLabel.Name = "LengthLabel";
			this.LengthLabel.Size = new System.Drawing.Size(58, 24);
			this.LengthLabel.TabIndex = 8;
			this.LengthLabel.Text = "长度";
			// 
			// OpenFileButton
			// 
			this.OpenFileButton.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.OpenFileButton.Location = new System.Drawing.Point(624, 28);
			this.OpenFileButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.OpenFileButton.Name = "OpenFileButton";
			this.OpenFileButton.Size = new System.Drawing.Size(133, 36);
			this.OpenFileButton.TabIndex = 10;
			this.OpenFileButton.Text = "选择文件";
			this.OpenFileButton.UseVisualStyleBackColor = true;
			this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
			// 
			// ToolBox
			// 
			this.ToolBox.Controls.Add(this.SortingMethodComboBox);
			this.ToolBox.Controls.Add(this.label3);
			this.ToolBox.Controls.Add(this.SearchingMethodComboBox);
			this.ToolBox.Controls.Add(this.label2);
			this.ToolBox.Controls.Add(this.TargetTextBox);
			this.ToolBox.Controls.Add(this.label1);
			this.ToolBox.Controls.Add(this.ParasLabel);
			this.ToolBox.Controls.Add(this.ThreePointSearchButton);
			this.ToolBox.Controls.Add(this.SortButton);
			this.ToolBox.Controls.Add(this.button7);
			this.ToolBox.Controls.Add(this.button4);
			this.ToolBox.Controls.Add(this.button3);
			this.ToolBox.Controls.Add(this.SearchButton);
			this.ToolBox.Controls.Add(this.OutputSortStatusButton);
			this.ToolBox.Controls.Add(this.ShowButton);
			this.ToolBox.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Bold);
			this.ToolBox.Location = new System.Drawing.Point(38, 146);
			this.ToolBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.ToolBox.Name = "ToolBox";
			this.ToolBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.ToolBox.Size = new System.Drawing.Size(822, 368);
			this.ToolBox.TabIndex = 11;
			this.ToolBox.TabStop = false;
			this.ToolBox.Text = "工具栏";
			// 
			// SearchingMethodComboBox
			// 
			this.SearchingMethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.SearchingMethodComboBox.Font = new System.Drawing.Font("黑体", 12F);
			this.SearchingMethodComboBox.FormattingEnabled = true;
			this.SearchingMethodComboBox.Items.AddRange(new object[] {
            "顺序检索",
            "二分检索"});
			this.SearchingMethodComboBox.Location = new System.Drawing.Point(345, 308);
			this.SearchingMethodComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.SearchingMethodComboBox.Name = "SearchingMethodComboBox";
			this.SearchingMethodComboBox.Size = new System.Drawing.Size(136, 32);
			this.SearchingMethodComboBox.TabIndex = 16;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("黑体", 12F);
			this.label2.Location = new System.Drawing.Point(234, 314);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(106, 24);
			this.label2.TabIndex = 15;
			this.label2.Text = "检索方式";
			// 
			// TargetTextBox
			// 
			this.TargetTextBox.Font = new System.Drawing.Font("黑体", 12F);
			this.TargetTextBox.Location = new System.Drawing.Point(114, 307);
			this.TargetTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.TargetTextBox.Name = "TargetTextBox";
			this.TargetTextBox.Size = new System.Drawing.Size(87, 35);
			this.TargetTextBox.TabIndex = 12;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("黑体", 12F);
			this.label1.Location = new System.Drawing.Point(7, 314);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(106, 24);
			this.label1.TabIndex = 14;
			this.label1.Text = "查找元素";
			// 
			// ParasLabel
			// 
			this.ParasLabel.AutoSize = true;
			this.ParasLabel.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Bold);
			this.ParasLabel.Location = new System.Drawing.Point(7, 257);
			this.ParasLabel.Name = "ParasLabel";
			this.ParasLabel.Size = new System.Drawing.Size(75, 30);
			this.ParasLabel.TabIndex = 13;
			this.ParasLabel.Text = "参数";
			// 
			// ThreePointSearchButton
			// 
			this.ThreePointSearchButton.BackColor = System.Drawing.Color.Gold;
			this.ThreePointSearchButton.Font = new System.Drawing.Font("黑体", 12F);
			this.ThreePointSearchButton.Location = new System.Drawing.Point(291, 113);
			this.ThreePointSearchButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.ThreePointSearchButton.Name = "ThreePointSearchButton";
			this.ThreePointSearchButton.Size = new System.Drawing.Size(240, 53);
			this.ThreePointSearchButton.TabIndex = 12;
			this.ThreePointSearchButton.Text = "三分检索(💎)";
			this.ThreePointSearchButton.UseVisualStyleBackColor = false;
			this.ThreePointSearchButton.Click += new System.EventHandler(this.ThreePointSearchButton_Click);
			// 
			// SortButton
			// 
			this.SortButton.Font = new System.Drawing.Font("黑体", 12F);
			this.SortButton.Location = new System.Drawing.Point(7, 186);
			this.SortButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.SortButton.Name = "SortButton";
			this.SortButton.Size = new System.Drawing.Size(240, 53);
			this.SortButton.TabIndex = 11;
			this.SortButton.Text = "排序";
			this.SortButton.UseVisualStyleBackColor = true;
			this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
			// 
			// button7
			// 
			this.button7.Font = new System.Drawing.Font("黑体", 12F);
			this.button7.Location = new System.Drawing.Point(577, 42);
			this.button7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(240, 53);
			this.button7.TabIndex = 9;
			this.button7.Text = "给我一吱雄鹰";
			this.button7.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("黑体", 12F);
			this.button4.Location = new System.Drawing.Point(577, 113);
			this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(240, 53);
			this.button4.TabIndex = 6;
			this.button4.Text = "给我一呲邂逅";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("黑体", 12F);
			this.button3.Location = new System.Drawing.Point(577, 186);
			this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(240, 53);
			this.button3.TabIndex = 5;
			this.button3.Text = "套马的______";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// SearchButton
			// 
			this.SearchButton.Font = new System.Drawing.Font("黑体", 12F);
			this.SearchButton.Location = new System.Drawing.Point(291, 42);
			this.SearchButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.SearchButton.Name = "SearchButton";
			this.SearchButton.Size = new System.Drawing.Size(240, 53);
			this.SearchButton.TabIndex = 4;
			this.SearchButton.Text = "检索值";
			this.SearchButton.UseVisualStyleBackColor = true;
			this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
			// 
			// OutputSortStatusButton
			// 
			this.OutputSortStatusButton.Font = new System.Drawing.Font("黑体", 12F);
			this.OutputSortStatusButton.Location = new System.Drawing.Point(7, 113);
			this.OutputSortStatusButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.OutputSortStatusButton.Name = "OutputSortStatusButton";
			this.OutputSortStatusButton.Size = new System.Drawing.Size(240, 53);
			this.OutputSortStatusButton.TabIndex = 3;
			this.OutputSortStatusButton.Text = "输出当前排序状态";
			this.OutputSortStatusButton.UseVisualStyleBackColor = true;
			this.OutputSortStatusButton.Click += new System.EventHandler(this.OutputSortStatusButton_Click);
			// 
			// SortingMethodComboBox
			// 
			this.SortingMethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.SortingMethodComboBox.Font = new System.Drawing.Font("黑体", 12F);
			this.SortingMethodComboBox.FormattingEnabled = true;
			this.SortingMethodComboBox.Items.AddRange(new object[] {
            "冒泡排序",
            "选择排序"});
			this.SortingMethodComboBox.Location = new System.Drawing.Point(626, 306);
			this.SortingMethodComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.SortingMethodComboBox.Name = "SortingMethodComboBox";
			this.SortingMethodComboBox.Size = new System.Drawing.Size(136, 32);
			this.SortingMethodComboBox.TabIndex = 18;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("黑体", 12F);
			this.label3.Location = new System.Drawing.Point(515, 312);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(106, 24);
			this.label3.TabIndex = 17;
			this.label3.Text = "排序方式";
			// 
			// Lab_Sorting
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(900, 540);
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
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "Lab_Sorting";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
		private System.Windows.Forms.TextBox TargetTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label ParasLabel;
		private System.Windows.Forms.Button ThreePointSearchButton;
		private System.Windows.Forms.Button SortButton;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button SearchButton;
		private System.Windows.Forms.Button OutputSortStatusButton;
		private System.Windows.Forms.ComboBox SearchingMethodComboBox;
		private System.Windows.Forms.ComboBox SortingMethodComboBox;
		private System.Windows.Forms.Label label3;
	}
}