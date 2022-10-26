using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Exec2_Star : Form
	{
		public Exec2_Star()
		{
			InitializeComponent();
		}

		private void leftButton_Click(object sender, EventArgs e)
		{
			int? rows = GetRows();

			if (rows.HasValue == false) 
			{
				MessageBox.Show("請輸入數列");
				return;
			}

			if (rows.Value <= 0 || rows.Value > 10) 
			{
				MessageBox.Show("列數必須介於1~10之間");
				return;
			}

			string stars = GenerateStars(rows.Value);

			resultTextBox.Text = stars;
		}

		private string GenerateStars(int rows)
		{
			string result = string.Empty;
			for (int i = 1; i <= rows; i++)
			{
				result += new string('*', i) + "\r\n";
			}
			return result;
		}

		private int? GetRows()
		{
			string input = rowsTextBox.Text;
			bool isInt = int.TryParse(input, out int rows);
			if (isInt)
			{
				return rows;
			}
			else
			{
				return null;
			}
		}

		private void rightButton_Click(object sender, EventArgs e)
		{
			int? rows = GetRows();

			if (rows.HasValue == false)
			{
				MessageBox.Show("請輸入數列");
				return;
			}

			if (rows.Value <= 0 || rows.Value > 10)
			{
				MessageBox.Show("列數必須介於1~10之間");
				return;
			}

			string stars = GenerateSpaceRight(rows.Value);

			resultTextBox.Text = stars;
		}

		private string GenerateSpaceRight(int rows)
		{
			string result = string.Empty;
			for (int i = 1; i <= rows; i++)
			{
				result += new string(' ', 2 * (rows - i)) + new string('*', i) + "\r\n";
			}
			return result;
		}

		private void midButton_Click(object sender, EventArgs e)
		{
			int? rows = GetRows();

			if (rows.HasValue == false)
			{
				MessageBox.Show("請輸入數列");
				return;
			}

			if (rows.Value <= 0 || rows.Value > 10)
			{
				MessageBox.Show("列數必須介於1~10之間");
				return;
			}

			string stars = GenerateStarMid(rows.Value);

			resultTextBox.Text = stars;
		}

		private string GenerateStarMid(int rows)
		{
			string result = string.Empty;
			for (int i = 1; i <= rows; i++)
			{
				result += new string(' ', rows - i) + new string('*', i) + "\r\n";
			}
			return result;
		}
	}
}
