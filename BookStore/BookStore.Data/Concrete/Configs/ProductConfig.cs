using System;
using BookStore.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.Data.Concrete.Configs
{
	public class ProductConfig:IEntityTypeConfiguration<Product>
	{
		public void Configure(EntityTypeBuilder<Product> builder)
		{
			builder.HasKey(p => p.Id);
			builder.Property(p => p.Id).ValueGeneratedOnAdd();

			builder.Property(p => p.Name).IsRequired().HasMaxLength(50);

			builder.Property(p => p.Subjects).IsRequired().HasMaxLength(500);

			builder.Property(p => p.Price).IsRequired().HasColumnType("real");

			builder.Property(p => p.Url).IsRequired().HasMaxLength(50);

			builder.Property(p => p.ImageUrl).IsRequired().HasMaxLength(500);

			builder.Property(p => p.CreatedDate).HasDefaultValueSql("date('now')");

			builder.Property(p => p.ModifiedDate).HasDefaultValueSql("date('now')");

			builder.HasData(
				new Product
				{
					Id = 1,
					Name = "Suç ve Ceza",
					Price = 7790,
					Subjects = "Dünyanın en büyük yazarlarından kabul edilen Rus Yazar Fyodor Mihayloviç Dostoyevski’nin 1866’da yayımlanan ölümsüz eseri Suç ve Ceza, tüm insanlığı kavrayan bir öyküye sahip. Aklın, inancın ve eylemlerin vicdan ile muhakemesini tüm çıplaklığıyla yansıtan eser, sizi hem suçlu hem yargıç olduğunuz 705 sayfalık bir soruşturmanın içine çekiyor.",
					Url = "suc-ve-ceza",
					ImageUrl = "sucveceza.png",
					IsHome=true
                },

                    new Product
                    {
                        Id = 2,
                        Name = "İnsan Ne ile Yaşar ?",
                        Price = 4650,
                        Subjects = "Edebiyatçı, filozof ve eğitimci kişiliğiyle toplumun aynası olan, çağının en büyük yazarlarından Tolstoy'un bu eseri, insanın dünyaya geliş amacı ve hayattaki önceliklerine, birleştirici güç olan sevgiye, insanın özünde var olan iyiliğe, açgözlülük ve tokgözlülüğe, hırsa dair içerdiği eşsiz hikâyelerle kendinize dışarıdan bakabilmenizi sağlıyor.",
                        Url = "insan-ne-ile-yasar",
                        ImageUrl = "insanneileyasar.png",
                        IsHome = true
                    },

                     new Product
                     {
                         Id = 3,
                         Name = "Fareler ve İnsanlar",
                         Price = 6650,
                         Subjects = "Nobel ödüllü yazar John Steinbeck’in ilk kez 1937 yılında yayınlanan eseri; çiftlikten çiftliğe dolaşarak çalışan iki yakın arkadaşın başından geçen maceraları ve onların hayallerine sıkı sıkıya olan bağlılığını konu ediniyor. Kendisi de bir dönem gezici çiftlik işçiliği yapmış olan John Steinback’in hayatından da izler taşıyan roman, realist yaklaşımı ile dikkat çekiyor. Gerçeğe yakın bir dil ile kurgulanan eser, oldukça sürükleyici ve etkileyici anlatımı ile günümüzde hala en çok okunan kitaplar arasında bulunuyor",
                         Url = "fareler-ve-insanlar",
                         ImageUrl = "farelerveinsanlar.png",
                         IsHome = true
                     },

                     new Product
                     {
                         Id = 4,
                         Name = "Doğu Ekspresi'nde Cinayet",
                         Price = 12695,
                         Subjects = "Korku-gerilim edebiyatının klasiklerinden. Karlar atlında bir trende herkesden uzakta yaşanan entrika dolu bir yolculuk...",
                         Url = "dogu-ekspresinde-cinayet",
                         ImageUrl = "doguekspresindecinayet.png",
                         IsHome = true
                     },

                      new Product
                      {
                          Id = 5,
                          Name = "Beklenmeyen Misafir",
                          Price = 8310,
                          Subjects = "Beklenmeyen Misafir' esrarengiz gibi görünmese de aslında esrarengiz bir cinayet öyküsü olarak tanımlanabilir. Güney Galler'de yoğun siste bir adam yolunu kaybeder ve arabası bir çukura yuvarlanır. Yardım aramak için girdiği evde, kocasını öldürdüğünü iddia eden, elinde silah bulunan bir kadınla karşılaşır...",
                          Url = "beklenmeyen-misafir",
                          ImageUrl = "beklenmeyenmisafir.png",
                          IsHome = true
                      },

                       new Product
                       {
                           Id = 6,
                           Name = "Ölüm Adası",
                           Price = 9425,
                           Subjects = "Karayip güneşinin tadını çıkaran Miss Marple huzursuz günler geçirmektedir.\nEvet, sıcak hava romatizmalarına iyi gelmiştir ama bu cennet gibi yerde heyecandan eser yoktur.\nMiss Marple’ın otelin müşterilerinden emekli bir subayla tanışması tatiline renk katar. Emekli subayın, tanıdığı bir katilin öyküsünü anlatması Miss Marple’ın ilgisini çeker. Binbaşı tam katilin fotoğrafını göstermek üzereyken birdenbire vazgeçer. Adamın panik içindeki davranışlarını otelde katili görmüş olmasına yoran Marple, yanlış kişiye odaklanır. Ve bu cennet gibi adada peş peşe cinayetler işlenir...",
                           Url = "olum-adası",
                           ImageUrl = "olumadası.png",
                           IsHome = true
                       },

                           new Product
                           {
                               Id = 7,
                               Name = "Saatleri Ayarlama Enstitüsü",
                               Price = 16410,
                               Subjects = "İmparatorluktan cumhuriyete geçiş döneminde Türkiye’nin yetiştirdiği en büyük şair ve yazarlardan olan Ahmet Hamdi Tanpınar’ın Saatleri Ayarlama Enstitüsü adlı eseri, modern Türk romanının kilometre taşları arasında yer alıyor. Yazarın büyük ses getiren Huzur adlı yapıtından sonra ikinci romanı olan Saatleri Ayarlama Enstitüsü, dönem Türkiye’sinin bir yansıması olarak günümüzde de edebi ve tarihi değerini koruyor.",
                               Url = "saatleri-ayarlama-enstitusu",
                               ImageUrl = "saatleriayarlamaenstitusu.png",
                               IsHome = true
                           },

                              new Product
                              {
                                  Id = 8,
                                  Name = "Yaban",
                                  Price = 9125,
                                  Subjects = "Romanda zaman aralığı olarak Birinci Dünya Savaşı’ndan Sakarya Meydan Muharebesi’nin sonuna kadar geçen süre seçiliyor.Yaban, söz konusu dönemde köylerin ve köylülerin durumunu ele alarak kurtuluş mücadelesine farklı bir perspektiften bakmaya olanak sağlıyor. Yazar bununla birlikte, yarattığı farklı statüdeki karakterlerle aydın-köylü çatışmasını da başarılı bir şekilde kurguya ekliyor.",
                                  Url = "yaban",
                                  ImageUrl = "yaban.png",
                                  IsHome = true
                              },

                                 new Product
                                 {
                                     Id = 9,
                                     Name = "Ateşten Gömlek",
                                     Price = 11900,
                                     Subjects = "Türk edebiyatının önemli yazarlarından Halide Edip Adıvar, Kurtuluş Savaşı yıllarını Ateşten Gömlek ile günümüze taşıyor. Adıvar, Kurtuluş Savaşı mücadelesinde Mustafa Kemal Atatürk’ün yanında bizzat yer alıyor. Ateşten Gömlek, yazar tarafından tam da bu yıllarda kaleme alınmaya başlıyor. 1922 yılında ilk kez yayımlanan eser, Kurtuluş Savaşı’nı anlatan ilk roman olarak biliniyor. Eserde savaş yıllarında Anadolu’nun durumu tüm gerçekliğiyle yansıtılırken, kahramanların iç dünyasına da değiniliyor.",
                                     Url = "atesten-gomlek",
                                     ImageUrl = "atestengomlek.png",
                                     IsHome = true
                                 },

                                      new Product
                                      {
                                          Id = 10,
                                          Name = "Bu Ölümsüz",
                                          Price = 12045,
                                          Subjects = "Nükleer savaş Dünya’yı neredeyse yerle bir etmiş, yalnızca dört milyon insan ve bundan çok daha fazla sayıda mutasyona uğramış canlı türü geride kalmıştır. Evrenin en güçlü uzaylı ırklarından biri olan Vegalılar için bu harabe gezegen artık turistik bir bölgeden farksızdır.",
                                          Url = "bu-olumsuz",
                                          ImageUrl = "buolumsuz.png",
                                          IsHome = true
                                      },

                                       new Product
                                       {
                                           Id = 11,
                                           Name = "Hayvan Çiftliği",
                                           Price = 4380,
                                           Subjects = "Kurgusal bir dünya. Eşitlikten uzak bir düzen. Bir tarafta açgözlü, dik kafalı, hırslı insanlar. Diğer tarafta ise insanların anlayıştan uzak, kötücül yönetiminden usanmış, ezilen hayvanlar. İki tür arasındaki savaşın kıvılcımlandığı bir çiftlik. Bu çiftlikte bilinçlenip kendilerini geliştirerek tüm hayvanları insanların zorbalığından kurtarmayı amaçlayan bir hayvan topluluğu. Büyük bir iktidar savaşı.",
                                           Url = "hayvan-ciftligi",
                                           ImageUrl = "hayvanciftligi.png",
                                           IsHome = true
                                       },

                                          new Product
                                          {
                                              Id = 12,
                                              Name = "Hayatı Yeniden Keşfedin",
                                              Price = 14325,
                                              Subjects = "Sosyal hayatımızda sürekli insanlarla iletişim hâlindeyiz. İnsanlarla olan iletişim süreçlerimizi kontrol edelim, hayatın genel akışına ayak uyduralım, derken kendimizle baş başa kalmayı unutuyoruz. İçimizdeki sese kulak vermiyor ve kendi ihtiyaçlarımızı göz ardı ediyoruz. Bunların hepsi bir araya geldiğinde ise büyük bir mutsuzluk döngüsünde kalıyoruz. Jeffrey E. Young ve Janet Klosko, Hayatı Yeniden Keşfedin'de hayatınızı nasıl pozitif yönde ilerletebileceğinizden bahsediyor. ",
                                              Url = "hayati-yeniden-kesfedin",
                                              ImageUrl = "hayatiyenidenkesfedin.png",
                                              IsHome = true
                                          },

                                            new Product
                                            {
                                                Id = 13,
                                                Name = "Sınırlar",
                                                Price = 12600,
                                                Subjects = "Siz de hayatın seyri içinde \"evet\" ve \"hayır\" demek için doğru zamanı bilemeyenlerden misiniz? Öyleyse Henry Cloud ve John Townsend'in Sınırlar kitabı, siz değerli okurlar için yol gösterici bir nitelik taşıyor. Hayatınızı kendi iradeniz doğrultusunda kontrol edebilmenizi sağlayacak bu kitabı keyifle okurken faydalı bilgiler öğreneceğinizi düşünüyoruz. ",
                                                Url = "sinirlar",
                                                ImageUrl = "sinirlar.png",
                                                IsHome = true
                                            },

                                              new Product
                                              {
                                                  Id = 14,
                                                  Name = "Kürk Mantolu Madonna",
                                                  Price = 2040,
                                                  Subjects = "İlk baskısı 1943 yılında yapılan Kürk Mantolu Madonna, günümüzde halen en çok ilgi gören ve satılan kitaplar arasında bulunuyor. Basıldığı günden bu yana 1 milyondan fazla satan kitap üzerine, birçok araştırma ve inceleme yapılmış, hakkında tezler yazılmış, fakat bu başarısının sırrı tam olarak çözülememiştir. Onu bu kadar özel kılan ve hala konuşuluyor olmasındaki en büyük pay, tabii ki Sabahattin Ali’nin usta kalemi ve başarılı ruh tahlilleridir.",
                                                  Url = "kurt-mantolu-madonna",
                                                  ImageUrl = "kurkmantolumadonna.png",
                                                  IsHome = true
                                              },

                                                new Product
                                                {
                                                    Id = 15,
                                                    Name = "Seninle Başlamadı",
                                                    Price = 10125,
                                                    Subjects = "Kendinizi keşfedeceğiniz bir psikoloji kitabına hazır mısınız? Yaşadığınız sorunların, hissettiğiniz duyguların yalnızca kendinize ait olmadığını bilseydiniz ne düşünürdünüz? Geçmişin bugünü etkilediğini ve psikolojik problemleri tetiklediğini öne süren Mark Wolynn, psikolojiye farklı bir bakış açısıyla yaklaşmanızı sağlayacak. Üç nesil öncesine kadar ulaşan hikâyeniz, Seninle Başlamadı'yı okuduktan sonra yeniden şekillenecek. ",
                                                    Url = "seninle-baslamadi",
                                                    ImageUrl = "seninlebaslamadi.png",
                                                    IsHome = true
                                                },

                                                  new Product
                                                  {
                                                      Id = 16,
                                                      Name = "İyi Hissetmek",
                                                      Price = 15800,
                                                      Subjects = "Psikiyatri ve davranış bilimleri alanında dünya genelinde adından en çok söz ettiren bilim insanlarından Dr. David D. Burns, İyi Hissetmek adlı kitabıyla okurlarına daha mutlu bir yaşamın kapılarını aralıyor. Kaygı, suçluluk ve özgüvensizlik gibi duyguların bireyin psikolojisi üzerindeki olumsuz tesirini aşmayı amaçlayan kitap, bilimsel olarak test edilmiş tekniklerle okurlarına eşsiz bir terapi sunuyor.",
                                                      Url = "iyi-hissetmek",
                                                      ImageUrl = "iyihissetmek.png",
                                                      IsHome = true
                                                  }







                );
		}
	}
}

