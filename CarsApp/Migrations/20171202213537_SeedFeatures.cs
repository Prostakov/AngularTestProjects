using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CarsApp.Migrations
{
    public partial class SeedFeatures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Anti-lock braking system ABS')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Forward-collision warning (FCW)')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Automatic emergency braking (AEB)')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Features WHERE Name IN ('Anti-lock braking system ABS', 'Forward-collision warning (FCW)', 'Automatic emergency braking (AEB)')");
        }
    }
}
