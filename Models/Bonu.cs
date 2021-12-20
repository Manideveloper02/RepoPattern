using System;
using System.Collections.Generic;

#nullable disable

namespace RepoPattern.Models
{
    public partial class Bonu
    {
        public int? WorkerRefId { get; set; }
        public int? BonusAmount { get; set; }
        public DateTime? BonusDate { get; set; }

        public virtual Worker WorkerRef { get; set; }
    }
}
