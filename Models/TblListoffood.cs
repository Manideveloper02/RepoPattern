using System;
using System.Collections.Generic;

#nullable disable

namespace RepoPattern.Models
{
    public partial class TblListoffood
    {
        public int PkId { get; set; }
        public string Name { get; set; }
        public string Categorie { get; set; }
        public string Price { get; set; }
        public string Img { get; set; }
        public string Status { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
