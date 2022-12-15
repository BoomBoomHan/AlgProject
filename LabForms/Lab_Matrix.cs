using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgProject.LabForms;

public partial class Lab_Matrix : Form
{
	private Matrix matrixA;
	private Matrix matrixB;

	public Lab_Matrix()
	{
		InitializeComponent();
	}

	private void Lab_Matrix_Load(object sender, EventArgs e)
	{
		ShowAButton.Enabled = false;
		ShowBButton.Enabled = false;
	}

	private void GenerateButton_Click(object sender, EventArgs e)
	{
		Random random = new Random();
		matrixA = Matrix.GenerateRandomMatrix(int.Parse(NDomain.Text), random);
		matrixB = Matrix.GenerateRandomMatrix(int.Parse(NDomain.Text), random);
		
		GenerateButton.Text = "重新生成";
		MessageBox.Show("生成成功！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
		ShowAButton.Enabled = true;
		ShowBButton.Enabled = true;
	}

	private void ShowAButton_Click(object sender, EventArgs e)
	{
		MessageBox.Show($"矩阵A:\n{matrixA}");
	}

	private void ShowBButton_Click(object sender, EventArgs e)
	{
		MessageBox.Show($"矩阵B:\n{matrixB}");
	}

	private void ForceButton_Click(object sender, EventArgs e)
	{
		DateTime begin = DateTime.Now;
		Matrix matrixC = Matrix.Mult_Force(matrixA, matrixB);
		DateTime end = DateTime.Now;

		MessageBox.Show($"矩阵C:\n{matrixC}\n\n耗时：{(end - begin).TotalMilliseconds :F5}ms。", "蛮力法计算结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
		ForceLabel.Text = $"用时：{(end - begin).TotalMilliseconds :F5}ms";
	}

	private void StrassenButton_Click(object sender, EventArgs e)
	{
		DateTime begin = DateTime.Now;
		Matrix matrixC = Matrix.Mult_Strassen(matrixA, matrixB);
		DateTime end = DateTime.Now;

		MessageBox.Show($"矩阵C:\n{matrixC}\n\n耗时：{(end - begin).TotalMilliseconds :F5}ms。", "斯特拉森算法计算结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
		StrassenLabel.Text = $"用时：{(end - begin).TotalMilliseconds :F5}ms";
	}
}