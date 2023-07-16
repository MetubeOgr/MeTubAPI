using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeTubApi.Models.Entities
{
    public class Subcription
    {
        public int Id { get; set; }
        public int ChannelId { get; set; }
        public bool Notification { get; set; }
        public DateTime CreatedAt { get;set; }
        public int CreatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int DeletedBy { get; set; }

    }
}
