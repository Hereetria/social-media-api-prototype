

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.ReportCommentDtos;
using DataAccessLayer.Repositories;

namespace DataAccessLayer.Services.ReportCommentServices
{
    
    public class ReportCommentServiceDAL : GenericRepositoryDAL<ReportComment, ResultReportCommentDto, ResultReportCommentByIdDto, CreateReportCommentDto, UpdateReportCommentDto, int>, IReportCommentServiceDAL

    {

        public ReportCommentServiceDAL(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }

    }
}