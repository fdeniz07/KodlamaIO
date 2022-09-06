using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Kodlama.io.Devs.Persistence.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProgramminLanguage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedByName = table.Column<string>(type: "text", nullable: true),
                    ModifiedByName = table.Column<string>(type: "text", nullable: true),
                    Note = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramminLanguage", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ProgramminLanguage",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2022, 9, 6, 9, 8, 18, 387, DateTimeKind.Utc).AddTicks(4529), true, false, "Admin", new DateTime(2022, 9, 6, 9, 8, 18, 387, DateTimeKind.Utc).AddTicks(4529), "Java", null },
                    { 2, "Admin", new DateTime(2022, 9, 6, 9, 8, 18, 387, DateTimeKind.Utc).AddTicks(4531), true, false, "Admin", new DateTime(2022, 9, 6, 9, 8, 18, 387, DateTimeKind.Utc).AddTicks(4531), "C#", null },
                    { 3, "Admin", new DateTime(2022, 9, 6, 9, 8, 18, 387, DateTimeKind.Utc).AddTicks(4532), true, false, "Admin", new DateTime(2022, 9, 6, 9, 8, 18, 387, DateTimeKind.Utc).AddTicks(4532), "Python", null },
                    { 4, "Admin", new DateTime(2022, 9, 6, 9, 8, 18, 387, DateTimeKind.Utc).AddTicks(4532), true, false, "Admin", new DateTime(2022, 9, 6, 9, 8, 18, 387, DateTimeKind.Utc).AddTicks(4533), "JavaScript", null },
                    { 5, "Admin", new DateTime(2022, 9, 6, 9, 8, 18, 387, DateTimeKind.Utc).AddTicks(4533), true, false, "Admin", new DateTime(2022, 9, 6, 9, 8, 18, 387, DateTimeKind.Utc).AddTicks(4534), "Go", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProgramminLanguage");
        }
    }
}
