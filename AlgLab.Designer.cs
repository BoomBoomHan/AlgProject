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
			this.Entrance_Fib = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Entrance_Fib
			// 
			this.Entrance_Fib.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Entrance_Fib.Location = new System.Drawing.Point(43, 42);
			this.Entrance_Fib.Name = "Entrance_Fib";
			this.Entrance_Fib.Size = new System.Drawing.Size(245, 82);
			this.Entrance_Fib.TabIndex = 0;
			this.Entrance_Fib.Text = "斐波那契数列求解";
			this.Entrance_Fib.UseVisualStyleBackColor = true;
			this.Entrance_Fib.Click += new System.EventHandler(this.Entrance_Fib_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.Entrance_Fib);
			this.Name = "Form1";
			this.Text = "算法设计与分析 实验";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button Entrance_Fib;
	}
}

