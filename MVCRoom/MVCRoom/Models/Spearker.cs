using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCRoom.Models
{
    public class Spearker
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int RoomSpeakerId { get; set; }
        public string Name { get; set; }
        public int RoomId { get; set; }

        public virtual Room Room { get; set; }
    }
}