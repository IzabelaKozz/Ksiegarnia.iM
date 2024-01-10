﻿// <auto-generated />
using System;
using Ksiegarnia.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ksiegarnia.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Ksiegarnia.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"), 1L, 1);

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CartId")
                        .HasColumnType("int");

                    b.Property<string>("CoverImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FavoriteId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookId");

                    b.HasIndex("CartId");

                    b.HasIndex("FavoriteId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            Author = "James Clear",
                            CoverImage = "1.jpg",
                            Description = "To książka, która pomoże Ci uświadomić sobie, jaki mechanizm stoi za tego typu zachowaniami. Jej lektura uświadomi również, jak odróżniać dobre zwyczaje od tych szkodliwych. Autor prezentuje tu oryginalną, lecz popartą naukowymi dowodami metodę kształtowania dobrych przyzwyczajeń i wyzbywania się złych. W oparciu o najnowsze zdobycze nauk kognitywnych i behawioralnych James Clear stworzył jeden z pierwszych (jak sam pisze) modeli ludzkiego zachowania, w którym nawyki wynikają zarówno z bodźców zewnętrznych, jak i z wewnętrznych emocji.",
                            Price = 29.99m,
                            Title = "Atomowe nawyki. Drobne zmiany, niezwykłe efekty"
                        },
                        new
                        {
                            BookId = 2,
                            Author = "Joanna Kuciel-Frydryszak",
                            CoverImage = "2.jpg",
                            Description = "To publikacja stanowiąca reportaż na temat życia wiejskich kobiet. Współczesny czytelnik może dzięki niemu zrozumieć, jak wiodło się jego babkom i prababkom oraz z jakimi problemami musiały się mierzyć. Książka przedstawia odbiorcy pracujące w pocie czoła gospodynie wiejskie, mamki, folwarczne wyrobnice, a także dziewczyny zatrudniające się w bogatszych gospodarstwach. Jak wynika z poszczególnych opowieści, ich największymi marzeniami były łóżka, wygodne buty czy edukacja. Każdej też zależało na posagu i dobrym wyjściu za mąż. Czytelnik zobaczy też, jak ogromnych wysiłków musiały dokonywać, by zapewnić wyżywienie całej swojej rodzinie. W publikacji pokazane zostają więc kobiety nieszanowane i wykorzystywane przez mężczyzn, nie tylko mężów, ale i ojców. Pomijane, podobnie jak ich potrzeby, dlatego też często niepotrafiące pisać ani czytać",
                            Price = 39.99m,
                            Title = "Chłopki. Opowieść o naszych babkach"
                        },
                        new
                        {
                            BookId = 3,
                            Author = "Anna Wolf",
                            CoverImage = "3.jpg",
                            Description = "Rose i Jason są sąsiadami, ale nie jest to dla nich powodem do radości. Wręcz przeciwnie: jeśli można powiedzieć, że cokolwiek ich łączy, to tylko wzajemna niechęć. Jason mieszka ze swoją babcią, Rose – z dziadkiem. Kiedy okazuje się, że starsi państwo bez ich wiedzy i zgody zaaranżowali Święta w gronie znajomych, młodzi muszą zakopać wojenny topór, ale czy na długo? Jedno jest pewne: to będzie najbardziej szalona i zaskakująca Gwiazdka w ich życiu.",
                            Price = 27.99m,
                            Title = "Święta po sąsiedzku"
                        },
                        new
                        {
                            BookId = 4,
                            Author = "Neal Shusterman",
                            CoverImage = "4.jpg",
                            Description = "Ekscytujący i przerażający świat Kosodomu jest pełen opowieści, które czekają na odkrycie. Od kiedy Thunderhead roztoczył opiekę nad ludzkością, do czasu gdy kosiarz Goddard próbował wywrócić wszystko do góry nogami, minęły całe wieki. Ludzie żyli bez głodu, chorób i śmierci, a kosiarze kontrolowali liczebność populacji. Pokłosie. Opowieści z Kosodomu to zbiór opowiadań osadzonych w uniwersum Żniw śmierci. Kolejne historie nie tylko rozwijają fabułę trylogii, lecz także wyjaśniają genezę niektórych zdarzeń. Pojawiają się również nowi kosiarze! Neal Shusterman wraz z Davidem Yoonem, Jarrodem Shustermanem, Sofíą Lapuente, Michaelem H. Payne'em, Michelle Knowlden i Joelle Shusterman zabiorą was z powrotem do niezwykłego świata Żniw śmierci.",
                            Price = 52.49m,
                            Title = "Pokłosie. Opowieści z Kosodomu. Żniwa śmierci. Tom 3.5"
                        },
                        new
                        {
                            BookId = 5,
                            Author = "Kristin Hannah",
                            CoverImage = "5.jpg",
                            Description = "Ta powieść jest protestem przeciwko wysyłaniu amerykańskich żołnierzy na misje pokojowe, które w rzeczywistości o wiele więcej mają wspólnego z polityką niż z utrwalaniem pokoju. Kosztem jest śmierć wielu młodych ludzi i cierpienie ich rodzin. Wielu weteranów powraca z misji ciężko okaleczonych zarówno fizycznie jak i psychicznie. Hannah opisuje proces żołnierza cierpiącego na PTSD - Zespół Stresu Pourazowego.Młody człowiek skrzywiony przez przeżycia w Iraku zostaje skazany na wieloletnie więzienie za zabójstwo żony, nie doczekawszy się wcześniej psychologicznej pomocy ze strony władz wojskowych. A Jolene, główna bohaterka powieści, pilotka zestrzelonego helikoptera, po amputacji nogi ma problemy z odnalezieniem się w życiu, dodatkowo obwiniając się o śmierć przyjaciółki oraz Smitty'ego, dwudziestoletniego strzelca pokładowego z załogi jej helikoptera.",
                            Price = 34.99m,
                            Title = "Na domowym froncie"
                        },
                        new
                        {
                            BookId = 6,
                            Author = "Susanna Isern & Rocio Bonilla ",
                            CoverImage = "6.jpg",
                            Description = "Co w życiu liczy się najbardziej? Na to pytanie odpowie dzieciom ta cudowna książeczka. To przepiękna propozycja dla najmłodszych ukazująca im, co naprawdę jest bezcenne. Lista tego, co w życiu jest najważniejsze, z pewnością okazałaby się bardzo długa. Ludzie mają różne wartości i na swój sposób postrzegają świat. Mimo to dobrze zastanowić się, czy na tej liście faktycznie znajduje się to, co powinno na niej być. Ta książka wyjaśni dzieciom, jak i również dorosłym, że w życiu są skarby piękniejsze niż rzeczy materialne.",
                            Price = 26.49m,
                            Title = "Wielka księga superskarbów. To, co naprawdę się liczy"
                        },
                        new
                        {
                            BookId = 7,
                            Author = "Aleksandra Mizielińska & Daniel Mizieliński  ",
                            CoverImage = "7.jpg",
                            Description = "Pozycja zawiera 51 ogromnych map, które ukazują piękno i różnorodność aż 42 krajów na 6 kontynentach. To niepowtarzalna okazja do zobaczenia gejzerów na Islandii, karawany na egipskiej pustyni, czy miasta Majów w Meksyku! Szczegóły, jakie mamy okazję poznać, pozwolą zatopić się w zupełnie innej kulturze i poznać jej różnorodność. Na co dzień trudno jest wyobrazić sobie, co dzieje się na drugim końcu ziemi. Tutaj jednak nie mamy tego problemu, gdyż wystarczy wybrać odpowiednią mapę i cieszyć się chwilą.",
                            Price = 42.99m,
                            Title = "Mapy. Obrazkowa podróż po lądach, morzach i kulturach świata. Edycja niebieska"
                        },
                        new
                        {
                            BookId = 8,
                            Author = "Marta Galewska-Kustra",
                            CoverImage = "8.jpg",
                            Description = "W tej części przygód Pucia i jego rodziny odwiedzamy razem z bohaterami restaurację Wesoła Marchewka. Dzieci są bardzo podekscytowane, przynajmniej do momentu, kiedy okazuje się, że makaron Pucia wygląda nie tak, jak w domu. Nie chce jeść, ale po chwili daje się namówić mamie i próbuje. Makaron jest smaczny! Pucio cieszy się, że spróbował. Po powrocie do domu cała rodzina angażuje się w przygotowywanie placuszków, które tata smaży potem na patelni. W książce znajduje się również przepis, dzięki któremu dzieci z pomocą rodziców będą mogły przygotować swoje własne placuszki.",
                            Price = 21.79m,
                            Title = "Pucio zostaje kucharzem, czyli o radości z jedzenia"
                        },
                        new
                        {
                            BookId = 9,
                            Author = "Jan Brzechwa",
                            CoverImage = "9.jpg",
                            Description = "Ciężko uwierzyć w to, że pierwsze wydanie Akademii Pana Kleksa datuje się na rok 1946! Do dzisiaj bowiem jest to jedna z najchętniej czytanych powieści dla dzieci, nie tylko z tego powodu, że jest omawiana w szkole jako lektura. To wspaniała, pełna przygód opowieść o Adasiu Niezgódce i niezwykłej Akademii.",
                            Price = 23.99m,
                            Title = "Akademia Pana Kleksa. Pan Kleks. Tom 1"
                        },
                        new
                        {
                            BookId = 10,
                            Author = "Irena Mąsior Mili0nerka",
                            CoverImage = "10.jpg",
                            Description = "Książeczka skierowana jest do młodszych dzieci, a dzięki pięknym, barwnym ilustracjom z pewnością na dłużej zatrzyma uwagę nawet najbardziej niecierpliwego maluszka. Pokaźna ilość treści powoduje z kolei, że książeczka idealnie nadaje się np. do czytania przed snem. Poza ciekawą historią niesie też ze sobą sporą dawkę wiedzy o otaczającym nas świecie.",
                            Price = 34.99m,
                            Title = "Świat Poli. Pytaj do woli"
                        },
                        new
                        {
                            BookId = 11,
                            Author = "Bonnie Garmus",
                            CoverImage = "11.jpg",
                            Description = "iteracki debiut, obok którego nie można przejść obojętnie! Książka jest pełną humoru opowieścią o poważnych problemach kobiet w latach 50. XX wieku, kiedy to świat był opanowany przez mężczyzn. Bonnie Garmus napisała niezwykle śmieszną historię, która porusza ważny temat równouprawnienia płci. Książka jest znakomitą zachętą do rozpoczęcia dyskusji na temat status quo. Chociaż zagadnienie jest poważne, zostało przedstawione w sposób swobodny i humorystyczny, a charyzmatyczna Elizabeth Zott stanowi ikonę feminizmu.",
                            Price = 33.00m,
                            Title = "Lekcje chemii"
                        },
                        new
                        {
                            BookId = 12,
                            Author = "Natalia de Barbaro",
                            CoverImage = "12.jpg",
                            Description = "Życie przynosi wiele nieoczekiwanych sytuacji i zrządzeń losu. Ani się obejrzysz, a okazuje się, że nie wiesz, jak się tu znalazłaś. Nie rozpoznajesz tego życia ani... samej siebie. Powrót do własnego ja, do prawdziwej siebie nie jest łatwy, a droga jest zazwyczaj wyboista. Ta książka została napisana właśnie po to, aby wesprzeć Cię w tej trudnej podróży. Autorka razem z czytelniczkami przebywa tę drogę, nadając książce bardzo osobisty charakter. Uczy, w jaki sposób odróżnić swoje prawdziwe potrzeby i pragnienia od poczucia obowiązku, pomaga wyzwolić się z toksycznych schematów i relacji. Ta książka da Ci realną siłę i sprawi, że inaczej spojrzysz na swoje życie. Książka będzie towarzyszyć Ci w podróży w głąb siebie i pomoże odnaleźć w sobie kobiecą mądrość.",
                            Price = 27.99m,
                            Title = "Czuła przewodniczka. Kobieca droga do siebie"
                        },
                        new
                        {
                            BookId = 13,
                            Author = "George Samuel Clason",
                            CoverImage = "13.jpg",
                            Description = "Książka szybko zyskała sławę jako jeden z najlepszych i najpraktyczniejszych poradników finansowych. Napisany z wielkim poczuciem humoru poradnik zawiera uniwersalne wskazówki, które sprawdzają się od tysięcy lat. Babilończycy wiedzieli, jak prowadzić swoje finanse, a ich mądrość w tym zakresie znajduje zastosowanie również we współczesnym świecie. Czytelnicy nie znajdą tutaj doraźnych wskazówek, lecz ogólne sposoby na to, aby stały dochód przekuł się w oszczędności i niwelację finansowych zobowiązań. Przypowieści osadzone w realiach starożytnego Babilonu działają na wyobraźnię i można je przenieść do dowolnej epoki, znajdując sposób na rozwiązanie swoich kłopotów finansowych.",
                            Price = 33.39m,
                            Title = "Najbogatszy człowiek w Babilonie"
                        },
                        new
                        {
                            BookId = 14,
                            Author = "Maria Zagnińska",
                            CoverImage = "14.jpg",
                            Description = "To ciekawa i praktyczna książeczka wspierająca naukę i ćwiczenie pisania literek dla dzieci, które właśnie zaczynają swoją edukacyjną przygodę! ozycja przede wszystkim przeznaczona została dla tych dzieci, które poznają świat liter i słów i zaczynają się go uczyć. Przy każdej z literek zamieszczony został wyraźny jej wzór, dodatkowo z przydatnymi strzałkami pokazującymi, jak zacząć pisać je prawidłowo. To znacznie ułatwia pracę dziecka i pomaga mu zrozumieć zasady, jakie obowiązują przy pisaniu. Ponadto przy niektórych symbolach znaleźć możemy barwne rysunki przedstawiające zwierzę, osobę lub rzecz, których nazwa rozpoczyna się na daną literę, natomiast przy innych można zatrzymać się na dłużej dzięki kolorowance czy ciekawym labiryncie.",
                            Price = 9.99m,
                            Title = "Moje pierwsze literki"
                        });
                });

            modelBuilder.Entity("Ksiegarnia.Models.Cart", b =>
                {
                    b.Property<int>("CartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CartId"), 1L, 1);

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("CartId");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("Ksiegarnia.Models.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int?>("CartId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.ToTable("CartItem");
                });

            modelBuilder.Entity("Ksiegarnia.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Ksiegarnia.Models.Favorite", b =>
                {
                    b.Property<int>("FavoriteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FavoriteId"), 1L, 1);

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("FavoriteId");

                    b.HasIndex("BookId");

                    b.HasIndex("UserId");

                    b.ToTable("Favorites");
                });

            modelBuilder.Entity("Ksiegarnia.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"), 1L, 1);

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Ksiegarnia.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Ksiegarnia.Models.Book", b =>
                {
                    b.HasOne("Ksiegarnia.Models.Cart", null)
                        .WithMany("Books")
                        .HasForeignKey("CartId");

                    b.HasOne("Ksiegarnia.Models.Favorite", null)
                        .WithMany("Books")
                        .HasForeignKey("FavoriteId");
                });

            modelBuilder.Entity("Ksiegarnia.Models.CartItem", b =>
                {
                    b.HasOne("Ksiegarnia.Models.Cart", null)
                        .WithMany("Items")
                        .HasForeignKey("CartId");
                });

            modelBuilder.Entity("Ksiegarnia.Models.Favorite", b =>
                {
                    b.HasOne("Ksiegarnia.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ksiegarnia.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Ksiegarnia.Models.Cart", b =>
                {
                    b.Navigation("Books");

                    b.Navigation("Items");
                });

            modelBuilder.Entity("Ksiegarnia.Models.Favorite", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
