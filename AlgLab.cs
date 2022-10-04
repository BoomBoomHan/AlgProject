using System;
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

		}

		private void Entrance_Fib_Click(object sender, EventArgs e)
		{
			var form = new Lab_Fib();
			form.ShowDialog(this);
		}
	}
}
