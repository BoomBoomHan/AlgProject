using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgProject.LabForms;

public partial class Lab_Fib : Form
{
	public Lab_Fib()
	{
		InitializeComponent();
	}

	private void Lab_Fib_Load(object sender, EventArgs e)
	{

	}

	private static int Fib_Recursion(int n, out bool except)
	{
		except = false;
		if (n < 0)
		{
			throw new ArgumentException("您所输入的n是负数，请核对后再输。");
		}

		if (n <= 1)
		{
			return n;
		}

		long result = Fib_Recursion(n - 1, out except) + Fib_Recursion(n - 2, out except);
		if (result > int.MaxValue)
		{
			except = true;
			return -1;
		}
		return (int)result;
	}

	private static int Fib_Iteration(int n, out bool except)
	{
		except = false;
		if (n < 0)
		{
			throw new ArgumentException("您所输入的n是负数，请核对后再输。");
		}

		if (n <= 1)
		{
			return n;
		}

		Queue<int> fibQueue = new Queue<int>(3);
		fibQueue.Enqueue(0);
		fibQueue.Enqueue(1);
		for (int i = 2; i <= n; i++)
		{
			int last = fibQueue.Dequeue();
			int result = last + fibQueue.Peek();
			if (result < 0)
			{
				except = true;
				return -1;
			}
			fibQueue.Enqueue(result);
		}

		return fibQueue.Last();
	}

	private void NumberInput_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
		{
			e.Handled = true;
		}
		else
		{
			e.Handled = false;
		}
	}

	private void IterationButton_Click(object sender, EventArgs e)
	{
		int n = int.Parse(NumberInput.Text);
		int result = Fib_Iteration(n, out bool except);
		if (except)
		{
			MessageBox.Show("您所输入的数已经变鬼。", "警告警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		else
		{
			MessageBox.Show($"Fib({n})的结果是{result}。", "迭代运算结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}

	private void RecursionButton_Click(object sender, EventArgs e)
	{
		int n = int.Parse(NumberInput.Text);
		int result = Fib_Recursion(n, out bool except);
		if (except)
		{
			MessageBox.Show("您所输入的数已经变鬼。", "警告警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		else
		{
			MessageBox.Show($"Fib({n})的结果是{result}。", "递归运算结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}

	private void NumberInput_TextChanged(object sender, EventArgs e)
	{

	}
}
