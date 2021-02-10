using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineStore.Data.Database.Context;
using Microsoft.EntityFrameworkCore;

namespace OnlineStore.Data.Database
{
    public class OnlineStoreDBInitializer
    {
        private readonly OnlineStoreDB _db;
        public OnlineStoreDBInitializer(OnlineStoreDB db) => _db = db;

        public void Initialize()
        {
            Console.WriteLine("Инициализация БД");

            var db = _db.Database;

            if (db.GetPendingMigrations().Any())
            {
                Console.WriteLine("Есть непримененные миграции");
                db.Migrate();
                Console.WriteLine("Миграции выполнены");
            }
            else Console.WriteLine("структура БД в актуальном состоянии");

            InitializeProducts();
        }

         void InitializeProducts()
        {
            if (_db.Products.Any())
                return;

            using (_db.Database.BeginTransaction())
            {
                _db.Categories.AddRange(TestData.Categories);
                _db.Database.ExecuteSqlRaw("SET IDENTITY_INSERT [dbo].[Categories] ON");
                _db.SaveChanges();
                _db.Database.ExecuteSqlRaw("SET IDENTITY_INSERT [dbo].[Categories] OFF");

                _db.Database.CommitTransaction();
            }

            using (_db.Database.BeginTransaction())
            {
                _db.Brands.AddRange(TestData.Brands);
                _db.Database.ExecuteSqlRaw("SET IDENTITY_INSERT [dbo].[Brands] ON");
                _db.SaveChanges();
                _db.Database.ExecuteSqlRaw("SET IDENTITY_INSERT [dbo].[Brands] OFF");

                _db.Database.CommitTransaction();
            }

            using (_db.Database.BeginTransaction())
            {
                _db.Products.AddRange(TestData.Products);
                _db.Database.ExecuteSqlRaw("SET IDENTITY_INSERT [dbo].[Products] ON");
                _db.SaveChanges();
                _db.Database.ExecuteSqlRaw("SET IDENTITY_INSERT [dbo].[Products] OFF");

                _db.Database.CommitTransaction();
            }

            Console.WriteLine("Данные добавлены успешно");
        }
    }
}
