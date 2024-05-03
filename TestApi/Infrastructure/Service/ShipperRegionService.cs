using ApplicationCore.Entities;
using ApplicationCore.Model.Request;
using ApplicationCore.Model.Response;
using ApplicationCore.RepositoryContracts;
using ApplicationCore.ServiceContracts;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Service
{
    public class ShipperRegionServiceAsync : IShipperRegionServiceAsync
    {
        private readonly IShipperRegionRepositoryAsync _repo;
        private readonly IMapper _mapper;
        public ShipperRegionServiceAsync(IShipperRegionRepositoryAsync repo, IMapper mapper) { 
            _repo = repo;
            _mapper = mapper;
        }
        public async Task<int> DeleteAsync(ShipperRegionRequestModel model)
        {
            ShipperRegion entity = _mapper.Map<ShipperRegion>(model);
            return await _repo.DeleteAsync(entity);
        }

        public async Task<IEnumerable<ShipperRegionResponseModel>> GetByRegionId(int id)
        {
            var l = await _repo.GetByRegionIdAsync(id);
            if (l != null)
            {
                return _mapper.Map<IEnumerable<ShipperRegionResponseModel>>(l);
            }
            else {
                return null;
            }
        }

        public async Task<IEnumerable<ShipperRegionResponseModel>> GetByShipperId(int id)
        {
            var l = await _repo.GetByShipperIdAsync(id);
            if (l != null)
            {
                return _mapper.Map<IEnumerable<ShipperRegionResponseModel>>(l);
            }
            else
            {
                return null;
            }
        }

        public async Task<int> InsertAsync(ShipperRegionRequestModel model)
        {
            return await _repo.InsertAsync(_mapper.Map<ShipperRegion>(model));
        }
    }
}
