﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TicketFlow.Shared.Messaging.Deduplication.Data;

#nullable disable

namespace TicketFlow.Services.Tickets.Core.Data.Migrations.Deduplication
{
    [DbContext(typeof(DeduplicationDbContext))]
    partial class DeduplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("deduplication")
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("TicketFlow.Shared.Messaging.Deduplication.Data.DeduplicationEntry", b =>
                {
                    b.Property<string>("MessageId")
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("ProcessedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("MessageId");

                    b.ToTable("DeduplicationEntries", "deduplication");
                });
#pragma warning restore 612, 618
        }
    }
}
