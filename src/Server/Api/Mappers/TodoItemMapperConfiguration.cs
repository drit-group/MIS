using MisSystem.Server.Api.Models.TodoItem;
using MisSystem.Shared.Dtos.TodoItem;

namespace MisSystem.Server.Api.Mappers;

public class TodoItemMapperConfiguration : Profile
{
    public TodoItemMapperConfiguration()
    {
        CreateMap<TodoItem, TodoItemDto>().ReverseMap();
    }
}
