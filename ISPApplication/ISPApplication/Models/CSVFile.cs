using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ISPApplication.Models
{
    public class CSVFile
    {
        public int Id { get; set; }
        public string Parameter { get; set; }
        public string ExpectedValue { get; set; }
        public string ActualValue { get; set; }
        public string Status { get; set; }
    }
}