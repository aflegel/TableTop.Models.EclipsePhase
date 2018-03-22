﻿// <auto-generated />
using System;
using EclipsePhase.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;

namespace EclipsePhase.Migrations
{
    [DbContext(typeof(EclipsePhaseCharacterBuilderContext))]
    partial class EclipsePhaseCharacterBuilderContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-preview1-28290")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EclipsePhase.Models.Aptitude", b =>
                {
                    b.Property<int>("AptitudeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("aptitudeId");

                    b.Property<string>("Abbreviation")
                        .IsRequired()
                        .HasColumnName("abbreviation")
                        .HasMaxLength(3);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(100);

                    b.HasKey("AptitudeId");

                    b.ToTable("Aptitude");
                });

            modelBuilder.Entity("EclipsePhase.Models.Background", b =>
                {
                    b.Property<int>("BackgroundId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("backgroundId");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(3);

                    b.HasKey("BackgroundId");

                    b.ToTable("Background");
                });

            modelBuilder.Entity("EclipsePhase.Models.BackgroundBonusMalus", b =>
                {
                    b.Property<int>("BackgroundId")
                        .HasColumnName("backgroundId");

                    b.Property<int>("BonusMalusId")
                        .HasColumnName("bonusMalusId");

                    b.Property<string>("Background")
                        .IsRequired()
                        .HasColumnName("background")
                        .HasMaxLength(100);

                    b.Property<string>("BonusMalus")
                        .IsRequired()
                        .HasColumnName("bonusMalus")
                        .HasMaxLength(100);

                    b.Property<short>("Occurrence")
                        .HasColumnName("occurrence");

                    b.HasKey("BackgroundId", "BonusMalusId");

                    b.ToTable("BackgroundBonusMalus");
                });

            modelBuilder.Entity("EclipsePhase.Models.BackgroundTrait", b =>
                {
                    b.Property<int>("BackgroundId")
                        .HasColumnName("backgroundId");

                    b.Property<int>("TraitId")
                        .HasColumnName("traitId");

                    b.Property<string>("Background")
                        .IsRequired()
                        .HasColumnName("background")
                        .HasMaxLength(100);

                    b.Property<string>("Trait")
                        .IsRequired()
                        .HasColumnName("trait")
                        .HasMaxLength(100);

                    b.HasKey("BackgroundId", "TraitId");

                    b.ToTable("BackgroundTrait");
                });

            modelBuilder.Entity("EclipsePhase.Models.BonusMalus", b =>
                {
                    b.Property<int>("BonusMalusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("bonusMalusId");

                    b.Property<string>("Desc")
                        .IsRequired()
                        .HasColumnName("desc");

                    b.Property<string>("MultiOccur")
                        .IsRequired()
                        .HasColumnName("multiOccur")
                        .HasMaxLength(20);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(100);

                    b.Property<string>("OnCost")
                        .IsRequired()
                        .HasColumnName("onCost")
                        .HasMaxLength(20);

                    b.Property<string>("Target")
                        .IsRequired()
                        .HasColumnName("target")
                        .HasMaxLength(60);

                    b.Property<string>("TragetForCh")
                        .IsRequired()
                        .HasColumnName("tragetForCh")
                        .HasMaxLength(20);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnName("type")
                        .HasMaxLength(3);

                    b.Property<string>("TypeTarget")
                        .IsRequired()
                        .HasColumnName("typeTarget")
                        .HasMaxLength(20);

                    b.Property<float>("Value")
                        .HasColumnName("value");

                    b.HasKey("BonusMalusId");

                    b.ToTable("BonusMalus");
                });

            modelBuilder.Entity("EclipsePhase.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("bookId");

                    b.Property<string>("Book1")
                        .IsRequired()
                        .HasColumnName("book")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(100);

                    b.HasKey("BookId");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("EclipsePhase.Models.Gear", b =>
                {
                    b.Property<int>("GearId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("gearId");

                    b.Property<short>("ArmorEnergy")
                        .HasColumnName("armorEnergy");

                    b.Property<short>("ArmorKinetic")
                        .HasColumnName("armorKinetic");

                    b.Property<short>("ArmorPene")
                        .HasColumnName("armorPene");

                    b.Property<short>("Cost")
                        .HasColumnName("cost");

                    b.Property<string>("Degat")
                        .IsRequired()
                        .HasColumnName("degat")
                        .HasMaxLength(30);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnName("description");

                    b.Property<string>("JustFor")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(100);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnName("type")
                        .HasMaxLength(3);

                    b.Property<string>("Unique")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("unique")
                        .HasDefaultValueSql("(N'Y')")
                        .HasMaxLength(1);

                    b.HasKey("GearId");

                    b.ToTable("Gear");
                });

            modelBuilder.Entity("EclipsePhase.Models.GearBonusMalus", b =>
                {
                    b.Property<int>("BonusMalusId")
                        .HasColumnName("bonusMalusId");

                    b.Property<int>("GearId")
                        .HasColumnName("gearId");

                    b.Property<string>("BonusMalus")
                        .IsRequired()
                        .HasColumnName("bonusMalus")
                        .HasMaxLength(100);

                    b.Property<string>("Gear")
                        .IsRequired()
                        .HasColumnName("gear")
                        .HasMaxLength(100);

                    b.Property<short>("Occur")
                        .HasColumnName("occur");

                    b.HasKey("BonusMalusId", "GearId");

                    b.ToTable("GearBonusMalus");
                });

            modelBuilder.Entity("EclipsePhase.Models.Info", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnName("id")
                        .HasMaxLength(100);

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnName("data");

                    b.HasKey("Id");

                    b.ToTable("Info");
                });

            modelBuilder.Entity("EclipsePhase.Models.Morph", b =>
                {
                    b.Property<int>("MorphId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("morphId");

                    b.Property<short>("Age")
                        .HasColumnName("age");

                    b.Property<short>("CpCost")
                        .HasColumnName("cpCost");

                    b.Property<string>("CreditCost")
                        .IsRequired()
                        .HasColumnName("creditCost")
                        .HasMaxLength(100);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnName("description");

                    b.Property<short>("Durablility")
                        .HasColumnName("durablility");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnName("gender")
                        .HasMaxLength(1);

                    b.Property<short>("MaxApptitude")
                        .HasColumnName("maxApptitude");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(100);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnName("type")
                        .HasMaxLength(20);

                    b.HasKey("MorphId");

                    b.ToTable("Morph");
                });

            modelBuilder.Entity("EclipsePhase.Models.MorphBonusMalus", b =>
                {
                    b.Property<int>("BonusMalusId")
                        .HasColumnName("bonusMalusId");

                    b.Property<int>("MorphId")
                        .HasColumnName("morphId");

                    b.Property<string>("BonusMalus")
                        .IsRequired()
                        .HasColumnName("bonusMalus")
                        .HasMaxLength(100);

                    b.Property<string>("Morph")
                        .IsRequired()
                        .HasColumnName("morph")
                        .HasMaxLength(100);

                    b.Property<short>("Occur")
                        .HasColumnName("occur");

                    b.HasKey("BonusMalusId", "MorphId");

                    b.ToTable("MorphBonusMalus");
                });

            modelBuilder.Entity("EclipsePhase.Models.MorphGear", b =>
                {
                    b.Property<int>("GearId")
                        .HasColumnName("gearId");

                    b.Property<int>("MorphId")
                        .HasColumnName("morphId");

                    b.Property<string>("Gear")
                        .IsRequired()
                        .HasColumnName("gear")
                        .HasMaxLength(100);

                    b.Property<string>("Morph")
                        .IsRequired()
                        .HasColumnName("morph")
                        .HasMaxLength(100);

                    b.Property<short>("Occur")
                        .HasColumnName("occur");

                    b.HasKey("GearId", "MorphId");

                    b.ToTable("MorphGear");
                });

            modelBuilder.Entity("EclipsePhase.Models.MorphTrait", b =>
                {
                    b.Property<int>("MorphId")
                        .HasColumnName("morphId");

                    b.Property<int>("TraitId")
                        .HasColumnName("traitId");

                    b.Property<string>("Morph")
                        .IsRequired()
                        .HasColumnName("morph")
                        .HasMaxLength(100);

                    b.Property<string>("Trait")
                        .IsRequired()
                        .HasColumnName("trait")
                        .HasMaxLength(100);

                    b.HasKey("MorphId", "TraitId");

                    b.ToTable("MorphTrait");
                });

            modelBuilder.Entity("EclipsePhase.Models.Psysleight", b =>
                {
                    b.Property<int>("PsysleightId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("psysleightId");

                    b.Property<string>("Action")
                        .IsRequired()
                        .HasColumnName("action")
                        .HasMaxLength(50);

                    b.Property<string>("Desc")
                        .IsRequired()
                        .HasColumnName("desc");

                    b.Property<string>("Duration")
                        .IsRequired()
                        .HasColumnName("duration")
                        .HasMaxLength(50);

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasColumnName("level")
                        .HasMaxLength(3);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(100);

                    b.Property<string>("Range")
                        .IsRequired()
                        .HasColumnName("range")
                        .HasMaxLength(50);

                    b.Property<string>("SkillNeeded")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("skillNeeded")
                        .HasDefaultValueSql("(N'none')")
                        .HasMaxLength(100);

                    b.Property<string>("StrainMod")
                        .IsRequired()
                        .HasColumnName("strainMod")
                        .HasMaxLength(100);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnName("type")
                        .HasMaxLength(50);

                    b.HasKey("PsysleightId");

                    b.ToTable("Psysleight");
                });

            modelBuilder.Entity("EclipsePhase.Models.PsysleightBonusMalus", b =>
                {
                    b.Property<int>("PsysleightId")
                        .HasColumnName("psysleightId");

                    b.Property<int>("BonusMalusId")
                        .HasColumnName("bonusMalusId");

                    b.Property<string>("Bonusmalus")
                        .IsRequired()
                        .HasColumnName("bonusmalus")
                        .HasMaxLength(100);

                    b.Property<short>("Occur")
                        .HasColumnName("occur");

                    b.Property<string>("Psy")
                        .IsRequired()
                        .HasColumnName("psy")
                        .HasMaxLength(100);

                    b.HasKey("PsysleightId", "BonusMalusId");

                    b.ToTable("PsysleightBonusMalus");
                });

            modelBuilder.Entity("EclipsePhase.Models.Reputation", b =>
                {
                    b.Property<int>("ReputationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("reputationId");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(100);

                    b.HasKey("ReputationId");

                    b.ToTable("Reputation");
                });

            modelBuilder.Entity("EclipsePhase.Models.Sapient", b =>
                {
                    b.Property<int>("SapientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("sapientId");

                    b.Property<short>("Cost")
                        .HasColumnName("cost");

                    b.Property<string>("Desc")
                        .IsRequired()
                        .HasColumnName("desc");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(100);

                    b.Property<string>("Unique")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("unique")
                        .HasDefaultValueSql("(N'N')")
                        .HasMaxLength(1);

                    b.HasKey("SapientId");

                    b.ToTable("Sapient");
                });

            modelBuilder.Entity("EclipsePhase.Models.SapientAptitude", b =>
                {
                    b.Property<int>("SapientId")
                        .HasColumnName("sapientId");

                    b.Property<int>("AptitudeId")
                        .HasColumnName("aptitudeId");

                    b.Property<string>("Ai")
                        .IsRequired()
                        .HasColumnName("ai")
                        .HasMaxLength(100);

                    b.Property<string>("Aptitude")
                        .IsRequired()
                        .HasColumnName("aptitude")
                        .HasMaxLength(100);

                    b.Property<short>("Value")
                        .HasColumnName("value");

                    b.HasKey("SapientId", "AptitudeId");

                    b.ToTable("SapientAptitude");
                });

            modelBuilder.Entity("EclipsePhase.Models.SapientSkill", b =>
                {
                    b.Property<string>("Ai")
                        .HasColumnName("ai")
                        .HasMaxLength(100);

                    b.Property<string>("SkillName")
                        .HasColumnName("skillName")
                        .HasMaxLength(100);

                    b.Property<string>("SkillPrefix")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("skillPrefix")
                        .HasDefaultValueSql("(N'')")
                        .HasMaxLength(100);

                    b.Property<short>("Value")
                        .HasColumnName("value");

                    b.HasKey("Ai", "SkillName", "SkillPrefix");

                    b.ToTable("SapientSkill");
                });

            modelBuilder.Entity("EclipsePhase.Models.SapientStat", b =>
                {
                    b.Property<int>("SapientId")
                        .HasColumnName("sapientId");

                    b.Property<int>("StatId")
                        .HasColumnName("statId");

                    b.Property<string>("Ai")
                        .IsRequired()
                        .HasColumnName("ai")
                        .HasMaxLength(100);

                    b.Property<string>("Stat")
                        .IsRequired()
                        .HasColumnName("stat")
                        .HasMaxLength(100);

                    b.Property<short>("Value")
                        .HasColumnName("value");

                    b.HasKey("SapientId", "StatId");

                    b.ToTable("SapientStat");
                });

            modelBuilder.Entity("EclipsePhase.Models.Skill", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasMaxLength(60);

                    b.Property<string>("Prefix")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("prefix")
                        .HasDefaultValueSql("(N'')")
                        .HasMaxLength(60);

                    b.Property<string>("Defaultable")
                        .IsRequired()
                        .HasColumnName("defaultable")
                        .HasMaxLength(1);

                    b.Property<string>("Desc")
                        .HasColumnName("desc");

                    b.Property<string>("LinkedApt")
                        .IsRequired()
                        .HasColumnName("linkedApt")
                        .HasMaxLength(3);

                    b.Property<string>("SkillType")
                        .IsRequired()
                        .HasColumnName("skillType")
                        .HasMaxLength(3);

                    b.HasKey("Name", "Prefix");

                    b.ToTable("Skill");
                });

            modelBuilder.Entity("EclipsePhase.Models.SkillGroup", b =>
                {
                    b.Property<string>("GroupName")
                        .HasColumnName("groupName")
                        .HasMaxLength(100);

                    b.Property<string>("TargetName")
                        .HasColumnName("targetName")
                        .HasMaxLength(100);

                    b.HasKey("GroupName", "TargetName");

                    b.ToTable("SkillGroup");
                });

            modelBuilder.Entity("EclipsePhase.Models.SkillPrefix", b =>
                {
                    b.Property<string>("Prefix")
                        .HasColumnName("prefix")
                        .HasMaxLength(100);

                    b.Property<string>("Desc")
                        .IsRequired()
                        .HasColumnName("desc");

                    b.Property<string>("LinkedApt")
                        .IsRequired()
                        .HasColumnName("linkedApt")
                        .HasMaxLength(3);

                    b.Property<string>("SkillType")
                        .IsRequired()
                        .HasColumnName("skillType")
                        .HasMaxLength(3);

                    b.HasKey("Prefix");

                    b.ToTable("SkillPrefix");
                });

            modelBuilder.Entity("EclipsePhase.Models.Stat", b =>
                {
                    b.Property<int>("StatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("statId");

                    b.Property<string>("Abbreviation")
                        .IsRequired()
                        .HasColumnName("abbreviation")
                        .HasMaxLength(3);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(100);

                    b.HasKey("StatId");

                    b.ToTable("Stat");
                });

            modelBuilder.Entity("EclipsePhase.Models.Trait", b =>
                {
                    b.Property<int>("TraitId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("traitId");

                    b.Property<short?>("CpCost")
                        .HasColumnName("cpCost");

                    b.Property<string>("Desc")
                        .IsRequired()
                        .HasColumnName("desc");

                    b.Property<string>("JustFor")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("(N'EVERY')")
                        .HasMaxLength(30);

                    b.Property<short>("Level")
                        .HasColumnName("level");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(60);

                    b.Property<string>("Onwhat")
                        .HasColumnName("onwhat")
                        .HasMaxLength(3);

                    b.Property<string>("Side")
                        .HasColumnName("side")
                        .HasMaxLength(3);

                    b.HasKey("TraitId");

                    b.ToTable("Trait");
                });

            modelBuilder.Entity("EclipsePhase.Models.TraitBonusMalus", b =>
                {
                    b.Property<int>("BonusMalusId")
                        .HasColumnName("bonusMalusId");

                    b.Property<int>("TraitId")
                        .HasColumnName("traitId");

                    b.Property<string>("BonusMalusName")
                        .IsRequired()
                        .HasColumnName("bonusMalusName")
                        .HasMaxLength(100);

                    b.Property<short>("Occur")
                        .HasColumnName("occur");

                    b.Property<string>("TraitName")
                        .IsRequired()
                        .HasColumnName("traitName")
                        .HasMaxLength(60);

                    b.HasKey("BonusMalusId", "TraitId");

                    b.ToTable("TraitBonusMalus");
                });
#pragma warning restore 612, 618
        }
    }
}
