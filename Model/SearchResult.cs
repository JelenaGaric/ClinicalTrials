using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SearchResult: StudyStructureEntity
    {
        public string Term { get; set; }
        public string NCTId { get; set; }

    }
}
