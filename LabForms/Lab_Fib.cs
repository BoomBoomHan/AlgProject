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
using Xamarin.Forms;

namespace AlgProject.LabForms;

public partial class Lab_Fib : Form
{
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

	class FibLimit
	{
		public int MaxNumber;

		public FibLimit(int maxNumber)
		{
			MaxNumber = maxNumber;
		}

		public static implicit operator long(FibLimit limit)
		{
			return limit.MaxNumber;
		}
	}

	class ComponentSet
	{
		public TextBox NBox;
		public System.Windows.Forms.Button ResButton;
		public System.Windows.Forms.Button IterButton;

		public ComponentSet(TextBox nBox, System.Windows.Forms.Button resButton, System.Windows.Forms.Button iterButton)
		{
			NBox = nBox;
			ResButton = resButton;
			IterButton = iterButton;
		}
	}

	public Lab_Fib()
	{
		InitializeComponent();
		OverrideCheckBox1.CheckedChanged += OverrideCheckBox1_CheckedChanged;
		OverrideCheckBox2.CheckedChanged += OverrideCheckBox2_CheckedChanged;
		OverrideTextBox1.KeyPress += NumberInput_KeyPress;
		OverrideTextBox2.KeyPress += NumberInput_KeyPress;
		OverrideTextBox1.TextChanged += OverrideTextBox1_TextChanged;
		OverrideTextBox2.TextChanged += OverrideTextBox2_TextChanged;
	}

	private Thread judgementStread;

	protected override void OnClosed(EventArgs e)
	{
		base.OnClosed(e);

		if (judgementStread != null)
		{
			judgementStread.Abort();
		}
	}

	private void Lab_Fib_Load(object sender, EventArgs e)
	{
		//MessageBox.Show($"{int.MaxValue}   {long.MaxValue}");
		Tip.Text = "警告：该电脑下的最大斐波那契数是" + Limit.MaxNumber;
		ParameterizedThreadStart start = new ParameterizedThreadStart((object obj) =>
		{
			ComponentSet set = obj as ComponentSet;
			while (true)
			{
                if (set == null)
                {
                    return;
                }

                if (set.NBox.Text == String.Empty)
                {
                    set.ResButton.Enabled = false;
                    set.IterButton.Enabled = false;
                }
                else
                {
                    set.ResButton.Enabled = true;
                    set.IterButton.Enabled = true;
                }
            }
			
		});
		judgementStread = new Thread(start);
        judgementStread.Start();
	}

	private FibLimit limit;

	private FibLimit Limit
	{
		get
		{
			if (limit == null)
			{
				Queue<long> fibQueue = new Queue<long>(2);
				fibQueue.Enqueue(0L);
				fibQueue.Enqueue(1L);
				int i = 2;
				for (; i <= 1000; i++)
				{
					long last = fibQueue.Dequeue();
					long result = last + fibQueue.Peek();
					if (result < 0)
					{
						break;
					}
					fibQueue.Enqueue(result);
				}
				limit = new FibLimit(i - 1);
			}

			return limit;
		}
	}

	private delegate void FibFunction(FibHelper fibHelper);

