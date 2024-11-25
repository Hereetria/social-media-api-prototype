
using DtoLayer.Dtos.ReportCommentDtos;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;

namespace DataAccessLayer.Services.ReportCommentServices
{
    
    public interface IReportCommentServiceDAL : IGenericRepositoryDAL<ReportComment, ResultReportCommentDto, ResultReportCommentByIdDto ,CreateReportCommentDto, UpdateReportCommentDto, int>

    {
        Task<List<ResultReportCommentDto>> GetReportCommentListCommentByUserIdAsync(string userId);
    }
}