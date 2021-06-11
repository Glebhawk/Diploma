using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SpacecraftData.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpacecraftSite.SpacecraftData
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
            //Country USSR = new Country { Name = "СРСР" };
            //Country USA = new Country { Name = "США" };
            //Countries.Add(USSR);
            //Countries.Add(USA);
            //Rocket Sputnik = new Rocket
            //{
            //    Name = "Супутник (8К71ПС)",
            //    Country = USSR,
            //    Mass = 267,
            //    Height = 29.167,
            //    Manufacturer = "ОКБ-1",
            //    Stages = new List<Stage>
            //            {
            //                new Stage {Number = 1, Name = "Блоки Б, В, Г, Д", Engines = "4 РД-107", Fuel = "Гас і рідкий кисень"},
            //                new Stage {Number = 1, Name = "Блок А", Engines = "РД-108", Fuel = "Гас і рідкий кисень"}
            //            }
            //};
            //Rocket Vanguard = new Rocket
            //{
            //    Name = "Авангард",
            //    Country = USA,
            //    Mass = 10.05,
            //    Height = 21.9,
            //    Manufacturer = "Glenn L. Martin Company",
            //    Stages = new List<Stage>
            //            {
            //                new Stage {Number = 1, Name = "Авангард", Engines = "X-405", Fuel = "Гас і рідкий кисень"},
            //                new Stage {Number = 1, Name = "Дельта", Engines = "AJ10-37", Fuel = "НДМГ і азотна кислота"},
            //                new Stage {Number = 1, Name = "Авангард 3", Engines = "33KS2800", Fuel = "Тверде"}
            //            }
            //};
            //Rockets.Add(Sputnik);
            //Rockets.Add(Vanguard);
            //SaveChanges();
            //Launches.Add(
            //    new Launch
            //    {
            //        LaunchDate = new DateTime(1957, 10, 4),
            //        Success = true,
            //        LaunchSite = "Байконур",
            //        Rocket = Sputnik,
            //        Payload = new List<Spacecraft> { new Spacecraft
            //        {
            //            Name = "Супутник-1 (ПС-1)",
            //            NSSDC = "1957-001B",
            //            Country = USSR,
            //            Type = "Технологія",
            //            Operator = "СРСР",
            //            Mass = 83.6,
            //            Configuration = "Відполірована алюмінієва сфера діаметром 58 см, заповнена азотом під тиском 1.3 атмосфери. 4 антени, 2 довжиною 2.4 м, 2 довжиною 2.9 м.",
            //            Equipment = "2 радіостанції, передавання на частотах 20.005 і 40.002 МГц. 4 антенни. Батареї массою близько 50 кг.",
            //            Mission = "Основні завдання: дослідження проходження радіохвиль через іоносферу, " +
            //            "дослідження щільності верхніх шарів атмосфери шляхом спостереження за змінами траекторії супутника, дослідження умов роботи апаратури." +
            //            "\n\nВ п'ятницю, 4 жовтня, в 22:28:34 за московським часом (19:28:34 за Гринвічем) здійснено успішний запуск. " +
            //            "Через 295 секунд після старту супутник і центральний блок (II ступінь) ракети массою 7.5 тонн були виведені на еліптичну орбіту висотою " +
            //            "в апоцентрі 947 км, і перицентрі 288 км. Два радіопередавачі почергово передавали короткі сигнали з періодом 0.3 с. На борту були присутні " +
            //            "термореле і барореле, що змінювали частоту імпульсів при виході температури з діапазону 0-50 °С або падінні тиску менше 250 мм рт. ст. " +
            //            "Під час польоту температура і тиск залишалися в межах норми. Радіопередавачі працювали 21 день, всього супутник провів на орбіті 92 дні."
            //        } }
            //    });
            //Launches.Add(
            //    new Launch
            //    {
            //        LaunchDate = new DateTime(1957, 11, 3),
            //        Success = true,
            //        LaunchSite = "Байконур",
            //        Rocket = Sputnik,
            //        Payload = new List<Spacecraft> { new Spacecraft
            //        {
            //            Name = "Супутник-2 (ПС-2)",
            //            NSSDC = "1957-002A",
            //            Country = USSR,
            //            Type = "Біологічні дослідження",
            //            Operator = "СРСР",
            //            Mass = 508.3,
            //            Configuration = "Чотириметрова висока конусоподібна капсула з діаметром основи 2 метри. Супутник не відділявся від другого ступеня ракети.",
            //            Equipment = "Детектори рентгенівських і ультрафіолетових променів, радіопередавачі, алюмінієва циліндрична кабіна з собакою діаметром 64 см " +
            //            "і довжиною 80 см, система життезабезпечення і моніторингу життевих показників.",
            //            Mission = "Основні завдання: дослідження впливу невагомості на живий організм, вимірювання радіаційного фону і космічного випромінювання " +
            //            "в навколоземному просторі." +
            //            "\n\nСупутник був успішно запущений 3 листопада 1957 року і вийшов на орбіту 212 на 1660 км з нахилом 65.3°. " +
            //            "Супутник передавав дані про частоту дихання, артеріальний тиск, електрокардіограму і актограму (запис рухів собаки). " +
            //            "Їжа і вода подавалися у формі желе. Запас їжі і кисню був розрахований на 7 днів. Відходи збиралися в спеціальний мішок. " +
            //            "Через несправність системи терморегуляції темпрература в кабіні швидко досягла 40° і собака загинула від перегріву через 5-7 годин польоту. " +
            //            "Систем повернення з орбіти ще не було, і супутник провів на орбіті 162 дні. "
            //        } }
            //    });
            //Launches.Add(
            //    new Launch
            //    {
            //        LaunchDate = new DateTime(1957, 12, 6),
            //        Success = false,
            //        LaunchSite = "Мис Канаверал",
            //        Rocket = Vanguard,
            //        Payload = new List<Spacecraft> { new Spacecraft
            //        {
            //            Name = "Авангард TV3",
            //            NSSDC = "VAGT3",
            //            Country = USA,
            //            Type = "Технологія",
            //            Operator = "Лабораторія військово-морських сил США (Naval Research Laboratory)",
            //            Mass = 1.36,
            //            Configuration = "Алюмінієва сфера діаметром 16.3 см з шістьома антеннами.",
            //            Equipment = "Радіостанція з частотою передавання 108 МГц на внутрішній батареї. Радіостанція з частотою передавання 108.03 МГц на 6 сонячних панелях. 6 антенн. 2 терморезистори.",
            //            Mission = "Основні завдання: відпрацювання технологій запуску і випробування термічного захисту." +
            //            "\n\n6 грудня 1957 року під час запуску на мисі Канаверал через дві секунди після відриву, піднявшись на 1,2 м, ракета втратила тягу " +
            //            "і впала на стартовий майданчик. Паливні баки розірвались і вибухнули, знищивши ракету-носій і частково пошкодивши стартовий майданчик. " +
            //            "Супутник залишився цілим і приземлився недалеко, а його передавачі продовжували передавати сигнал радіомаяка. Однак супутник було пошкоджено " +
            //            "і неможливо використати повторно. Нині він виставлений в Національному музеї авіації і космонавтики Смітсонського інституту. " +
            //            "Зовнішній вигляд змінили, щоб показати, яким його знайшли на стартовому майданчику. " +
            //            "\n\nТочну причину аварії не встановлено, загальноприйняте пояснення — низький тиск у паливному баку до початку нагнітання палива " +
            //            "турбонасосом через витік з інжектора спричинив загорання в паливній системі під час запуску. " +
            //            "\n\nКатастрофу TV3 спостерігали багато репортерів, що були запрошені для заспокоєння суспільства после запусків радянських Супутника-1 " +
            //            "і Супутника-2. Катастрофа призвела до подальшого розгортання подій, що увійшли в історію як Супутникова криза. " +
            //            "Американські газети в новинах і заголовках обігрували назву перших радянських супутників, і називали американський апарат «Flopnik» " +
            //            "(від англ. to flop, провал), «Kaputnik», «Oopsnik» (від англ. oops, ой, отакої) і «Stayputnik» (від англ. to stay, стояти)."
            //        } }
            //    });
            //SaveChanges();
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Spacecraft> Spacecrafts { get; set; }
        public DbSet<Launch> Launches { get; set; }
        public DbSet<Rocket> Rockets { get; set; }
        public DbSet<Stage> Stages { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Spacecraft>().Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Entity<Country>().Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Entity<Launch>().Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Entity<Rocket>().Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Entity<Stage>().Property(e => e.Id).ValueGeneratedOnAdd();
        }
    }
}
