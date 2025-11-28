namespace CV_Proyekt.Models.SqlModels
{
    public class WhatIdo
    {
      public long Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public string IconClass { get; set; } // e.g., "fa fa-code"
        public string ColorClass { get; set; } // e.g., "iron-color"
        public string Delay { get; set; }      // e.g., "0.3s"
    }
}
