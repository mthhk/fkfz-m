/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2017/6/25
 * Time: 12:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace cms_m
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox displayOrder;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox topicName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TabControl contentTab;
		private System.Windows.Forms.TabPage vedioTab;
		private System.Windows.Forms.TabPage mediaTab;
		private System.Windows.Forms.TabPage answerTab;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox videoFilePath;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox videoName;
		private System.Windows.Forms.TextBox videoImgPath;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TreeView contentTree;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button addMediaBtn;
		private System.Windows.Forms.Button button4;
		
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
			System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Root");
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button4 = new System.Windows.Forms.Button();
			this.displayOrder = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.topicName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.contentTree = new System.Windows.Forms.TreeView();
			this.contentTab = new System.Windows.Forms.TabControl();
			this.vedioTab = new System.Windows.Forms.TabPage();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.videoName = new System.Windows.Forms.TextBox();
			this.videoImgPath = new System.Windows.Forms.TextBox();
			this.videoFilePath = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.mediaTab = new System.Windows.Forms.TabPage();
			this.button5 = new System.Windows.Forms.Button();
			this.addMediaBtn = new System.Windows.Forms.Button();
			this.answerTab = new System.Windows.Forms.TabPage();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.contentTab.SuspendLayout();
			this.vedioTab.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.mediaTab.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button4);
			this.groupBox1.Controls.Add(this.displayOrder);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.topicName);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(803, 62);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "主题基本信息";
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(596, 18);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 2;
			this.button4.Text = "初始化";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// displayOrder
			// 
			this.displayOrder.Location = new System.Drawing.Point(268, 20);
			this.displayOrder.Name = "displayOrder";
			this.displayOrder.Size = new System.Drawing.Size(85, 21);
			this.displayOrder.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(209, 23);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 0;
			this.label3.Text = "显示顺序";
			// 
			// topicName
			// 
			this.topicName.Location = new System.Drawing.Point(72, 20);
			this.topicName.Name = "topicName";
			this.topicName.Size = new System.Drawing.Size(114, 21);
			this.topicName.TabIndex = 1;
			this.topicName.Text = "最多六个字";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(6, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "主题名称";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.contentTree);
			this.groupBox2.Controls.Add(this.contentTab);
			this.groupBox2.Location = new System.Drawing.Point(12, 80);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(803, 469);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "主题内容";
			// 
			// contentTree
			// 
			this.contentTree.Location = new System.Drawing.Point(10, 20);
			this.contentTree.Name = "contentTree";
			treeNode1.Name = "mediaRoot";
			treeNode1.Text = "Root";
			this.contentTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
			treeNode1});
			this.contentTree.Size = new System.Drawing.Size(783, 275);
			this.contentTree.TabIndex = 4;
			// 
			// contentTab
			// 
			this.contentTab.Controls.Add(this.vedioTab);
			this.contentTab.Controls.Add(this.mediaTab);
			this.contentTab.Controls.Add(this.answerTab);
			this.contentTab.Location = new System.Drawing.Point(6, 301);
			this.contentTab.Name = "contentTab";
			this.contentTab.SelectedIndex = 0;
			this.contentTab.Size = new System.Drawing.Size(791, 132);
			this.contentTab.TabIndex = 2;
			// 
			// vedioTab
			// 
			this.vedioTab.Controls.Add(this.groupBox3);
			this.vedioTab.Location = new System.Drawing.Point(4, 22);
			this.vedioTab.Name = "vedioTab";
			this.vedioTab.Padding = new System.Windows.Forms.Padding(3);
			this.vedioTab.Size = new System.Drawing.Size(783, 106);
			this.vedioTab.TabIndex = 0;
			this.vedioTab.Text = "视频";
			this.vedioTab.UseVisualStyleBackColor = true;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.button3);
			this.groupBox3.Controls.Add(this.button2);
			this.groupBox3.Controls.Add(this.videoName);
			this.groupBox3.Controls.Add(this.videoImgPath);
			this.groupBox3.Controls.Add(this.videoFilePath);
			this.groupBox3.Controls.Add(this.button1);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Location = new System.Drawing.Point(3, 6);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(771, 100);
			this.groupBox3.TabIndex = 1;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "视频基本信息";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(652, 53);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(100, 31);
			this.button3.TabIndex = 5;
			this.button3.Text = "添加";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(460, 53);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 4;
			this.button2.Text = "浏览";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// videoName
			// 
			this.videoName.Location = new System.Drawing.Point(92, 18);
			this.videoName.Name = "videoName";
			this.videoName.Size = new System.Drawing.Size(100, 21);
			this.videoName.TabIndex = 2;
			// 
			// videoImgPath
			// 
			this.videoImgPath.Location = new System.Drawing.Point(92, 55);
			this.videoImgPath.Name = "videoImgPath";
			this.videoImgPath.Size = new System.Drawing.Size(351, 21);
			this.videoImgPath.TabIndex = 3;
			// 
			// videoFilePath
			// 
			this.videoFilePath.Location = new System.Drawing.Point(349, 18);
			this.videoFilePath.Name = "videoFilePath";
			this.videoFilePath.Size = new System.Drawing.Size(351, 21);
			this.videoFilePath.TabIndex = 3;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(706, 16);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(59, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "浏览";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(7, 58);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 0;
			this.label5.Text = "视频首图路径";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(252, 21);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 0;
			this.label4.Text = "视频源文件路径";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(7, 21);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "视频显示名称";
			// 
			// mediaTab
			// 
			this.mediaTab.Controls.Add(this.button5);
			this.mediaTab.Controls.Add(this.addMediaBtn);
			this.mediaTab.Location = new System.Drawing.Point(4, 22);
			this.mediaTab.Name = "mediaTab";
			this.mediaTab.Padding = new System.Windows.Forms.Padding(3);
			this.mediaTab.Size = new System.Drawing.Size(783, 106);
			this.mediaTab.TabIndex = 1;
			this.mediaTab.Text = "多媒体";
			this.mediaTab.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(586, 49);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(98, 33);
			this.button5.TabIndex = 4;
			this.button5.Text = "删除多媒体";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// addMediaBtn
			// 
			this.addMediaBtn.Location = new System.Drawing.Point(137, 49);
			this.addMediaBtn.Name = "addMediaBtn";
			this.addMediaBtn.Size = new System.Drawing.Size(98, 33);
			this.addMediaBtn.TabIndex = 4;
			this.addMediaBtn.Text = "添加多媒体";
			this.addMediaBtn.UseVisualStyleBackColor = true;
			this.addMediaBtn.Click += new System.EventHandler(this.AddMediaBtnClick);
			// 
			// answerTab
			// 
			this.answerTab.Location = new System.Drawing.Point(4, 22);
			this.answerTab.Name = "answerTab";
			this.answerTab.Padding = new System.Windows.Forms.Padding(3);
			this.answerTab.Size = new System.Drawing.Size(783, 106);
			this.answerTab.TabIndex = 2;
			this.answerTab.Text = "知识问答";
			this.answerTab.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(827, 564);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "cms-m";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.contentTab.ResumeLayout(false);
			this.vedioTab.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.mediaTab.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
