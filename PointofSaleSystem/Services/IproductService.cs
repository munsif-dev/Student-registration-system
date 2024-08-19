using PointofSaleSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointofSaleSystem.Services
{
    public interface IproductService
    {
        Task<List<ProductModel>> GetAllProduct();
        Task<ProductModel> GetProductByID(int StudentID);
        Task<int> AddProduct(ProductModel productModel);
        Task<int> UpdateProduct(ProductModel productModel);
        Task<int> DeleteProduct(ProductModel productModel);
    }
}
