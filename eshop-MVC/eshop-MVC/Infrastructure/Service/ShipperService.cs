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
    public class ShipperService : IShipperService
    {

        private readonly IShipperRepository shipperRepository;

        public ShipperService(IShipperRepository repo)
        {
            shipperRepository = repo;
        }
        public int DeleteShipper(int id)
        {
            return shipperRepository.Delete(id);
        }

        public IEnumerable<ShipperResponseModel> GetAllShipper()
        {
            List<ShipperResponseModel> lst = new List<ShipperResponseModel>();
            var collection = shipperRepository.GetAll();
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

        public ShipperResponseModel GetShipperbyId(int id)
        {
            var shipper = shipperRepository.GetById(id);
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

        public int InsertShipper(ShipperRequestModel shipper)
        {
            Shipper p = new Shipper()
            {
                Name = shipper.Name,
                Price = shipper.Price,

            };

            return shipperRepository.Insert(p);
        }

        public int UpdateShipper(ShipperRequestModel shipper)
        {
            Shipper c = new Shipper()
            {
                Name = shipper.Name,
                Price = shipper.Price,
            };
            return shipperRepository.Update(c);
        }

        int IShipperService.DeleteShipper(int id)
        {
            return shipperRepository.Delete(id);
        }
    }


}
