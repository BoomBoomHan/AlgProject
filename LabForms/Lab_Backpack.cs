using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgProject.LabForms;

public partial class Lab_Backpack : Form
{

	class Staff
	{
		public string Name;
		public float Weight;
		public float Value;
		public bool Picked;

		public Staff(string name, float weight, float value)
		{
			Name = name;
			Weight = weight;
			Value = value;
			Picked = false;
		}

		public Staff(string name, string weightStr, string valueStr)
			:this(name, float.Parse(weightStr), float.Parse(valueStr))
		{

		}

		public override string ToString()
		{
			return $"物品名：{Name}	重量：{Weight}	价值：{Value}";
		}

		public override int GetHashCode()
		{
			return Name.GetHashCode();
		}

		public static Staff[] LoadFromStringArray(string[,] inArray)
		{
			Staff[] result = new Staff[inArray.GetLength(0)];
			for (int i = 0; i < result.Length; i++)
			{
				result[i] = new Staff(inArray[i, 0], inArray[i, 1], inArray[i, 2]);
			}

			return result;
		}
	}

	class StaffSet
	{
		HashSet<Staff> set;

		public StaffSet(params Staff[] staffs)
		{
			set = new HashSet<Staff>();
			foreach (Staff staff in staffs)
			{
				Debug.Assert(!set.Contains(staff));

				set.Add(staff);
			}
		}

		public StaffSet(StaffSet other)
		{
			set = new HashSet<Staff>(other.set);
		}

		public float TotalWeight
		{
			get => set.Sum((Staff staff) => staff.Weight);
		}

		public float TotalValue
		{
			get => set.Sum((Staff staff) => staff.Value);
		}

		public int Count
		{
			get => set.Count;
		}

		public Staff[] ToArray()
		{
			return set.ToArray();
		}

		public static StaffSet operator +(StaffSet staffSet, Staff staff)
		{
			if (staffSet.set.Contains(staff))
			{
				return null;
			}

			StaffSet result = new StaffSet(staffSet);
			result.set.Add(staff);
			return result;
		}

		public bool EqualsTo(StaffSet b)
		{
			if (b == null)
			{
				return false;
			}
			if (Count != b.Count)
			{
				return false;
			}
			foreach (var aEle in set)
			{
				if (!b.set.Contains(aEle))
				{
					return false;
				}
			}
			return true;
		}
	}

	class AdvancedBackpack
	{
		Staff[] staffs;
		float maxTolerance;


		public AdvancedBackpack(Staff[] staffs, float maxTolerance)
		{
			this.staffs = staffs;
			this.maxTolerance = maxTolerance;
		}

		private int Pow2(int expo)
		{
			if (expo == 0)
			{
				return 1;
			}
			if (expo == 1)
			{
				return 2;
			}
			int res = Pow2(expo / 2);
			return res * res * Pow2(expo % 2);
		}

		private void AppendFrom(HashSet<StaffSet> sets, List<StaffSet> list)
		{
			int b4 = sets.Count;
			foreach (var ele in list)
			{
				if (!sets.Contains(ele))
				{
					sets.Add(ele);
				}
			}
			//MessageBox.Show($"BEFORE:{b4}	AFTER:{sets.Count}");
		}

		private StaffSet[] GenerateSubSets()
		{
			int count = staffs.Length;
			HashSet<StaffSet> sets = new HashSet<StaffSet>();

			List<StaffSet> tempList = new List<StaffSet>();
			foreach (var staff in staffs)
			{
				tempList.Add(new StaffSet(staff));
			}
			
			for (int i = 1; i < count; i++)
			{
				AppendFrom(sets, tempList);
				List<StaffSet> tempList2 = new List<StaffSet>();
				foreach (var staff in staffs)
				{
					foreach (var ele in tempList)
					{
						StaffSet set = ele + staff;
						if ((set != null) && (set.TotalWeight <= maxTolerance))
						{
							bool flag = true;
							foreach (var ele2 in tempList2)
							{
								if (ele2.EqualsTo(set))
								{
									flag = false;
								}
							}
							if (flag)
							{
								tempList2.Add(set);
							}
						}
					}
				}
				tempList = tempList2;
			}

			var full = new StaffSet(staffs);
			if (full.TotalWeight <= maxTolerance)
				sets.Add(full);

			return sets.ToArray();
		}

		public StaffSet MaxValueStaffs()
		{
			//生成所有可能的子集
			var subs = GenerateSubSets();
			//对子集进行排序
			Array.Sort(subs, (a, b) =>
			{
				if (a.TotalValue > b.TotalValue) return 1;
				if (a.TotalValue == b.TotalValue) return 0;
				return -1;
			});
			/*StringBuilder builder = new StringBuilder();
			foreach (var sub in subs)
			{
				builder.Append(sub.TotalValue.ToString() + "\t");
			}
			MessageBox.Show(builder.ToString());*/

			//返回最大的结果
			return subs[subs.Length - 1];
		}
	}

	string csvPath = "";

	public Lab_Backpack()
	{
		InitializeComponent();
	}

	private void Lab_Backpack_Load(object sender, EventArgs e)
	{
		ComputeButton.Enabled = false;
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

	private async void GenerateStaffCsvButton_Click(object sender, EventArgs e)
	{
		csvPath = await CsvHelper.CreateCsv("backpack", "物品名", "物品重量", "物品价值");
		Process.Start(csvPath);
		ComputeButton.Enabled = true;
		//MessageBox.Show(CsvHelper.CreateCsv("backpack"));
	}


	private void ComputeButton_Click(object sender, EventArgs e)
	{
		var staffs = Staff.LoadFromStringArray(CsvHelper.LoadFromCsv(csvPath));
		AdvancedBackpack backpack = new AdvancedBackpack(staffs, int.Parse(BackpackToleranceTextBox.Text));
		DateTime start = DateTime.Now;
		var result = backpack.MaxValueStaffs();
		DateTime end = DateTime.Now;
		var resArr = result.ToArray();

		float maxValue = result.TotalValue;

		StringBuilder builder = new StringBuilder();
		builder.AppendLine($"最大总价值：{maxValue}。");
		builder.Append($"子集：");
		for (int i = 0; i < resArr.Length; i++)
		{
			builder.Append($"\n{resArr[i].Name}");
		}
		builder.Append("。");

		MessageBox.Show(builder.ToString(), "计算结果", MessageBoxButtons.OK, MessageBoxIcon.Information);

		MessageBox.Show($"用时：{(end - start).TotalMilliseconds}毫秒。", "计算结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
	}

	
}
