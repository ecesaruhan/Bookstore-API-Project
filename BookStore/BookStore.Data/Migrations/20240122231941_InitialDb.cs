using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStore.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    Url = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Subjects = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(type: "real", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    IsHome = table.Column<bool>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "date('now')"),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "date('now')"),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    Url = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => new { x.ProductId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_ProductCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductCategories_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedDate", "Name", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(2870), "Bir yazarın kaleminden çıkıp dünyaca üne kavuşan ve bu ünü evrensel olarak yıllar boyu devam ettiren eserlerden oluşan seridir.", true, false, new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(2900), "Dünya Klasikleri", "dunya-klasikleri" },
                    { 2, new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(2910), "Suçlularla dedektiflerin anlatıldığı, gizem ve merak unsurunun ön planda tutulduğu kurgusal metinlerdir.", true, false, new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(2910), "Polisiye Romanlar", "polisiye-romanlar" },
                    { 3, new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(2910), "Türk dilinde yazılmış ve Türk yazarların kaleminden çıkıp  üne kavuşan ve bu ünü yıllar boyu devam ettiren eserlerden oluşan seridir.", true, false, new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(2910), "Türk Edebiyatı Klasikleri", "turk-edebiyati-klasikleri" },
                    { 4, new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(2920), "Gelecek ve alternatif zaman dilimlerini bilim ve teknolojinin bulgularını kullanarak anlatan roman serisidir.", true, false, new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(2920), "Bilim Kurgu Romanları", "bilim-kurgu-romanları" },
                    { 5, new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(2920), "Okurların yaşanmışlıklarından çıkarılan dersleri ve deneyimleri sunar.", true, false, new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(2920), "Kişisel Gelişim", "kisisel-gelisim" },
                    { 6, new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(2930), "Son zamanlarda en çok okunan kitapların bir araya geldiği çok satanlar serisidir.", true, false, new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(2930), "Çok Satanlar", "cok-satanlar" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedDate", "ImageUrl", "IsActive", "IsDeleted", "IsHome", "ModifiedDate", "Name", "Price", "Subjects", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(6650), "sucveceza.png", true, false, true, new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(6660), "Suç ve Ceza", 7790m, "Dünyanın en büyük yazarlarından kabul edilen Rus Yazar Fyodor Mihayloviç Dostoyevski’nin 1866’da yayımlanan ölümsüz eseri Suç ve Ceza, tüm insanlığı kavrayan bir öyküye sahip. Aklın, inancın ve eylemlerin vicdan ile muhakemesini tüm çıplaklığıyla yansıtan eser, sizi hem suçlu hem yargıç olduğunuz 705 sayfalık bir soruşturmanın içine çekiyor.", "suc-ve-ceza" },
                    { 2, new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(6670), "insanneileyasar.png", true, false, true, new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(6670), "İnsan Ne ile Yaşar ?", 4650m, "Edebiyatçı, filozof ve eğitimci kişiliğiyle toplumun aynası olan, çağının en büyük yazarlarından Tolstoy'un bu eseri, insanın dünyaya geliş amacı ve hayattaki önceliklerine, birleştirici güç olan sevgiye, insanın özünde var olan iyiliğe, açgözlülük ve tokgözlülüğe, hırsa dair içerdiği eşsiz hikâyelerle kendinize dışarıdan bakabilmenizi sağlıyor.", "insan-ne-ile-yasar" },
                    { 3, new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(6670), "farelerveinsanlar.png", true, false, true, new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(6670), "Fareler ve İnsanlar", 6650m, "Nobel ödüllü yazar John Steinbeck’in ilk kez 1937 yılında yayınlanan eseri; çiftlikten çiftliğe dolaşarak çalışan iki yakın arkadaşın başından geçen maceraları ve onların hayallerine sıkı sıkıya olan bağlılığını konu ediniyor. Kendisi de bir dönem gezici çiftlik işçiliği yapmış olan John Steinback’in hayatından da izler taşıyan roman, realist yaklaşımı ile dikkat çekiyor. Gerçeğe yakın bir dil ile kurgulanan eser, oldukça sürükleyici ve etkileyici anlatımı ile günümüzde hala en çok okunan kitaplar arasında bulunuyor", "fareler-ve-insanlar" },
                    { 4, new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(6680), "doguekspresindecinayet.png", true, false, true, new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(6680), "Doğu Ekspresi'nde Cinayet", 12695m, "Korku-gerilim edebiyatının klasiklerinden. Karlar atlında bir trende herkesden uzakta yaşanan entrika dolu bir yolculuk...", "dogu-ekspresinde-cinayet" },
                    { 5, new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(6680), "beklenmeyenmisafir.png", true, false, true, new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(6680), "Beklenmeyen Misafir", 8310m, "Beklenmeyen Misafir' esrarengiz gibi görünmese de aslında esrarengiz bir cinayet öyküsü olarak tanımlanabilir. Güney Galler'de yoğun siste bir adam yolunu kaybeder ve arabası bir çukura yuvarlanır. Yardım aramak için girdiği evde, kocasını öldürdüğünü iddia eden, elinde silah bulunan bir kadınla karşılaşır...", "beklenmeyen-misafir" },
                    { 6, new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(6680), "olumadası.png", true, false, true, new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(6690), "Ölüm Adası", 9425m, "Karayip güneşinin tadını çıkaran Miss Marple huzursuz günler geçirmektedir.\nEvet, sıcak hava romatizmalarına iyi gelmiştir ama bu cennet gibi yerde heyecandan eser yoktur.\nMiss Marple’ın otelin müşterilerinden emekli bir subayla tanışması tatiline renk katar. Emekli subayın, tanıdığı bir katilin öyküsünü anlatması Miss Marple’ın ilgisini çeker. Binbaşı tam katilin fotoğrafını göstermek üzereyken birdenbire vazgeçer. Adamın panik içindeki davranışlarını otelde katili görmüş olmasına yoran Marple, yanlış kişiye odaklanır. Ve bu cennet gibi adada peş peşe cinayetler işlenir...", "olum-adası" },
                    { 7, new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(6690), "saatleriayarlamaenstitusu.png", true, false, true, new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(6690), "Saatleri Ayarlama Enstitüsü", 16410m, "İmparatorluktan cumhuriyete geçiş döneminde Türkiye’nin yetiştirdiği en büyük şair ve yazarlardan olan Ahmet Hamdi Tanpınar’ın Saatleri Ayarlama Enstitüsü adlı eseri, modern Türk romanının kilometre taşları arasında yer alıyor. Yazarın büyük ses getiren Huzur adlı yapıtından sonra ikinci romanı olan Saatleri Ayarlama Enstitüsü, dönem Türkiye’sinin bir yansıması olarak günümüzde de edebi ve tarihi değerini koruyor.", "saatleri-ayarlama-enstitusu" },
                    { 8, new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(6690), "yaban.png", true, false, true, new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(6700), "Yaban", 9125m, "Romanda zaman aralığı olarak Birinci Dünya Savaşı’ndan Sakarya Meydan Muharebesi’nin sonuna kadar geçen süre seçiliyor.Yaban, söz konusu dönemde köylerin ve köylülerin durumunu ele alarak kurtuluş mücadelesine farklı bir perspektiften bakmaya olanak sağlıyor. Yazar bununla birlikte, yarattığı farklı statüdeki karakterlerle aydın-köylü çatışmasını da başarılı bir şekilde kurguya ekliyor.", "yaban" },
                    { 9, new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(6700), "atestengomlek.png", true, false, true, new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(6700), "Ateşten Gömlek", 11900m, "Türk edebiyatının önemli yazarlarından Halide Edip Adıvar, Kurtuluş Savaşı yıllarını Ateşten Gömlek ile günümüze taşıyor. Adıvar, Kurtuluş Savaşı mücadelesinde Mustafa Kemal Atatürk’ün yanında bizzat yer alıyor. Ateşten Gömlek, yazar tarafından tam da bu yıllarda kaleme alınmaya başlıyor. 1922 yılında ilk kez yayımlanan eser, Kurtuluş Savaşı’nı anlatan ilk roman olarak biliniyor. Eserde savaş yıllarında Anadolu’nun durumu tüm gerçekliğiyle yansıtılırken, kahramanların iç dünyasına da değiniliyor.", "atesten-gomlek" },
                    { 10, new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(6700), "buolumsuz.png", true, false, true, new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(6700), "Bu Ölümsüz", 12045m, "Nükleer savaş Dünya’yı neredeyse yerle bir etmiş, yalnızca dört milyon insan ve bundan çok daha fazla sayıda mutasyona uğramış canlı türü geride kalmıştır. Evrenin en güçlü uzaylı ırklarından biri olan Vegalılar için bu harabe gezegen artık turistik bir bölgeden farksızdır.", "bu-olumsuz" },
                    { 11, new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(6710), "hayvanciftligi.png", true, false, true, new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(6710), "Hayvan Çiftliği", 4380m, "Kurgusal bir dünya. Eşitlikten uzak bir düzen. Bir tarafta açgözlü, dik kafalı, hırslı insanlar. Diğer tarafta ise insanların anlayıştan uzak, kötücül yönetiminden usanmış, ezilen hayvanlar. İki tür arasındaki savaşın kıvılcımlandığı bir çiftlik. Bu çiftlikte bilinçlenip kendilerini geliştirerek tüm hayvanları insanların zorbalığından kurtarmayı amaçlayan bir hayvan topluluğu. Büyük bir iktidar savaşı.", "hayvan-ciftligi" },
                    { 12, new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(6710), "hayatiyenidenkesfedin.png", true, false, true, new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(6710), "Hayatı Yeniden Keşfedin", 14325m, "Sosyal hayatımızda sürekli insanlarla iletişim hâlindeyiz. İnsanlarla olan iletişim süreçlerimizi kontrol edelim, hayatın genel akışına ayak uyduralım, derken kendimizle baş başa kalmayı unutuyoruz. İçimizdeki sese kulak vermiyor ve kendi ihtiyaçlarımızı göz ardı ediyoruz. Bunların hepsi bir araya geldiğinde ise büyük bir mutsuzluk döngüsünde kalıyoruz. Jeffrey E. Young ve Janet Klosko, Hayatı Yeniden Keşfedin'de hayatınızı nasıl pozitif yönde ilerletebileceğinizden bahsediyor. ", "hayati-yeniden-kesfedin" },
                    { 13, new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(6720), "sinirlar.png", true, false, true, new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(6720), "Sınırlar", 12600m, "Siz de hayatın seyri içinde \"evet\" ve \"hayır\" demek için doğru zamanı bilemeyenlerden misiniz? Öyleyse Henry Cloud ve John Townsend'in Sınırlar kitabı, siz değerli okurlar için yol gösterici bir nitelik taşıyor. Hayatınızı kendi iradeniz doğrultusunda kontrol edebilmenizi sağlayacak bu kitabı keyifle okurken faydalı bilgiler öğreneceğinizi düşünüyoruz. ", "sinirlar" },
                    { 14, new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(6720), "kurkmantolumadonna.png", true, false, true, new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(6720), "Kürk Mantolu Madonna", 2040m, "İlk baskısı 1943 yılında yapılan Kürk Mantolu Madonna, günümüzde halen en çok ilgi gören ve satılan kitaplar arasında bulunuyor. Basıldığı günden bu yana 1 milyondan fazla satan kitap üzerine, birçok araştırma ve inceleme yapılmış, hakkında tezler yazılmış, fakat bu başarısının sırrı tam olarak çözülememiştir. Onu bu kadar özel kılan ve hala konuşuluyor olmasındaki en büyük pay, tabii ki Sabahattin Ali’nin usta kalemi ve başarılı ruh tahlilleridir.", "kurt-mantolu-madonna" },
                    { 15, new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(6730), "seninlebaslamadi.png", true, false, true, new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(6730), "Seninle Başlamadı", 10125m, "Kendinizi keşfedeceğiniz bir psikoloji kitabına hazır mısınız? Yaşadığınız sorunların, hissettiğiniz duyguların yalnızca kendinize ait olmadığını bilseydiniz ne düşünürdünüz? Geçmişin bugünü etkilediğini ve psikolojik problemleri tetiklediğini öne süren Mark Wolynn, psikolojiye farklı bir bakış açısıyla yaklaşmanızı sağlayacak. Üç nesil öncesine kadar ulaşan hikâyeniz, Seninle Başlamadı'yı okuduktan sonra yeniden şekillenecek. ", "seninle-baslamadi" },
                    { 16, new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(6730), "iyihissetmek.png", true, false, true, new DateTime(2024, 1, 23, 2, 19, 41, 843, DateTimeKind.Local).AddTicks(6730), "İyi Hissetmek", 15800m, "Psikiyatri ve davranış bilimleri alanında dünya genelinde adından en çok söz ettiren bilim insanlarından Dr. David D. Burns, İyi Hissetmek adlı kitabıyla okurlarına daha mutlu bir yaşamın kapılarını aralıyor. Kaygı, suçluluk ve özgüvensizlik gibi duyguların bireyin psikolojisi üzerindeki olumsuz tesirini aşmayı amaçlayan kitap, bilimsel olarak test edilmiş tekniklerle okurlarına eşsiz bir terapi sunuyor.", "iyi-hissetmek" }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 6, 1 },
                    { 1, 2 },
                    { 6, 2 },
                    { 1, 3 },
                    { 6, 3 },
                    { 2, 4 },
                    { 2, 5 },
                    { 2, 6 },
                    { 3, 7 },
                    { 3, 8 },
                    { 3, 9 },
                    { 4, 10 },
                    { 1, 11 },
                    { 4, 11 },
                    { 5, 12 },
                    { 5, 13 },
                    { 3, 14 },
                    { 6, 14 },
                    { 5, 15 },
                    { 6, 15 },
                    { 5, 16 },
                    { 6, 16 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_CategoryId",
                table: "ProductCategories",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
