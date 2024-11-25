
using BussinessLogicLayer.Repositories;
using DtoLayer.Dtos.ReportCommentDtos;
using EntityLayer.Entities;
namespace BussinessLogicLayer.Services.ReportCommentServices
{
        public interface IReportCommentServiceBLL : IGenericRepositoryBLL<ReportComment, ResultReportCommentDto, ResultReportCommentByIdDto, CreateReportCommentDto, UpdateReportCommentDto, int>
    {

    }
}