namespace Q3
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
			this.components = new System.ComponentModel.Container();
			this.generateButton = new System.Windows.Forms.Button();
			this.inputTextBox = new System.Windows.Forms.TextBox();
			this.BirthLabel = new System.Windows.Forms.Label();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.topicLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// generateButton
			// 
			this.generateButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.generateButton.Location = new System.Drawing.Point(284, 250);
			this.generateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.generateButton.Name = "generateButton";
			this.generateButton.Size = new System.Drawing.Size(132, 50);
			this.generateButton.TabIndex = 0;
			this.generateButton.Text = "顯示";
			this.generateButton.UseVisualStyleBackColor = true;
			this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
			// 
			// inputTextBox
			// 
			this.inputTextBox.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.inputTextBox.Location = new System.Drawing.Point(123, 144);
			this.inputTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.inputTextBox.Multiline = true;
			this.inputTextBox.Name = "inputTextBox";
			this.inputTextBox.Size = new System.Drawing.Size(292, 74);
			this.inputTextBox.TabIndex = 1;
			// 
			// BirthLabel
			// 
			this.BirthLabel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.BirthLabel.Location = new System.Drawing.Point(9, 158);
			this.BirthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.BirthLabel.Name = "BirthLabel";
			this.BirthLabel.Size = new System.Drawing.Size(105, 41);
			this.BirthLabel.TabIndex = 2;
			this.BirthLabel.Text = "生日";
			this.BirthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// topicLabel
			// 
			this.topicLabel.AutoSize = true;
			this.topicLabel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.topicLabel.Location = new System.Drawing.Point(16, 68);
			this.topicLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.topicLabel.Name = "topicLabel";
			this.topicLabel.Size = new System.Drawing.Size(337, 30);
			this.topicLabel.TabIndex = 6;
			this.topicLabel.Text = "請輸入生日，例如2022/10/26";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(440, 335);
			this.Controls.Add(this.topicLabel);
			this.Controls.Add(this.BirthLabel);
			this.Controls.Add(this.inputTextBox);
			this.Controls.Add(this.generateButton);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button generateButton;
		private System.Windows.Forms.TextBox inputTextBox;
		private System.Windows.Forms.Label BirthLabel;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.Label topicLabel;
	}
}

