using System;
using EclipsePhase.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EclipsePhase.Data
{
    public partial class EclipsePhaseCharacterBuilderContext : DbContext
    {
        public virtual DbSet<Aptitude> Aptitude { get; set; }
        public virtual DbSet<Background> Background { get; set; }
        public virtual DbSet<BackgroundBonusMalus> BackgroundBonusMalus { get; set; }
        public virtual DbSet<BackgroundTrait> BackgroundTrait { get; set; }
        public virtual DbSet<BonusMalus> BonusMalus { get; set; }
        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<Gear> Gear { get; set; }
        public virtual DbSet<GearBonusMalus> GearBonusMalus { get; set; }
        public virtual DbSet<Info> Info { get; set; }
        public virtual DbSet<Morph> Morph { get; set; }
        public virtual DbSet<MorphBonusMalus> MorphBonusMalus { get; set; }
        public virtual DbSet<MorphGear> MorphGear { get; set; }
        public virtual DbSet<MorphTrait> MorphTrait { get; set; }
        public virtual DbSet<Psysleight> Psysleight { get; set; }
        public virtual DbSet<PsysleightBonusMalus> PsysleightBonusMalus { get; set; }
        public virtual DbSet<Reputation> Reputation { get; set; }
        public virtual DbSet<Sapient> Sapient { get; set; }
        public virtual DbSet<SapientAptitude> SapientAptitude { get; set; }
        public virtual DbSet<SapientSkill> SapientSkill { get; set; }
        public virtual DbSet<SapientStat> SapientStat { get; set; }
        public virtual DbSet<Skill> Skill { get; set; }
        public virtual DbSet<SkillGroup> SkillGroup { get; set; }
        public virtual DbSet<SkillPrefix> SkillPrefix { get; set; }
        public virtual DbSet<Stat> Stat { get; set; }
        public virtual DbSet<Trait> Trait { get; set; }
        public virtual DbSet<TraitBonusMalus> TraitBonusMalus { get; set; }

        // Unable to generate entity type for table 'dbo.BonusMalusType'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Server=Alex-Desktop;Database=EclipsePhaseCharacterBuilder;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aptitude>(entity =>
            {
                entity.Property(e => e.AptitudeId).HasColumnName("aptitudeId");

                entity.Property(e => e.Abbreviation)
                    .IsRequired()
                    .HasColumnName("abbreviation")
                    .HasMaxLength(3);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Background>(entity =>
            {
                entity.Property(e => e.BackgroundId).HasColumnName("backgroundId");

				entity.Property(e => e.Description)
					.IsRequired();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(3);
            });

            modelBuilder.Entity<BackgroundBonusMalus>(entity =>
            {
                entity.HasKey(e => new { e.BackgroundId, e.BonusMalusId });

                entity.Property(e => e.BackgroundId).HasColumnName("backgroundId");

                entity.Property(e => e.BonusMalusId).HasColumnName("bonusMalusId");

                entity.Property(e => e.Background)
                    .IsRequired()
                    .HasColumnName("background")
                    .HasMaxLength(100);

                entity.Property(e => e.BonusMalus)
                    .IsRequired()
                    .HasColumnName("bonusMalus")
                    .HasMaxLength(100);

                entity.Property(e => e.Occurrence).HasColumnName("occurrence");
            });

            modelBuilder.Entity<BackgroundTrait>(entity =>
            {
                entity.HasKey(e => new { e.BackgroundId, e.TraitId });

                entity.Property(e => e.BackgroundId).HasColumnName("backgroundId");

                entity.Property(e => e.TraitId).HasColumnName("traitId");

                entity.Property(e => e.Background)
                    .IsRequired()
                    .HasColumnName("background")
                    .HasMaxLength(100);

                entity.Property(e => e.Trait)
                    .IsRequired()
                    .HasColumnName("trait")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<BonusMalus>(entity =>
            {
                entity.Property(e => e.BonusMalusId).HasColumnName("bonusMalusId");

                entity.Property(e => e.Desc)
                    .IsRequired()
                    .HasColumnName("desc");

                entity.Property(e => e.MultiOccur)
                    .IsRequired()
                    .HasColumnName("multiOccur")
                    .HasMaxLength(20);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.OnCost)
                    .IsRequired()
                    .HasColumnName("onCost")
                    .HasMaxLength(20);

                entity.Property(e => e.Target)
                    .IsRequired()
                    .HasColumnName("target")
                    .HasMaxLength(60);

                entity.Property(e => e.TragetForCh)
                    .IsRequired()
                    .HasColumnName("tragetForCh")
                    .HasMaxLength(20);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(3);

                entity.Property(e => e.TypeTarget)
                    .IsRequired()
                    .HasColumnName("typeTarget")
                    .HasMaxLength(20);

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.Property(e => e.BookId).HasColumnName("bookId");

                entity.Property(e => e.Book1)
                    .IsRequired()
                    .HasColumnName("book")
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Gear>(entity =>
            {
                entity.Property(e => e.GearId).HasColumnName("gearId");

                entity.Property(e => e.ArmorEnergy).HasColumnName("armorEnergy");

                entity.Property(e => e.ArmorKinetic).HasColumnName("armorKinetic");

                entity.Property(e => e.ArmorPene).HasColumnName("armorPene");

                entity.Property(e => e.Cost).HasColumnName("cost");

                entity.Property(e => e.Degat)
                    .IsRequired()
                    .HasColumnName("degat")
                    .HasMaxLength(30);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.JustFor)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(3);

                entity.Property(e => e.Unique)
                    .IsRequired()
                    .HasColumnName("unique")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'Y')");
            });

            modelBuilder.Entity<GearBonusMalus>(entity =>
            {
                entity.HasKey(e => new { e.BonusMalusId, e.GearId });

                entity.Property(e => e.BonusMalusId).HasColumnName("bonusMalusId");

                entity.Property(e => e.GearId).HasColumnName("gearId");

                entity.Property(e => e.BonusMalus)
                    .IsRequired()
                    .HasColumnName("bonusMalus")
                    .HasMaxLength(100);

                entity.Property(e => e.Gear)
                    .IsRequired()
                    .HasColumnName("gear")
                    .HasMaxLength(100);

                entity.Property(e => e.Occur).HasColumnName("occur");
            });

            modelBuilder.Entity<Info>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(100)
                    .ValueGeneratedNever();

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasColumnName("data");
            });

            modelBuilder.Entity<Morph>(entity =>
            {
                entity.Property(e => e.MorphId).HasColumnName("morphId");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.CpCost).HasColumnName("cpCost");

                entity.Property(e => e.CreditCost)
                    .IsRequired()
                    .HasColumnName("creditCost")
                    .HasMaxLength(100);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.Durablility).HasColumnName("durablility");

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasColumnName("gender")
                    .HasMaxLength(1);

                entity.Property(e => e.MaxApptitude).HasColumnName("maxApptitude");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<MorphBonusMalus>(entity =>
            {
                entity.HasKey(e => new { e.BonusMalusId, e.MorphId });

                entity.Property(e => e.BonusMalusId).HasColumnName("bonusMalusId");

                entity.Property(e => e.MorphId).HasColumnName("morphId");

                entity.Property(e => e.BonusMalus)
                    .IsRequired()
                    .HasColumnName("bonusMalus")
                    .HasMaxLength(100);

                entity.Property(e => e.Morph)
                    .IsRequired()
                    .HasColumnName("morph")
                    .HasMaxLength(100);

                entity.Property(e => e.Occur).HasColumnName("occur");
            });

            modelBuilder.Entity<MorphGear>(entity =>
            {
                entity.HasKey(e => new { e.GearId, e.MorphId });

                entity.Property(e => e.GearId).HasColumnName("gearId");

                entity.Property(e => e.MorphId).HasColumnName("morphId");

                entity.Property(e => e.Gear)
                    .IsRequired()
                    .HasColumnName("gear")
                    .HasMaxLength(100);

                entity.Property(e => e.Morph)
                    .IsRequired()
                    .HasColumnName("morph")
                    .HasMaxLength(100);

                entity.Property(e => e.Occur).HasColumnName("occur");
            });

            modelBuilder.Entity<MorphTrait>(entity =>
            {
                entity.HasKey(e => new { e.MorphId, e.TraitId });

                entity.Property(e => e.MorphId).HasColumnName("morphId");

                entity.Property(e => e.TraitId).HasColumnName("traitId");

                entity.Property(e => e.Morph)
                    .IsRequired()
                    .HasColumnName("morph")
                    .HasMaxLength(100);

                entity.Property(e => e.Trait)
                    .IsRequired()
                    .HasColumnName("trait")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Psysleight>(entity =>
            {
                entity.Property(e => e.PsysleightId).HasColumnName("psysleightId");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasColumnName("action")
                    .HasMaxLength(50);

                entity.Property(e => e.Desc)
                    .IsRequired()
                    .HasColumnName("desc");

                entity.Property(e => e.Duration)
                    .IsRequired()
                    .HasColumnName("duration")
                    .HasMaxLength(50);

                entity.Property(e => e.Level)
                    .IsRequired()
                    .HasColumnName("level")
                    .HasMaxLength(3);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.Range)
                    .IsRequired()
                    .HasColumnName("range")
                    .HasMaxLength(50);

                entity.Property(e => e.SkillNeeded)
                    .IsRequired()
                    .HasColumnName("skillNeeded")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'none')");

                entity.Property(e => e.StrainMod)
                    .IsRequired()
                    .HasColumnName("strainMod")
                    .HasMaxLength(100);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PsysleightBonusMalus>(entity =>
            {
                entity.HasKey(e => new { e.PsysleightId, e.BonusMalusId });

                entity.Property(e => e.PsysleightId).HasColumnName("psysleightId");

                entity.Property(e => e.BonusMalusId).HasColumnName("bonusMalusId");

                entity.Property(e => e.Bonusmalus)
                    .IsRequired()
                    .HasColumnName("bonusmalus")
                    .HasMaxLength(100);

                entity.Property(e => e.Occur).HasColumnName("occur");

                entity.Property(e => e.Psy)
                    .IsRequired()
                    .HasColumnName("psy")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Reputation>(entity =>
            {
                entity.Property(e => e.ReputationId).HasColumnName("reputationId");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Sapient>(entity =>
            {
                entity.Property(e => e.SapientId).HasColumnName("sapientId");

                entity.Property(e => e.Cost).HasColumnName("cost");

                entity.Property(e => e.Desc)
                    .IsRequired()
                    .HasColumnName("desc");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.Unique)
                    .IsRequired()
                    .HasColumnName("unique")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'N')");
            });

            modelBuilder.Entity<SapientAptitude>(entity =>
            {
                entity.HasKey(e => new { e.SapientId, e.AptitudeId });

                entity.Property(e => e.SapientId).HasColumnName("sapientId");

                entity.Property(e => e.AptitudeId).HasColumnName("aptitudeId");

                entity.Property(e => e.Ai)
                    .IsRequired()
                    .HasColumnName("ai")
                    .HasMaxLength(100);

                entity.Property(e => e.Aptitude)
                    .IsRequired()
                    .HasColumnName("aptitude")
                    .HasMaxLength(100);

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<SapientSkill>(entity =>
            {
                entity.HasKey(e => new { e.Ai, e.SkillName, e.SkillPrefix });

                entity.Property(e => e.Ai)
                    .HasColumnName("ai")
                    .HasMaxLength(100);

                entity.Property(e => e.SkillName)
                    .HasColumnName("skillName")
                    .HasMaxLength(100);

                entity.Property(e => e.SkillPrefix)
                    .HasColumnName("skillPrefix")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<SapientStat>(entity =>
            {
                entity.HasKey(e => new { e.SapientId, e.StatId });

                entity.Property(e => e.SapientId).HasColumnName("sapientId");

                entity.Property(e => e.StatId).HasColumnName("statId");

                entity.Property(e => e.Ai)
                    .IsRequired()
                    .HasColumnName("ai")
                    .HasMaxLength(100);

                entity.Property(e => e.Stat)
                    .IsRequired()
                    .HasColumnName("stat")
                    .HasMaxLength(100);

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<Skill>(entity =>
            {
                entity.HasKey(e => new { e.Name, e.Prefix });

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(60);

                entity.Property(e => e.Prefix)
                    .HasColumnName("prefix")
                    .HasMaxLength(60)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Defaultable)
                    .IsRequired()
                    .HasColumnName("defaultable")
                    .HasMaxLength(1);

                entity.Property(e => e.Desc).HasColumnName("desc");

                entity.Property(e => e.LinkedApt)
                    .IsRequired()
                    .HasColumnName("linkedApt")
                    .HasMaxLength(3);

                entity.Property(e => e.SkillType)
                    .IsRequired()
                    .HasColumnName("skillType")
                    .HasMaxLength(3);
            });

            modelBuilder.Entity<SkillGroup>(entity =>
            {
                entity.HasKey(e => new { e.GroupName, e.TargetName });

                entity.Property(e => e.GroupName)
                    .HasColumnName("groupName")
                    .HasMaxLength(100);

                entity.Property(e => e.TargetName)
                    .HasColumnName("targetName")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<SkillPrefix>(entity =>
            {
                entity.HasKey(e => e.Prefix);

                entity.Property(e => e.Prefix)
                    .HasColumnName("prefix")
                    .HasMaxLength(100)
                    .ValueGeneratedNever();

                entity.Property(e => e.Desc)
                    .IsRequired()
                    .HasColumnName("desc");

                entity.Property(e => e.LinkedApt)
                    .IsRequired()
                    .HasColumnName("linkedApt")
                    .HasMaxLength(3);

                entity.Property(e => e.SkillType)
                    .IsRequired()
                    .HasColumnName("skillType")
                    .HasMaxLength(3);
            });

            modelBuilder.Entity<Stat>(entity =>
            {
                entity.Property(e => e.StatId).HasColumnName("statId");

                entity.Property(e => e.Abbreviation)
                    .IsRequired()
                    .HasColumnName("abbreviation")
                    .HasMaxLength(3);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Trait>(entity =>
            {
                entity.Property(e => e.TraitId).HasColumnName("traitId");

                entity.Property(e => e.CpCost).HasColumnName("cpCost");

                entity.Property(e => e.Desc)
                    .IsRequired()
                    .HasColumnName("desc");

                entity.Property(e => e.JustFor)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(N'EVERY')");

                entity.Property(e => e.Level).HasColumnName("level");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(60);

                entity.Property(e => e.Onwhat)
                    .HasColumnName("onwhat")
                    .HasMaxLength(3);

                entity.Property(e => e.Side)
                    .HasColumnName("side")
                    .HasMaxLength(3);
            });

            modelBuilder.Entity<TraitBonusMalus>(entity =>
            {
                entity.HasKey(e => new { e.BonusMalusId, e.TraitId });

                entity.Property(e => e.BonusMalusId).HasColumnName("bonusMalusId");

                entity.Property(e => e.TraitId).HasColumnName("traitId");

                entity.Property(e => e.BonusMalusName)
                    .IsRequired()
                    .HasColumnName("bonusMalusName")
                    .HasMaxLength(100);

                entity.Property(e => e.Occur).HasColumnName("occur");

                entity.Property(e => e.TraitName)
                    .IsRequired()
                    .HasColumnName("traitName")
                    .HasMaxLength(60);
            });
        }
    }
}
