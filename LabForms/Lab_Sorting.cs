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

public unsafe partial class Lab_Sorting : Form
{
	private int[] iArray;

	public Lab_Sorting()
	{
		InitializeComponent();
		iArray = null;
		MinTextBox.KeyPress += NumberInput_KeyPress;
		MaxTextBox.KeyPress += NumberInput_KeyPress;
		LengthTextBox.KeyPress += NumberInput_KeyPress;
		TargetTextBox.KeyPress += NumberInput_KeyPress;
	}

	private void Lab_Sorting_Load(object sender, EventArgs e)
	{
		LoadFromFileButton.Enabled = false;
		GenerateButton.Enabled = false;
		ShowButton.Enabled = false;
		SearchingMethodComboBox.SelectedIndex = 0;
		SortingMethodComboBox.SelectedIndex = 0;
		ToolBox.Enabled = false;
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

	private bool CanClickLoad() => PathDisplay.Text != "";

	private bool CanClickGenerate()
	{
		return (MinTextBox.Text != "") && (MaxTextBox.Text != "") && (LengthTextBox.Text != "");
	}

	private void MinTextBox_TextChanged(object sender, EventArgs e)
	{
		GenerateButton.Enabled = CanClickGenerate();
	}

	private void MaxTextBox_TextChanged(object sender, EventArgs e)
	{
		GenerateButton.Enabled = CanClickGenerate();
	}

	private void LengthTextBox_TextChanged(object sender, EventArgs e)
	{
		GenerateButton.Enabled = CanClickGenerate();
	}

	private void PathDisplay_TextChanged(object sender, EventArgs e)
	{
		LoadFromFileButton.Enabled = CanClickLoad();
	}

	private void OpenFileButton_Click(object sender, EventArgs e)
	{
		string path = "";
		FileDialog fileDialog = new OpenFileDialog()
		{
			Filter = "CSV文件 (*.csv)|*.csv"
		};

		if (fileDialog.ShowDialog() == DialogResult.OK)
		{
			path = fileDialog.FileName;
		}

		PathDisplay.Text = path;
	}

	private bool LoadArray(out int* repeated)
	{
		var mat = CsvHelper.LoadFromCsv(PathDisplay.Text);
		repeated = null;
		if (mat == null)
		{
			return false;
		}
		if (mat.Length <= 1)
		{
			return false;
		}
		HashSet<int> uniqueSet = new HashSet<int>();
		int length = mat.Length;
		iArray = new int[length];
		for (int i = 0; i < length; i++)
		{
			int x = int.Parse(mat[i, 0]);
			if (uniqueSet.Contains(x))
			{
				repeated = &x;
				return false;
			}
			iArray[i] = x;
			uniqueSet.Add(x);
		}
		return true;
	}

	private bool GenerateArray()
	{
		int min = int.Parse(MinTextBox.Text);
		int max = int.Parse(MaxTextBox.Text);
		int length = int.Parse(LengthTextBox.Text);

		if (length <= 1)
		{
			return false;
		}
		if (max - min < length)
		{
			return false;
		}

		iArray = new int[length];
		HashSet<int> uniqueSet = new HashSet<int>();
		Random random = new Random();
		for (int i = 0; i < length; i++)
		{
			int rand;
			do
			{
				rand = random.Next(min, max + 1);
			} while (uniqueSet.Contains(rand));
			iArray[i] = rand;
			uniqueSet.Add(rand);
		}

		return true;
	}

	private void LoadFromFileButton_Click(object sender, EventArgs e)
	{
		bool success = LoadArray(out int* repeated);
		if (!success)
		{
			if (repeated == null)
			{
				MessageBox.Show("读取失败，文件不存在或数组长度不足！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				MessageBox.Show($"读取失败，数组中存在相同元素{*repeated}！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		else
		{
			MessageBox.Show("读取成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
			ToolBox.Enabled = true;
		}
	}

	private void GenerateButton_Click(object sender, EventArgs e)
	{
		bool success = GenerateArray();
		if (!success)
		{
			MessageBox.Show("生成失败，请不要玩弄程序！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		else
		{
			MessageBox.Show("生成成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
			ToolBox.Enabled = true;
		}
	}

	private void ShowButton_Click(object sender, EventArgs e)
	{
		MessageBox.Show(ConvertToString(iArray), "数组信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
	}

	private void OutputSortStatusButton_Click(object sender, EventArgs e)
	{
		var state = JudgeSortState(iArray);
		MessageBox.Show(state.ToString(), "排序信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
	}
	
	private void SortButton_Click(object sender, EventArgs e)
	{
		int methodIndex = SortingMethodComboBox.SelectedIndex;
		Action<int[]> sortAction = methodIndex == 0 ? BubbleSort : SelectionSort;
		sortAction.Invoke(iArray);
		MessageBox.Show($"当前使用的是{SortingMethodComboBox.SelectedItem}排序，排序后的数组为：{ConvertToString(iArray)}。", "排序结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
	}

	private delegate bool ExistsFun(int[] arr, int target, out int count);

	private void SearchButton_Click(object sender, EventArgs e)
	{
		int methodIndex = SearchingMethodComboBox.SelectedIndex;
		if (methodIndex == 1)
		{
			var state = JudgeSortState(iArray);
			if (state != ArraySortState.Ascending && state != ArraySortState.Descending)
			{
				MessageBox.Show("当前数组未排序，无法使用二分查找！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
		}
		ExistsFun existsFun = methodIndex == 0 ? Exists_Sequence : Exists_Binary;
		int target = int.Parse(TargetTextBox.Text);
		bool exists = existsFun(iArray, target, out int count);
		MessageBox.Show($"当前使用的是{SearchingMethodComboBox.SelectedItem}查找，{target}在数组中{(exists ? "存在" : "不存在")}，查找次数为{count}。", "查找结果", MessageBoxButtons.OK, exists ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
	}
	
	private void ThreePointSearchButton_Click(object sender, EventArgs e)
	{
		var result = MessageBox.Show("此功能是付费功能，只有开通VIP才能使用，是否继续？", "氪金提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
		//MessageBox.Show(result.ToString());
		if (result == DialogResult.Yes)
		{
			DialogResult whRes = DialogResult.Retry;
			while (whRes == DialogResult.Retry)
			{
				whRes = MessageBox.Show("余额不足，请充值后重逝！", "开通失败", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
			}

			Thread.Sleep(1000);
			int val = Search_Ternary(iArray, out ArraySortState state, out int count);
			if (val == -1)
			{
				MessageBox.Show($"当前数组未达到先升后降或先降后升状态，无法使用三分查找！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			
			string mV = state == ArraySortState.AscendingToDescending ? "最大值" : "最小值";
			MessageBox.Show($"数组属于{state.Display}状态，{mV}为{val}，查找次数为{count}。", "查找结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
			//Application.Exit();
		}
	}

	#region ALG

	//将数组转化为字符串
	private string ConvertToString(int[] arr)
	{
		StringBuilder builder = new StringBuilder();
		builder.Append($"[{arr[0]}");
		for (int i = 1; i < arr.Length; i++)
		{
			builder.Append($", {arr[i]}");
		}
		builder.Append("]");
		return builder.ToString();
	}

	//判断一个数组是无序、升序、降序、先升后降还是先降后升
	private ArraySortState JudgeSortState(int[] arr)
	{
		int length = arr.Length;
		if (length == 1)
		{
			return ArraySortState.Unsorted;
		}
		if (length == 2)
		{
			if (arr[0] < arr[1])
			{
				return ArraySortState.Ascending;
			}
			else if (arr[0] > arr[1])
			{
				return ArraySortState.Descending;
			}
			else
			{
				return ArraySortState.Unsorted;
			}
		}
		
		int i = 1;
		
		if (arr[i] > arr[i - 1])
		{
			while (i < length && arr[i] > arr[i - 1])
			{
				i++;
			}
			
			if (i == length)
			{
				return ArraySortState.Ascending;
			}

			while (i < length && arr[i] < arr[i - 1])
			{
				i++;
			}
			
			if (i == length)
			{
				return ArraySortState.AscendingToDescending;
			}
			return ArraySortState.Unsorted;
		}
		else
		{
			while (i < length && arr[i] < arr[i - 1])
			{
				i++;
			}
			
			if (i == length)
			{
				return ArraySortState.Descending;
			}

			while (i < length && arr[i] > arr[i - 1])
			{
				i++;
			}
			
			if (i == length)
			{
				return ArraySortState.DescendingToAscending;
			}
			return ArraySortState.Unsorted;
		}
	}

	//给定某具体元素，使用顺序检索判断该元素是否出现在数组中，并统计比较次数
	bool Exists_Sequence(int[] arr, int target, out int count)
	{
		int length = arr.Length;
		count = 0;
		for (int i = 0; i < length; i++)
		{
			count++;
			if (arr[i] == target)
			{
				return true;
			}
		}
		return false;
	}

	//给定某具体元素，使用二分检索判断该元素是否出现在数组中，并统计比较次数。需要先判断原数组是否为升序或降序
	bool Exists_Binary(int[] arr, int target, out int count)
	{
		count = 0;
		var state = JudgeSortState(arr);
		if (state != ArraySortState.Ascending & state != ArraySortState.Descending)
		{
			return false;
		}

		int length = arr.Length;
		int left = 0;
		int right = length - 1;
		int mid;
		while (left <= right)
		{
			count++;
			mid = (left + right) / 2;
			if (arr[mid] == target)
			{
				return true;
			}
			
			if (arr[mid] > target)
			{
				right = mid - 1;
			}
			else
			{
				left = mid + 1;
			}
		}
		return false;
	}

	//对数组进行选择排序
	void SelectionSort(int[] arr)
	{
		int length = arr.Length;
		for (int i = 0; i < length - 1; i++)
		{
			int min = i;
			for (int j = i + 1; j < length; j++)
			{
				if (arr[j] < arr[min])
				{
					min = j;
				}
			}
			if (min != i)
			{
				int temp = arr[i];
				arr[i] = arr[min];
				arr[min] = temp;
			}
		}
	}

	//对数组进行冒泡排序
	void BubbleSort(int[] arr)
	{
		int length = arr.Length;
		for (int i = 0; i < length - 1; i++)
		{
			for (int j = 0; j < length - i - 1; j++)
			{
				if (arr[j] > arr[j + 1])
				{
					int temp = arr[j];
					arr[j] = arr[j + 1];
					arr[j + 1] = temp;
				}
			}
		}
	}

	//使用三分检索判断数组是先升后降(ArraySortState.AscendingToDescending)还是先降后升(ArraySortState.DescendingToAscending)，查找该数组的最大值或最小值，并统计比较次数
	int Search_Ternary(int[] arr, out ArraySortState state, out int count)
	{
		count = 0;
		state = JudgeSortState(arr);
		if (state != ArraySortState.AscendingToDescending && state != ArraySortState.DescendingToAscending)
		{
			return -1;
		}

		int RoundInt(float f)
		{
			return (int)(f + 0.5f);
		}

		int length = arr.Length;
		float left = 0;
		float right = length - 1.0f;
		float mid1;
		float mid2;
		while ((int)left < (int)right - 1)
		{
			count++;
			mid1 = left + (right - left) / 3;
			mid2 = right - (right - left) / 3;
			int iMid1 = RoundInt(mid1);
			int iMid2 = RoundInt(mid2);
			if (arr[iMid1] < arr[iMid2])
			{
				left = mid1;
			}
			else if (arr[iMid1] > arr[iMid2])
			{
				right = mid2;
			}

			/*if (count <= 15)
			{
				MessageBox.Show($"{left}  {right}");
			}*/
			//MessageBox.Show($"{left}  {right}");
		}

		int iLeft = (int)left;
		int iRight = (int)right;
		if (arr[iLeft] > arr[iRight])
		{
			return arr[iLeft];
		}
		else
		{
			return arr[iRight];
		}
	}

	//三分查找数组的最值
	int Search_ThreePoint(int[] arr)
	{
		int length = arr.Length;
		int left = 0;
		int right = length - 1;
		int mid1;
		int mid2;
		while (left < right - 1)
		{
			mid1 = left + (right - left) / 3;
			mid2 = right - (right - left) / 3;
			if (arr[mid1] < arr[mid2])
			{
				left = mid1;
			}
			else if (arr[mid1] > arr[mid2])
			{
				right = mid2;
			}
			else
			{
				left = mid1;
				right = mid2;
			}
		}
		if (arr[left] > arr[right])
		{
			return arr[left];
		}
		else
		{
			return arr[right];
		}
	}


	#endregion
}

