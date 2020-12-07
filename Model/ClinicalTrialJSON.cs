using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ClinicalTrialJSON: StudyStructureEntity
    {
        public string NCTId { get; set; }
        public string JSON { get; set; }
    }
}
