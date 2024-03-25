using Microsoft.EntityFrameworkCore;
using TarefaApi.Models;

namespace TarefaApi.Context
{
    public class OrganizadorContext : DbContext
    {
        public OrganizadorContext(DbContextOptions<OrganizadorContext> options) : base(options) { 
        }

        public DbSet<Tarefa> Tarefas { get; set; }
    }
}
