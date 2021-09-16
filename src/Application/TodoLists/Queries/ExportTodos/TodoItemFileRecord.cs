using Potato.Application.Common.Mappings;
using Potato.Domain.Entities;

namespace Potato.Application.TodoLists.Queries.ExportTodos
{
    public class TodoItemRecord : IMapFrom<TodoItem>
    {
        public string Title { get; set; }

        public bool Done { get; set; }
    }
}
