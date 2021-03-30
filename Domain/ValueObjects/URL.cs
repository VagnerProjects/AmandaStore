using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmandaStore.Domain.ValueObjects
{
    public class URL
    {
        public string Link { get; private set; }

        protected URL() { }

        public URL(string link)
        {
            Link = link;
        }

        public void SetLink(string urlLink)
        {
            if (!string.IsNullOrEmpty(urlLink))
            {
                if (urlLink.Contains("http"))
                    this.Link = urlLink;
                else
                    this.Link = "http://" + urlLink;
            }
        }
    }
}
