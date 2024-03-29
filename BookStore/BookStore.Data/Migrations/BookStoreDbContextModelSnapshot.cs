﻿// <auto-generated />
using System;
using BookStore.Data.Concrete.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookStore.Data.Migrations
{
    [DbContext(typeof(BookStoreDbContext))]
    partial class BookStoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.15");

            modelBuilder.Entity("BookStore.Entity.Concrete.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(2870),
                            Description = "Bir yazarın kaleminden çıkıp dünyaca üne kavuşan ve bu ünü evrensel olarak yıllar boyu devam ettiren eserlerden oluşan seridir.",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(2900),
                            Name = "Dünya Klasikleri",
                            Url = "dunya-klasikleri"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(2910),
                            Description = "Suçlularla dedektiflerin anlatıldığı, gizem ve merak unsurunun ön planda tutulduğu kurgusal metinlerdir.",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(2910),
                            Name = "Polisiye Romanlar",
                            Url = "polisiye-romanlar"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(2910),
                            Description = "Türk dilinde yazılmış ve Türk yazarların kaleminden çıkıp  üne kavuşan ve bu ünü yıllar boyu devam ettiren eserlerden oluşan seridir.",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(2910),
                            Name = "Türk Edebiyatı Klasikleri",
                            Url = "turk-edebiyati-klasikleri"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(2920),
                            Description = "Gelecek ve alternatif zaman dilimlerini bilim ve teknolojinin bulgularını kullanarak anlatan roman serisidir.",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(2920),
                            Name = "Bilim Kurgu Romanları",
                            Url = "bilim-kurgu-romanları"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(2920),
                            Description = "Okurların yaşanmışlıklarından çıkarılan dersleri ve deneyimleri sunar.",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(2920),
                            Name = "Kişisel Gelişim",
                            Url = "kisisel-gelisim"
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(2930),
                            Description = "Son zamanlarda en çok okunan kitapların bir araya geldiği çok satanlar serisidir.",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(2930),
                            Name = "Çok Satanlar",
                            Url = "cok-satanlar"
                        });
                });

            modelBuilder.Entity("BookStore.Entity.Concrete.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("date('now')");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsHome")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ModifiedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("date('now')");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("real");

                    b.Property<string>("Subjects")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(6650),
                            ImageUrl = "sucveceza.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(6660),
                            Name = "Suç ve Ceza",
                            Price = 7790m,
                            Subjects = "Dünyanın en büyük yazarlarından kabul edilen Rus Yazar Fyodor Mihayloviç Dostoyevski’nin 1866’da yayımlanan ölümsüz eseri Suç ve Ceza, tüm insanlığı kavrayan bir öyküye sahip. Aklın, inancın ve eylemlerin vicdan ile muhakemesini tüm çıplaklığıyla yansıtan eser, sizi hem suçlu hem yargıç olduğunuz 705 sayfalık bir soruşturmanın içine çekiyor.",
                            Url = "suc-ve-ceza"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(6670),
                            ImageUrl = "insanneileyasar.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(6670),
                            Name = "İnsan Ne ile Yaşar ?",
                            Price = 4650m,
                            Subjects = "Edebiyatçı, filozof ve eğitimci kişiliğiyle toplumun aynası olan, çağının en büyük yazarlarından Tolstoy'un bu eseri, insanın dünyaya geliş amacı ve hayattaki önceliklerine, birleştirici güç olan sevgiye, insanın özünde var olan iyiliğe, açgözlülük ve tokgözlülüğe, hırsa dair içerdiği eşsiz hikâyelerle kendinize dışarıdan bakabilmenizi sağlıyor.",
                            Url = "insan-ne-ile-yasar"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(6670),
                            ImageUrl = "farelerveinsanlar.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(6670),
                            Name = "Fareler ve İnsanlar",
                            Price = 6650m,
                            Subjects = "Nobel ödüllü yazar John Steinbeck’in ilk kez 1937 yılında yayınlanan eseri; çiftlikten çiftliğe dolaşarak çalışan iki yakın arkadaşın başından geçen maceraları ve onların hayallerine sıkı sıkıya olan bağlılığını konu ediniyor. Kendisi de bir dönem gezici çiftlik işçiliği yapmış olan John Steinback’in hayatından da izler taşıyan roman, realist yaklaşımı ile dikkat çekiyor. Gerçeğe yakın bir dil ile kurgulanan eser, oldukça sürükleyici ve etkileyici anlatımı ile günümüzde hala en çok okunan kitaplar arasında bulunuyor",
                            Url = "fareler-ve-insanlar"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(6680),
                            ImageUrl = "doguekspresindecinayet.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(6680),
                            Name = "Doğu Ekspresi'nde Cinayet",
                            Price = 12695m,
                            Subjects = "Korku-gerilim edebiyatının klasiklerinden. Karlar atlında bir trende herkesden uzakta yaşanan entrika dolu bir yolculuk...",
                            Url = "dogu-ekspresinde-cinayet"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(6680),
                            ImageUrl = "beklenmeyenmisafir.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(6680),
                            Name = "Beklenmeyen Misafir",
                            Price = 8310m,
                            Subjects = "Beklenmeyen Misafir' esrarengiz gibi görünmese de aslında esrarengiz bir cinayet öyküsü olarak tanımlanabilir. Güney Galler'de yoğun siste bir adam yolunu kaybeder ve arabası bir çukura yuvarlanır. Yardım aramak için girdiği evde, kocasını öldürdüğünü iddia eden, elinde silah bulunan bir kadınla karşılaşır...",
                            Url = "beklenmeyen-misafir"
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(6680),
                            ImageUrl = "olumadası.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(6690),
                            Name = "Ölüm Adası",
                            Price = 9425m,
                            Subjects = "Karayip güneşinin tadını çıkaran Miss Marple huzursuz günler geçirmektedir.\nEvet, sıcak hava romatizmalarına iyi gelmiştir ama bu cennet gibi yerde heyecandan eser yoktur.\nMiss Marple’ın otelin müşterilerinden emekli bir subayla tanışması tatiline renk katar. Emekli subayın, tanıdığı bir katilin öyküsünü anlatması Miss Marple’ın ilgisini çeker. Binbaşı tam katilin fotoğrafını göstermek üzereyken birdenbire vazgeçer. Adamın panik içindeki davranışlarını otelde katili görmüş olmasına yoran Marple, yanlış kişiye odaklanır. Ve bu cennet gibi adada peş peşe cinayetler işlenir...",
                            Url = "olum-adası"
                        },
                        new
                        {
                            Id = 7,
                            CreatedDate = new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(6690),
                            ImageUrl = "saatleriayarlamaenstitusu.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(6690),
                            Name = "Saatleri Ayarlama Enstitüsü",
                            Price = 16410m,
                            Subjects = "İmparatorluktan cumhuriyete geçiş döneminde Türkiye’nin yetiştirdiği en büyük şair ve yazarlardan olan Ahmet Hamdi Tanpınar’ın Saatleri Ayarlama Enstitüsü adlı eseri, modern Türk romanının kilometre taşları arasında yer alıyor. Yazarın büyük ses getiren Huzur adlı yapıtından sonra ikinci romanı olan Saatleri Ayarlama Enstitüsü, dönem Türkiye’sinin bir yansıması olarak günümüzde de edebi ve tarihi değerini koruyor.",
                            Url = "saatleri-ayarlama-enstitusu"
                        },
                        new
                        {
                            Id = 8,
                            CreatedDate = new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(6690),
                            ImageUrl = "yaban.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(6700),
                            Name = "Yaban",
                            Price = 9125m,
                            Subjects = "Romanda zaman aralığı olarak Birinci Dünya Savaşı’ndan Sakarya Meydan Muharebesi’nin sonuna kadar geçen süre seçiliyor.Yaban, söz konusu dönemde köylerin ve köylülerin durumunu ele alarak kurtuluş mücadelesine farklı bir perspektiften bakmaya olanak sağlıyor. Yazar bununla birlikte, yarattığı farklı statüdeki karakterlerle aydın-köylü çatışmasını da başarılı bir şekilde kurguya ekliyor.",
                            Url = "yaban"
                        },
                        new
                        {
                            Id = 9,
                            CreatedDate = new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(6700),
                            ImageUrl = "atestengomlek.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(6700),
                            Name = "Ateşten Gömlek",
                            Price = 11900m,
                            Subjects = "Türk edebiyatının önemli yazarlarından Halide Edip Adıvar, Kurtuluş Savaşı yıllarını Ateşten Gömlek ile günümüze taşıyor. Adıvar, Kurtuluş Savaşı mücadelesinde Mustafa Kemal Atatürk’ün yanında bizzat yer alıyor. Ateşten Gömlek, yazar tarafından tam da bu yıllarda kaleme alınmaya başlıyor. 1922 yılında ilk kez yayımlanan eser, Kurtuluş Savaşı’nı anlatan ilk roman olarak biliniyor. Eserde savaş yıllarında Anadolu’nun durumu tüm gerçekliğiyle yansıtılırken, kahramanların iç dünyasına da değiniliyor.",
                            Url = "atesten-gomlek"
                        },
                        new
                        {
                            Id = 10,
                            CreatedDate = new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(6700),
                            ImageUrl = "buolumsuz.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(6700),
                            Name = "Bu Ölümsüz",
                            Price = 12045m,
                            Subjects = "Nükleer savaş Dünya’yı neredeyse yerle bir etmiş, yalnızca dört milyon insan ve bundan çok daha fazla sayıda mutasyona uğramış canlı türü geride kalmıştır. Evrenin en güçlü uzaylı ırklarından biri olan Vegalılar için bu harabe gezegen artık turistik bir bölgeden farksızdır.",
                            Url = "bu-olumsuz"
                        },
                        new
                        {
                            Id = 11,
                            CreatedDate = new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(6710),
                            ImageUrl = "hayvanciftligi.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(6710),
                            Name = "Hayvan Çiftliği",
                            Price = 4380m,
                            Subjects = "Kurgusal bir dünya. Eşitlikten uzak bir düzen. Bir tarafta açgözlü, dik kafalı, hırslı insanlar. Diğer tarafta ise insanların anlayıştan uzak, kötücül yönetiminden usanmış, ezilen hayvanlar. İki tür arasındaki savaşın kıvılcımlandığı bir çiftlik. Bu çiftlikte bilinçlenip kendilerini geliştirerek tüm hayvanları insanların zorbalığından kurtarmayı amaçlayan bir hayvan topluluğu. Büyük bir iktidar savaşı.",
                            Url = "hayvan-ciftligi"
                        },
                        new
                        {
                            Id = 12,
                            CreatedDate = new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(6710),
                            ImageUrl = "hayatiyenidenkesfedin.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(6710),
                            Name = "Hayatı Yeniden Keşfedin",
                            Price = 14325m,
                            Subjects = "Sosyal hayatımızda sürekli insanlarla iletişim hâlindeyiz. İnsanlarla olan iletişim süreçlerimizi kontrol edelim, hayatın genel akışına ayak uyduralım, derken kendimizle baş başa kalmayı unutuyoruz. İçimizdeki sese kulak vermiyor ve kendi ihtiyaçlarımızı göz ardı ediyoruz. Bunların hepsi bir araya geldiğinde ise büyük bir mutsuzluk döngüsünde kalıyoruz. Jeffrey E. Young ve Janet Klosko, Hayatı Yeniden Keşfedin'de hayatınızı nasıl pozitif yönde ilerletebileceğinizden bahsediyor. ",
                            Url = "hayati-yeniden-kesfedin"
                        },
                        new
                        {
                            Id = 13,
                            CreatedDate = new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(6720),
                            ImageUrl = "sinirlar.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(6720),
                            Name = "Sınırlar",
                            Price = 12600m,
                            Subjects = "Siz de hayatın seyri içinde \"evet\" ve \"hayır\" demek için doğru zamanı bilemeyenlerden misiniz? Öyleyse Henry Cloud ve John Townsend'in Sınırlar kitabı, siz değerli okurlar için yol gösterici bir nitelik taşıyor. Hayatınızı kendi iradeniz doğrultusunda kontrol edebilmenizi sağlayacak bu kitabı keyifle okurken faydalı bilgiler öğreneceğinizi düşünüyoruz. ",
                            Url = "sinirlar"
                        },
                        new
                        {
                            Id = 14,
                            CreatedDate = new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(6720),
                            ImageUrl = "kurkmantolumadonna.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(6720),
                            Name = "Kürk Mantolu Madonna",
                            Price = 2040m,
                            Subjects = "İlk baskısı 1943 yılında yapılan Kürk Mantolu Madonna, günümüzde halen en çok ilgi gören ve satılan kitaplar arasında bulunuyor. Basıldığı günden bu yana 1 milyondan fazla satan kitap üzerine, birçok araştırma ve inceleme yapılmış, hakkında tezler yazılmış, fakat bu başarısının sırrı tam olarak çözülememiştir. Onu bu kadar özel kılan ve hala konuşuluyor olmasındaki en büyük pay, tabii ki Sabahattin Ali’nin usta kalemi ve başarılı ruh tahlilleridir.",
                            Url = "kurt-mantolu-madonna"
                        },
                        new
                        {
                            Id = 15,
                            CreatedDate = new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(6730),
                            ImageUrl = "seninlebaslamadi.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(6730),
                            Name = "Seninle Başlamadı",
                            Price = 10125m,
                            Subjects = "Kendinizi keşfedeceğiniz bir psikoloji kitabına hazır mısınız? Yaşadığınız sorunların, hissettiğiniz duyguların yalnızca kendinize ait olmadığını bilseydiniz ne düşünürdünüz? Geçmişin bugünü etkilediğini ve psikolojik problemleri tetiklediğini öne süren Mark Wolynn, psikolojiye farklı bir bakış açısıyla yaklaşmanızı sağlayacak. Üç nesil öncesine kadar ulaşan hikâyeniz, Seninle Başlamadı'yı okuduktan sonra yeniden şekillenecek. ",
                            Url = "seninle-baslamadi"
                        },
                        new
                        {
                            Id = 16,
                            CreatedDate = new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(6730),
                            ImageUrl = "iyihissetmek.png",
                            IsActive = true,
                            IsDeleted = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(6730),
                            Name = "İyi Hissetmek",
                            Price = 15800m,
                            Subjects = "Psikiyatri ve davranış bilimleri alanında dünya genelinde adından en çok söz ettiren bilim insanlarından Dr. David D. Burns, İyi Hissetmek adlı kitabıyla okurlarına daha mutlu bir yaşamın kapılarını aralıyor. Kaygı, suçluluk ve özgüvensizlik gibi duyguların bireyin psikolojisi üzerindeki olumsuz tesirini aşmayı amaçlayan kitap, bilimsel olarak test edilmiş tekniklerle okurlarına eşsiz bir terapi sunuyor.",
                            Url = "iyi-hissetmek"
                        });
                });

            modelBuilder.Entity("BookStore.Entity.Concrete.ProductCategory", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProductId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("ProductCategories");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1
                        },
                        new
                        {
                            ProductId = 1,
                            CategoryId = 6
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 1
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 6
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 1
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 6
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 2
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 2
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryId = 2
                        },
                        new
                        {
                            ProductId = 7,
                            CategoryId = 3
                        },
                        new
                        {
                            ProductId = 8,
                            CategoryId = 3
                        },
                        new
                        {
                            ProductId = 9,
                            CategoryId = 3
                        },
                        new
                        {
                            ProductId = 10,
                            CategoryId = 4
                        },
                        new
                        {
                            ProductId = 11,
                            CategoryId = 1
                        },
                        new
                        {
                            ProductId = 11,
                            CategoryId = 4
                        },
                        new
                        {
                            ProductId = 12,
                            CategoryId = 5
                        },
                        new
                        {
                            ProductId = 13,
                            CategoryId = 5
                        },
                        new
                        {
                            ProductId = 14,
                            CategoryId = 3
                        },
                        new
                        {
                            ProductId = 14,
                            CategoryId = 6
                        },
                        new
                        {
                            ProductId = 15,
                            CategoryId = 5
                        },
                        new
                        {
                            ProductId = 15,
                            CategoryId = 6
                        },
                        new
                        {
                            ProductId = 16,
                            CategoryId = 5
                        },
                        new
                        {
                            ProductId = 16,
                            CategoryId = 6
                        });
                });

            modelBuilder.Entity("BookStore.Entity.Concrete.ProductCategory", b =>
                {
                    b.HasOne("BookStore.Entity.Concrete.Category", "Category")
                        .WithMany("ProductCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookStore.Entity.Concrete.Product", "Product")
                        .WithMany("ProductCategories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("BookStore.Entity.Concrete.Category", b =>
                {
                    b.Navigation("ProductCategories");
                });

            modelBuilder.Entity("BookStore.Entity.Concrete.Product", b =>
                {
                    b.Navigation("ProductCategories");
                });
#pragma warning restore 612, 618
        }
    }
}
