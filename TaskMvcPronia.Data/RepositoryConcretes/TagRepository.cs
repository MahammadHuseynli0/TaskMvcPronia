using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TaskMvcPronia.Data.RepositoryConcretes.GenericRepository;
using TaskMvcPronia.Core.Models;
using TaskMvcPronia.Core.RepositoryAbstract;
using TaskMvcPronia.Data.DAL;

namespace TaskMvcPronia.Data.RepositoryConcretes
{
    public class TagRepository : GenericRepository<Tag>, ITagRepository
    {
        public TagRepository(AppDbContext dbContext) : base(dbContext) { }
    }
}
