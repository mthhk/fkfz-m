using cms_m.pos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace cms_m.utils
{
    public class XmlWriter
    {
        public static void CreateVideoXml(String absPath)
        {
            XDocument doc = new XDocument();
            XDeclaration xDeclaration = new XDeclaration("1.0", "utf-8", "yes");
            doc.Declaration = xDeclaration;    //指定XML声明对象  
            XElement xElement = new XElement("videos");
            doc.Add(xElement);
            doc.Save(absPath);
        }

        public static bool AddVideoInfo(String absPath, Video param, int id)
        {
            XElement xml = XElement.Load(absPath);
            //创建book节点  
            XElement bookXml = new XElement("video");
            //添加属性  
            bookXml.Add(new XAttribute("Type", "sub"));
            //添加子节点  
            bookXml.Add(new XElement("id", id));
            bookXml.Add(new XElement("title", param.name));
            bookXml.Add(new XElement("path", FileUtil.GetFileNameFromPath(param.filePath)));
            bookXml.Add(new XElement("cover", FileUtil.GetFileNameFromPath(param.firstImg)));
            xml.Add(bookXml);
            //保存  
            xml.Save(absPath);
            return true;
        }

        public static void CreateMultiXml(String absPath)
        {
            XDocument doc = new XDocument();
            XDeclaration xDeclaration = new XDeclaration("1.0", "utf-8", "yes");
            doc.Declaration = xDeclaration;    //指定XML声明对象  
            XElement xElement = new XElement("MultiMedias");
            doc.Add(xElement);
            doc.Save(absPath);
        }

        public static bool AddMultiInfo(String absPath, MediaPage param, int id)
        {
            XElement xml = XElement.Load(absPath);
            //创建book节点  
            XElement bookXml = new XElement("page");
            //添加子节点  
            bookXml.Add(new XElement("id", id));
            bookXml.Add(new XElement("Name", param.note));
            bookXml.Add(new XElement("StartTime", param.startTime));
            bookXml.Add(new XElement("TextPath", FileUtil.GetFileNameFromPath(param.textPath)));

            XElement p1 = new XElement("PicPath", FileUtil.GetFileNameFromPath(param.img1));
            p1.Add(new XAttribute("index", "0"));
            bookXml.Add(p1);

            XElement p2 = new XElement("PicPath", FileUtil.GetFileNameFromPath(param.img2));
            p2.Add(new XAttribute("index", "1"));
            bookXml.Add(p2);

            xml.Add(bookXml);
            //保存  
            xml.Save(absPath);
            return true;
        }

        public static void CreateQAXml(String absPath)
        {
            XDocument doc = new XDocument();
            XDeclaration xDeclaration = new XDeclaration("1.0", "utf-8", "yes");
            doc.Declaration = xDeclaration;    //指定XML声明对象  
            XElement xElement = new XElement("questions");
            doc.Add(xElement);
            doc.Save(absPath);
        }

        public static bool AddQAInfo(String absPath, Awser param, int id)
        {
            XElement xml = XElement.Load(absPath);
            //创建book节点  
            XElement bookXml = new XElement("question");
            //添加子节点  
            bookXml.Add(new XElement("id", id));
            bookXml.Add(new XElement("title", param.title));
            bookXml.Add(new XElement("score", param.score));
            bookXml.Add(new XElement("answerid", param.awserIndex));

            if (null != param.items && param.items.Count > 0)
            {
                foreach (Option v in param.items)
                {
                    XElement p = new XElement("option", v.Title);
                    p.Add(new XAttribute("id", v.Id));
                    bookXml.Add(p);
                }
            }
            xml.Add(bookXml);
            //保存  
            xml.Save(absPath);
            return true;
        }


        
    }
}
