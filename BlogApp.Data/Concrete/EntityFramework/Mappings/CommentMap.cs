﻿using BlogApp.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Data.Concrete.EntityFramework.Mappings
{
    public class CommentMap : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(c=>c.Id);
            builder.Property(c=>c.Id).ValueGeneratedOnAdd();
            builder.Property(c=>c.Text).IsRequired();
            builder.Property(c=>c.Text).HasMaxLength(1000);
            builder.Property(c => c.CreatedByName).HasMaxLength(50);
            builder.Property(c => c.CreatedByName).IsRequired();
            builder.Property(c => c.ModifiedByName).HasMaxLength(50);
            builder.Property(c => c.ModifiedByName).IsRequired();
            builder.Property(c => c.CreatedDate).IsRequired();
            builder.Property(c => c.ModifiedDate).IsRequired();
            builder.Property(c => c.IsActive).IsRequired();
            builder.Property(c => c.IsDeleted).IsRequired();
            builder.Property(c => c.Note).HasMaxLength(500);

            builder.HasOne<Article>(c => c.Article).WithMany(a => a.Comments).HasForeignKey(c => c.ArticleId);

            builder.ToTable("Comments");

            //builder.HasData(new Comment
            //{
            //    Id = 1,
            //    ArticleId = 1,
            //    Text = "Bu büyük yenilik sonrasında yeni kodlar ile eski(legacy) kodlar kıyaslandığında, konsept kullanılarak yazılan kodların çok daha anlaşılır ve kullanımının daha kolay olduğunu hep birlikte deneyimleyeceğiz.",
            //    IsActive = true,
            //    IsDeleted = false,
            //    CreatedByName = "InitialCreate",
            //    CreatedDate = DateTime.Now,
            //    ModifiedByName = "InitialCreate",
            //    ModifiedDate = DateTime.Now,
            //    Note = "C# Makale Yorumu",
            //},
            //new Comment 
            //{
            //    Id = 2,
            //    ArticleId = 2,
            //    Text = "Bu büyük yenilik sonrasında yeni kodlar ile eski(legacy) kodlar kıyaslandığında, konsept kullanılarak yazılan kodların çok daha anlaşılır ve kullanımının daha kolay olduğunu hep birlikte deneyimleyeceğiz.",
            //    IsActive = true,
            //    IsDeleted = false,
            //    CreatedByName = "InitialCreate",
            //    CreatedDate = DateTime.Now,
            //    ModifiedByName = "InitialCreate",
            //    ModifiedDate = DateTime.Now,
            //    Note = "C++ Makale Yorumu",
            //},
            //new Comment
            //{
            //    Id = 3,
            //    ArticleId = 3,
            //    Text = "Bu büyük yenilik sonrasında yeni kodlar ile eski(legacy) kodlar kıyaslandığında, konsept kullanılarak yazılan kodların çok daha anlaşılır ve kullanımının daha kolay olduğunu hep birlikte deneyimleyeceğiz.",
            //    IsActive = true,
            //    IsDeleted = false,
            //    CreatedByName = "InitialCreate",
            //    CreatedDate = DateTime.Now,
            //    ModifiedByName = "InitialCreate",
            //    ModifiedDate = DateTime.Now,
            //    Note = "JavaScript Makale Yorumu",
            //});
        }
    }
}
