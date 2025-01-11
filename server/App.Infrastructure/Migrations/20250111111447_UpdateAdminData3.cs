using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Infrastructure.Migrations
{
    public partial class UpdateAdminData3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Role",
                table: "Admins",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "SalesAssociate",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Admins",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "Active");

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "Address", "CreatedAt", "CreatedById", "DisplayName", "Email", "Password", "PhoneNumber", "Role", "Status", "UpdatedAt", "Username" },
                values: new object[,]
                {
                    { new Guid("08d1f92a-d16e-449a-a524-2988991098d6"), null, new DateTime(2025, 1, 11, 18, 14, 47, 502, DateTimeKind.Local).AddTicks(924), null, "Osbert Gore", "ogorep@wordpress.com", "$2a$04$Ud0SQpKMTt0i9NdMLmTbDOZ2L5aVf1jBequCAFJe9e7QZFm0gRFqu", null, "SalesAssociate", "Active", null, "ogorep" },
                    { new Guid("16e0e145-8f78-4ea9-bb97-73935fbf671c"), null, new DateTime(2025, 1, 11, 18, 14, 47, 502, DateTimeKind.Local).AddTicks(636), null, "Tobi Kolakovic", "tkolakovicc@trellian.com", "$2a$04$pmx4w4iwJPNoA/58J0Rm1.vX3OjKhmTZrpA2vcI3qHjHdGQhFHDwC", null, "SalesAssociate", "Active", null, "tkolakovicc" },
                    { new Guid("1c48a372-eb5f-42f7-9399-44855fe8d026"), null, new DateTime(2025, 1, 11, 18, 14, 47, 502, DateTimeKind.Local).AddTicks(871), null, "Man Skirlin", "mskirlinm@businesswire.com", "$2a$04$74BZIib7/aubEl4OvpbyNeJyH5/TLYipMOSEmCDf1mQsb/22kdxvO", null, "SalesAssociate", "Active", null, "mskirlinm" },
                    { new Guid("2174b032-e122-4f76-958f-c2699a7257ae"), null, new DateTime(2025, 1, 11, 18, 14, 47, 502, DateTimeKind.Local).AddTicks(815), null, "Parrnell Scoon", "pscoonj@exblog.jp", "$2a$04$RHF9KF4Gc0OlAxaAUYO1XeWYQ6uhrQiCPbzZ2Od3PUn5kwAfgpvmi", null, "SalesAssociate", "Active", null, "pscoonj" },
                    { new Guid("262b2ee5-2530-4599-b4b2-13ad83556a18"), null, new DateTime(2025, 1, 11, 18, 14, 47, 502, DateTimeKind.Local).AddTicks(777), null, "Alexei Jenken", "ajenkenh@ezinearticles.com", "$2a$04$S4ZkoHJZusA1nHUGw4rpPeS9Be8NgMIhLx63vhvenf8pUcVm9QIw.", null, "SalesAssociate", "Active", null, "ajenkenh" },
                    { new Guid("2905d4de-a3cf-4c3a-b6f1-a0a7ef3526ed"), null, new DateTime(2025, 1, 11, 18, 14, 47, 502, DateTimeKind.Local).AddTicks(671), null, "Karylin Haglinton", "khaglintone@utexas.edu", "$2a$04$CELBLoaS5s9Hjj0rl9l72.a2dKtpZ3jq1saD0utdFR6USeas0IjFq", null, "SalesAssociate", "Active", null, "khaglintone" },
                    { new Guid("2ac19fc6-7d0e-486f-89b8-0ebf71ea7d46"), null, new DateTime(2025, 1, 11, 18, 14, 47, 502, DateTimeKind.Local).AddTicks(618), null, "Philbert Grimwad", "pgrimwadb@tiny.cc", "$2a$04$B5zadGbsBhE8dPpk102Xqusxxrx25hbO8aHWufTTvBte3fgpcB6QO", null, "SalesAssociate", "Active", null, "pgrimwadb" },
                    { new Guid("508f45f9-a981-41ef-a1e2-4ac7f9a779c6"), null, new DateTime(2025, 1, 11, 18, 14, 47, 502, DateTimeKind.Local).AddTicks(412), null, "Keene Bale", "kbale1@youtube.com", "$2a$04$S4p42MoLbiCT2DRGjLjeXOnGTUj.LMm/zUideI3DKkHC7IX618Qse", null, "SalesAssociate", "Active", null, "kbale1" },
                    { new Guid("65ea5436-1ef6-4fc0-9773-df34d2d04643"), null, new DateTime(2025, 1, 11, 18, 14, 47, 502, DateTimeKind.Local).AddTicks(942), null, "Cinnamon Packwood", "cpackwoodq@drupal.org", "$2a$04$SWjLq7uiS13zx9PPHFYxEuPAt1F5yRR/gIqskYUSZkgYf68EyKzDm", null, "SalesAssociate", "Active", null, "cpackwoodq" },
                    { new Guid("6dc7173c-e46d-4d93-b83d-dc292c674689"), null, new DateTime(2025, 1, 11, 18, 14, 47, 502, DateTimeKind.Local).AddTicks(690), null, "Trish Hotchkin", "thotchkinf@soundcloud.com", "$2a$04$bFeG7J8HL0AG8GuyB.IYDOy1EpJFetGDknB3lGI4MXnuKvRmWTqCC", null, "SalesAssociate", "Active", null, "thotchkinf" },
                    { new Guid("7a758875-9af4-4977-a6d3-c78d464bfcaa"), null, new DateTime(2025, 1, 11, 18, 14, 47, 502, DateTimeKind.Local).AddTicks(834), null, "Witty Dive", "wdivek@forbes.com", "$2a$04$lC.XbFRoroN9auhBzb0QTe6/3WDQ9r3z3722fVTYDmVFdmDn5biAC", null, "SalesAssociate", "Active", null, "wdivek" },
                    { new Guid("7e0367b3-3ba5-4f52-8ed7-94b15d09a972"), null, new DateTime(2025, 1, 11, 18, 14, 47, 502, DateTimeKind.Local).AddTicks(708), null, "Ronalda Antoniewicz", "rantoniewiczg@paginegialle.it", "$2a$04$Gl3ubGe0iVHYVYQEoBdYQ.L5SJ3hfFBBKQVjUvZHfsURxDxqsl8MO", null, "SalesAssociate", "Active", null, "rantoniewiczg" },
                    { new Guid("7eb9106f-e403-4b4b-97ea-8242591be0ad"), null, new DateTime(2025, 1, 11, 18, 14, 47, 502, DateTimeKind.Local).AddTicks(458), null, "Starr Lay", "slay3@timesonline.co.uk", "$2a$04$Qbf0k.RHLbx1BjOjpAokee9jvob/PzUkAUAuTZhTJqtWZ0Ev5kGfa", null, "SalesAssociate", "Active", null, "slay3" },
                    { new Guid("80b5604b-f2b2-4cd0-99d1-9e1d3a833254"), null, new DateTime(2025, 1, 11, 18, 14, 47, 502, DateTimeKind.Local).AddTicks(888), null, "Joni Plampin", "jplampinn@nps.gov", "$2a$04$/tlKvjG0dDyX6W8avz1xIevRHIcTq4dvcHafPb6On70BC5uEaTQTm", null, "SalesAssociate", "Active", null, "jplampinn" },
                    { new Guid("92eacbf0-5ecf-4d8a-affd-61403c30c62a"), null, new DateTime(2025, 1, 11, 18, 14, 47, 502, DateTimeKind.Local).AddTicks(906), null, "Louisette Causnett", "lcausnetto@usatoday.com", "$2a$04$FOF9eaMqQ2ortw1.bcRlUu.cvxUGX9hS67kPcTsdlpzVg.7sX3Yuu", null, "SalesAssociate", "Active", null, "lcausnetto" },
                    { new Guid("a98e4e28-0d8a-4bc1-8deb-929ad1731239"), null, new DateTime(2025, 1, 11, 18, 14, 47, 502, DateTimeKind.Local).AddTicks(852), null, "Alphard McNeish", "amcneishl@discuz.net", "$2a$04$yvS7XfiIfYmgAL5Yx2yw2.NHEkTkspqKe4Kd4F/rjKUATq9VLff2q", null, "SalesAssociate", "Active", null, "amcneishl" },
                    { new Guid("b020db79-81f9-43a3-84cc-23681aa7246d"), null, new DateTime(2025, 1, 11, 18, 14, 47, 502, DateTimeKind.Local).AddTicks(267), null, "Janna Longford", "jlongford0@marketwatch.com", "$2a$04$eOgiynEu3KdZl0PSnNHAoO869MQ7fea1jSKBTfrgZejxcqXV.rTD6", null, "SalesAssociate", "Active", null, "jlongford0" },
                    { new Guid("b2b44bb2-3261-40b4-8319-4054f59c9c8c"), null, new DateTime(2025, 1, 11, 18, 14, 47, 502, DateTimeKind.Local).AddTicks(599), null, "Estell Wardhough", "ewardhougha@mediafire.com", "$2a$04$4wG80/nH79T/EvzbjSODCOopRbmKXbDga7jmnKjVptHRSib3kK.Nq", null, "SalesAssociate", "Active", null, "ewardhougha" },
                    { new Guid("b4b13be2-002a-4966-a3b2-c77c0d82705a"), null, new DateTime(2025, 1, 11, 18, 14, 47, 502, DateTimeKind.Local).AddTicks(654), null, "Valentino LeEstut", "vleestutd@a8.net", "$2a$04$qFYN1FxLDQ7KpYTFqxCUJOe1OAnU4OHWeqejT1IPrLkfjzVe6AWQW", null, "SalesAssociate", "Active", null, "vleestutd" },
                    { new Guid("c0529d4f-2b25-4d7d-b2ec-d55a3c0210c2"), null, new DateTime(2025, 1, 11, 18, 14, 47, 502, DateTimeKind.Local).AddTicks(542), null, "Lee Burnard", "lburnard7@live.com", "$2a$04$SfAGtJ7OCherL5MlaKBj5ut6Sq0.fj0Nmgu/WSZcJmqfClhygYRsC", null, "SalesAssociate", "Active", null, "lburnard7" },
                    { new Guid("c19a64b0-d62d-4d50-994a-cbe3ad8ed97b"), null, new DateTime(2025, 1, 11, 18, 14, 47, 502, DateTimeKind.Local).AddTicks(437), null, "Helyn Carl", "hcarl2@ustream.tv", "$2a$04$/0j3DJV1umEjQt6AjUXs6.jyOTPz6h7MxzD9PgLphpxN8f37LvdIK", null, "SalesAssociate", "Active", null, "hcarl2" },
                    { new Guid("c21c2e8d-a275-4ae7-9ebd-336e16ec57ab"), null, new DateTime(2025, 1, 11, 18, 14, 47, 502, DateTimeKind.Local).AddTicks(581), null, "Dimitri Guisler", "dguisler9@smugmug.com", "$2a$04$IlBv6mYPJP4LNvhcN7.gbO84HvcstwzvWwZokhgnRyzLSvr2SFxYC", null, "SalesAssociate", "Active", null, "dguisler9" },
                    { new Guid("c99ebece-d2c5-4868-8e09-e6210257fa91"), null, new DateTime(2025, 1, 11, 18, 14, 47, 502, DateTimeKind.Local).AddTicks(959), null, "Maren Mullany", "mmullanyr@pagesperso-orange.fr", "$2a$04$YopqILMBP8nTsFfT1.01/O5yZK7wdVdPa1D.vbgRQo38ayaFqlGnS", null, "SalesAssociate", "Active", null, "mmullanyr" },
                    { new Guid("cd5d29de-2225-4a8e-8b52-506bf8f1e995"), null, new DateTime(2025, 1, 11, 18, 14, 47, 502, DateTimeKind.Local).AddTicks(502), null, "Merwin Basili", "mbasili5@google.fr", "$2a$04$rbNiJO3bL8k622TwqlQUMubh7kxVRqMkUCZW6r9v/NsvpdYw8Pjx6", null, "SalesAssociate", "Active", null, "mbasili5" },
                    { new Guid("ce583f0e-8737-406a-9cf4-226eff7b8e55"), null, new DateTime(2025, 1, 11, 18, 14, 47, 502, DateTimeKind.Local).AddTicks(978), null, "Torey Mowbray", "tmowbrays@imdb.com", "$2a$04$3UHAHwshpdPNNeBW3vTwQO4Z2dw/P/.t5Kq3iLwid6A73Yvzf43SK", null, "SalesAssociate", "Active", null, "tmowbrays" },
                    { new Guid("d2135181-9dba-4fe6-b3e3-bde127de8c02"), null, new DateTime(2025, 1, 11, 18, 14, 47, 502, DateTimeKind.Local).AddTicks(479), null, "Madlin Wohlers", "mwohlers4@phpbb.com", "$2a$04$ABckV.1E6enmFXa5V84PHOaPGGkSns9c8lmjTXsFOqKTLxmT0nlYK", null, "SalesAssociate", "Active", null, "mwohlers4" },
                    { new Guid("ed05ae89-9f4d-4393-bd8f-3fbe98cd4ce0"), null, new DateTime(2025, 1, 11, 18, 14, 47, 502, DateTimeKind.Local).AddTicks(797), null, "Liuka Obeney", "lobeneyi@prnewswire.com", "$2a$04$BEgZh/9fSoWmZd6pnw.pD.pSJXnsi9V2GnjPkWLufI4ouHKlGWWBy", null, "SalesAssociate", "Active", null, "lobeneyi" },
                    { new Guid("ee300ab3-85ff-4f92-9839-8fbd92f3147b"), null, new DateTime(2025, 1, 11, 18, 14, 47, 502, DateTimeKind.Local).AddTicks(995), null, "Bank Dabels", "bdabelst@google.es", "$2a$04$wmfyx6v4/seiBuCWNusmJOEsk9l5vALPMYCjReG2CjFLRKFLahLjq", null, "SalesAssociate", "Active", null, "bdabelst" },
                    { new Guid("eecf5fa7-a683-489f-aefb-42933946ce1d"), null, new DateTime(2025, 1, 11, 18, 14, 47, 502, DateTimeKind.Local).AddTicks(560), null, "Arlen Beddows", "abeddows8@howstuffworks.com", "$2a$04$8HJKu7g4fcl9YhLw3jF/jur9rjk5N6ic0dkPc4XetIZqS2AfV9I8e", null, "SalesAssociate", "Active", null, "abeddows8" },
                    { new Guid("f99b60f8-311d-4aa6-b08f-fe14da1e5a38"), null, new DateTime(2025, 1, 11, 18, 14, 47, 502, DateTimeKind.Local).AddTicks(523), null, "Jelene Bevar", "jbevar6@cdc.gov", "$2a$04$lEcVrgXYRzi4Y.KReF9F/.PEv01dSjzfPLAqaWFCmbwb6ms.VXDFS", null, "SalesAssociate", "Active", null, "jbevar6" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("08d1f92a-d16e-449a-a524-2988991098d6"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("16e0e145-8f78-4ea9-bb97-73935fbf671c"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("1c48a372-eb5f-42f7-9399-44855fe8d026"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("2174b032-e122-4f76-958f-c2699a7257ae"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("262b2ee5-2530-4599-b4b2-13ad83556a18"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("2905d4de-a3cf-4c3a-b6f1-a0a7ef3526ed"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("2ac19fc6-7d0e-486f-89b8-0ebf71ea7d46"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("508f45f9-a981-41ef-a1e2-4ac7f9a779c6"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("65ea5436-1ef6-4fc0-9773-df34d2d04643"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("6dc7173c-e46d-4d93-b83d-dc292c674689"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("7a758875-9af4-4977-a6d3-c78d464bfcaa"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("7e0367b3-3ba5-4f52-8ed7-94b15d09a972"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("7eb9106f-e403-4b4b-97ea-8242591be0ad"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("80b5604b-f2b2-4cd0-99d1-9e1d3a833254"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("92eacbf0-5ecf-4d8a-affd-61403c30c62a"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("a98e4e28-0d8a-4bc1-8deb-929ad1731239"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("b020db79-81f9-43a3-84cc-23681aa7246d"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("b2b44bb2-3261-40b4-8319-4054f59c9c8c"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("b4b13be2-002a-4966-a3b2-c77c0d82705a"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("c0529d4f-2b25-4d7d-b2ec-d55a3c0210c2"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("c19a64b0-d62d-4d50-994a-cbe3ad8ed97b"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("c21c2e8d-a275-4ae7-9ebd-336e16ec57ab"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("c99ebece-d2c5-4868-8e09-e6210257fa91"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("cd5d29de-2225-4a8e-8b52-506bf8f1e995"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("ce583f0e-8737-406a-9cf4-226eff7b8e55"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("d2135181-9dba-4fe6-b3e3-bde127de8c02"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("ed05ae89-9f4d-4393-bd8f-3fbe98cd4ce0"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("ee300ab3-85ff-4f92-9839-8fbd92f3147b"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("eecf5fa7-a683-489f-aefb-42933946ce1d"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("f99b60f8-311d-4aa6-b08f-fe14da1e5a38"));

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Admins");

            migrationBuilder.AlterColumn<string>(
                name: "Role",
                table: "Admins",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldDefaultValue: "SalesAssociate");
        }
    }
}
