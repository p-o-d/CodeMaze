using System;
using System.Collections.Generic;
using System.Linq;
using Entities.Models;
using Contracts;
using Entities;

namespace Repository
{
    public class CompanyRepository : RepositoryBase<Company>, ICompanyRepository
    {
        public CompanyRepository(RepositoryContext context) : base(context)
        {
        }

        public IEnumerable<Company> GetAllCompanies(bool trackChanges)
        {
           return GetAll(trackChanges).OrderBy(company => company.Name).ToList();
        }

        public Company GetCompany(Guid companyId, bool trackChanges)
        {
            return GetByCondition(c => c.Id.Equals(companyId), trackChanges).SingleOrDefault();
        }

        public void CreateCompany(Company company)
        {
            Create(company);
        }
    }
}
