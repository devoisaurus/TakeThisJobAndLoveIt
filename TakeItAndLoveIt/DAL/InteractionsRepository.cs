using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using TakeItAndLoveIt.Controllers;
using TakeItAndLoveIt.Models;

namespace TakeItAndLoveIt.DAL
{
    public class InteractionsRepository : IInteractionsRepository
    {
       readonly AppContext _context;

        public InteractionsRepository(AppContext context)
        {
            _context = context;
        }

        public void Save(Interaction newInteraction)
        {
            _context.Interactions.Add(newInteraction);
            _context.SaveChanges();
        }

        public IEnumerable<Interaction> GetAllInteractions()
        {
            return _context.Interactions;
        }


    }
}