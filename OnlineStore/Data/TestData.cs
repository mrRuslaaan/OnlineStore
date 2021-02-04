﻿using System;
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

        public static IEnumerable<Product> Products { get; } = new[]
       {
            new Product { Id = 1, Name = "Белое платье", Price = 1025, ImageUrl = "product1.jpg",CategoryId = 2, BrandId = 1 },
            new Product { Id = 2, Name = "Розовое платье", Price = 1025, ImageUrl = "product2.jpg",CategoryId = 2, BrandId = 1 },
            new Product { Id = 3, Name = "Красное платье", Price = 1025, ImageUrl = "product3.jpg",CategoryId = 2, BrandId = 7 },
            new Product { Id = 4, Name = "Джинсы", Price = 1025, ImageUrl = "product4.jpg",CategoryId = 2, BrandId = 1 },
            new Product { Id = 5, Name = "Лёгкая майка", Price = 1025, ImageUrl = "product5.jpg",CategoryId = 2, BrandId = 2 },
            new Product { Id = 6, Name = "Лёгкое голубое поло", Price = 1025, ImageUrl = "product6.jpg",CategoryId = 2, BrandId = 1 },
            new Product { Id = 7, Name = "Платье белое", Price = 1025, ImageUrl = "product7.jpg",CategoryId = 2, BrandId = 1 },
            new Product { Id = 8, Name = "Костюм кролика", Price = 1025, ImageUrl = "product8.jpg",CategoryId = 25, BrandId = 1 },
            new Product { Id = 9, Name = "Красное китайское платье", Price = 1025, ImageUrl = "product9.jpg",CategoryId = 25, BrandId = 1 },
            new Product { Id = 10, Name = "Женские джинсы", Price = 1025, ImageUrl = "product10.jpg",CategoryId = 25, BrandId = 3 },
            new Product { Id = 11, Name = "Джинсы женские", Price = 1025, ImageUrl = "product11.jpg", CategoryId = 25, BrandId = 3 },
            new Product { Id = 12, Name = "Летний костюм", Price = 1025, ImageUrl = "product12.jpg", CategoryId = 25, BrandId = 3 },
        };
    }
}
