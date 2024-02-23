﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcMovie.Data;

#nullable disable

namespace MVCMovie.Migrations
{
    [DbContext(typeof(MvcMovieContext))]
    [Migration("20240223195747_ALterDatabase")]
    partial class ALterDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.16");

            modelBuilder.Entity("ArtistMovie", b =>
                {
                    b.Property<int>("ArtistsArtistId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MoviesId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ArtistsArtistId", "MoviesId");

                    b.HasIndex("MoviesId");

                    b.ToTable("ArtistMovie");
                });

            modelBuilder.Entity("MvcMovie.Models.Artist", b =>
                {
                    b.Property<int>("ArtistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Site")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ArtistId");

                    b.ToTable("Artist");
                });

            modelBuilder.Entity("MvcMovie.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Genre")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("TEXT");

                    b.Property<int?>("StudioId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("StudioId");

                    b.ToTable("Movie");
                });

            modelBuilder.Entity("MvcMovie.Models.Studio", b =>
                {
                    b.Property<int>("StudioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("StudioId");

                    b.ToTable("Studio");
                });

            modelBuilder.Entity("MvcMovie.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PassWord")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("UserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("ArtistMovie", b =>
                {
                    b.HasOne("MvcMovie.Models.Artist", null)
                        .WithMany()
                        .HasForeignKey("ArtistsArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MvcMovie.Models.Movie", null)
                        .WithMany()
                        .HasForeignKey("MoviesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MvcMovie.Models.Movie", b =>
                {
                    b.HasOne("MvcMovie.Models.Studio", "Studio")
                        .WithMany("Movies")
                        .HasForeignKey("StudioId");

                    b.Navigation("Studio");
                });

            modelBuilder.Entity("MvcMovie.Models.Studio", b =>
                {
                    b.Navigation("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}
