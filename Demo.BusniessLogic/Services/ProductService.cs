using Demo.DataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.BusniessLogic.Services
{
    public class ProductService : IProductService
    {
        private readonly DemoDBContext _dBContext = null;

        public ProductService(DemoDBContext dBContext)
        {
            this._dBContext = dBContext;

        }
        public List<Produit> GetProduits()
        {
            return _dBContext.Produits.ToList();
        }
    }
}
