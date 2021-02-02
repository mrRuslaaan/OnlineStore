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
            new Blog() {ID = 1, AuthorID = 2, Head = "Новая блузка", Body = "ASDasdasdasdasdasdasdasdasdasd", DateOfPublication = DateTime.Now },
            new Blog() {ID = 2, AuthorID = 1, Head = "Синяя блущка", Body = "ASDasdasdasdasdasdasdasdasdasd", DateOfPublication = DateTime.Now },
        };


        public static IEnumerable<Category> Categories { get; } = new[]
      {
              new Category { Id = 1, Name = "Спорт"},
              new Category { Id = 2, Name = "Nike", ParentId = 1 },
              new Category { Id = 3, Name = "Under Armour", ParentId = 1 },
              new Category { Id = 4, Name = "Adidas", ParentId = 1 },
              new Category { Id = 5, Name = "Puma", ParentId = 1 },
              new Category { Id = 6, Name = "ASICS", ParentId = 1 },
              new Category { Id = 7, Name = "Для мужчин"},
              new Category { Id = 8, Name = "Fendi", ParentId = 7 },
              new Category { Id = 9, Name = "Guess", ParentId = 7 },
              new Category { Id = 10, Name = "Valentino", ParentId = 7 },
              new Category { Id = 11, Name = "Диор", ParentId = 7 },
              new Category { Id = 12, Name = "Версачи", ParentId = 7 },
              new Category { Id = 13, Name = "Армани", ParentId = 7 },
              new Category { Id = 14, Name = "Prada", ParentId = 7 },
              new Category { Id = 15, Name = "Дольче и Габбана", ParentId = 7 },
              new Category { Id = 16, Name = "Шанель", ParentId = 7 },
              new Category { Id = 17, Name = "Гуччи", ParentId = 7 },
              new Category { Id = 18, Name = "Для женщин"},
              new Category { Id = 19, Name = "Fendi", ParentId = 18 },
              new Category { Id = 20, Name = "Guess", ParentId = 18 },
              new Category { Id = 21, Name = "Valentino", ParentId = 18 },
              new Category { Id = 22, Name = "Dior", ParentId = 18 },
              new Category { Id = 23, Name = "Versace", ParentId = 18 },
              new Category { Id = 24, Name = "Для детей"},
              new Category { Id = 25, Name = "Мода"},
              new Category { Id = 26, Name = "Для дома"},
              new Category { Id = 27, Name = "Интерьер"},
              new Category { Id = 28, Name = "Одежда"},
              new Category { Id = 29, Name = "Сумки"},
              new Category { Id = 30, Name = "Обувь"},
        };

        public static IEnumerable<Brand> Brands { get; } = new[]
        {
            new Brand { Id = 1, Name = "Acne"},
            new Brand { Id = 2, Name = "Grune Erde"},
            new Brand { Id = 3, Name = "Albiro"},
            new Brand { Id = 4, Name = "Ronhill"},
            new Brand { Id = 5, Name = "Oddmolly"},
            new Brand { Id = 6, Name = "Boudestijn"},
            new Brand { Id = 7, Name = "Rosch creative culture"},
        };
    }
}
