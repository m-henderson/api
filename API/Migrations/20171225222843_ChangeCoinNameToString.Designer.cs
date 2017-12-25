﻿// <auto-generated />
using API.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace API.Migrations
{
    [DbContext(typeof(MentorientDbContext))]
    [Migration("20171225222843_ChangeCoinNameToString")]
    partial class ChangeCoinNameToString
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("API.Models.Coin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ForumId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("ForumId");

                    b.ToTable("Coins");
                });

            modelBuilder.Entity("API.Models.Forum", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Forums");
                });

            modelBuilder.Entity("API.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Body");

                    b.Property<int?>("CoinId");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("CoinId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("API.Models.Coin", b =>
                {
                    b.HasOne("API.Models.Forum", "Forum")
                        .WithMany("Coins")
                        .HasForeignKey("ForumId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("API.Models.Post", b =>
                {
                    b.HasOne("API.Models.Coin")
                        .WithMany("Posts")
                        .HasForeignKey("CoinId");
                });
#pragma warning restore 612, 618
        }
    }
}