﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using NetCoreSample.Models;

namespace NetCoreSample.Migrations
{
    [DbContext(typeof(NetCoreSampleContext))]
    partial class NetCoreSampleContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NetCoreSample.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Password");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Users");
                });
        }
    }
}
