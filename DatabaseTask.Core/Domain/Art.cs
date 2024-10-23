using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Art
    {
        [Key]
        public int Id { get; set; }
        public string ArtName { get; set; }
        public string Type { get; set; }
        public int FinishedYear { get; set; }
    }
}
