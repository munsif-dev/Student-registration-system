using SQLite;
using PointofSaleSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointofSaleSystem.Services
{
    public class ProductService : IproductService
    {
        private SQLiteAsyncConnection _dbConnection;
        public ProductService()
        {
            setUpDb();
        }
        private async void setUpDb()
        {
            if (_dbConnection == null)
            {
                string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Product.db3");
                _dbConnection = new SQLiteAsyncConnection(dbPath);
                await _dbConnection.CreateTableAsync<ProductModel>();
            }
        }
        public async Task<int> AddProduct(ProductModel productModel)
        {
            return await _dbConnection.InsertAsync(productModel);
        }

        public Task<int> DeleteProduct(ProductModel productModel)
        {
            return _dbConnection.DeleteAsync(productModel);
        }

        public async Task<List<ProductModel>> GetAllProduct()
        {
            return await _dbConnection.Table<ProductModel>().ToListAsync();
        }

        public async Task<int> UpdateProduct(ProductModel productModel)
        {
            return await _dbConnection.UpdateAsync(productModel);
        }
        public async Task<ProductModel> GetProductByID(int ProductID)
        {
            var product = await _dbConnection.QueryAsync<ProductModel>($"Select * From {nameof(ProductModel)} where ProductID={ProductID}");
            return product.FirstOrDefault();
        }
    }
}
