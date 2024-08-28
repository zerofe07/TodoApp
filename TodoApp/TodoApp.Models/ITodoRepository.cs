using System.Collections.Generic;

namespace TodoApp.Models
{
    public interface ITodoRepository
    {
        void Add(Todo model);  // 입력 시그니쳐...
        List<Todo> GetAll();  // 출력
    }
    /*
    public class TodoRepositorySqlServer : ITodoRepository
    {
        // SQL Server
    }*/
}
