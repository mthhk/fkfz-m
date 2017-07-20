/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2017/6/25
 * Time: 15:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

using System.Collections.Generic;
namespace cms_m.pos
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public class Media
	{
		public String name { get; set; }
		public String firstImgPath { get; set; }
		public String audioFiltPath { get; set; }
		public List<MediaPage>  mediaPages { get; set; }

		public Media()
		{
			
		}
	}
}
