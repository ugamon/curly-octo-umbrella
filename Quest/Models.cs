using Microsoft.EntityFrameworkCore;



namespace Game.Model {

    class GameDbContext: DbContext {
        public DbSet<HeroClassModel> HeroClasses {get; set;}
        public DbSet<HeroAttribute> HeroAttributes {get; set;}
        public string DbPath { get; }
        public GameDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "gaming.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
        }


    class HeroClassModel {
        public int HeroClassModelId {get; set;}

        public string? HeroClassName {get; set;}

        public int HeroAttributeId {get; set;}

        public HeroAttribute HeroAttribute{get; set;}
    }


    class HeroAttribute {
        public int HeroAttributeId {get; set;}
        public double Hp {get; set;}
        public double Mana {get; set;}
        public double Exp {get; set;}
        public double? Dex {get; set;}
        public double? Str {get; set;}

        public List<HeroClassModel> HeroClassModels { get; } = new();

        public override string ToString()
        {
            return $"HP: {this.Hp}, Mana: {this.Mana}, Exp: {this.Exp}";
        }

    }

};
