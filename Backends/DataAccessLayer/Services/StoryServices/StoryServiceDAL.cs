

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.StoryDtos;
using DataAccessLayer.Repositories;

namespace DataAccessLayer.Services.StoryServices
{
    
    public class StoryServiceDAL : GenericRepositoryDAL<Story, ResultStoryDto, ResultStoryByIdDto, CreateStoryDto, UpdateStoryDto, int>, IStoryServiceDAL

    {

        public StoryServiceDAL(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }

    }
}