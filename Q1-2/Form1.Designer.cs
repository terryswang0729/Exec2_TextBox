namespace Q1
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
			this.generateButton = new System.Windows.Forms.Button();
			this.inputTextBox = new System.Windows.Forms.TextBox();
			this.topicLabel = new System.Windows.Forms.Label();
			this.resultLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// generateButton
			// 
			this.generateButton.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.generateButton.Location = new System.Drawing.Point(269, 68);
			this.generateButton.Name = "generateButton";
			this.generateButton.Size = new System.Drawing.Size(134, 34);
			this.generateButton.TabIndex = 0;
			this.generateButton.Text = "判斷是否為1-99之間";
			this.generateButton.UseVisualStyleBackColor = true;
			this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
			// 
			// inputTextBox
			// 
			this.inputTextBox.Location = new System.Drawing.Point(24, 63);
			this.inputTextBox.Multiline = true;
			this.inputTextBox.Name = "inputTextBox";
			this.inputTextBox.Size = new System.Drawing.Size(239, 39);
			this.inputTextBox.TabIndex = 1;
			// 
			// topicLabel
			// 
			this.topicLabel.AutoSize = true;
			this.topicLabel.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.topicLabel.Location = new System.Drawing.Point(20, 31);
			this.topicLabel.Name = "topicLabel";
			this.topicLabel.Size = new System.Drawing.Size(99, 19);
			this.topicLabel.TabIndex = 2;
			this.topicLabel.Text = "輸入任意數字";
			// 
			// resultLabel
			// 
			this.resultLabel.AutoSize = true;
			this.resultLabel.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.resultLabel.Location = new System.Drawing.Point(22, 124);
			this.resultLabel.Name = "resultLabel";
			this.resultLabel.Size = new System.Drawing.Size(48, 19);
			this.resultLabel.TabIndex = 3;
			this.resultLabel.Text = "result";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(458, 226);
			this.Controls.Add(this.resultLabel);
			this.Controls.Add(this.topicLabel);
			this.Controls.Add(this.inputTextBox);
			this.Controls.Add(this.generateButton);
			this.Name = "Form1";
			this.Text = "1-99";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button generateButton;
		private System.Windows.Forms.TextBox inputTextBox;
		private System.Windows.Forms.Label topicLabel;
		private System.Windows.Forms.Label resultLabel;
	}
}

