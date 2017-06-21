using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using TakeItAndLoveIt.Models;

namespace TakeItAndLoveIt.Controllers
{
    public class CompanyController : ApiController
    {
        readonly ICompanyRepository _companyRepository;

        public CompanyController(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }


        [System.Web.Http.Route("api/companies")]
        [System.Web.Http.HttpPost]
        public void AddACompany(Company company)
        {
            _companyRepository.Save(company);
           
        }

        [System.Web.Http.Route("api/companies")]
        [System.Web.Http.HttpGet]
        public IEnumerable<Company> GetCompanies()
        {
            return _companyRepository.GetAllCompanies();
        }

        [System.Web.Http.Route("api/companies/{id}")]
        [System.Web.Http.HttpGet]
        public IHttpActionResult GetACompany(int id)
        {
            return Ok(_companyRepository.GetOneCompany(id));
        }

        [System.Web.Http.Route("api/companies/{id}")]
        [System.Web.Http.HttpDelete]
        public void DeleteACompany(int id)
        {
            var selectedCompany =_companyRepository.GetOneCompany(id);
            _companyRepository.Delete(selectedCompany);
        }


    }
}
