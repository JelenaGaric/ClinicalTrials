using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicalTrialsWebApp.Repository
{
    public interface IRepositoryWrapper
    {
        IStudyStructureRepository StudyStructure { get; }
        ITagRepository Tag { get; }
        ITagListRepository TagList { get; }
        void Save();
    }
}
