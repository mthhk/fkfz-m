using cms_m.utils;
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
using System.Diagnostics;
using System.IO;

namespace cms_m.pos
{
    /// <summary>
    /// Description of Class1.
    /// </summary>
    public class Topic
    {
        public String name { get; set; }
        public int disOrder { get; set; }
        public List<Media> medias { get; set; }
        public List<Video> videos { get; set; }
        public List<Awser> awser { get; set; }

        public Topic()
        {
            // fuck myself~
            medias = new List<Media>();
            videos = new List<Video>();
            awser = new List<Awser>();
        }

        public bool CreateTopic(String path)
        {
            if (!path.EndsWith("\\"))
            {
                path += "\\";
            }
            //创建视频
            string tpath = path + disOrder + "@" + name;
            Directory.CreateDirectory(tpath);
            if (videos.Count > 0)
            {
                string vp = tpath + "\\视频";

                Directory.CreateDirectory(vp);

                XmlWriter.CreateVideoXml(vp + "\\config.xml");
                for (int i = 0; i < videos.Count; i++)
                {
                    string fname = FileUtil.GetFileNameFromPath(videos[i].filePath);
                    CopyResult Result = CopyFile(videos[i].filePath, vp, fname);
                    if (2 == Result.result)
                    {
                        videos[i].filePath = vp + "\\" + Result.name;
                    }

                    fname = FileUtil.GetFileNameFromPath(videos[i].firstImg);
                    Result = CopyFile(videos[i].firstImg, vp, fname);
                    if (2 == Result.result)
                    {
                        videos[i].firstImg = vp + "\\" + Result.name;
                    }

                    XmlWriter.AddVideoInfo(vp + "\\config.xml", videos[i], i);
                }
            }
            //创建多媒体
            if (medias.Count > 0)
            {
                string mp = tpath + "\\多媒体";
                Directory.CreateDirectory(mp);
                string tmpPath;
                for (int i = 0; i < medias.Count; i++)
                {
                    tmpPath = mp + "\\" + i + "@" + medias[i].name;
                    Directory.CreateDirectory(tmpPath);
                    string fname = FileUtil.GetFileNameFromPath(medias[i].audioFiltPath);
                    CopyResult Result = CopyFile(medias[i].audioFiltPath, tmpPath, fname);
                    if (2 == Result.result)
                    {
                        medias[i].audioFiltPath = tmpPath + "\\" + Result.name;
                    }

                    List<MediaPage> pages = medias[i].mediaPages;
                    if (null != pages)
                    {
                        XmlWriter.CreateMultiXml(tmpPath + "\\config.xml");
                        for (int j = 0; j < pages.Count; j++)
                        {
                            string tname = FileUtil.GetFileNameFromPath(pages[j].img1);
                            CopyResult ResPage = CopyFile(pages[j].img1, tmpPath, tname);
                            if (2 == ResPage.result)
                            {
                                pages[j].img1 = tmpPath + "\\" + ResPage.name;
                            }

                            tname = FileUtil.GetFileNameFromPath(pages[j].img2);
                            ResPage = CopyFile(pages[j].img2, tmpPath, tname);
                            if (2 == ResPage.result)
                            {
                                pages[j].img2 = tmpPath + "\\" + ResPage.name;
                            }

                            tname = FileUtil.GetFileNameFromPath(pages[j].textPath);
                            ResPage = CopyFile(pages[j].textPath, tmpPath, tname);
                            if (2 == ResPage.result)
                            {
                                pages[j].textPath = tmpPath + "\\" + ResPage.name;
                            }

                            XmlWriter.AddMultiInfo(tmpPath + "\\config.xml", pages[j], j);
                        }
                    }
                }
            }
            //创建知识问答
            if (null != awser)
            {
                string mp = tpath + "\\知识问答";
                Directory.CreateDirectory(mp);
                XmlWriter.CreateQAXml(mp + "\\config.xml");
                List<Awser> items = awser;
                if (null != items)
                {
                    for (int i = 0; i < items.Count; i++)
                    {
                        XmlWriter.AddQAInfo(mp + "\\config.xml", items[i], i);
                    }
                }
            }

            return true;
        }

        private CopyResult CopyFile(String srcPath, String dstPath, String fname)
        {
            CopyResult Result = new CopyResult();
            try
            {
                FileInfo fi = new FileInfo(dstPath + "\\" + fname);
                if (fi.Exists)
                {
                    Result.name = Rename(fname);
                    Result.result = 2;
                }
                fi = new FileInfo(srcPath);
                if (fi.Exists)
                {
                    fi.CopyTo(dstPath + "\\" + (Result.name == null ? fname : Result.name));
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Result.result = 1;
            }
            return Result;
        }

        private string Rename(String fname)
        {
            if (null != fname)
            {
                int index = fname.LastIndexOf(".");
                if (-1 != index)
                {
                    string ext = fname.Substring(index);
                    string name = fname.Substring(0, index);
                    return name + "- 副本" + ext;
                }
            }

            return null;
        }
    }

    public class CopyResult
    {
        /**
         * 0:成功
         * 1：失败
         * 2：需要重命名
         */
        public int result { get; set; }

        public string name { get; set; }
    }
}