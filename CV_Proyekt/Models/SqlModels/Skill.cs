namespace CV_Proyekt.Models.SqlModels
{

    public class Skill
    {
        // CV_Proyekt.Models.SqlModels.Skill.cs
            public int Id { get; set; }
            public string Name { get; set; }
            public int Percentage { get; set; }
            public string Type { get; set; }

            // **NEW FEATURE GOES HERE:**
            public string Description { get; set; }
        
    }
}
