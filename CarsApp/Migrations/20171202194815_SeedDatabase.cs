using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CarsApp.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Manufacturers (Name) VALUES ('Audi')");
            migrationBuilder.Sql("INSERT INTO Models (Name, ManufacturerId) VALUES ('A4', (SELECT ID FROM Manufacturers WHERE Name = 'Audi'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, ManufacturerId) VALUES ('A6', (SELECT ID FROM Manufacturers WHERE Name = 'Audi'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, ManufacturerId) VALUES ('A8', (SELECT ID FROM Manufacturers WHERE Name = 'Audi'))");
            
            migrationBuilder.Sql("INSERT INTO Manufacturers (Name) VALUES ('BMW')");
            migrationBuilder.Sql("INSERT INTO Models (Name, ManufacturerId) VALUES ('320', (SELECT ID FROM Manufacturers WHERE Name = 'BMW'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, ManufacturerId) VALUES ('520', (SELECT ID FROM Manufacturers WHERE Name = 'BMW'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, ManufacturerId) VALUES ('725', (SELECT ID FROM Manufacturers WHERE Name = 'BMW'))");

            migrationBuilder.Sql("INSERT INTO Manufacturers (Name) VALUES ('Mercedes-Benz')");
            migrationBuilder.Sql("INSERT INTO Models (Name, ManufacturerId) VALUES ('CLS 55 AMG', (SELECT ID FROM Manufacturers WHERE Name = 'Mercedes-Benz'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, ManufacturerId) VALUES ('GLS 500', (SELECT ID FROM Manufacturers WHERE Name = 'Mercedes-Benz'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, ManufacturerId) VALUES ('S 600', (SELECT ID FROM Manufacturers WHERE Name = 'Mercedes-Benz'))");

            migrationBuilder.Sql("INSERT INTO Manufacturers (Name) VALUES ('Porsche')");
            migrationBuilder.Sql("INSERT INTO Models (Name, ManufacturerId) VALUES ('911', (SELECT ID FROM Manufacturers WHERE Name = 'Porsche'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, ManufacturerId) VALUES ('Boxster', (SELECT ID FROM Manufacturers WHERE Name = 'Porsche'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, ManufacturerId) VALUES ('Panamera', (SELECT ID FROM Manufacturers WHERE Name = 'Porsche'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, ManufacturerId) VALUES ('Cayenne', (SELECT ID FROM Manufacturers WHERE Name = 'Porsche'))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Manufacturers WHERE Name IN ('Audi', 'BMW', 'Mercedes-Benz', 'Porsche')");
        }
    }
}
