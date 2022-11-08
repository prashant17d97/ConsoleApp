using System.Collections.Generic;

namespace ConsoleApp.Model
{
    public class Comments
    {
        public int UserId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }

    public class DataModel
    {
        public List<Comments> Data { get; set; }
    }
}
