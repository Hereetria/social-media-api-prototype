
using EntityLayer.Entities;
using BussinessLogicLayer.Repositories;
using DtoLayer.Dtos.ReportCommentDtos;
using BussinessLogicLayer.Services.ReportCommentServices;
using DataAccessLayer.Factories.Abstract;
namespace BussinessLogicLayer.Services.ReportCommentServices
{
     public class ReportCommentServiceBLL : GenericRepositoryBLL<ReportComment, ResultReportCommentDto, ResultReportCommentByIdDto, CreateReportCommentDto, UpdateReportCommentDto, int>, IReportCommentServiceBLL
    {
        public ReportCommentServiceBLL(IGenericRepositoryDALFactory repositoryDALFactory)
            : base(repositoryDALFactory)
        {
        }
    }
}