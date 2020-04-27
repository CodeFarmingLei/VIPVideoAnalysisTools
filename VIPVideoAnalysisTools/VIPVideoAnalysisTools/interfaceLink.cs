using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIPVideoAnalysisTools
{
    public class Link  //网站链接数据Model类
    {
        public string LinkName { get; set; }
        public string LinkSrc { get; set; }

        public Link(string linkName, string linkSrc)
        {
            LinkName = linkName;
            LinkSrc = linkSrc;
        }

    }
}
