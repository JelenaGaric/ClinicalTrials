
using Model.Context;

namespace ClinicalTrialsWebApp.Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private ClinicalTrialsContext _repoContext;

       // private ClinicalTrialsJSONContext _jsonContext;

        private IStudyStructureRepository _studyStructure;

        private ITagRepository _tag;

        private ITagListRepository _tagList;

        private IStatisticsSearchRepository _statisticsSearchRepository;
        
       // private IJSONRepository _jsonRepository;

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

        public IStatisticsSearchRepository StatisticsSearch
        {
            get
            {
                if (_statisticsSearchRepository == null)
                {
                    _statisticsSearchRepository = new StatisticsSearchRepository(_repoContext);
                }
                return _statisticsSearchRepository;
            }
        }

        //public IJSONRepository JSONRepository
        //{
        //    get
        //    {
        //        if (_jsonRepository == null)
        //        {
        //            _jsonRepository = new JSONRepository(_jsonContext);
        //        }
        //        return _jsonRepository;
        //    }
        //}

        public RepositoryWrapper(ClinicalTrialsContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }

        //public RepositoryWrapper(ClinicalTrialsJSONContext repositoryContext)
        //{
        //    _jsonContext = repositoryContext;
        //}

        public void Save()
        {
            _repoContext.SaveChanges();
        }
    }
}
