

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.FollowDtos;
using DataAccessLayer.Repositories;

namespace DataAccessLayer.Services.FollowServices
{
    
    public class FollowServiceDAL : GenericRepositoryDAL<Follow, ResultFollowDto, ResultFollowByIdDto, CreateFollowDto, UpdateFollowDto, int>, IFollowServiceDAL

    {

        public FollowServiceDAL(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }

    }
}