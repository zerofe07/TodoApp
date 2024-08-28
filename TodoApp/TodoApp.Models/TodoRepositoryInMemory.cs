using System;
using System.Collections.Generic;
using System.Linq;

namespace TodoApp.Models
{
    /*
    public class TodoRepository : ITodoRepository
    {
    }
    */
    public class TodoRepositoryInMemory : ITodoRepository
    {
        // DB 역할을 하는 메모리 상 리스트를 만들어준다
        private static List<Todo> _todos = new List<Todo>();

        public TodoRepositoryInMemory()
        {
            _todos = new List<Todo>
            {
                new Todo {Id=1, Title ="ASP.NET Core 학습", IsDone = false},
                new Todo {Id=2, Title ="Blazer 학습", IsDone = false},
                new Todo {Id=3, Title ="C# 학습", IsDone = true}
            };
        }


        // 인-메모리 데이터베이스 사용 영역
        public void Add(Todo model)
        {
            model.Id = _todos.Max(t => t.Id) + 1;
            _todos.Add(model);
        }

        public List<Todo> GetAll()
        {
            return _todos.ToList();
        }
    }
    /*
    public class TodoRepositorySqlServer : ITodoRepository
    {
        // SQL Server
    }*/
}
