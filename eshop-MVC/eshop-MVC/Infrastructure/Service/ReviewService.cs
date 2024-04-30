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
    public class ReviewService: IReviewService
    {
        private readonly IReviewRepository reviewRepository;
        private readonly IMapper _mapper;

        public ReviewService(IReviewRepository repo, IMapper mapper)
        {
            reviewRepository = repo;
            _mapper = mapper;
        }
        public int DeleteReview(int id)
        {
            return reviewRepository.Delete(id);
        }

        public IEnumerable<ReviewResponseModel> GetAllReview()
        {
            var result =  reviewRepository.GetAll();
            if (result != null)
            {
                return _mapper.Map<IEnumerable<ReviewResponseModel>>(result);
            }
            else {
                return null;
            }
        }

        public IEnumerable<ReviewResponseModel> GetReviewByCustomerId(int id)
        {
            var result = reviewRepository.GetReviewByCustomerId(id);
            if (result != null)
            {
                return _mapper.Map<IEnumerable<ReviewResponseModel>>(result);
            }
            return null;
        }

        public ReviewResponseModel GetReviewbyId(int id)
        {
            var result = reviewRepository.GetById(id);
            if (result != null)
            {
                return _mapper.Map<ReviewResponseModel>(result);
            }
            return null;
        }

        public IEnumerable<ReviewResponseModel> GetReviewByProductId(int id)
        {
            var result = reviewRepository.GetReviewByProductId(id);
            if (result != null)
            {
                return _mapper.Map<IEnumerable<ReviewResponseModel>>(result);
            }
            return null;
        }

        public int InsertReview(ReviewRequestModel review)
        {
            return reviewRepository.Insert(_mapper.Map<Review>(review));
        }

        public int UpdateReview(ReviewRequestModel review)
        {
            return reviewRepository.Update(_mapper.Map<Review>(review));


        }
    }
}
