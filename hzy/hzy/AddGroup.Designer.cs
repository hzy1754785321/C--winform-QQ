﻿namespace hzy
{
	partial class AddGroup
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
			this.components = new System.ComponentModel.Container();
			this.skinTextBox1 = new CCWin.SkinControl.SkinTextBox();
			this.skinButton1 = new CCWin.SkinControl.SkinButton();
			this.skinButton2 = new CCWin.SkinControl.SkinButton();
			this.SuspendLayout();
			// 
			// skinTextBox1
			// 
			this.skinTextBox1.BackColor = System.Drawing.Color.Transparent;
			this.skinTextBox1.DownBack = null;
			this.skinTextBox1.Icon = null;
			this.skinTextBox1.IconIsButton = false;
			this.skinTextBox1.IconMouseState = CCWin.SkinClass.ControlState.Normal;
			this.skinTextBox1.IsPasswordChat = '\0';
			this.skinTextBox1.IsSystemPasswordChar = false;
			this.skinTextBox1.Lines = new string[] {
        "skinTextBox1"};
			this.skinTextBox1.Location = new System.Drawing.Point(9, 16);
			this.skinTextBox1.Margin = new System.Windows.Forms.Padding(0);
			this.skinTextBox1.MaxLength = 32767;
			this.skinTextBox1.MinimumSize = new System.Drawing.Size(28, 28);
			this.skinTextBox1.MouseBack = null;
			this.skinTextBox1.MouseState = CCWin.SkinClass.ControlState.Normal;
			this.skinTextBox1.Multiline = true;
			this.skinTextBox1.Name = "skinTextBox1";
			this.skinTextBox1.NormlBack = null;
			this.skinTextBox1.Padding = new System.Windows.Forms.Padding(5);
			this.skinTextBox1.ReadOnly = false;
			this.skinTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.skinTextBox1.Size = new System.Drawing.Size(324, 33);
			// 
			// 
			// 
			this.skinTextBox1.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.skinTextBox1.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
			this.skinTextBox1.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
			this.skinTextBox1.SkinTxt.Location = new System.Drawing.Point(5, 5);
			this.skinTextBox1.SkinTxt.Name = "BaseText";
			this.skinTextBox1.SkinTxt.Size = new System.Drawing.Size(175, 18);
			this.skinTextBox1.SkinTxt.TabIndex = 0;
			this.skinTextBox1.SkinTxt.Text = "skinTextBox1";
			this.skinTextBox1.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
			this.skinTextBox1.SkinTxt.WaterText = "";
			this.skinTextBox1.TabIndex = 0;
			this.skinTextBox1.Text = "skinTextBox1";
			this.skinTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.skinTextBox1.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
			this.skinTextBox1.WaterText = "";
			this.skinTextBox1.WordWrap = true;
			// 
			// skinButton1
			// 
			this.skinButton1.BackColor = System.Drawing.Color.Transparent;
			this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
			this.skinButton1.DownBack = null;
			this.skinButton1.Location = new System.Drawing.Point(12, 83);
			this.skinButton1.MouseBack = null;
			this.skinButton1.Name = "skinButton1";
			this.skinButton1.NormlBack = null;
			this.skinButton1.Size = new System.Drawing.Size(89, 33);
			this.skinButton1.TabIndex = 1;
			this.skinButton1.Text = "skinButton1";
			this.skinButton1.UseVisualStyleBackColor = false;
			// 
			// skinButton2
			// 
			this.skinButton2.BackColor = System.Drawing.Color.Transparent;
			this.skinButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
			this.skinButton2.DownBack = null;
			this.skinButton2.Location = new System.Drawing.Point(215, 83);
			this.skinButton2.MouseBack = null;
			this.skinButton2.Name = "skinButton2";
			this.skinButton2.NormlBack = null;
			this.skinButton2.Size = new System.Drawing.Size(89, 33);
			this.skinButton2.TabIndex = 2;
			this.skinButton2.Text = "skinButton2";
			this.skinButton2.UseVisualStyleBackColor = false;
			// 
			// AddGroup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(342, 502);
			this.Controls.Add(this.skinButton2);
			this.Controls.Add(this.skinButton1);
			this.Controls.Add(this.skinTextBox1);
			this.Name = "AddGroup";
			this.Text = "AddGroup";
			this.ResumeLayout(false);

		}

		#endregion

		private CCWin.SkinControl.SkinTextBox skinTextBox1;
		private CCWin.SkinControl.SkinButton skinButton1;
		private CCWin.SkinControl.SkinButton skinButton2;
	}
}