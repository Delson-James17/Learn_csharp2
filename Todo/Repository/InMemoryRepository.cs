using Microsoft.AspNetCore.Mvc;

namespace Todo.Repository.InMemory
{
    public class InMemoryRepository
    {
        // it will hold the data in runtime and allow to perfrom crud operations

        static List<Todo> todoList = new List<Todo>();

        static InMemoryRepository()
        {
            todoList.Add(new Todo(1, "Shopping", "For Birthday", false, DateTime.Now.AddDays(1)));
            todoList.Add(new Todo(2, "Learn C#", "In Jump Trainin", false, DateTime.Now.AddDays(2)));
            todoList.Add(new Todo(3, "Learn MSSQL", "In Jump Trainin", false, DateTime.Now.AddDays(2)));
        }
        public List<Todo> GetAllTodos()
        {
            return todoList;
        }

    }
}