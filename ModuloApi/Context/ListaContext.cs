using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ModuloApi.Entities;

namespace ModuloApi.Context
{
    public class ListaContext : DbContext
    {
        public ListaContext(DbContextOptions<ListaContext> options): base(options){

        }
        public DbSet<Contato> Contatos{get; set;}
    }
}