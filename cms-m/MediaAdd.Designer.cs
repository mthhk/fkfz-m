/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2017/6/25
 * Time: 14:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace cms_m
{
	partial class MediaAddForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.TextBox name;
		private System.Windows.Forms.TextBox firstImgPath;
		private System.Windows.Forms.TextBox audioPath;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TreeView contentTree;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox img2;
		private System.Windows.Forms.TextBox img1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox text;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox note;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.TextBox startTimeText;
		private System.Windows.Forms.Button button8;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.button7 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.name = new System.Windows.Forms.TextBox();
			this.firstImgPath = new System.Windows.Forms.TextBox();
			this.audioPath = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.button6 = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.contentTree = new System.Windows.Forms.TreeView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button8 = new System.Windows.Forms.Button();
			this.startTimeText = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.note = new System.Windows.Forms.TextBox();
			this.text = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.img2 = new System.Windows.Forms.TextBox();
			this.img1 = new System.Windows.Forms.TextBox();
			this.groupBox4.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.button7);
			this.groupBox4.Controls.Add(this.button5);
			this.groupBox4.Controls.Add(this.name);
			this.groupBox4.Controls.Add(this.firstImgPath);
			this.groupBox4.Controls.Add(this.audioPath);
			this.groupBox4.Controls.Add(this.label6);
			this.groupBox4.Controls.Add(this.button6);
			this.groupBox4.Controls.Add(this.label7);
			this.groupBox4.Controls.Add(this.label8);
			this.groupBox4.Location = new System.Drawing.Point(12, 12);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(771, 102);
			this.groupBox4.TabIndex = 3;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "多媒体基本信息";
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(551, 63);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(75, 23);
			this.button7.TabIndex = 5;
			this.button7.Text = "初始化";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.Button7Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(672, 16);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 23);
			this.button5.TabIndex = 4;
			this.button5.Text = "浏览";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// name
			// 
			this.name.Location = new System.Drawing.Point(113, 21);
			this.name.Name = "name";
			this.name.Size = new System.Drawing.Size(155, 21);
			this.name.TabIndex = 1;
			// 
			// firstImgPath
			// 
			this.firstImgPath.Location = new System.Drawing.Point(489, 18);
			this.firstImgPath.Name = "firstImgPath";
			this.firstImgPath.Size = new System.Drawing.Size(155, 21);
			this.firstImgPath.TabIndex = 2;
			// 
			// audioPath
			// 
			this.audioPath.Location = new System.Drawing.Point(113, 63);
			this.audioPath.Name = "audioPath";
			this.audioPath.Size = new System.Drawing.Size(155, 21);
			this.audioPath.TabIndex = 3;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(377, 21);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 0;
			this.label6.Text = "多媒体首图路径";
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(292, 63);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(75, 23);
			this.button6.TabIndex = 2;
			this.button6.Text = "浏览";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.Button6Click);
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(7, 66);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 0;
			this.label7.Text = "音频源文件路径";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(7, 24);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 0;
			this.label8.Text = "多媒体显示名称";
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(331, 504);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(100, 31);
			this.button4.TabIndex = 5;
			this.button4.Text = "确定并返回";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.contentTree);
			this.groupBox1.Location = new System.Drawing.Point(12, 120);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(771, 378);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "多媒体内容信息";
			// 
			// contentTree
			// 
			this.contentTree.Location = new System.Drawing.Point(7, 20);
			this.contentTree.Name = "contentTree";
			this.contentTree.Size = new System.Drawing.Size(758, 159);
			this.contentTree.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.button8);
			this.groupBox2.Controls.Add(this.startTimeText);
			this.groupBox2.Controls.Add(this.button3);
			this.groupBox2.Controls.Add(this.note);
			this.groupBox2.Controls.Add(this.text);
			this.groupBox2.Controls.Add(this.button2);
			this.groupBox2.Controls.Add(this.button1);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.img2);
			this.groupBox2.Controls.Add(this.img1);
			this.groupBox2.Location = new System.Drawing.Point(18, 317);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(759, 162);
			this.groupBox2.TabIndex = 8;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "多媒体单页信息";
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(16, 82);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(75, 23);
			this.button8.TabIndex = 9;
			this.button8.Text = "从文件上传";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.Button8Click);
			// 
			// startTimeText
			// 
			this.startTimeText.Location = new System.Drawing.Point(80, 125);
			this.startTimeText.Name = "startTimeText";
			this.startTimeText.Size = new System.Drawing.Size(248, 21);
			this.startTimeText.TabIndex = 7;
			this.startTimeText.Text = "输入这段文字在背景音乐中的起始时间，格式：时:分:秒，比如：00:00:32";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(654, 128);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 6;
			this.button3.Text = "添加";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// note
			// 
			this.note.Location = new System.Drawing.Point(435, 125);
			this.note.Name = "note";
			this.note.Size = new System.Drawing.Size(203, 21);
			this.note.TabIndex = 8;
			// 
			// text
			// 
			this.text.Location = new System.Drawing.Point(107, 52);
			this.text.Multiline = true;
			this.text.Name = "text";
			this.text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.text.Size = new System.Drawing.Size(634, 63);
			this.text.TabIndex = 6;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(653, 17);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "浏览";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(292, 20);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "浏览";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(383, 26);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "图片2";
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(371, 128);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(58, 23);
			this.label5.TabIndex = 1;
			this.label5.Text = "小节备注";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 128);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(58, 23);
			this.label4.TabIndex = 1;
			this.label4.Text = "起始时间点";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 56);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 23);
			this.label3.TabIndex = 1;
			this.label3.Text = "文本内容";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "图片1";
			// 
			// img2
			// 
			this.img2.Location = new System.Drawing.Point(435, 20);
			this.img2.Name = "img2";
			this.img2.Size = new System.Drawing.Size(203, 21);
			this.img2.TabIndex = 5;
			// 
			// img1
			// 
			this.img1.Location = new System.Drawing.Point(80, 20);
			this.img1.Name = "img1";
			this.img1.Size = new System.Drawing.Size(203, 21);
			this.img1.TabIndex = 4;
			// 
			// MediaAddForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(786, 541);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.groupBox4);
			this.Name = "MediaAddForm";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.MediaAddFormLoad);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
