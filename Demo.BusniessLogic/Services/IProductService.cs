using Demo.DataModels.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.BusniessLogic.Services
{
    public interface IProductService
    {
        List<Produit> GetProduits();
    }
}
