using Potato.Application.TodoLists.Queries.ExportTodos;
using System.Collections.Generic;

namespace Potato.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
    }
}
