using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcConf.Models
{
    public class Room
    {
        public int RoomId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Speaker> Speakers { get; set; }
    }
}