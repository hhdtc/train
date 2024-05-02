using ApplicationCore.Entities;
using ApplicationCore.Model.Request;
using ApplicationCore.Model.Response;
using ApplicationCore.RepositoryContracts;
using ApplicationCore.ServiceContracts;
using AutoMapper;
using Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Service
{
    public class ReviewServiceAsync : IReviewServiceAsync
    {
        private readonly IReviewRepositoryAsync reviewRepository;
        private readonly IMapper _mapper;

        public ReviewServiceAsync(IReviewRepositoryAsync repo, IMapper mapper)
        {
            reviewRepository = repo;
            _mapper = mapper;
        }
        public async Task<int> DeleteReviewAsync(int id)
        {
            return await reviewRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<ReviewResponseModel>> GetAllReviewAsync()
        {
            var result = await reviewRepository.GetAllAsync();
            if (result != null)
            {
                return _mapper.Map<IEnumerable<ReviewResponseModel>>(result);
            }
            else {
                return null;
            }
        }

        public async Task<IEnumerable<ReviewResponseModel>> GetReviewByCustomerIdAsync(int id)
        {
            var result = await reviewRepository.GetReviewByCustomerIdAsync(id);
            if (result != null)
            {
                return _mapper.Map<IEnumerable<ReviewResponseModel>>(result);
            }
            return null;
        }

        public async Task<ReviewResponseModel> GetReviewbyIdAsync(int id)
        {
            var result = await reviewRepository.GetByIdAsync (id);
            if (result != null)
            {
                return _mapper.Map<ReviewResponseModel>(result);
            }
            return null;
        }

        public async Task<IEnumerable<ReviewResponseModel>> GetReviewByProductIdAsync(int id)
        {
            var result = await reviewRepository.GetReviewByProductIdAsync(id);
            if (result != null)
            {
                return _mapper.Map<IEnumerable<ReviewResponseModel>>(result);
            }
            return null;
        }

        public async Task<int> InsertReviewAsync(ReviewRequestModel review)
        {
            return await reviewRepository.InsertAsync(_mapper.Map<Review>(review));
        }

        public async Task<int> UpdateReviewAsync(ReviewRequestModel review, int id)
        {
            var r = _mapper.Map<Review>(review);
            r.Id = id;
            return await reviewRepository.UpdateAsync(r);


        }
    }
}
