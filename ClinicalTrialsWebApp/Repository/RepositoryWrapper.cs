
using Model.Context;

namespace ClinicalTrialsWebApp.Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private ClinicalTrialsContext _repoContext;

        private IStudyStructureRepository _studyStructure;

        private ITagRepository _tag;

        private ITagListRepository _tagList;

        public IStudyStructureRepository StudyStructure
        {
            get
            {
                if (_studyStructure == null)
                {
                    _studyStructure = new StudyStructureRepository(_repoContext);
                }
                return _studyStructure;
            }
        }
        public ITagRepository Tag
        {
            get
            {
                if (_tag == null)
                {
                    _tag = new TagRepository(_repoContext);
                }
                return _tag;
            }
        }

        public ITagListRepository TagList
        {
            get
            {
                if (_tagList == null)
                {
                    _tagList = new TagListRepository(_repoContext);
                }
                return _tagList;
            }
        }
       
        public RepositoryWrapper(ClinicalTrialsContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }

        public void Save()
        {
            _repoContext.SaveChanges();
        }
    }
}
