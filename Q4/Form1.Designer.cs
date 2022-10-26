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
			this.peopleLabel.Location = new System.Drawing.Point(12, 46);
			this.peopleLabel.Name = "peopleLabel";
			this.peopleLabel.Size = new System.Drawing.Size(100, 44);
			this.peopleLabel.TabIndex = 0;
			this.peopleLabel.Text = "人數";
			// 
			// carLabel
			// 
			this.carLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.carLabel.Location = new System.Drawing.Point(215, 46);
			this.carLabel.Name = "carLabel";
			this.carLabel.Size = new System.Drawing.Size(100, 44);
			this.carLabel.TabIndex = 1;
			this.carLabel.Text = "車數";
			// 
			// calcButton
			// 
			this.calcButton.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.calcButton.Location = new System.Drawing.Point(305, 140);
			this.calcButton.Name = "calcButton";
			this.calcButton.Size = new System.Drawing.Size(96, 31);
			this.calcButton.TabIndex = 3;
			this.calcButton.Text = "計算";
			this.calcButton.UseVisualStyleBackColor = true;
			this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
			// 
			// resultLabel
			// 
			this.resultLabel.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.resultLabel.Location = new System.Drawing.Point(12, 192);
			this.resultLabel.Name = "resultLabel";
			this.resultLabel.Size = new System.Drawing.Size(389, 144);
			this.resultLabel.TabIndex = 4;
			this.resultLabel.Text = "金額";
			// 
			// peopleTextBox
			// 
			this.peopleTextBox.Location = new System.Drawing.Point(90, 46);
			this.peopleTextBox.Multiline = true;
			this.peopleTextBox.Name = "peopleTextBox";
			this.peopleTextBox.Size = new System.Drawing.Size(108, 44);
			this.peopleTextBox.TabIndex = 5;
			// 
			// carTextBox
			// 
			this.carTextBox.Location = new System.Drawing.Point(293, 46);
			this.carTextBox.Multiline = true;
			this.carTextBox.Name = "carTextBox";
			this.carTextBox.Size = new System.Drawing.Size(108, 44);
			this.carTextBox.TabIndex = 6;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(419, 345);
			this.Controls.Add(this.carTextBox);
			this.Controls.Add(this.peopleTextBox);
			this.Controls.Add(this.resultLabel);
			this.Controls.Add(this.calcButton);
			this.Controls.Add(this.carLabel);
			this.Controls.Add(this.peopleLabel);
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

