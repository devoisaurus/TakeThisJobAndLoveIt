using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TakeItAndLoveIt.Controllers;

namespace TakeItAndLoveIt.DAL
{
    public class CompanyRepository : ICompanyRepository
    {
        readonly AppContext _context;

        public CompanyRepository(AppContext context)
        {
            _context = context;
        }
    
    }
}