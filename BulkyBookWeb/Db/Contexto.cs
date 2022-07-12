using BulkyBookWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyBookWeb.Db
{
    //DbContext é responsável por abrir conexão de nossa aplicação com o banco de dados
    public class Contexto : DbContext
    {
        //Essa é uma configuração geral para usar o contexto de banco de dados
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }

        //DbSet faz as operações no banco de dados, criar, ler, atualizar e excluir
        public DbSet<Categoria> Categorias { get; set; }
    }
}
