using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetCoreTodo.Models;

namespace AspNetCoreTodo.Services
{
    public class FakeTodoItemService : ITodoItemService
    {
        public Task<bool> AddItemAsync(NewTodoItem newItem)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TodoItem>> GetIncompleteItemsAsync()
        {
            // Return an array of TodoItems
            IEnumerable<TodoItem> items = new[]
            {
                new TodoItem
                {
                    Title = "Learn ASP.NET Core",
                    DueAt = DateTimeOffset.Now.AddDays(1)
                },
                new TodoItem
                {
                    Title = "Build awesome apps",
                    DueAt = DateTimeOffset.Now.AddDays(1)
                },
                new TodoItem
                {
                    Title = "Enjoy goodness of .NET Core 2.0",
                    DueAt = DateTimeOffset.Now.AddDays(1)
                },
            };

            return Task.FromResult(items);
        }

        public Task<bool> MarkDoneAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}