using Clientes.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clientes.Data.Context;

public class ClientesContext : DbContext
{
    public ClientesContext(DbContextOptions<ClientesContext> options) : base(options) { }

    public DbSet<Cliente> Clientes { get; set; }
}
