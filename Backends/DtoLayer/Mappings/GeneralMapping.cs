
using AutoMapper;
using EntityLayer.Entities;
using DtoLayer.Dtos.BlockUserDtos;
using DtoLayer.Dtos.CommentDtos;
using DtoLayer.Dtos.FollowDtos;
using DtoLayer.Dtos.LikeDtos;
using DtoLayer.Dtos.MediaDtos;
using DtoLayer.Dtos.MessageDtos;
using DtoLayer.Dtos.NotificationDtos;
using DtoLayer.Dtos.PostDtos;
using DtoLayer.Dtos.PostTagDtos;
using DtoLayer.Dtos.ReportCommentDtos;
using DtoLayer.Dtos.SavedPostDtos;
using DtoLayer.Dtos.StoryDtos;
using DtoLayer.Dtos.TagDtos;
using DtoLayer.Dtos.UserDtos;
using DtoLayer.Dtos.UserSettingDtos;
using DtoLayer.Dtos.ViewStoryDtos;

namespace DtoLayer.Mappings
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<BlockUser, ResultBlockUserDto>().ReverseMap();
            CreateMap<BlockUser, ResultBlockUserByIdDto>().ReverseMap();
            CreateMap<BlockUser, CreateBlockUserDto>().ReverseMap();
            CreateMap<BlockUser, UpdateBlockUserDto>().ReverseMap();

            CreateMap<Comment, ResultCommentDto>().ReverseMap();
            CreateMap<Comment, ResultCommentByIdDto>().ReverseMap();
            CreateMap<Comment, CreateCommentDto>().ReverseMap();
            CreateMap<Comment, UpdateCommentDto>().ReverseMap();

            CreateMap<Follow, ResultFollowDto>().ReverseMap();
            CreateMap<Follow, ResultFollowByIdDto>().ReverseMap();
            CreateMap<Follow, CreateFollowDto>().ReverseMap();
            CreateMap<Follow, UpdateFollowDto>().ReverseMap();

            CreateMap<Like, ResultLikeDto>().ReverseMap();
            CreateMap<Like, ResultLikeByIdDto>().ReverseMap();
            CreateMap<Like, CreateLikeDto>().ReverseMap();
            CreateMap<Like, UpdateLikeDto>().ReverseMap();

            CreateMap<Media, ResultMediaDto>().ReverseMap();
            CreateMap<Media, ResultMediaByIdDto>().ReverseMap();
            CreateMap<Media, CreateMediaDto>().ReverseMap();
            CreateMap<Media, UpdateMediaDto>().ReverseMap();

            CreateMap<Message, ResultMessageDto>().ReverseMap();
            CreateMap<Message, ResultMessageByIdDto>().ReverseMap();
            CreateMap<Message, CreateMessageDto>().ReverseMap();
            CreateMap<Message, UpdateMessageDto>().ReverseMap();

            CreateMap<Notification, ResultNotificationDto>().ReverseMap();
            CreateMap<Notification, ResultNotificationByIdDto>().ReverseMap();
            CreateMap<Notification, CreateNotificationDto>().ReverseMap();
            CreateMap<Notification, UpdateNotificationDto>().ReverseMap();

            CreateMap<Post, ResultPostDto>().ReverseMap();
            CreateMap<Post, ResultPostByIdDto>().ReverseMap();
            CreateMap<Post, CreatePostDto>().ReverseMap();
            CreateMap<Post, UpdatePostDto>().ReverseMap();

            CreateMap<PostTag, ResultPostTagDto>().ReverseMap();
            CreateMap<PostTag, ResultPostTagByIdDto>().ReverseMap();
            CreateMap<PostTag, CreatePostTagDto>().ReverseMap();
            CreateMap<PostTag, UpdatePostTagDto>().ReverseMap();

            CreateMap<ReportComment, ResultReportCommentDto>().ReverseMap();
            CreateMap<ReportComment, ResultReportCommentByIdDto>().ReverseMap();
            CreateMap<ReportComment, CreateReportCommentDto>().ReverseMap();
            CreateMap<ReportComment, UpdateReportCommentDto>().ReverseMap();

            CreateMap<SavedPost, ResultSavedPostDto>().ReverseMap();
            CreateMap<SavedPost, ResultSavedPostByIdDto>().ReverseMap();
            CreateMap<SavedPost, CreateSavedPostDto>().ReverseMap();
            CreateMap<SavedPost, UpdateSavedPostDto>().ReverseMap();

            CreateMap<Story, ResultStoryDto>().ReverseMap();
            CreateMap<Story, ResultStoryByIdDto>().ReverseMap();
            CreateMap<Story, CreateStoryDto>().ReverseMap();
            CreateMap<Story, UpdateStoryDto>().ReverseMap();

            CreateMap<Tag, ResultTagDto>().ReverseMap();
            CreateMap<Tag, ResultTagByIdDto>().ReverseMap();
            CreateMap<Tag, CreateTagDto>().ReverseMap();
            CreateMap<Tag, UpdateTagDto>().ReverseMap();

            CreateMap<User, ResultUserDto>().ReverseMap();
            CreateMap<User, ResultUserByIdDto>().ReverseMap();
            CreateMap<User, CreateUserDto>().ReverseMap();
            CreateMap<User, UpdateUserDto>().ReverseMap();

            CreateMap<UserSetting, ResultUserSettingDto>().ReverseMap();
            CreateMap<UserSetting, ResultUserSettingByIdDto>().ReverseMap();
            CreateMap<UserSetting, CreateUserSettingDto>().ReverseMap();
            CreateMap<UserSetting, UpdateUserSettingDto>().ReverseMap();

            CreateMap<ViewStory, ResultViewStoryDto>().ReverseMap();
            CreateMap<ViewStory, ResultViewStoryByIdDto>().ReverseMap();
            CreateMap<ViewStory, CreateViewStoryDto>().ReverseMap();
            CreateMap<ViewStory, UpdateViewStoryDto>().ReverseMap();

        }
    }
}