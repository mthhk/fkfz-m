/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2017/6/25
 * 时间: 17:21
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Collections.Generic;
namespace cms_m.pos
{
	/// <summary>
	/// Description of Awser.
	/// </summary>
	public class Awser
	{
		public String title { get; set; }
        public List<Option> items { get; set; }
		/**正确答案在items中的索引**/
		public int awserIndex { get; set; }
		public int score { get; set; }
		
		public Awser()
		{
            items = new List<Option>();
		}
	}
}
