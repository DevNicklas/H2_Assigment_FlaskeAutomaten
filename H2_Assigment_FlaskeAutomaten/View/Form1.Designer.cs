namespace H2_Assigment_FlaskeAutomaten
{
    partial class FlaskeautomatenForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.label1 = new System.Windows.Forms.Label();
			this.beerBtn = new System.Windows.Forms.Button();
			this.sodaBtn = new System.Windows.Forms.Button();
			this.producerBufferLabel = new System.Windows.Forms.Label();
			this.beerBufferLabel = new System.Windows.Forms.Label();
			this.sodaBufferLabel = new System.Windows.Forms.Label();
			this.producerProgressBar = new System.Windows.Forms.ProgressBar();
			this.beerProgressBar = new System.Windows.Forms.ProgressBar();
			this.sodaProgressBar = new System.Windows.Forms.ProgressBar();
			this.producerBuffer = new System.Windows.Forms.ListBox();
			this.beerBuffer = new System.Windows.Forms.ListBox();
			this.sodaBuffer = new System.Windows.Forms.ListBox();
			this.SplitterBuffer = new System.Windows.Forms.ListBox();
			this.SpiltterProgressBar = new System.Windows.Forms.ProgressBar();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 13);
			this.label1.TabIndex = 1;
			// 
			// beerBtn
			// 
			this.beerBtn.Location = new System.Drawing.Point(12, 8);
			this.beerBtn.Name = "beerBtn";
			this.beerBtn.Size = new System.Drawing.Size(145, 33);
			this.beerBtn.TabIndex = 2;
			this.beerBtn.Text = "+1 Øl";
			this.beerBtn.UseVisualStyleBackColor = true;
			this.beerBtn.Click += new System.EventHandler(this.beerBtn_Click);
			// 
			// sodaBtn
			// 
			this.sodaBtn.Location = new System.Drawing.Point(163, 8);
			this.sodaBtn.Name = "sodaBtn";
			this.sodaBtn.Size = new System.Drawing.Size(145, 33);
			this.sodaBtn.TabIndex = 3;
			this.sodaBtn.Text = "+1 Soda";
			this.sodaBtn.UseVisualStyleBackColor = true;
			this.sodaBtn.Click += new System.EventHandler(this.sodaBtn_Click);
			// 
			// producerBufferLabel
			// 
			this.producerBufferLabel.AutoSize = true;
			this.producerBufferLabel.Location = new System.Drawing.Point(10, 59);
			this.producerBufferLabel.Name = "producerBufferLabel";
			this.producerBufferLabel.Size = new System.Drawing.Size(81, 13);
			this.producerBufferLabel.TabIndex = 7;
			this.producerBufferLabel.Text = "Producer Buffer";
			// 
			// beerBufferLabel
			// 
			this.beerBufferLabel.AutoSize = true;
			this.beerBufferLabel.Location = new System.Drawing.Point(465, 59);
			this.beerBufferLabel.Name = "beerBufferLabel";
			this.beerBufferLabel.Size = new System.Drawing.Size(60, 13);
			this.beerBufferLabel.TabIndex = 8;
			this.beerBufferLabel.Text = "Beer Buffer";
			// 
			// sodaBufferLabel
			// 
			this.sodaBufferLabel.AutoSize = true;
			this.sodaBufferLabel.Location = new System.Drawing.Point(616, 59);
			this.sodaBufferLabel.Name = "sodaBufferLabel";
			this.sodaBufferLabel.Size = new System.Drawing.Size(63, 13);
			this.sodaBufferLabel.TabIndex = 9;
			this.sodaBufferLabel.Text = "Soda Buffer";
			// 
			// producerProgressBar
			// 
			this.producerProgressBar.Location = new System.Drawing.Point(10, 415);
			this.producerProgressBar.Maximum = 10;
			this.producerProgressBar.Name = "producerProgressBar";
			this.producerProgressBar.Size = new System.Drawing.Size(145, 23);
			this.producerProgressBar.TabIndex = 10;
			// 
			// beerProgressBar
			// 
			this.beerProgressBar.Location = new System.Drawing.Point(468, 415);
			this.beerProgressBar.Maximum = 10;
			this.beerProgressBar.Name = "beerProgressBar";
			this.beerProgressBar.Size = new System.Drawing.Size(145, 23);
			this.beerProgressBar.TabIndex = 11;
			// 
			// sodaProgressBar
			// 
			this.sodaProgressBar.Location = new System.Drawing.Point(619, 415);
			this.sodaProgressBar.Maximum = 10;
			this.sodaProgressBar.Name = "sodaProgressBar";
			this.sodaProgressBar.Size = new System.Drawing.Size(145, 23);
			this.sodaProgressBar.TabIndex = 12;
			// 
			// producerBuffer
			// 
			this.producerBuffer.FormattingEnabled = true;
			this.producerBuffer.Location = new System.Drawing.Point(10, 75);
			this.producerBuffer.Name = "producerBuffer";
			this.producerBuffer.Size = new System.Drawing.Size(145, 329);
			this.producerBuffer.TabIndex = 13;
			// 
			// beerBuffer
			// 
			this.beerBuffer.FormattingEnabled = true;
			this.beerBuffer.Location = new System.Drawing.Point(468, 75);
			this.beerBuffer.Name = "beerBuffer";
			this.beerBuffer.Size = new System.Drawing.Size(145, 329);
			this.beerBuffer.TabIndex = 14;
			// 
			// sodaBuffer
			// 
			this.sodaBuffer.FormattingEnabled = true;
			this.sodaBuffer.Location = new System.Drawing.Point(619, 75);
			this.sodaBuffer.Name = "sodaBuffer";
			this.sodaBuffer.Size = new System.Drawing.Size(145, 329);
			this.sodaBuffer.TabIndex = 15;
			// 
			// SplitterBuffer
			// 
			this.SplitterBuffer.FormattingEnabled = true;
			this.SplitterBuffer.Location = new System.Drawing.Point(248, 75);
			this.SplitterBuffer.Name = "SplitterBuffer";
			this.SplitterBuffer.Size = new System.Drawing.Size(145, 329);
			this.SplitterBuffer.TabIndex = 18;
			// 
			// SpiltterProgressBar
			// 
			this.SpiltterProgressBar.Location = new System.Drawing.Point(248, 415);
			this.SpiltterProgressBar.Name = "SpiltterProgressBar";
			this.SpiltterProgressBar.Size = new System.Drawing.Size(145, 23);
			this.SpiltterProgressBar.TabIndex = 17;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(245, 59);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 13);
			this.label2.TabIndex = 16;
			this.label2.Text = "Splitter";
			// 
			// FlaskeautomatenForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.SplitterBuffer);
			this.Controls.Add(this.SpiltterProgressBar);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.sodaBuffer);
			this.Controls.Add(this.beerBuffer);
			this.Controls.Add(this.producerBuffer);
			this.Controls.Add(this.sodaProgressBar);
			this.Controls.Add(this.beerProgressBar);
			this.Controls.Add(this.producerProgressBar);
			this.Controls.Add(this.sodaBufferLabel);
			this.Controls.Add(this.beerBufferLabel);
			this.Controls.Add(this.producerBufferLabel);
			this.Controls.Add(this.sodaBtn);
			this.Controls.Add(this.beerBtn);
			this.Controls.Add(this.label1);
			this.Name = "FlaskeautomatenForm";
			this.Text = "Flaskeautomaten";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button beerBtn;
        private System.Windows.Forms.Button sodaBtn;
        private System.Windows.Forms.Label producerBufferLabel;
        private System.Windows.Forms.Label beerBufferLabel;
        private System.Windows.Forms.Label sodaBufferLabel;
        private System.Windows.Forms.ProgressBar producerProgressBar;
        private System.Windows.Forms.ProgressBar beerProgressBar;
        private System.Windows.Forms.ProgressBar sodaProgressBar;
        private System.Windows.Forms.ListBox producerBuffer;
        private System.Windows.Forms.ListBox beerBuffer;
        private System.Windows.Forms.ListBox sodaBuffer;
		private System.Windows.Forms.ListBox SplitterBuffer;
		private System.Windows.Forms.ProgressBar SpiltterProgressBar;
		private System.Windows.Forms.Label label2;
	}
}

