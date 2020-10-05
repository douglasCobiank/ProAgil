﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NovoProjeto.API.Data;

namespace NovoProjeto.API.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("NovoProjeto.API.Model.Evento", b =>
                {
                    b.Property<int>("EventoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DataEvento");

                    b.Property<string>("Local");

                    b.Property<string>("Lote");

                    b.Property<int>("QtdPessoas");

                    b.Property<string>("Tema");
                    
                    b.Property<string>("ImagemURL");

                    b.HasKey("EventoId");

                    b.ToTable("Eventos");
                });
#pragma warning restore 612, 618
        }
    }
}
