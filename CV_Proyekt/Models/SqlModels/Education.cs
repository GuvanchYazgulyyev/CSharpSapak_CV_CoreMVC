namespace CV_Proyekt.Models.SqlModels
{
    public class Education
    {
        public long  Id { get; set; }
        public string Title { get; set; }
        public bool isEnabled { get; set; } = true;
        public DateTime? Period { get; set; }

        public string Description { get; set; }

    }
}
