

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.ViewStoryDtos;
using DataAccessLayer.Repositories;

namespace DataAccessLayer.Services.ViewStoryServices
{
    
    public class ViewStoryServiceDAL : GenericRepositoryDAL<ViewStory, ResultViewStoryDto, ResultViewStoryByIdDto, CreateViewStoryDto, UpdateViewStoryDto, int>, IViewStoryServiceDAL

    {

        public ViewStoryServiceDAL(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }

    }
}