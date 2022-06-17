using System;
using System.ComponentModel.DataAnnotations;


namespace TranslateApi.Model
{
    public class UpdateFiles
    {
        [Key]
   
        public string NameFile { get; set; }
        public string Link { get; set; }

        public DateTime CreatedDate { get; set; } 
        public DateTime EndDate { get; set; }
        public string Status { get; set; }
        public int IdUser { get; set; }
    }
}
