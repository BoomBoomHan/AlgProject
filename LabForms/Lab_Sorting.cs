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
	}

	private void Lab_Sorting_Load(object sender, EventArgs e)
	{
		LoadFromFileButton.Enabled = false;
		GenerateButton.Enabled = false;
		ShowButton.Enabled = false;
		SortingMethodComboBox.SelectedIndex = 0;
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
				MessageBox.Show("读取失败，文件不存在！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				MessageBox.Show($"读取失败，数组中存在相同元素{*repeated}！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		else
		{
			MessageBox.Show("读取成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
			ShowButton.Enabled = true;
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
			ShowButton.Enabled = true;
		}
	}

	private void ShowButton_Click(object sender, EventArgs e)
	{
		StringBuilder builder = new StringBuilder();
		builder.Append($"[{iArray[0]}");
		for (int i = 1; i < iArray.Length; i++)
		{
			builder.Append($", {iArray[i]}");
		}
		builder.Append("]");
		MessageBox.Show(builder.ToString(), "数组信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
	}
}
