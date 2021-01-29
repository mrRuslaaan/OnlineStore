using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineStore.Models;

namespace OnlineStore.Data
{
    public static class TestData
    {
        public static List<Worker> Workers { get; } = new List<Worker>()
        {
            new Worker() { ID = 1, Name = "Александр", Surname ="Пушкин", Patronymic = "Сергеевич", Age = 25 },
            new Worker() { ID = 2, Name = "Федор", Surname ="Достоевский", Patronymic = "Михайлович", Age = 32 },
            new Worker() { ID = 3, Name = "Лев", Surname ="Толстой", Patronymic = "Николаевич", Age = 33 },
        };

        public static List<Blog> Blogs { get; } = new List<Blog>()
        {
            new Blog() {ID = 1, AuthorID = 1, Head = "Новая блузка", Body = "ASDasdasdasdasdasdasdasdasdasd", DateOfPublication = DateTime.Now },
        };
    }
}
