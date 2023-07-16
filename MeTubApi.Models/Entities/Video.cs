using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeTubApi.Models.Entities
{
    public class Video
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int NumOfLike { get; set; }
        public int NumOfDisLike { get; set; }
        public int NumOfView { get; set; }
        public string Thumbnail { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime LastUpdatedAt { get; set; }
        public int LastUpdatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int DeletedBy { get; set; }
    }
}
