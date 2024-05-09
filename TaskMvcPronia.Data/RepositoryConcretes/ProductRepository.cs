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
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext dbContext) : base(dbContext)
        {

        }
    }
