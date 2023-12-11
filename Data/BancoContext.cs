﻿using Microsoft.EntityFrameworkCore;
using StudioSintoniaPreview.Models;

namespace StudioSintoniaPreview.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {

        }
        public DbSet<ContatoModel> Contatos { get; set; }
    }
}
