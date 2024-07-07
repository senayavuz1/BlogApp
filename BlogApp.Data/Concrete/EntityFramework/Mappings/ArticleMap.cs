using BlogApp.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Data.Concrete.EntityFramework.Mappings
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasKey(a=>a.Id);
            builder.Property(a=>a.Id).ValueGeneratedOnAdd();
            builder.Property(a=>a.Title).HasMaxLength(100);
            builder.Property(a=>a.Title).IsRequired(true);
            builder.Property(a=>a.Content).IsRequired(true);
            builder.Property(a=>a.Content).HasColumnType("NVARCHAR(MAX)");
            builder.Property(a=>a.Date).IsRequired(true);
            builder.Property(a=>a.SeoAuthor).IsRequired(true);
            builder.Property(a=>a.SeoAuthor).HasMaxLength(50);
            builder.Property(a=>a.SeoDescription).HasMaxLength(150);
            builder.Property(a=>a.SeoDescription).IsRequired(true);
            builder.Property(a=>a.SeoTags).IsRequired(true);
            builder.Property(a=>a.SeoTags).HasMaxLength(70);
            builder.Property(a=>a.ViewsCount).IsRequired(true);
            builder.Property(a=>a.CommentCount).IsRequired();
            builder.Property(a=>a.Thumbnail).IsRequired();
            builder.Property(a=>a.Thumbnail).HasMaxLength(250);
            builder.Property(a=>a.CreatedByName).HasMaxLength(50);
            builder.Property(a=>a.CreatedByName).IsRequired();
            builder.Property(a => a.ModifiedByName).HasMaxLength(50);
            builder.Property(a => a.ModifiedByName).IsRequired();
            builder.Property(a => a.CreatedDate).IsRequired();
            builder.Property(a => a.ModifiedDate).IsRequired();
            builder.Property(a => a.IsActive).IsRequired();
            builder.Property(a => a.IsDeleted).IsRequired();
            builder.Property(a => a.Note).HasMaxLength(500);

            builder.HasOne<Category>(a => a.Category).WithMany(c=>c.Articles).HasForeignKey(a=>a.CategoryId);
            builder.HasOne<User>(a => a.User).WithMany(u => u.Articles).HasForeignKey(a => a.UserId);

            builder.ToTable("Articles");

            //builder.HasData(new Article
            //{
            //    Id = 1,
            //    CategoryId = 1,
            //    Title = "C# 9.0 ve .Net 5 Yenilikleri",
            //    Content = "C#9.0 güncellemesi 2020'nin kasım ayında .Net 5.0 ve Visual Studio 16.8.0 güncellemesi ile beraber geldi. Microsoft bu yeni .Net Core güncellemesinde ismindeki Core ifadesini kaldırmış ve diğer bütün platformları .Net çatısı altında birleştirmeyi amaçlamış.",
            //    Thumbnail = "Default.jpg",
            //    SeoDescription = "C# 9.0 ve .Net 5 Yenilikleri",
            //    SeoTags = "C#, C# 9, .NET5, .NET Framework, .NET Core",
            //    SeoAuthor = "Sena Yavuz",
            //    Date = DateTime.Now,
            //    IsActive = true,
            //    IsDeleted = false,
            //    CreatedByName = "InitialCreate",
            //    CreatedDate = DateTime.Now,
            //    ModifiedByName = "InitialCreate",
            //    ModifiedDate = DateTime.Now,
            //    Note = "C# 9.0 ve .Net 5 Yenilikleri",
            //    UserId = 1,
            //    ViewsCount = 100,
            //    CommentCount = 1
                
            //},
            //new Article 
            //{
            //    Id = 2,
            //    CategoryId = 2,
            //    Title = "C++ 20 Yenilikleri",
            //    Content = "C++11 ile başlayan ve her 3 yılda bir güncellenen standart, geleneğini C++20 güncellemesi ile devam ettiriyor. C++14 ve C++17 standartları, C++11 ile gelen özelliklerin güçlendirilmesi, daha çok derleyici zamanında kod çalıştırılması gibi yenilikler getirirken, dile çok fazla veya çok büyük yenilikler getirmemişlerdi. Ancak, C++20 standardı ile birlikte gelen 4 büyük yenilik ve birçok yeni iyileştirme sayesinde C++ dili, diğer diller ile olan rekabetinde yeni bir sayfa daha açacağa benziyor.",
            //    Thumbnail = "Default.jpg",
            //    SeoDescription = "C++ 20 Yenilikleri",
            //    SeoTags = "C++, C++ 20",
            //    SeoAuthor = "Sena Yavuz",
            //    Date = DateTime.Now,
            //    IsActive = true,
            //    IsDeleted = false,
            //    CreatedByName = "InitialCreate",
            //    CreatedDate = DateTime.Now,
            //    ModifiedByName = "InitialCreate",
            //    ModifiedDate = DateTime.Now,
            //    Note = "C++ 20 Yenilikleri",
            //    UserId = 1,
            //    ViewsCount = 295,
            //    CommentCount = 1
            //},
            //new Article 
            //{
            //    Id = 3,
            //    CategoryId = 3,
            //    Title = "JavaScript Yenilikleri",
            //    Content = "ES6'dan once, bir değişkeni tanımlamanın tek yolu var anahtar kelimesiydi. Artık gelişmiş işlevsellik sağlayan birkaç farklı seçeneğimiz var.",
            //    Thumbnail = "Default.jpg",
            //    SeoDescription = "JavaScript Yenilikleri",
            //    SeoTags = "JavaScript, ES6",
            //    SeoAuthor = "Sena Yavuz",
            //    Date = DateTime.Now,
            //    IsActive = true,
            //    IsDeleted = false,
            //    CreatedByName = "InitialCreate",
            //    CreatedDate = DateTime.Now,
            //    ModifiedByName = "InitialCreate",
            //    ModifiedDate = DateTime.Now,
            //    Note = "JavaScript Yenilikleri",
            //    UserId = 1,
            //    ViewsCount = 12,
            //    CommentCount = 1
            //});
        }
    }
}
