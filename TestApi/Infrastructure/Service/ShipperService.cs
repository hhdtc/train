using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Entities;
using ApplicationCore.Model.Request;
using ApplicationCore.Model.Response;
using ApplicationCore.RepositoryContracts;
using ApplicationCore.ServiceContracts;
using Infrastructure.Repository;

namespace Infrastructure.Service
{
    public class ShipperServiceAsync : IShipperServiceAsync
    {

        private readonly IShipperRepositoryAsync shipperRepository;

        public ShipperServiceAsync(IShipperRepositoryAsync repo)
        {
            shipperRepository = repo;
        }
        public async Task<int> DeleteShipperAsync(int id)
        {
            return await shipperRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<ShipperResponseModel>> GetAllShipperAsync()
        {
            List<ShipperResponseModel> lst = new List<ShipperResponseModel>();
            var collection = await shipperRepository.GetAllAsync();
            if (collection != null)
            {
                foreach (var item in collection)
                {
                    ShipperResponseModel m = new ShipperResponseModel();
                    m.Id = item.Id;
                    m.Name = item.Name;
                    m.Price = item.Price;
                    lst.Add(m);
                }
                return lst;
            }
            return null;
        }

        public async Task<ShipperResponseModel> GetShipperbyIdAsync(int id)
        {
            var shipper = await shipperRepository.GetByIdAsync(id);
            if (shipper != null)
            {
                ShipperResponseModel shipperResponseModel = new ShipperResponseModel();
                shipperResponseModel.Id = shipper.Id;
                shipperResponseModel.Name = shipper.Name;
                shipperResponseModel.Price = shipper.Price;
                return shipperResponseModel;
            }
            return null;
        }

        public async Task<int> InsertShipperAsync(ShipperRequestModel shipper)
        {
            Shipper p = new Shipper()
            {
                Name = shipper.Name,
                Price = shipper.Price,

            };

            return await shipperRepository.InsertAsync(p);
        }

        public async Task<int> UpdateShipperAsync(ShipperRequestModel shipper, int id)
        {
            Shipper c = new Shipper()
            {
                Id = id,
                Name = shipper.Name,
                Price = shipper.Price,
            };
            return await shipperRepository.UpdateAsync(c);
        }


    }


}
