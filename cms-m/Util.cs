﻿/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2017/6/25
 * Time: 15:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Windows.Forms;
namespace cms_m
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public class Util
	{
		private Util()
		{
		}
		public static Boolean isEmpty(string content)
		{
			return content == null || content.Length < 1;
		}
		public static Boolean isEmpty(TextBox tb)
		{
			return tb == null || isEmpty(tb.Text);
		}
		public static Boolean isEmpty(params TextBox[] TextBoxs)
		{
			foreach (var textBox in TextBoxs) {
				if (isEmpty(textBox)) {
					return true;
				}
			}
			return false;
		}

        public static Boolean ValidateDir(String dir)
        {
            if (!isEmpty(dir))
            {
                DirectoryInfo info = new DirectoryInfo(dir);
                return info.Exists;
            }

            return false;
        }
	}
}
