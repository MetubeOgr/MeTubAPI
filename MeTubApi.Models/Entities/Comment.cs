using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeTubApi.Models.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public int VideoId { get; set; }
        public int? CommentId { get; set; }
        public string Content { get; set; }
        public int NumOfLike { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime LastUpdatedAt { get; set; }
        public int LastUpdatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int DeletedBy { get; set; }
    }
}
