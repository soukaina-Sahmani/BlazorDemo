using Demo.DataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.UI.services
{
    public interface IFrontEndService
    {
       Task<List<Produit>> GetProduits();
        
    }
}
