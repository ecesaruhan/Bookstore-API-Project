using System;
using BookStore.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.Data.Concrete.Configs
{
	public class CategoryConfig:IEntityTypeConfiguration<Category>
	{
		public void Configure(EntityTypeBuilder<Category> builder)
		{
			builder.HasKey(c => c.Id);
			builder.Property(c => c.Id).ValueGeneratedOnAdd();
			

			builder.Property(c => c.Name).IsRequired().HasMaxLength(100);

			builder.Property(c => c.Description).IsRequired().HasMaxLength(500);

			builder.Property(c => c.Url).IsRequired().HasMaxLength(100);

			builder
				.HasData(

				new Category
				{
					Id = 1,
					Name = "Dünya Klasikleri",
					Description = "Bir yazarın kaleminden çıkıp dünyaca üne kavuşan ve bu ünü evrensel olarak yıllar boyu devam ettiren eserlerden oluşan seridir.",
					Url = "dunya-klasikleri"
				},

				new Category
				{
					Id = 2,
					Name = "Polisiye Romanlar",
					Description = "Suçlularla dedektiflerin anlatıldığı, gizem ve merak unsurunun ön planda tutulduğu kurgusal metinlerdir.",
					Url = "polisiye-romanlar"
				},

				new Category
				{
					Id = 3,
					Name = "Türk Edebiyatı Klasikleri",
					Description = "Türk dilinde yazılmış ve Türk yazarların kaleminden çıkıp  üne kavuşan ve bu ünü yıllar boyu devam ettiren eserlerden oluşan seridir.",
					Url = "turk-edebiyati-klasikleri"
				},

				new Category
				{
					Id = 4,
					Name = "Bilim Kurgu Romanları",
					Description = "Gelecek ve alternatif zaman dilimlerini bilim ve teknolojinin bulgularını kullanarak anlatan roman serisidir.",
					Url = "bilim-kurgu-romanları"
				},

				new Category
				{
                    Id = 5,
                    Name = "Kişisel Gelişim",
                    Description = "Okurların yaşanmışlıklarından çıkarılan dersleri ve deneyimleri sunar.",
                    Url = "kisisel-gelisim"
                },


                new Category
                {
                    Id = 6,
                    Name = "Çok Satanlar",
                    Description = "Son zamanlarda en çok okunan kitapların bir araya geldiği çok satanlar serisidir.",
                    Url = "cok-satanlar"
                }

            );

		}
	}
}

