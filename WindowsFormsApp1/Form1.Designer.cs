namespace WindowsFormsApp1
{
	partial class Exec2_Star
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.rowsTextBox = new System.Windows.Forms.TextBox();
			this.leftButton = new System.Windows.Forms.Button();
			this.midButton = new System.Windows.Forms.Button();
			this.rightButton = new System.Windows.Forms.Button();
			this.resultTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(12, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(113, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "請輸入1~10的數: ";
			// 
			// rowsTextBox
			// 
			this.rowsTextBox.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.rowsTextBox.Location = new System.Drawing.Point(131, 9);
			this.rowsTextBox.Name = "rowsTextBox";
			this.rowsTextBox.Size = new System.Drawing.Size(100, 25);
			this.rowsTextBox.TabIndex = 1;
			// 
			// leftButton
			// 
			this.leftButton.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.leftButton.Location = new System.Drawing.Point(15, 58);
			this.leftButton.Name = "leftButton";
			this.leftButton.Size = new System.Drawing.Size(54, 23);
			this.leftButton.TabIndex = 2;
			this.leftButton.Text = "靠左";
			this.leftButton.UseVisualStyleBackColor = true;
			this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
			// 
			// midButton
			// 
			this.midButton.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.midButton.Location = new System.Drawing.Point(96, 58);
			this.midButton.Name = "midButton";
			this.midButton.Size = new System.Drawing.Size(54, 23);
			this.midButton.TabIndex = 3;
			this.midButton.Text = "等腰";
			this.midButton.UseVisualStyleBackColor = true;
			this.midButton.Click += new System.EventHandler(this.midButton_Click);
			// 
			// rightButton
			// 
			this.rightButton.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.rightButton.Location = new System.Drawing.Point(177, 58);
			this.rightButton.Name = "rightButton";
			this.rightButton.Size = new System.Drawing.Size(54, 23);
			this.rightButton.TabIndex = 4;
			this.rightButton.Text = "靠右";
			this.rightButton.UseVisualStyleBackColor = true;
			this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
			// 
			// resultTextBox
			// 
			this.resultTextBox.Location = new System.Drawing.Point(15, 98);
			this.resultTextBox.Multiline = true;
			this.resultTextBox.Name = "resultTextBox";
			this.resultTextBox.ReadOnly = true;
			this.resultTextBox.Size = new System.Drawing.Size(215, 187);
			this.resultTextBox.TabIndex = 5;
			// 
			// Exec2_Star
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(246, 323);
			this.Controls.Add(this.resultTextBox);
			this.Controls.Add(this.rightButton);
			this.Controls.Add(this.midButton);
			this.Controls.Add(this.leftButton);
			this.Controls.Add(this.rowsTextBox);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Exec2_Star";
			this.Text = "Exec2_Star";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox rowsTextBox;
		private System.Windows.Forms.Button leftButton;
		private System.Windows.Forms.Button midButton;
		private System.Windows.Forms.Button rightButton;
		private System.Windows.Forms.TextBox resultTextBox;
	}
}

