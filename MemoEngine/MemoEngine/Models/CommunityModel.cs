using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MemoEngine.Models
{
    public class CommunityModel
    {
        public int CommunityId { get; set; }
        public string CommunityName { get; set; }
        public string CommunityDescription { get; set; }
        public DateTime CreationDate { get; set; }
        public string MeaderHtnl { get; set; }
        public string FooterHtnl { get; set; }
    }
}