/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2017/6/25
 * Time: 14:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using cms_m.pos;
using System.Collections.Generic;
namespace cms_m
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class MediaAddForm : Form
	{
		// callback best , but ,fuck that~
		public TreeNode resultNode = null;
		private Media media;
		
		public MediaAddForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button6Click(object sender, EventArgs e)
		{
			var ofd = new OpenFileDialog(); 
			ofd.Filter = "*.mp3|*.MP3";
			if (ofd.ShowDialog() == DialogResult.OK) {
				audioPath.Text = ofd.FileName.ToString();
			}
		}
		void Button5Click(object sender, EventArgs e)
		{
			var ofd = new OpenFileDialog(); 
			ofd.Filter = "*.jpg|*.JPG|*.jpeg|*.png";
			if (ofd.ShowDialog() == DialogResult.OK) {
				firstImgPath.Text = ofd.FileName.ToString();
			}
		}
		void Label2Click(object sender, EventArgs e)
		{
	
		}
		void Button3Click(object sender, EventArgs e)
		{
			// content check
			if (Util.isEmpty(img1, img2, text, startTimeText, note)) {
				MessageBox.Show("所有选项均为必填项");
				return;
			}
			MediaPage page = new MediaPage();
			page.img1 = img1.Text;
			page.img2 = img2.Text;
			page.startTime = startTimeText.Text;
			page.text = text.Text;
			page.note = note.Text;
			if (media.mediaPages == null) {
				media.mediaPages = new List<MediaPage>();
			}
			media.mediaPages.Add(page);
			render();
			img1.Text = null;
			img2.Text = null;
			startTimeText.Text = null;
			note.Text = null;
			text.Text = null;
			
		}
		void Button1Click(object sender, EventArgs e)
		{
			var ofd = new OpenFileDialog(); 
			ofd.Filter = "*.jpg|*.JPG|*.jpeg|*.png";
			if (ofd.ShowDialog() == DialogResult.OK) {
				img1.Text = ofd.FileName.ToString();
			}
			
		}
		void Button2Click(object sender, EventArgs e)
		{
			var ofd = new OpenFileDialog(); 
			ofd.Filter = "*.jpg|*.JPG|*.jpeg|*.png";
			if (ofd.ShowDialog() == DialogResult.OK) {
				img2.Text = ofd.FileName.ToString();
			}
		}
		void Button4Click(object sender, EventArgs e)
		{
			MainForm.lastInvokeResult = this.media;
			this.Close();
		}
		void Button7Click(object sender, EventArgs e)
		{
			if (Util.isEmpty(name, audioPath, firstImgPath)) {
				MessageBox.Show("所有选项均为必填项");
				return;
			}
			if (media == null) {
				media = new Media();
			}
			
			media.audioFiltPath = audioPath.Text;
			media.firstImgPath = firstImgPath.Text;
			media.name = name.Text;
			render();
		}
		private void render()
		{
			contentTree.Nodes.Clear();
			
			if (media != null) {
				var root = new TreeNode("name:" + media.name);
				root.Nodes.Add(new TreeNode("firstImg:" + media.firstImgPath));
				root.Nodes.Add(new TreeNode("audioFilePath:" + media.audioFiltPath));
				if (media.mediaPages != null) {
					TreeNode[] allPageNodes = new TreeNode[media.mediaPages.Count];
					for (int i = 0; i < media.mediaPages.Count; i++) {
						MediaPage page = (MediaPage)(media.mediaPages[i]);
						var pageNode = new TreeNode[5];
						pageNode[0] = new TreeNode("name:" + page.note);
						pageNode[1] = new TreeNode("img1:" + page.img1);
						pageNode[2] = new TreeNode("img2:" + page.img2);
						pageNode[3] = new TreeNode("text:" + page.text);
						pageNode[4] = new TreeNode("start:" + page.startTime);
						allPageNodes[i] = new TreeNode(page.note, pageNode);
						;
					}
					root.Nodes.Add(new TreeNode("pages", allPageNodes));
				}
				contentTree.Nodes.Add(root);
			}
			
		}
		void MediaAddFormLoad(object sender, EventArgs e)
		{
			MainForm.lastInvokeResult = null;
		}
		void Button8Click(object sender, EventArgs e)
		{
			var ofd = new OpenFileDialog(); 
			ofd.Filter = "文本文件(*.txt)|*.txt";
			if (ofd.ShowDialog() == DialogResult.OK) {
				var filePath = ofd.FileName.ToString();
				using (var reader = new StreamReader(filePath, Encoding.Default)) {
					text.Text = reader.ReadToEnd();
				} 
			}
		}
	}
}
