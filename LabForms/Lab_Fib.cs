using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

	class FibHelper
	{
		public int N;
		public bool Success;
		
		public FibHelper(int n)
		{
			N = n;
			Success = true;
		}
	}

	class FibObject
	{
		public FibHelper Helper;
		public int Result;

		public FibObject(FibHelper helper)
		{
			Helper = helper;
			Result = -1;
		}
	}

	private delegate void FibFunction(FibHelper fibHelper);

	private static async Task<int> Fib_RecursionAsync(FibHelper fibHelper)
	{
		int n = fibHelper.N;
		if (n < 0)
		{
			throw new ArgumentException("您所输入的n是负数，请核对后再输。");
		}

		if (n <= 1)
		{
			return n;
		}
		var last1 = Fib_RecursionAsync(new FibHelper(n - 1));
		var last2 = Fib_RecursionAsync(new FibHelper(n - 2));
		int result = last1.Result + last2.Result;
		if (result < 0)
		{
			fibHelper.Success = false;
			return -1;
		}
		return result;
	}

	private static async Task<int> Fib_IterationAsync(FibHelper fibHelper)
	{
		int n = fibHelper.N;
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
				fibHelper.Success = false;
				return -1;
			}
			fibQueue.Enqueue(result);
		}

		return fibQueue.Last();

		//FibObject obj = new FibObject(fibHelper);

		/*ParameterizedThreadStart start = new ParameterizedThreadStart(obj =>
		{
			Queue<int> fibQueue = new Queue<int>(3);
			fibQueue.Enqueue(0);
			fibQueue.Enqueue(1);
			for (int i = 2; i <= n; i++)
			{
				int last = fibQueue.Dequeue();
				int result = last + fibQueue.Peek();
				if (result < 0)
				{
					fibHelper.Success = false;
					return;
				}
				fibQueue.Enqueue(result);
			}

			(obj as FibObject).Result = fibQueue.Last();
		});*/
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

	private void SetTipVisibility(bool visibility)
	{
		Tip.Visible = visibility;
		Refresh();
	}

	private async void RecursionButton_Click(object sender, EventArgs e)
	{
		int n = int.Parse(NumberInput.Text);
		FibHelper helper = new FibHelper(n);
		SetTipVisibility(true);
		var result = await Fib_RecursionAsync(helper);
		SetTipVisibility(false);
		if (!helper.Success)
		{
			MessageBox.Show("您所输入的数已经变鬼。", "警告警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		else
		{
			MessageBox.Show($"Fib({n})的结果是{result}。", "递归运算结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

	}

	private async void IterationButton_Click(object sender, EventArgs e)
	{
		int n = int.Parse(NumberInput.Text);
		FibHelper helper = new FibHelper(n);
		SetTipVisibility(true);
		int result = await Fib_IterationAsync(helper);
		SetTipVisibility(false);
		if (!helper.Success)
		{
			MessageBox.Show("您所输入的数已经变鬼。", "警告警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		else
		{
			MessageBox.Show($"Fib({n})的结果是{result}。", "迭代运算结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}

	private void NumberInput_TextChanged(object sender, EventArgs e)
	{

	}
}
