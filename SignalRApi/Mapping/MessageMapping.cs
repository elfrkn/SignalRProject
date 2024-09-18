using AutoMapper;
using SignalR.DtoLayer.CategoryDto;
using SignalR.DtoLayer.MessageDto;
using SignalR.EntityLayer.Entities;
using SignalR.EntiyLayer.Entities;

namespace SignalRApi.Mapping
{
	public class MessageMapping :Profile
	{
        public MessageMapping()
        {
			CreateMap<Message, CreateMessageDto>().ReverseMap();
			CreateMap<Message, GetByIdMessageDto>().ReverseMap();
			CreateMap<Message, ResultMessageDto>().ReverseMap();
			CreateMap<Message, UpdateMessageDto>().ReverseMap();
		}
    }
}
