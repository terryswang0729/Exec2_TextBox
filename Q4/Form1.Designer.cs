namespace Q4
{
	partial class Form1
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
			this.peopleLabel = new System.Windows.Forms.Label();
			this.carLabel = new System.Windows.Forms.Label();
			this.calcButton = new System.Windows.Forms.Button();
			this.resultLabel = new System.Windows.Forms.Label();
			this.peopleTextBox = new System.Windows.Forms.TextBox();
			this.carTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// peopleLabel
			// 
			this.peopleLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.peopleLabel.Location = new System.Drawing.Point(9, 37);
			this.peopleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.peopleLabel.Name = "peopleLabel";
			this.peopleLabel.Size = new System.Drawing.Size(75, 35);
			this.peopleLabel.TabIndex = 0;
			this.peopleLabel.Text = "人數";
			// 
			// carLabel
			// 
			this.carLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.carLabel.Location = new System.Drawing.Point(161, 37);
			this.carLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.carLabel.Name = "carLabel";
			this.carLabel.Size = new System.Drawing.Size(75, 35);
			this.carLabel.TabIndex = 1;
			this.carLabel.Text = "車數";
			// 
			// calcButton
			// 
			this.calcButton.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.calcButton.Location = new System.Drawing.Point(229, 112);
			this.calcButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.calcButton.Name = "calcButton";
			this.calcButton.Size = new System.Drawing.Size(72, 25);
			this.calcButton.TabIndex = 3;
			this.calcButton.Text = "計算";
			this.calcButton.UseVisualStyleBackColor = true;
			this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
			// 
			// resultLabel
			// 
			this.resultLabel.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.resultLabel.Location = new System.Drawing.Point(9, 154);
			this.resultLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.resultLabel.Name = "resultLabel";
			this.resultLabel.Size = new System.Drawing.Size(292, 115);
			this.resultLabel.TabIndex = 4;
			this.resultLabel.Text = "金額";
			// 
			// peopleTextBox
			// 
			this.peopleTextBox.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.peopleTextBox.Location = new System.Drawing.Point(68, 37);
			this.peopleTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.peopleTextBox.Multiline = true;
			this.peopleTextBox.Name = "peopleTextBox";
			this.peopleTextBox.Size = new System.Drawing.Size(82, 36);
			this.peopleTextBox.TabIndex = 5;
			// 
			// carTextBox
			// 
			this.carTextBox.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.carTextBox.Location = new System.Drawing.Point(220, 37);
			this.carTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.carTextBox.Multiline = true;
			this.carTextBox.Name = "carTextBox";
			this.carTextBox.Size = new System.Drawing.Size(82, 36);
			this.carTextBox.TabIndex = 6;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(314, 276);
			this.Controls.Add(this.carTextBox);
			this.Controls.Add(this.peopleTextBox);
			this.Controls.Add(this.resultLabel);
			this.Controls.Add(this.calcButton);
			this.Controls.Add(this.carLabel);
			this.Controls.Add(this.peopleLabel);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label peopleLabel;
		private System.Windows.Forms.Label carLabel;
		private System.Windows.Forms.Button calcButton;
		private System.Windows.Forms.Label resultLabel;
		private System.Windows.Forms.TextBox peopleTextBox;
		private System.Windows.Forms.TextBox carTextBox;
	}
}

