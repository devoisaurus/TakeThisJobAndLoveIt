using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TakeItAndLoveIt.Controllers;
using TakeItAndLoveIt.Models;

namespace TakeItAndLoveIt.DAL
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly AppContext _context;

        public CompanyRepository(AppContext context)
        {
            _context = context;
        }

        public void Save(Company newCompany)
        {
            _context.Companies.Add(newCompany);
            _context.SaveChanges();
        }

        public IEnumerable<Company> GetAllCompanies()
        {
            return _context.Companies;
        }
    
    }
}