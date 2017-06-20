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

        public InteractionsController(IInteractionsRepository interactionsRepository)
        {
            _interactionsRepository = interactionsRepository;
        }


        [System.Web.Http.Route("api/interactions")]
        [System.Web.Http.HttpPost]
        public void AddACompany(Interaction interaction)
        {
            _interactionsRepository.Save(interaction);

        }


        [System.Web.Http.Route("api/interactions")]
        [System.Web.Http.HttpGet]
        public IEnumerable<Interaction> GetInteractions()
        {
            return _interactionsRepository.GetAllInteractions();
        }
    }
}
