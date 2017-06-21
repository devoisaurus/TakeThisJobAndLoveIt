using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TakeItAndLoveIt.Models;

namespace TakeItAndLoveIt.Controllers
{
    public class InteractionsController : ApiController
    {
       readonly IInteractionsRepository _interactionsRepository;
       readonly ICompanyRepository _companyRepository;

        public InteractionsController(IInteractionsRepository interactionsRepository, ICompanyRepository companyRepository)
        {
            _interactionsRepository = interactionsRepository;
            _companyRepository = companyRepository;
        }


        [System.Web.Http.Route("api/companies/{id}/interactions")]
        [System.Web.Http.HttpPost]
        public void AddACompany(int id, Interaction interaction)
        {
            var company = _companyRepository.GetOneCompany(id);
            interaction.Company = company;
            _interactionsRepository.Save(interaction);

        }


        [System.Web.Http.Route("api/companies/{id}/interactions")]
        [System.Web.Http.HttpGet]
        public IEnumerable<Interaction> GetInteractions(int id)
        {
            var company = _companyRepository.GetOneCompany(id);
            return company.Interactions;
        }
    }
}
