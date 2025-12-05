using System.Reflection;

namespace CV_Proyekt.Models.SqlModels
{
    public class Portfolio
    {
        public Int64 id { get; set; }
        public string name { get; set; }
        public string Title { get; set; }
        public string IconUrl1 { get; set; }
        public string Description { get; set; }
        public string Tags { get; set; }

        public string LiveDemo { get; set; }


        
    }
}
