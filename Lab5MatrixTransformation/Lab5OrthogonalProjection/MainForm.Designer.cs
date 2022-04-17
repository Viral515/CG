
namespace Lab5OrthogonalProjection
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.DrawPanel = new System.Windows.Forms.Panel();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.AlgorithmGroupBox = new System.Windows.Forms.GroupBox();
            this.ZTranslateTextBox = new System.Windows.Forms.TextBox();
            this.YTranslateTextBox = new System.Windows.Forms.TextBox();
            this.XTranslateTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ZScaleTextBox = new System.Windows.Forms.TextBox();
            this.YScaleTextBox = new System.Windows.Forms.TextBox();
            this.RotateAngleTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.XScaleTextBox = new System.Windows.Forms.TextBox();
            this.TimerButton = new System.Windows.Forms.Button();
            this.ColorButton = new System.Windows.Forms.Button();
            this.DrawButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.SetTransformButton = new System.Windows.Forms.Button();
            this.ZTranslationTextBox = new System.Windows.Forms.TextBox();
            this.YTranslationTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.XTranslationTextBox = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.RadioButton1 = new System.Windows.Forms.RadioButton();
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.DrawPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.AlgorithmGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // DrawPanel
            // 
            this.DrawPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DrawPanel.Controls.Add(this.PictureBox);
            this.DrawPanel.Location = new System.Drawing.Point(10, 9);
            this.DrawPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DrawPanel.Name = "DrawPanel";
            this.DrawPanel.Size = new System.Drawing.Size(459, 394);
            this.DrawPanel.TabIndex = 0;
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(3, 2);
            this.PictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(452, 387);
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            this.PictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDown);
            this.PictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseUp);
            // 
            // AlgorithmGroupBox
            // 
            this.AlgorithmGroupBox.Controls.Add(this.ZTranslateTextBox);
            this.AlgorithmGroupBox.Controls.Add(this.YTranslateTextBox);
            this.AlgorithmGroupBox.Controls.Add(this.XTranslateTextBox);
            this.AlgorithmGroupBox.Controls.Add(this.label1);
            this.AlgorithmGroupBox.Controls.Add(this.ZScaleTextBox);
            this.AlgorithmGroupBox.Controls.Add(this.YScaleTextBox);
            this.AlgorithmGroupBox.Controls.Add(this.RotateAngleTextBox);
            this.AlgorithmGroupBox.Controls.Add(this.label9);
            this.AlgorithmGroupBox.Controls.Add(this.label7);
            this.AlgorithmGroupBox.Controls.Add(this.XScaleTextBox);
            this.AlgorithmGroupBox.Controls.Add(this.TimerButton);
            this.AlgorithmGroupBox.Controls.Add(this.ColorButton);
            this.AlgorithmGroupBox.Controls.Add(this.DrawButton);
            this.AlgorithmGroupBox.Controls.Add(this.label5);
            this.AlgorithmGroupBox.Controls.Add(this.WidthTextBox);
            this.AlgorithmGroupBox.Controls.Add(this.SetTransformButton);
            this.AlgorithmGroupBox.Controls.Add(this.ZTranslationTextBox);
            this.AlgorithmGroupBox.Controls.Add(this.YTranslationTextBox);
            this.AlgorithmGroupBox.Controls.Add(this.label2);
            this.AlgorithmGroupBox.Controls.Add(this.XTranslationTextBox);
            this.AlgorithmGroupBox.Controls.Add(this.ClearButton);
            this.AlgorithmGroupBox.Controls.Add(this.RadioButton1);
            this.AlgorithmGroupBox.Location = new System.Drawing.Point(474, 9);
            this.AlgorithmGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AlgorithmGroupBox.Name = "AlgorithmGroupBox";
            this.AlgorithmGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AlgorithmGroupBox.Size = new System.Drawing.Size(215, 393);
            this.AlgorithmGroupBox.TabIndex = 1;
            this.AlgorithmGroupBox.TabStop = false;
            this.AlgorithmGroupBox.Text = "Выберите алгоритм";
            // 
            // ZTranslateTextBox
            // 
            this.ZTranslateTextBox.Location = new System.Drawing.Point(174, 197);
            this.ZTranslateTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ZTranslateTextBox.Name = "ZTranslateTextBox";
            this.ZTranslateTextBox.Size = new System.Drawing.Size(36, 23);
            this.ZTranslateTextBox.TabIndex = 40;
            this.ZTranslateTextBox.Text = "1";
            // 
            // YTranslateTextBox
            // 
            this.YTranslateTextBox.Location = new System.Drawing.Point(135, 197);
            this.YTranslateTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.YTranslateTextBox.Name = "YTranslateTextBox";
            this.YTranslateTextBox.Size = new System.Drawing.Size(36, 23);
            this.YTranslateTextBox.TabIndex = 39;
            this.YTranslateTextBox.Text = "1";
            // 
            // XTranslateTextBox
            // 
            this.XTranslateTextBox.Location = new System.Drawing.Point(93, 197);
            this.XTranslateTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.XTranslateTextBox.Name = "XTranslateTextBox";
            this.XTranslateTextBox.Size = new System.Drawing.Size(36, 23);
            this.XTranslateTextBox.TabIndex = 38;
            this.XTranslateTextBox.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 37;
            this.label1.Text = "Поворот";
            // 
            // ZScaleTextBox
            // 
            this.ZScaleTextBox.Location = new System.Drawing.Point(175, 146);
            this.ZScaleTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ZScaleTextBox.Name = "ZScaleTextBox";
            this.ZScaleTextBox.Size = new System.Drawing.Size(36, 23);
            this.ZScaleTextBox.TabIndex = 36;
            this.ZScaleTextBox.Text = "1";
            // 
            // YScaleTextBox
            // 
            this.YScaleTextBox.Location = new System.Drawing.Point(135, 146);
            this.YScaleTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.YScaleTextBox.Name = "YScaleTextBox";
            this.YScaleTextBox.Size = new System.Drawing.Size(36, 23);
            this.YScaleTextBox.TabIndex = 35;
            this.YScaleTextBox.Text = "1";
            // 
            // RotateAngleTextBox
            // 
            this.RotateAngleTextBox.Location = new System.Drawing.Point(93, 225);
            this.RotateAngleTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RotateAngleTextBox.Name = "RotateAngleTextBox";
            this.RotateAngleTextBox.Size = new System.Drawing.Size(116, 23);
            this.RotateAngleTextBox.TabIndex = 34;
            this.RotateAngleTextBox.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 15);
            this.label9.TabIndex = 32;
            this.label9.Text = "Угол";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 15);
            this.label7.TabIndex = 29;
            this.label7.Text = "Масштаб";
            // 
            // XScaleTextBox
            // 
            this.XScaleTextBox.Location = new System.Drawing.Point(94, 146);
            this.XScaleTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.XScaleTextBox.Name = "XScaleTextBox";
            this.XScaleTextBox.Size = new System.Drawing.Size(36, 23);
            this.XScaleTextBox.TabIndex = 26;
            this.XScaleTextBox.Text = "1";
            // 
            // TimerButton
            // 
            this.TimerButton.Location = new System.Drawing.Point(5, 93);
            this.TimerButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TimerButton.Name = "TimerButton";
            this.TimerButton.Size = new System.Drawing.Size(205, 22);
            this.TimerButton.TabIndex = 25;
            this.TimerButton.Text = "Запустить таймер";
            this.TimerButton.UseVisualStyleBackColor = true;
            this.TimerButton.Click += new System.EventHandler(this.TimerButton_Click);
            // 
            // ColorButton
            // 
            this.ColorButton.Location = new System.Drawing.Point(5, 67);
            this.ColorButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(205, 22);
            this.ColorButton.TabIndex = 24;
            this.ColorButton.Text = "Выбрать цвет";
            this.ColorButton.UseVisualStyleBackColor = true;
            this.ColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // DrawButton
            // 
            this.DrawButton.Location = new System.Drawing.Point(5, 119);
            this.DrawButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DrawButton.Name = "DrawButton";
            this.DrawButton.Size = new System.Drawing.Size(205, 22);
            this.DrawButton.TabIndex = 21;
            this.DrawButton.Text = "Нарисовать фигуру";
            this.DrawButton.UseVisualStyleBackColor = true;
            this.DrawButton.Click += new System.EventHandler(this.DrawButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Толщина";
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(101, 42);
            this.WidthTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(110, 23);
            this.WidthTextBox.TabIndex = 12;
            this.WidthTextBox.Text = "2";
            // 
            // SetTransformButton
            // 
            this.SetTransformButton.Location = new System.Drawing.Point(6, 340);
            this.SetTransformButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SetTransformButton.Name = "SetTransformButton";
            this.SetTransformButton.Size = new System.Drawing.Size(204, 22);
            this.SetTransformButton.TabIndex = 10;
            this.SetTransformButton.Text = "Применить трасформацию";
            this.SetTransformButton.UseVisualStyleBackColor = true;
            this.SetTransformButton.Click += new System.EventHandler(this.SetTransformButton_Click);
            // 
            // ZTranslationTextBox
            // 
            this.ZTranslationTextBox.Location = new System.Drawing.Point(175, 170);
            this.ZTranslationTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ZTranslationTextBox.Name = "ZTranslationTextBox";
            this.ZTranslationTextBox.Size = new System.Drawing.Size(36, 23);
            this.ZTranslationTextBox.TabIndex = 7;
            this.ZTranslationTextBox.Text = "0";
            // 
            // YTranslationTextBox
            // 
            this.YTranslationTextBox.Location = new System.Drawing.Point(135, 170);
            this.YTranslationTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.YTranslationTextBox.Name = "YTranslationTextBox";
            this.YTranslationTextBox.Size = new System.Drawing.Size(36, 23);
            this.YTranslationTextBox.TabIndex = 6;
            this.YTranslationTextBox.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Сдвиг";
            // 
            // XTranslationTextBox
            // 
            this.XTranslationTextBox.Location = new System.Drawing.Point(94, 170);
            this.XTranslationTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.XTranslationTextBox.Name = "XTranslationTextBox";
            this.XTranslationTextBox.Size = new System.Drawing.Size(36, 23);
            this.XTranslationTextBox.TabIndex = 3;
            this.XTranslationTextBox.Text = "0";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(5, 367);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(205, 22);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.Text = "Очистить холст";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // RadioButton1
            // 
            this.RadioButton1.AutoSize = true;
            this.RadioButton1.Checked = true;
            this.RadioButton1.Location = new System.Drawing.Point(5, 20);
            this.RadioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RadioButton1.Name = "RadioButton1";
            this.RadioButton1.Size = new System.Drawing.Size(108, 19);
            this.RadioButton1.TabIndex = 0;
            this.RadioButton1.TabStop = true;
            this.RadioButton1.Text = "Обычный ЦДА";
            this.RadioButton1.UseVisualStyleBackColor = true;
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 411);
            this.Controls.Add(this.AlgorithmGroupBox);
            this.Controls.Add(this.DrawPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Ортогональная проекция";
            this.DrawPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.AlgorithmGroupBox.ResumeLayout(false);
            this.AlgorithmGroupBox.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel DrawPanel;
		private System.Windows.Forms.PictureBox PictureBox;
		private System.Windows.Forms.GroupBox AlgorithmGroupBox;
		private System.Windows.Forms.Button ClearButton;
		private System.Windows.Forms.RadioButton RadioButton1;
		private System.Windows.Forms.Button SetTransformButton;
		private System.Windows.Forms.TextBox ZTranslationTextBox;
		private System.Windows.Forms.TextBox YTranslationTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox XTranslationTextBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox WidthTextBox;
		private System.Windows.Forms.Button DrawButton;
		private System.Windows.Forms.ColorDialog ColorDialog;
		private System.Windows.Forms.Button ColorButton;
		private System.Windows.Forms.Button TimerButton;
		private System.Windows.Forms.Timer Timer;
		private System.Windows.Forms.TextBox XScaleTextBox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox RotateAngleTextBox;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox ZScaleTextBox;
		private System.Windows.Forms.TextBox YScaleTextBox;
        private System.Windows.Forms.TextBox ZTranslateTextBox;
        private System.Windows.Forms.TextBox YTranslateTextBox;
        private System.Windows.Forms.TextBox XTranslateTextBox;
        private System.Windows.Forms.Label label1;
    }
}

