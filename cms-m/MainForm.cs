/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2017/6/25
 * Time: 12:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using cms_m.pos;
namespace cms_m
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		// xixi ~~~
		public static Object lastInvokeResult = null;
		
		
		private Topic topic;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void GroupBox1Enter(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			var ofd = new OpenFileDialog(); 
			ofd.Filter = "*.mp4|*.MP4|*.wmv|*.WMV";
			if (ofd.ShowDialog() == DialogResult.OK) {
				videoFilePath.Text = ofd.FileName.ToString();
			}
		
			
		}
		void Button2Click(object sender, EventArgs e)
		{
			var ofd = new OpenFileDialog(); 
			ofd.Filter = "*.jpg|*.JPG|*.jpeg|*.png";
			if (ofd.ShowDialog() == DialogResult.OK) {
				videoImgPath.Text = ofd.FileName.ToString();
			}
		}
		void Button3Click(object sender, EventArgs e)
		{
			if (videoName.Text == null || videoName.Text.Length < 1 || videoImgPath.Text == null || videoImgPath.Text.Length < 1 || videoFilePath.Text == null || videoFilePath.Text.Length < 1) {
				alert("所有内容均为必填项");
				return;
			}
			if (this.topic == null) {
				alert("主题还未初始化");
				return;
			}
			var video = new Video();
			video.name = videoName.Text;
			video.firstImg = videoImgPath.Text;
			video.filePath = videoFilePath.Text;
			if (topic.videos == null) {
				topic.videos = new List<Video>();
			}
			topic.videos.Add(video);
			render();
			clearVideoInput();
		}
		void clearVideoInput()
		{
			videoName.Text = null;
			videoImgPath.Text = null;
			videoFilePath.Text = null;
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			var ofd = new OpenFileDialog(); 
			ofd.Filter = "*.jpg|*.JPG|*.jpeg|*.png";
			if (ofd.ShowDialog() == DialogResult.OK) {
				videoImgPath.Text = ofd.FileName.ToString();
			}
		}
		void AddMediaBtnClick(object sender, EventArgs e)
		{
			if (topic == null) {
				alert("还未初始化");
				return;
			}
			MainForm.lastInvokeResult = null;
			new MediaAddForm().ShowDialog();
			if (MainForm.lastInvokeResult != null) {
				if (topic == null) {
					topic = new Topic();
				}
				Media media = (Media)MainForm.lastInvokeResult;
				topic.medias.Add(media);
			}
			render();
		}
		//				Media media = (Meidea)MainForm.lastInvokeResult;
		//				if (media.mediaPages != null) {
		//					TreeNode[] pages = new TreeNode[media.mediaPages.Count];
		//					for (int i = 0; i < media.mediaPages.Count; i++) {
		//						MediaPage page = media.mediaPages[i];
		//						var pageNode = new TreeNode[5];
		//						pageNode[0] = new TreeNode("name:" + page.note);
		//						pageNode[1] = new TreeNode("img1:" + page.img1);
		//						pageNode[2] = new TreeNode("img2:" + page.img2);
		//						pageNode[3] = new TreeNode("text:" + page.text);
		//						pageNode[4] = new TreeNode("start:" + page.startTime);
		//						allPageNodes[i] = new TreeNode(page.note, pageNode);
		//					}
		//				}
		//			}
						
		 
		void Button4Click(object sender, EventArgs e)
		{
			if (Util.isEmpty(topicName, displayOrder)) {
				alert("所有选项均为必填项");
				return;
			}
			if (topic == null) {
				topic = new Topic();
			}
			this.topic.name = topicName.Text;
			this.topic.disOrder = Int16.Parse(displayOrder.Text);
			render();
		}
		public void render()
		{
			// init content tree
			var videoNode = new TreeNode("视频");
			var mediaNode = new TreeNode("多媒体");
			var answerNode = new TreeNode("知识问答");
			contentTree.Nodes.Clear();
			contentTree.Nodes.Add(videoNode);
			contentTree.Nodes.Add(mediaNode);
			contentTree.Nodes.Add(answerNode);
			// step 1__video
			if (topic.videos != null && topic.videos.Count > 0) {
				foreach (var video in topic.videos) {
					TreeNode node = new TreeNode(video.name);
					node.Nodes.Add(new TreeNode("首图：" + video.firstImg));
					node.Nodes.Add(new TreeNode("文件路径：" + video.filePath));
					videoNode.Nodes.Add(node);
				}
			}
			// step 2__media
			if (topic.medias != null && topic.medias.Count > 0) {
				foreach (var media in topic.medias) {
					var node = new TreeNode(media.name);
					node.Nodes.Add(new TreeNode("首图：" + media.firstImgPath));
					node.Nodes.Add(new TreeNode("音频路径：" + media.audioFiltPath));
					var pages = new TreeNode("pages");
					foreach (var page in media.mediaPages) {
						var pageNode = new TreeNode(page.note);
						pageNode.Nodes.Add(new TreeNode("img1:" + page.img1));
						pageNode.Nodes.Add(new TreeNode("img2:" + page.img2));
						pageNode.Nodes.Add(new TreeNode("开始时间：" + page.startTime));
						pageNode.Nodes.Add(new TreeNode("文本【" + page.text + "】"));
						pages.Nodes.Add(pageNode);
					}
					node.Nodes.Add(pages);
					mediaNode.Nodes.Add(node);
				}
			}
			// step 3__quession
			if (topic.awser != null && topic.awser.Count > 0) {
				foreach (var awnser in topic.awser) {
					var node = new TreeNode(awnser.title);
					node.Nodes.Add(new TreeNode("分数：" + awnser.score));
					for (int i = 0; i < 4; i++) {
						var item = awnser.items[i];
						Boolean rightAwnser = awnser.awserIndex == i;
						if (rightAwnser) {
							node.Nodes.Add(new TreeNode("[" + "ABCD".Substring(i, 1) + "]√√√" + item));
						} else {
							node.Nodes.Add(new TreeNode("[" + "ABCD".Substring(i, 1) + "]" + item));
						}
						
					}
					answerNode.Nodes.Add(node);
				}
			}
		}
		 
		void alert(string msg)
		{
			MessageBox.Show(msg);
		}

        private void button6_Click(object sender, EventArgs e)
        {
            if (null != topic)
            {
                topic.CreateTopic("D:");
            }
        }
		void Button5Click(object sender, EventArgs e)
		{
			if (Util.isEmpty(quession, anwserA, anwserB, anwserC, anwserD, score)) {
				alert("所有选项均为必填项");
				return;
			}
			if (topic == null) {
				alert("还未初始化");
				return;
			}
			var awser = new Awser();
			awser.awserIndex = getAwnserIndex();
			awser.score = Int32.Parse(score.Text);
			awser.title = quession.Text;
            awser.items.Add(new Option(0,anwserA.Text));
			awser.items.Add(new Option(1,anwserB.Text));
			awser.items.Add(new Option(2,anwserC.Text));
			awser.items.Add(new Option(3,anwserD.Text));
			topic.awser.Add(awser);
			quession.Text = "";
			anwserA.Text = "";
			anwserB.Text = "";
			anwserD.Text = "";
			anwserC.Text = "";
            score.Text = "";
			render();
		}
		
		public   int getAwnserIndex()
		{
			if (rightAnwserA.Checked) {
				return 0;
			} else if (rightAnwserB.Checked) {
				return 1;
			} else if (rightAnwserC.Checked) {
				return 2;
			} else if (rightAnwserD.Checked) {
				return 3;
			}
			return 0;
		}
		void GenerateBtnClick(object sender, EventArgs e)
		{
            if (!Util.ValidateDir(textBox1.Text))
            {
                alert("请选择有效的主题存储路径");
                return;
            }
            if (null != topic)
            {
                topic.CreateTopic(textBox1.Text);
            }
		}

        private void button7_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = folderBrowserDialog1.SelectedPath;
                textBox1.Text = path;
            }
        }
	}
}
