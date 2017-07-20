/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2017/6/25
 * 时间: 16:10
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Collections.Generic;
namespace cms_m.pos
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public class Topic
	{
		public String name{ get; set; }
		public int disOrder{ get; set; }
		public List<Media> medias { get; set; }
		public List<Video> videos { get; set; }
		public Awser awser { get; set; }
		
		public Topic()
		{
			// fuck myself~
			medias=new List<Media>();
			videos=new List<Video>();
		}
	}
}
