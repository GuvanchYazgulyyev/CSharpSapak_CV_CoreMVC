namespace CV_Proyekt.Models.SqlModels
{
    public class WorkExperience
    {
        public long Id { get; set; }
        public string Title { get; set; }

        public DateTime? Period { get; set; }
        public string Responsibility { get; set; }
    }
}
