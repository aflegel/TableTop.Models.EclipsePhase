using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EclipsePhase.Migrations
{
    public partial class InitialCommit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aptitude",
                columns: table => new
                {
                    name = table.Column<string>(maxLength: 100, nullable: false),
                    description = table.Column<string>(nullable: false),
                    abbreviation = table.Column<string>(maxLength: 3, nullable: false),
                    aptitudeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aptitude", x => x.aptitudeId);
                });

            migrationBuilder.CreateTable(
                name: "AtomPage",
                columns: table => new
                {
                    name = table.Column<string>(maxLength: 100, nullable: false),
                    page = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtomPage", x => x.name);
                });

            migrationBuilder.CreateTable(
                name: "Background",
                columns: table => new
                {
                    name = table.Column<string>(maxLength: 100, nullable: false),
                    description = table.Column<string>(nullable: false),
                    type = table.Column<string>(maxLength: 3, nullable: false),
                    backgroundId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Background", x => x.backgroundId);
                });

            migrationBuilder.CreateTable(
                name: "BackgroundBonusMalus",
                columns: table => new
                {
                    background = table.Column<string>(maxLength: 100, nullable: false),
                    bonusMalus = table.Column<string>(maxLength: 100, nullable: false),
                    occurrence = table.Column<short>(nullable: false),
                    backgroundId = table.Column<int>(nullable: false),
                    bonusMalusId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BackgroundBonusMalus", x => new { x.backgroundId, x.bonusMalusId });
                });

            migrationBuilder.CreateTable(
                name: "BackgroundTrait",
                columns: table => new
                {
                    background = table.Column<string>(maxLength: 100, nullable: false),
                    trait = table.Column<string>(maxLength: 100, nullable: false),
                    backgroundId = table.Column<int>(nullable: false),
                    traitId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BackgroundTrait", x => new { x.backgroundId, x.traitId });
                });

            migrationBuilder.CreateTable(
                name: "BonusMalus",
                columns: table => new
                {
                    name = table.Column<string>(maxLength: 100, nullable: false),
                    desc = table.Column<string>(nullable: false),
                    type = table.Column<string>(maxLength: 3, nullable: false),
                    target = table.Column<string>(maxLength: 60, nullable: false),
                    value = table.Column<float>(nullable: false),
                    tragetForCh = table.Column<string>(maxLength: 20, nullable: false),
                    typeTarget = table.Column<string>(maxLength: 20, nullable: false),
                    onCost = table.Column<string>(maxLength: 20, nullable: false),
                    multiOccur = table.Column<string>(maxLength: 20, nullable: false),
                    bonusMalusId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BonusMalus", x => x.bonusMalusId);
                });

            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    name = table.Column<string>(maxLength: 100, nullable: false),
                    book = table.Column<string>(maxLength: 100, nullable: false),
                    bookId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.bookId);
                });

            migrationBuilder.CreateTable(
                name: "Gear",
                columns: table => new
                {
                    name = table.Column<string>(maxLength: 100, nullable: false),
                    description = table.Column<string>(nullable: false),
                    type = table.Column<string>(maxLength: 3, nullable: false),
                    cost = table.Column<short>(nullable: false),
                    armorKinetic = table.Column<short>(nullable: false),
                    armorEnergy = table.Column<short>(nullable: false),
                    degat = table.Column<string>(maxLength: 30, nullable: false),
                    armorPene = table.Column<short>(nullable: false),
                    JustFor = table.Column<string>(maxLength: 100, nullable: false),
                    unique = table.Column<string>(maxLength: 1, nullable: false, defaultValueSql: "(N'Y')"),
                    gearId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gear", x => x.gearId);
                });

            migrationBuilder.CreateTable(
                name: "GearBonusMalus",
                columns: table => new
                {
                    gear = table.Column<string>(maxLength: 100, nullable: false),
                    bonusMalus = table.Column<string>(maxLength: 100, nullable: false),
                    occur = table.Column<short>(nullable: false),
                    gearId = table.Column<int>(nullable: false),
                    bonusMalusId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GearBonusMalus", x => new { x.bonusMalusId, x.gearId });
                });

            migrationBuilder.CreateTable(
                name: "Info",
                columns: table => new
                {
                    id = table.Column<string>(maxLength: 100, nullable: false),
                    data = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Info", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Morph",
                columns: table => new
                {
                    name = table.Column<string>(maxLength: 100, nullable: false),
                    description = table.Column<string>(nullable: false),
                    type = table.Column<string>(maxLength: 20, nullable: false),
                    gender = table.Column<string>(maxLength: 1, nullable: false),
                    age = table.Column<short>(nullable: false),
                    maxApptitude = table.Column<short>(nullable: false),
                    durablility = table.Column<short>(nullable: false),
                    cpCost = table.Column<short>(nullable: false),
                    creditCost = table.Column<string>(maxLength: 100, nullable: false),
                    morphId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Morph", x => x.morphId);
                });

            migrationBuilder.CreateTable(
                name: "MorphBonusMalus",
                columns: table => new
                {
                    morph = table.Column<string>(maxLength: 100, nullable: false),
                    bonusMalus = table.Column<string>(maxLength: 100, nullable: false),
                    occur = table.Column<short>(nullable: false),
                    morphId = table.Column<int>(nullable: false),
                    bonusMalusId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MorphBonusMalus", x => new { x.bonusMalusId, x.morphId });
                });

            migrationBuilder.CreateTable(
                name: "MorphGear",
                columns: table => new
                {
                    morph = table.Column<string>(maxLength: 100, nullable: false),
                    gear = table.Column<string>(maxLength: 100, nullable: false),
                    occur = table.Column<short>(nullable: false),
                    morphId = table.Column<int>(nullable: false),
                    gearId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MorphGear", x => new { x.gearId, x.morphId });
                });

            migrationBuilder.CreateTable(
                name: "MorphTrait",
                columns: table => new
                {
                    morph = table.Column<string>(maxLength: 100, nullable: false),
                    trait = table.Column<string>(maxLength: 100, nullable: false),
                    morphId = table.Column<int>(nullable: false),
                    traitId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MorphTrait", x => new { x.morphId, x.traitId });
                });

            migrationBuilder.CreateTable(
                name: "Psysleight",
                columns: table => new
                {
                    name = table.Column<string>(maxLength: 100, nullable: false),
                    desc = table.Column<string>(nullable: false),
                    type = table.Column<string>(maxLength: 50, nullable: false),
                    range = table.Column<string>(maxLength: 50, nullable: false),
                    duration = table.Column<string>(maxLength: 50, nullable: false),
                    action = table.Column<string>(maxLength: 50, nullable: false),
                    level = table.Column<string>(maxLength: 3, nullable: false),
                    strainMod = table.Column<string>(maxLength: 100, nullable: false),
                    skillNeeded = table.Column<string>(maxLength: 100, nullable: false, defaultValueSql: "(N'none')"),
                    psysleightId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Psysleight", x => x.psysleightId);
                });

            migrationBuilder.CreateTable(
                name: "PsysleightBonusMalus",
                columns: table => new
                {
                    psy = table.Column<string>(maxLength: 100, nullable: false),
                    bonusmalus = table.Column<string>(maxLength: 100, nullable: false),
                    occur = table.Column<short>(nullable: false),
                    psysleightId = table.Column<int>(nullable: false),
                    bonusMalusId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PsysleightBonusMalus", x => new { x.psysleightId, x.bonusMalusId });
                });

            migrationBuilder.CreateTable(
                name: "Reputation",
                columns: table => new
                {
                    name = table.Column<string>(maxLength: 100, nullable: false),
                    description = table.Column<string>(nullable: false),
                    reputationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reputation", x => x.reputationId);
                });

            migrationBuilder.CreateTable(
                name: "Sapient",
                columns: table => new
                {
                    name = table.Column<string>(maxLength: 100, nullable: false),
                    desc = table.Column<string>(nullable: false),
                    cost = table.Column<short>(nullable: false),
                    unique = table.Column<string>(maxLength: 1, nullable: false, defaultValueSql: "(N'N')"),
                    sapientId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sapient", x => x.sapientId);
                });

            migrationBuilder.CreateTable(
                name: "SapientAptitude",
                columns: table => new
                {
                    ai = table.Column<string>(maxLength: 100, nullable: false),
                    aptitude = table.Column<string>(maxLength: 100, nullable: false),
                    value = table.Column<short>(nullable: false),
                    sapientId = table.Column<int>(nullable: false),
                    aptitudeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SapientAptitude", x => new { x.sapientId, x.aptitudeId });
                });

            migrationBuilder.CreateTable(
                name: "SapientSkill",
                columns: table => new
                {
                    ai = table.Column<string>(maxLength: 100, nullable: false),
                    skillName = table.Column<string>(maxLength: 100, nullable: false),
                    skillPrefix = table.Column<string>(maxLength: 100, nullable: false, defaultValueSql: "(N'')"),
                    value = table.Column<short>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SapientSkill", x => new { x.ai, x.skillName, x.skillPrefix });
                });

            migrationBuilder.CreateTable(
                name: "SapientStat",
                columns: table => new
                {
                    ai = table.Column<string>(maxLength: 100, nullable: false),
                    stat = table.Column<string>(maxLength: 100, nullable: false),
                    value = table.Column<short>(nullable: false),
                    sapientId = table.Column<int>(nullable: false),
                    statId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SapientStat", x => new { x.sapientId, x.statId });
                });

            migrationBuilder.CreateTable(
                name: "Skill",
                columns: table => new
                {
                    name = table.Column<string>(maxLength: 60, nullable: false),
                    desc = table.Column<string>(nullable: true),
                    linkedApt = table.Column<string>(maxLength: 3, nullable: false),
                    prefix = table.Column<string>(maxLength: 60, nullable: false, defaultValueSql: "(N'')"),
                    skillType = table.Column<string>(maxLength: 3, nullable: false),
                    defaultable = table.Column<string>(maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skill", x => new { x.name, x.prefix });
                });

            migrationBuilder.CreateTable(
                name: "SkillGroup",
                columns: table => new
                {
                    groupName = table.Column<string>(maxLength: 100, nullable: false),
                    targetName = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillGroup", x => new { x.groupName, x.targetName });
                });

            migrationBuilder.CreateTable(
                name: "SkillPrefix",
                columns: table => new
                {
                    prefix = table.Column<string>(maxLength: 100, nullable: false),
                    linkedApt = table.Column<string>(maxLength: 3, nullable: false),
                    skillType = table.Column<string>(maxLength: 3, nullable: false),
                    desc = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillPrefix", x => x.prefix);
                });

            migrationBuilder.CreateTable(
                name: "Stat",
                columns: table => new
                {
                    name = table.Column<string>(maxLength: 100, nullable: false),
                    description = table.Column<string>(nullable: false),
                    abbreviation = table.Column<string>(maxLength: 3, nullable: false),
                    statId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stat", x => x.statId);
                });

            migrationBuilder.CreateTable(
                name: "Trait",
                columns: table => new
                {
                    name = table.Column<string>(maxLength: 60, nullable: false),
                    desc = table.Column<string>(nullable: false),
                    side = table.Column<string>(maxLength: 3, nullable: true),
                    onwhat = table.Column<string>(maxLength: 3, nullable: true),
                    cpCost = table.Column<short>(nullable: true),
                    level = table.Column<short>(nullable: false),
                    JustFor = table.Column<string>(maxLength: 30, nullable: false, defaultValueSql: "(N'EVERY')"),
                    traitId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trait", x => x.traitId);
                });

            migrationBuilder.CreateTable(
                name: "TraitBonusMalus",
                columns: table => new
                {
                    traitName = table.Column<string>(maxLength: 60, nullable: false),
                    bonusMalusName = table.Column<string>(maxLength: 100, nullable: false),
                    occur = table.Column<short>(nullable: false),
                    traitId = table.Column<int>(nullable: false),
                    bonusMalusId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TraitBonusMalus", x => new { x.bonusMalusId, x.traitId });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aptitude");

            migrationBuilder.DropTable(
                name: "AtomPage");

            migrationBuilder.DropTable(
                name: "Background");

            migrationBuilder.DropTable(
                name: "BackgroundBonusMalus");

            migrationBuilder.DropTable(
                name: "BackgroundTrait");

            migrationBuilder.DropTable(
                name: "BonusMalus");

            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DropTable(
                name: "Gear");

            migrationBuilder.DropTable(
                name: "GearBonusMalus");

            migrationBuilder.DropTable(
                name: "Info");

            migrationBuilder.DropTable(
                name: "Morph");

            migrationBuilder.DropTable(
                name: "MorphBonusMalus");

            migrationBuilder.DropTable(
                name: "MorphGear");

            migrationBuilder.DropTable(
                name: "MorphTrait");

            migrationBuilder.DropTable(
                name: "Psysleight");

            migrationBuilder.DropTable(
                name: "PsysleightBonusMalus");

            migrationBuilder.DropTable(
                name: "Reputation");

            migrationBuilder.DropTable(
                name: "Sapient");

            migrationBuilder.DropTable(
                name: "SapientAptitude");

            migrationBuilder.DropTable(
                name: "SapientSkill");

            migrationBuilder.DropTable(
                name: "SapientStat");

            migrationBuilder.DropTable(
                name: "Skill");

            migrationBuilder.DropTable(
                name: "SkillGroup");

            migrationBuilder.DropTable(
                name: "SkillPrefix");

            migrationBuilder.DropTable(
                name: "Stat");

            migrationBuilder.DropTable(
                name: "Trait");

            migrationBuilder.DropTable(
                name: "TraitBonusMalus");
        }
    }
}
