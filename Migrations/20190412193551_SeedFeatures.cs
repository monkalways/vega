using Microsoft.EntityFrameworkCore.Migrations;

namespace vega.Migrations
{
  public partial class SeedFeatures : Migration
  {
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Adaptive Cruise Control')");
      migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Blind Spot Monitoring')");
      migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Lane Keep Assist')");
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.Sql("DELETE FROM Features WHERE Name in ('Adaptive Cruise Control', 'Blind Spot Monitoring', 'Lane Keep Assist')");
    }
  }
}