	//使用异步主要为了使Fib(n-1)和Fib(n-2)同时运算，以相对节省时间。实际测试时发现，异步比同步用时减少50%。
	private static async Task<long> Fib_RecursionAsync(FibHelper fibHelper)
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
		await last1;
		await last2;
		long result = last1.Result + last2.Result;
		if (result < 0)
		{
			fibHelper.Success = false;
			return -1L;
		}
		return result;
	}

	private static long Fib_Iteration(FibHelper fibHelper)
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

		Queue<long> fibQueue = new Queue<long>(2);
		fibQueue.Enqueue(0L);
		fibQueue.Enqueue(1L);
		for (int i = 2; i <= n; i++)
		{
			long last = fibQueue.Dequeue();
			long result = last + fibQueue.Peek();
			if (result < 0)
			{
				fibHelper.Success = false;
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

	private void SetTipVisibility(bool visibility)
	{
		Tip.Visible = visibility;
		if (visibility)
		{
			Tip.Text = "正在计算中......";
		}

		Refresh();
	}

	private async void RecursionButton_Click(object sender, EventArgs e)
	{
		int n = int.Parse(NumberInput.Text);
		FibHelper helper = new FibHelper(n);
		SetTipVisibility(true);
		DateTime now1 = DateTime.Now;
		var task = Fib_RecursionAsync(helper);
		var result = await task;
        DateTime now2 = DateTime.Now;
        SetTipVisibility(false);
		if (!helper.Success)
		{
			MessageBox.Show("您所输入的数已经变鬼。", "警告警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		else
		{
			MessageBox.Show($"Fib({n})的结果是{result}。用时{(now2 - now1).TotalSeconds}秒", "递归运算结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}

	private void IterationButton_Click(object sender, EventArgs e)
	{
		int n = int.Parse(NumberInput.Text);
		FibHelper helper = new FibHelper(n);
		SetTipVisibility(true);
		long result = Fib_Iteration(helper);
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

	private uint maxTime1 = 60;
	private uint maxTime2 = 30;

	private void OverrideCheckBox1_CheckedChanged(object sender, EventArgs e)
	{
		bool overrideChecked = OverrideCheckBox1.Checked;
		OverrideLabel1.Visible = overrideChecked;
		OverrideTextBox1.Visible = overrideChecked;
		if (!overrideChecked)
		{
			maxTime1 = 60;
			ComputeMaxButton.Text = $"检测{maxTime1}秒内能否计算本机支持的最大斐波那契数列(递归)";
		}
		Refresh();
	}

	private void OverrideCheckBox2_CheckedChanged(object sender, EventArgs e)
	{
		bool overrideChecked = OverrideCheckBox2.Checked;
		OverrideLabel2.Visible = overrideChecked;
		OverrideTextBox2.Visible = overrideChecked;
		if (!overrideChecked)
		{
			maxTime2 = 30;
			ComputeHalfMinButton.Text = $"计算本机{maxTime2}秒内可计算的最大斐波那契数(递归)";
		}
		Refresh();
	}

	private void OverrideTextBox1_TextChanged(object sender, EventArgs e)
	{
		maxTime1 = OverrideTextBox1.Text != "" ? uint.Parse(OverrideTextBox1.Text) : 60u;
		ComputeMaxButton.Text = $"检测{maxTime1}秒内能否计算本机支持的最大斐波那契数列(递归)";
	}

	private void OverrideTextBox2_TextChanged(object sender, EventArgs e)
	{
		maxTime2 = OverrideTextBox2.Text != "" ? uint.Parse(OverrideTextBox2.Text) : 30u;
		ComputeHalfMinButton.Text = $"计算本机{maxTime2}秒内可计算的最大斐波那契数(递归)";
	}

	private async void NumberInput_TextChanged(object sender, EventArgs e)
	{
		
	}

	private async void ComputeMaxButton_Click(object sender, EventArgs e)
	{
		SetTipVisibility(true);
		double duration = await DurationOfRes(limit.MaxNumber);
		StringBuilder builder = new StringBuilder();
		builder.Append($"计算本机支持的最大斐波那契数{limit.MaxNumber}");
		builder.Append(duration < 60.0 ? "可以" : "无法");
		builder.Append($"在{maxTime1}秒内完成，具体时间为{duration}秒。");
		MessageBox.Show(builder.ToString(), "检验结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
		SetTipVisibility(false);
	}

	private async void ComputeHalfMinButton_Click(object sender, EventArgs e)
	{
		SetTipVisibility(true);
		double duration = 0.0;
		int result = 0;
		for (; result < limit.MaxNumber; result++)
		{
			duration = await DurationOfRes(result);
			if (duration > maxTime2)
			{
				break;
			}
		}
		MessageBox.Show($"{maxTime2}秒内能计算的最大斐波那契数是第{result - 1}个，计算出下一个的时间是{duration}秒。", "计算结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
		SetTipVisibility(false);
	}

	private async Task<double> DurationOfRes(int n)
	{
		DateTime now1 = DateTime.Now;
		FibHelper helper = new FibHelper(n);
		await Fib_RecursionAsync(helper);
		return (DateTime.Now - now1).TotalSeconds;
	}
}
