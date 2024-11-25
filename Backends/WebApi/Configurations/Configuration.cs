using System;
using System.Collections.Generic;
using DataAccessLayer.Services.BlockUserServices;
using DataAccessLayer.Services.CommentServices;
using DataAccessLayer.Services.FollowServices;
using DataAccessLayer.Services.LikeServices;
using DataAccessLayer.Services.MediaServices;
using DataAccessLayer.Services.MessageServices;
using DataAccessLayer.Services.NotificationServices;
using DataAccessLayer.Services.PostServices;
using DataAccessLayer.Services.PostTagServices;
using DataAccessLayer.Services.ReportCommentServices;
using DataAccessLayer.Services.SavedPostServices;
using DataAccessLayer.Services.StoryServices;
using DataAccessLayer.Services.TagServices;
using DataAccessLayer.Services.UserServices;
using DataAccessLayer.Services.UserSettingServices;
using DataAccessLayer.Services.ViewStoryServices;

using DataAccessLayer.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

using DtoLayer.Mappings;
using System.Reflection;
using BussinessLogicLayer.Services.BlockUserServices;
using BussinessLogicLayer.Services.CommentServices;
using BussinessLogicLayer.Services.FollowServices;
using BussinessLogicLayer.Services.LikeServices;
using BussinessLogicLayer.Services.MediaServices;
using BussinessLogicLayer.Services.MessageServices;
using BussinessLogicLayer.Services.NotificationServices;
using BussinessLogicLayer.Services.PostServices;
using BussinessLogicLayer.Services.PostTagServices;
using BussinessLogicLayer.Services.ReportCommentServices;
using BussinessLogicLayer.Services.SavedPostServices;
using BussinessLogicLayer.Services.StoryServices;
using BussinessLogicLayer.Services.TagServices;
using BussinessLogicLayer.Services.UserServices;
using BussinessLogicLayer.Services.UserSettingServices;
using BussinessLogicLayer.Services.ViewStoryServices;
using DataAccessLayer.Factories.Abstract;
using DataAccessLayer.Factories.Concrete;
using DataAccessLayer.Repositories;

namespace WebApi.Configurations
{
    public class Configuration
    {

        public static void ConfigureServices(WebApplicationBuilder builder)

        {
            builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
            builder.Services.AddAutoMapper(typeof(GeneralMapping));

            builder.Services.AddDbContext<Context>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddScoped<IGenericRepositoryDALFactory, GenericRepositoryDALFactory>();

            builder.Services.AddScoped(typeof(IGenericRepositoryDAL<,,,,,>), typeof(GenericRepositoryDAL<,,,,,>));

            builder.Services.AddScoped<IBlockUserServiceDAL, BlockUserServiceDAL>();
            builder.Services.AddScoped<IBlockUserServiceBLL, BlockUserServiceBLL>();

            builder.Services.AddScoped<ICommentServiceDAL, CommentServiceDAL>();
            builder.Services.AddScoped<ICommentServiceBLL, CommentServiceBLL>();

            builder.Services.AddScoped<IFollowServiceDAL, FollowServiceDAL>();
            builder.Services.AddScoped<IFollowServiceBLL, FollowServiceBLL>();

            builder.Services.AddScoped<ILikeServiceDAL, LikeServiceDAL>();
            builder.Services.AddScoped<ILikeServiceBLL, LikeServiceBLL>();

            builder.Services.AddScoped<IMediaServiceDAL, MediaServiceDAL>();
            builder.Services.AddScoped<IMediaServiceBLL, MediaServiceBLL>();

            builder.Services.AddScoped<IMessageServiceDAL, MessageServiceDAL>();
            builder.Services.AddScoped<IMessageServiceBLL, MessageServiceBLL>();

            builder.Services.AddScoped<INotificationServiceDAL, NotificationServiceDAL>();
            builder.Services.AddScoped<INotificationServiceBLL, NotificationServiceBLL>();

            builder.Services.AddScoped<IPostServiceDAL, PostServiceDAL>();
            builder.Services.AddScoped<IPostServiceBLL, PostServiceBLL>();

            builder.Services.AddScoped<IPostTagServiceDAL, PostTagServiceDAL>();
            builder.Services.AddScoped<IPostTagServiceBLL, PostTagServiceBLL>();

            builder.Services.AddScoped<IReportCommentServiceDAL, ReportCommentServiceDAL>();
            builder.Services.AddScoped<IReportCommentServiceBLL, ReportCommentServiceBLL>();

            builder.Services.AddScoped<ISavedPostServiceDAL, SavedPostServiceDAL>();
            builder.Services.AddScoped<ISavedPostServiceBLL, SavedPostServiceBLL>();

            builder.Services.AddScoped<IStoryServiceDAL, StoryServiceDAL>();
            builder.Services.AddScoped<IStoryServiceBLL, StoryServiceBLL>();

            builder.Services.AddScoped<ITagServiceDAL, TagServiceDAL>();
            builder.Services.AddScoped<ITagServiceBLL, TagServiceBLL>();

            builder.Services.AddScoped<IUserServiceDAL, UserServiceDAL>();
            builder.Services.AddScoped<IUserServiceBLL, UserServiceBLL>();

            builder.Services.AddScoped<IUserSettingServiceDAL, UserSettingServiceDAL>();
            builder.Services.AddScoped<IUserSettingServiceBLL, UserSettingServiceBLL>();

            builder.Services.AddScoped<IViewStoryServiceDAL, ViewStoryServiceDAL>();
            builder.Services.AddScoped<IViewStoryServiceBLL, ViewStoryServiceBLL>();

        }
    }
}