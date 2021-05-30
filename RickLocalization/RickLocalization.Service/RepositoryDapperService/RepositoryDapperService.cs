using Microsoft.Extensions.Configuration;
using RickLocalization.Repository.Dapper;

namespace RickLocalization.Service.RepositoryDapperService
{
    public class RepositoryDapperService : GenericRepositoryDapper, IRepositoryDapperService
    {
        public RepositoryDapperService(IConfiguration configuration)
            : base(configuration)
        {

        }
    }
}
