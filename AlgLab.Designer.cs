namespace AlgProject
{
	partial class AlgLab
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlgLab));
			this.Entrance_Fib = new System.Windows.Forms.Button();
			this.Title = new System.Windows.Forms.Label();
			this.Btn6 = new System.Windows.Forms.Button();
			this.Btn5 = new System.Windows.Forms.Button();
			this.Btn4 = new System.Windows.Forms.Button();
			this.Btn3 = new System.Windows.Forms.Button();
			this.Btn2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Entrance_Fib
			// 
			this.Entrance_Fib.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Entrance_Fib.Location = new System.Drawing.Point(50, 120);
			this.Entrance_Fib.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Entrance_Fib.Name = "Entrance_Fib";
			this.Entrance_Fib.Size = new System.Drawing.Size(276, 98);
			this.Entrance_Fib.TabIndex = 0;
			this.Entrance_Fib.Text = "斐波那契数列求解";
			this.Entrance_Fib.UseVisualStyleBackColor = true;
			this.Entrance_Fib.Click += new System.EventHandler(this.Entrance_Fib_Click);
			// 
			// Title
			// 
			this.Title.AutoSize = true;
			this.Title.Font = new System.Drawing.Font("宋体", 20F);
			this.Title.Location = new System.Drawing.Point(47, 47);
			this.Title.Name = "Title";
			this.Title.Size = new System.Drawing.Size(357, 40);
			this.Title.TabIndex = 1;
			this.Title.Text = "杨波 老师，您好！";
			// 
			// Btn6
			// 
			this.Btn6.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Btn6.Location = new System.Drawing.Point(462, 360);
			this.Btn6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Btn6.Name = "Btn6";
			this.Btn6.Size = new System.Drawing.Size(276, 98);
			this.Btn6.TabIndex = 3;
			this.Btn6.Text = "电信诈骗";
			this.Btn6.UseVisualStyleBackColor = true;
			this.Btn6.Click += new System.EventHandler(this.button2_Click);
			// 
			// Btn5
			// 
			this.Btn5.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Btn5.Location = new System.Drawing.Point(50, 360);
			this.Btn5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Btn5.Name = "Btn5";
			this.Btn5.Size = new System.Drawing.Size(276, 98);
			this.Btn5.TabIndex = 4;
			this.Btn5.Text = "《算法分析与设计》从入门到挂科";
			this.Btn5.UseVisualStyleBackColor = true;
			// 
			// Btn4
			// 
			this.Btn4.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Btn4.Location = new System.Drawing.Point(462, 240);
			this.Btn4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Btn4.Name = "Btn4";
			this.Btn4.Size = new System.Drawing.Size(276, 98);
			this.Btn4.TabIndex = 5;
			this.Btn4.Text = "22=35";
			this.Btn4.UseVisualStyleBackColor = true;
			// 
			// Btn3
			// 
			this.Btn3.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Btn3.Location = new System.Drawing.Point(50, 240);
			this.Btn3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Btn3.Name = "Btn3";
			this.Btn3.Size = new System.Drawing.Size(276, 98);
			this.Btn3.TabIndex = 6;
			this.Btn3.Text = "买瓜.exe";
			this.Btn3.UseVisualStyleBackColor = true;
			// 
			// Btn2
			// 
			this.Btn2.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Btn2.Location = new System.Drawing.Point(462, 120);
			this.Btn2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Btn2.Name = "Btn2";
			this.Btn2.Size = new System.Drawing.Size(276, 98);
			this.Btn2.TabIndex = 7;
			this.Btn2.Text = "二仙桥到成华大道";
			this.Btn2.UseVisualStyleBackColor = true;
			// 
			// AlgLab
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(798, 540);
			this.Controls.Add(this.Btn2);
			this.Controls.Add(this.Btn3);
			this.Controls.Add(this.Btn4);
			this.Controls.Add(this.Btn5);
			this.Controls.Add(this.Btn6);
			this.Controls.Add(this.Title);
			this.Controls.Add(this.Entrance_Fib);
			this.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "AlgLab";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "破摆之王の算法分析与设计实验";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Entrance_Fib;
		private System.Windows.Forms.Label Title;
		private System.Windows.Forms.Button Btn6;
		private System.Windows.Forms.Button Btn5;
		private System.Windows.Forms.Button Btn4;
		private System.Windows.Forms.Button Btn3;
		private System.Windows.Forms.Button Btn2;
	}
}

