using Infra.Entidades;
using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace Infra
{
    public class Contexto : DbContext
    {
        private NpgsqlConnectionStringBuilder Conn = new NpgsqlConnectionStringBuilder();

        private NpgsqlConnectionStringBuilder RetornaConexao()
        {
            NpgsqlConnectionStringBuilder sqlBuilder = new NpgsqlConnectionStringBuilder();
            sqlBuilder = new NpgsqlConnectionStringBuilder
            {
                Host = "127.0.0.1",
                Database = "GdProcesso",
                Username = "postgres",
                Password = "discovoador",
                Pooling = false,
                ConvertInfinityDateTime = true,


            };

            return sqlBuilder;
        }

        public Contexto()
           : base()
        {
            Conn = RetornaConexao();

        }

        #region DBSET

        public DbSet<Processo> Processo { get; set; }
        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<Estado> Estado { get; set; }

        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.EnableSensitiveDataLogging(true);
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseNpgsql(Conn.ConnectionString);
        }
      

    }
}
