using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BatchAssessment.Migrations
{
    public partial class addBatchtoDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Batches",
                columns: table => new
                {
                    BatchId = table.Column<Guid>(nullable: false),
                    BusinessUnit = table.Column<string>(nullable: false),
                    ExpiryDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Batches", x => x.BatchId);
                });

            migrationBuilder.CreateTable(
                name: "ACLs",
                columns: table => new
                {
                    ReadUser = table.Column<string>(nullable: false),
                    ReadGroup = table.Column<string>(nullable: true),
                    BatchModelBatchId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ACLs", x => x.ReadUser);
                    table.ForeignKey(
                        name: "FK_ACLs_Batches_BatchModelBatchId",
                        column: x => x.BatchModelBatchId,
                        principalTable: "Batches",
                        principalColumn: "BatchId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Attributes",
                columns: table => new
                {
                    Key = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: false),
                    BatchModelBatchId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attributes", x => x.Key);
                    table.ForeignKey(
                        name: "FK_Attributes_Batches_BatchModelBatchId",
                        column: x => x.BatchModelBatchId,
                        principalTable: "Batches",
                        principalColumn: "BatchId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ACLs_BatchModelBatchId",
                table: "ACLs",
                column: "BatchModelBatchId");

            migrationBuilder.CreateIndex(
                name: "IX_Attributes_BatchModelBatchId",
                table: "Attributes",
                column: "BatchModelBatchId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ACLs");

            migrationBuilder.DropTable(
                name: "Attributes");

            migrationBuilder.DropTable(
                name: "Batches");
        }
    }
}
