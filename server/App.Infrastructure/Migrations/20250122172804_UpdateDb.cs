using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Infrastructure.Migrations
{
    public partial class UpdateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "RefreshTokenExpired",
                table: "Admins",
                type: "int",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("08d1f92a-d16e-449a-a524-2988991098d6"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 23, 0, 28, 3, 631, DateTimeKind.Local).AddTicks(5119));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("16e0e145-8f78-4ea9-bb97-73935fbf671c"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 23, 0, 28, 3, 631, DateTimeKind.Local).AddTicks(4291));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("1c48a372-eb5f-42f7-9399-44855fe8d026"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 23, 0, 28, 3, 631, DateTimeKind.Local).AddTicks(4934));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("2174b032-e122-4f76-958f-c2699a7257ae"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 23, 0, 28, 3, 631, DateTimeKind.Local).AddTicks(4755));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("262b2ee5-2530-4599-b4b2-13ad83556a18"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 23, 0, 28, 3, 631, DateTimeKind.Local).AddTicks(4689));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("2905d4de-a3cf-4c3a-b6f1-a0a7ef3526ed"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 23, 0, 28, 3, 631, DateTimeKind.Local).AddTicks(4397));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("2ac19fc6-7d0e-486f-89b8-0ebf71ea7d46"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 23, 0, 28, 3, 631, DateTimeKind.Local).AddTicks(4237));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("508f45f9-a981-41ef-a1e2-4ac7f9a779c6"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 23, 0, 28, 3, 631, DateTimeKind.Local).AddTicks(3789));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("65ea5436-1ef6-4fc0-9773-df34d2d04643"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 23, 0, 28, 3, 631, DateTimeKind.Local).AddTicks(5182));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("6dc7173c-e46d-4d93-b83d-dc292c674689"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 23, 0, 28, 3, 631, DateTimeKind.Local).AddTicks(4482));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("7a758875-9af4-4977-a6d3-c78d464bfcaa"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 23, 0, 28, 3, 631, DateTimeKind.Local).AddTicks(4791));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("7e0367b3-3ba5-4f52-8ed7-94b15d09a972"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 23, 0, 28, 3, 631, DateTimeKind.Local).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("7eb9106f-e403-4b4b-97ea-8242591be0ad"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 23, 0, 28, 3, 631, DateTimeKind.Local).AddTicks(3886));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("80b5604b-f2b2-4cd0-99d1-9e1d3a833254"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 23, 0, 28, 3, 631, DateTimeKind.Local).AddTicks(4996));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("92eacbf0-5ecf-4d8a-affd-61403c30c62a"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 23, 0, 28, 3, 631, DateTimeKind.Local).AddTicks(5046));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("a98e4e28-0d8a-4bc1-8deb-929ad1731239"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 23, 0, 28, 3, 631, DateTimeKind.Local).AddTicks(4880));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("b020db79-81f9-43a3-84cc-23681aa7246d"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 23, 0, 28, 3, 631, DateTimeKind.Local).AddTicks(3516));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("b2b44bb2-3261-40b4-8319-4054f59c9c8c"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 23, 0, 28, 3, 631, DateTimeKind.Local).AddTicks(4175));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("b4b13be2-002a-4966-a3b2-c77c0d82705a"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 23, 0, 28, 3, 631, DateTimeKind.Local).AddTicks(4348));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("c0529d4f-2b25-4d7d-b2ec-d55a3c0210c2"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 23, 0, 28, 3, 631, DateTimeKind.Local).AddTicks(4035));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("c19a64b0-d62d-4d50-994a-cbe3ad8ed97b"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 23, 0, 28, 3, 631, DateTimeKind.Local).AddTicks(3853));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("c21c2e8d-a275-4ae7-9ebd-336e16ec57ab"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 23, 0, 28, 3, 631, DateTimeKind.Local).AddTicks(4106));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("c99ebece-d2c5-4868-8e09-e6210257fa91"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 23, 0, 28, 3, 631, DateTimeKind.Local).AddTicks(5220));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("cd5d29de-2225-4a8e-8b52-506bf8f1e995"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 23, 0, 28, 3, 631, DateTimeKind.Local).AddTicks(3963));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("ce583f0e-8737-406a-9cf4-226eff7b8e55"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 23, 0, 28, 3, 631, DateTimeKind.Local).AddTicks(5255));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("d2135181-9dba-4fe6-b3e3-bde127de8c02"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 23, 0, 28, 3, 631, DateTimeKind.Local).AddTicks(3920));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("ed05ae89-9f4d-4393-bd8f-3fbe98cd4ce0"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 23, 0, 28, 3, 631, DateTimeKind.Local).AddTicks(4722));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("ee300ab3-85ff-4f92-9839-8fbd92f3147b"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 23, 0, 28, 3, 631, DateTimeKind.Local).AddTicks(5288));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("eecf5fa7-a683-489f-aefb-42933946ce1d"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 23, 0, 28, 3, 631, DateTimeKind.Local).AddTicks(4067));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("f99b60f8-311d-4aa6-b08f-fe14da1e5a38"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 23, 0, 28, 3, 631, DateTimeKind.Local).AddTicks(4000));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "RefreshTokenExpired",
                table: "Admins",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("08d1f92a-d16e-449a-a524-2988991098d6"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 21, 51, 40, 149, DateTimeKind.Local).AddTicks(9428));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("16e0e145-8f78-4ea9-bb97-73935fbf671c"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 21, 51, 40, 149, DateTimeKind.Local).AddTicks(8980));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("1c48a372-eb5f-42f7-9399-44855fe8d026"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 21, 51, 40, 149, DateTimeKind.Local).AddTicks(9344));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("2174b032-e122-4f76-958f-c2699a7257ae"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 21, 51, 40, 149, DateTimeKind.Local).AddTicks(9256));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("262b2ee5-2530-4599-b4b2-13ad83556a18"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 21, 51, 40, 149, DateTimeKind.Local).AddTicks(9196));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("2905d4de-a3cf-4c3a-b6f1-a0a7ef3526ed"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 21, 51, 40, 149, DateTimeKind.Local).AddTicks(9033));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("2ac19fc6-7d0e-486f-89b8-0ebf71ea7d46"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 21, 51, 40, 149, DateTimeKind.Local).AddTicks(8955));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("508f45f9-a981-41ef-a1e2-4ac7f9a779c6"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 21, 51, 40, 149, DateTimeKind.Local).AddTicks(8643));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("65ea5436-1ef6-4fc0-9773-df34d2d04643"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 21, 51, 40, 149, DateTimeKind.Local).AddTicks(9460));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("6dc7173c-e46d-4d93-b83d-dc292c674689"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 21, 51, 40, 149, DateTimeKind.Local).AddTicks(9058));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("7a758875-9af4-4977-a6d3-c78d464bfcaa"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 21, 51, 40, 149, DateTimeKind.Local).AddTicks(9286));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("7e0367b3-3ba5-4f52-8ed7-94b15d09a972"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 21, 51, 40, 149, DateTimeKind.Local).AddTicks(9162));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("7eb9106f-e403-4b4b-97ea-8242591be0ad"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 21, 51, 40, 149, DateTimeKind.Local).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("80b5604b-f2b2-4cd0-99d1-9e1d3a833254"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 21, 51, 40, 149, DateTimeKind.Local).AddTicks(9372));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("92eacbf0-5ecf-4d8a-affd-61403c30c62a"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 21, 51, 40, 149, DateTimeKind.Local).AddTicks(9405));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("a98e4e28-0d8a-4bc1-8deb-929ad1731239"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 21, 51, 40, 149, DateTimeKind.Local).AddTicks(9314));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("b020db79-81f9-43a3-84cc-23681aa7246d"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 21, 51, 40, 149, DateTimeKind.Local).AddTicks(8465));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("b2b44bb2-3261-40b4-8319-4054f59c9c8c"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 21, 51, 40, 149, DateTimeKind.Local).AddTicks(8927));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("b4b13be2-002a-4966-a3b2-c77c0d82705a"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 21, 51, 40, 149, DateTimeKind.Local).AddTicks(9007));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("c0529d4f-2b25-4d7d-b2ec-d55a3c0210c2"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 21, 51, 40, 149, DateTimeKind.Local).AddTicks(8829));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("c19a64b0-d62d-4d50-994a-cbe3ad8ed97b"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 21, 51, 40, 149, DateTimeKind.Local).AddTicks(8678));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("c21c2e8d-a275-4ae7-9ebd-336e16ec57ab"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 21, 51, 40, 149, DateTimeKind.Local).AddTicks(8897));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("c99ebece-d2c5-4868-8e09-e6210257fa91"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 21, 51, 40, 149, DateTimeKind.Local).AddTicks(9486));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("cd5d29de-2225-4a8e-8b52-506bf8f1e995"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 21, 51, 40, 149, DateTimeKind.Local).AddTicks(8774));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("ce583f0e-8737-406a-9cf4-226eff7b8e55"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 21, 51, 40, 149, DateTimeKind.Local).AddTicks(9513));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("d2135181-9dba-4fe6-b3e3-bde127de8c02"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 21, 51, 40, 149, DateTimeKind.Local).AddTicks(8738));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("ed05ae89-9f4d-4393-bd8f-3fbe98cd4ce0"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 21, 51, 40, 149, DateTimeKind.Local).AddTicks(9227));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("ee300ab3-85ff-4f92-9839-8fbd92f3147b"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 21, 51, 40, 149, DateTimeKind.Local).AddTicks(9541));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("eecf5fa7-a683-489f-aefb-42933946ce1d"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 21, 51, 40, 149, DateTimeKind.Local).AddTicks(8859));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("f99b60f8-311d-4aa6-b08f-fe14da1e5a38"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 14, 21, 51, 40, 149, DateTimeKind.Local).AddTicks(8801));
        }
    }
}
