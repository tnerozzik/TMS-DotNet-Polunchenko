using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Polunchenko.Homework3
{
    class Todo
    {
        private readonly string Id = Guid.NewGuid().ToString().ToUpper().Substring(0, 5);
        private readonly DateTime _dateTime = DateTime.Now;
        private TodoStatus _status = TodoStatus.Backlog;

        
        public string Name { get; set; }

        public string Description { get; set; }

       
        public void SetStatus(TodoStatus status)
        {
            _status = status;
        }

       
        public string GetId()
        {
            return Id;
        }

       
        public void GetInfo()
        {
            Console.WriteLine(Id);
            Console.WriteLine("---");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Status: {_status}");
            Console.WriteLine($"DateTime: {_dateTime}");
            Console.WriteLine();
        }

        public TodoStatus ConvertStatus(string status)
        {
            return status switch
            {
                "Backlog" => TodoStatus.Backlog,
                "InProgress" => TodoStatus.InProgress,
                "Done" => TodoStatus.Done,
                "Canceled" => TodoStatus.Canceled,
                _ => TodoStatus.Unknown,
            };
        }
    }
}

