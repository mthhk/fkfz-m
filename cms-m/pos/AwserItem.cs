/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2017/6/25
 * 时间: 17:26
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Collections.Generic;
namespace cms_m.pos
{
    public class Option
    {
        public Option() { }

        public Option(int id, String title)
        {
            Id = id;
            Title = title;
        }
        public int Id { get; set; }
        public String Title { get; set; }
    }
}
