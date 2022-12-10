using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlgProject.LabForms;

namespace AlgProject
{
	public partial class AlgLab : Form
	{
		public AlgLab()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			/*string[] split = Application.UserAppDataPath.Split('\\');

			Title.Text = split[2] + "，您好！";*/
		}

		private void Entrance_Fib_Click(object sender, EventArgs e)
		{
			var form = new Lab_Fib();
			form.ShowDialog(this);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.bilibili.com/video/BV1GJ411x7h7/?spm_id_from=333.337.search-card.all.click&vd_source=02588a7ac4bf38d46eefc0bb0273ea10");
			Text = "【官方 MV】Never Gonna Give You Up - Rick Astley";
			Title.Text = "We're no strangers to love, You know the rules and so do I";
			Font nFont = new Font("宋体", 15.0f, FontStyle.Regular);
			Title.Font = nFont;
			Entrance_Fib.Text = "A full commitments what I'm thinking of, You wouldn't get this from any other guy";
			Entrance_Backpack.Text = "I just wanna tell you how I'm feeling, Gotta make you understand";
			Entrance_Sorting.Text = "Never gonna give yu up, Never gonna let you down";
			Btn4.Text = "Never gonna run around and desert you";
			Btn5.Text = "Never gonna make you cry, Never gonna say goodbye";
			Btn6.Text = "Never gonna tell a lie and hurt you";
		}

		private void Entrance_Backpack_Click(object sender, EventArgs e)
		{
			var form = new Lab_Backpack();
			form.ShowDialog(this);
		}

		private void Entrance_Sorting_Click(object sender, EventArgs e)
		{
			var form = new Lab_Sorting();
			form.ShowDialog(this);
		}
	}
}
