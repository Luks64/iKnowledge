using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iKnowledge.Models
{
    public class Code
    {
        public long Id { get; set; }
        public long ProgrammingLanguageId { get; set; }
        public string Explanation { get; set; }
        public string Snippet { get; set; }
        public long CreatedById { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
