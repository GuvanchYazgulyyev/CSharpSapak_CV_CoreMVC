namespace CV_Proyekt.Models.SqlModels
{
    public class FeaturedPosts
    {
        public Int64 Id { get; set; }
        public string Title { get; set; }

        public DateTime? CreatedTime { get; set; }
        public string PostedBy { get; set; }
        public string Description { get; set; }
        public string ReadMoreUrl { get; set; }


        public string BlogTitle { get; set; }
        public string BlogPictureUrls { get; set; }

        public string BlogDescription { get; set;  }
    }
}
