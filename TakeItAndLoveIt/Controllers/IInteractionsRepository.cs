using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TakeItAndLoveIt.Models;

namespace TakeItAndLoveIt.Controllers
{
    public interface IInteractionsRepository
    {
        void Save(Interaction newInteraction);
        IEnumerable<Interaction> GetAllInteractions();
    }
}
