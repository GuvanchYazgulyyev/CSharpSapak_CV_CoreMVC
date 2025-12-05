namespace CV_Proyekt.Models.SqlModels
{
    public class Blog
    {

        public Int64 Id { get; set; }

        public string IconUrl { get; set; }
        public string Tag { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

        public string BlogUrl { get; set; }
        public string Blogic { get; set; }

        public DateTime PostedOn { get; set; }
        public string PosteBy { get; set; }
        public string BlogDescription { get; set; }

        public string NextBlogUrl {  get; set; }
        public string PrevBlogUrl { get; set; }

    }
}

