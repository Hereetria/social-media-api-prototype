

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.LikeDtos;
using DataAccessLayer.Repositories;

namespace DataAccessLayer.Services.LikeServices
{
    
    public class LikeServiceDAL : GenericRepositoryDAL<Like, ResultLikeDto, ResultLikeByIdDto, CreateLikeDto, UpdateLikeDto, int>, ILikeServiceDAL

    {

        public LikeServiceDAL(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }

    }
}