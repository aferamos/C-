using System;
using System.Data.Entity;
using System.Globalization;
using BarberShop.DoMain;
using BarberShop.Entity.Mappings;

namespace BarberShop.Entity.DataContexts
{
    public class BarberShopDataContext : DbContext
    {
        public BarberShopDataContext()
            : base("BarberShopConnectionString")
        {
            Database.SetInitializer<BarberShopDataContext>( new BarberShopDataContextInitializer());
            //Configuration.LazyLoadingEnabled = false;
            //Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Agenda> Agenda { get; set; }
        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Cargo> Cargo { get; set; }
        
        //public DbSet<PessoaFisica> PessoaFisicas { get; set; }
        //public DbSet<PessoaJuridica> PessoaJuridicas { get; set; }
        /*
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AgendaMap());
            modelBuilder.Configurations.Add(new PessoaMap());
            modelBuilder.Configurations.Add(new PessoaFisicaMap());
            modelBuilder.Configurations.Add(new PessoaJuridicaMap());
            base.OnModelCreating(modelBuilder);
        }*/
    }
    //DropCreateDatabaseIfModelChanges cria e atualiza
    public class BarberShopDataContextInitializer : DropCreateDatabaseIfModelChanges<BarberShopDataContext>
    {
        protected override void Seed(BarberShopDataContext context)
        {
            //BarberShopDataContextInitializer data = new BarberShopDataContextInitializer(); 
            var dtinicio = DateTime.Parse("02/09/2019");
            var dtfim = DateTime.Parse("03/09/2019");
            var parse = TimeSpan.Parse("01:00");
            CultureInfo info = new CultureInfo("pt-BR");
            DateTimeFormatInfo dtfInfo = info.DateTimeFormat;
            int i = 0;
            while (dtinicio <= dtfim)
            {
                while (parse < TimeSpan.Parse("23:59"))
                {
                    i = i + 1;
                    context.Agenda.Add( new Agenda { Id = i, Data = dtinicio, Dia = dtinicio.Day, Ano = dtinicio.Year , Mes = dtinicio.Month,
                                                      Mes_Nome = dtinicio.ToString("MMMM"), Dia_Da_Semana_Nome = dtfInfo.GetDayName(dtinicio.DayOfWeek),
                                                      Dia_Do_Ano = dtinicio.DayOfYear, Data_Por_Extenso = dtfInfo.GetDayName(dtinicio.DayOfWeek) + ", dia " + dtinicio.Day + " de " + dtinicio.ToString("MMMM") + " de " + dtinicio.Year,
                                                      Dia_Util = Dia_Util(dtinicio.Day, dtinicio.Month), Ag_Horario = parse.ToString().Substring(0, 5)
                    });                    
                    parse = parse.Add(TimeSpan.FromMinutes(5));
                }
                context.SaveChanges();
                //context.Dispose();
                dtinicio = dtinicio.AddDays(1);
                parse = TimeSpan.Parse("01:00");
            }

            //context.PessoaFisicas.Add(new PessoaFisica { Id = 1, Cpf ="09254526703",
            //                                               DtNascimento = DateTime.Parse("02/09/2019"),
            //                                               Rg = "131850265" });
            context.Cargo.Add( new Cargo { Descricao = "Adminstrador"});
            context.Cargo.Add(new Cargo { Descricao = "Barbeiro" });
            context.SaveChanges();
            context.Pessoa.Add( new Pessoa {
                Id = 1,
                Nome = "Alessandro Ferreira Ramos",
                Email = "aferaramos@gmail.com",
                Sexo = "M",
                TipoPessoa = true,
                Acesso = "A",
                Status = "A",
                Rg = "131850265",
                Cpf = "09254526",
                Usuario = "ramos",
                DtCadastro = DateTime.Now
            });
            context.SaveChanges();

            context.Usuario.Add(new Usuario {
                id = 1,
                Descricao = "aramos",
                Senha = "1980",
                DtCadastro = DateTime.Now,
                Dtvalidade = DateTime.Now.AddYears(1)

            });

            context.Funcionario.Add(new Funcionario {
                Id = 1,
                UsuarioId = 1,
                Acesso = "A",
                Status = "A",
                Cpf = "09254526",
                Nome = "Alessandro",
                DtCadastro = DateTime.Now,
                Email = "aferaramos@gmail.com",
                CargoId = 2
            });
            //context.PessoaJuridicas.Add(new PessoaJuridica { Id = 2,
            //                                                   Cnpj = "12345678900",
            //                                                   Insc_Estadual = "Suporte TI",
            //                                                   Razao_Social = "Ramos TI"});
            /*context.Pessoas.Add(new Pessoa {
                Id = 2,
                Nome = "Alessandro",
                Email = "aferaramos@gmail.com",
                Sexo = "M",
                PessoaFisicaId = 1,
                Acesso = "A",
                Status = "A",
                Usuario = "ramos",
                DtCadastro = DateTime.Now
            });
            context.SaveChanges();

            //context.PessoaJuridicas.Add(new PessoaJuridica
           // {
           //     Id = 3,
           //     Cnpj = "12345678900",
           //     Insc_Estadual = "Suporte TI",
           //     Razao_Social = "Ramos TI"
          ///  });
            context.Pessoas.Add(new Pessoa
            {
                Id = 3,
                Nome = "Alessandro",
                Email = "aferaramos@gmail.com",
                Sexo = "M",
                Acesso = "A",
                Status = "A",
                //PessoaFisicaId = 1,
                Usuario = "ramos",
                DtCadastro = DateTime.Now
            });
            context.SaveChanges();
            */
            base.Seed(context);            
        }
        int Dia_Util(int Day, int Month)
        {
            int input;
            switch (Day)
            {
                case 1 when Month == 1: //-- confraternização universal
                    input = 0;
                    break;
                case 21 when Month == 4: //-- tiradentes
                    input = 0;
                    break;
                case 1 when Month == 5: //-- trabalho
                    input = 0;
                    break;
                case 7 when Month == 9: //-- independência
                    input = 0;
                    break;
                case 12 when Month == 10: //-- nossa sra. aparecida
                    input = 0;
                    break;
                case 2 when Month == 11: //-- finados
                    input = 0;
                    break;
                case 15 when Month == 11: //-- proclamação da república
                    input = 0;
                    break;
                case 25 when Month == 12: // Natal
                    input = 0;
                    break;
                default:
                    input = 1;
                    break;
            }
            return input;
        }
    }
}
