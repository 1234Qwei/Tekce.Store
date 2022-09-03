using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GroupClaims",
                columns: table => new
                {
                    GroupId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClaimId = table.Column<Guid>(type: "uuid", nullable: false),
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ChangedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    Changed = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupClaims", x => new { x.GroupId, x.ClaimId });
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    GroupName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ChangedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    Changed = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    Code = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ChangedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    Changed = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    Pid = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ChangedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    Changed = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Logs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    MessageTemplate = table.Column<string>(type: "text", nullable: true),
                    Level = table.Column<string>(type: "text", nullable: true),
                    TimeStamp = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Exception = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MobileLogins",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Provider = table.Column<int>(type: "integer", nullable: false),
                    ExternalUserId = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    Code = table.Column<int>(type: "integer", maxLength: 50, nullable: false),
                    SendDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsSend = table.Column<bool>(type: "boolean", nullable: false),
                    IsUsed = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ChangedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    Changed = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MobileLogins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperationClaims",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Alias = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ChangedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    Changed = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Translates",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    LangId = table.Column<Guid>(type: "uuid", nullable: false),
                    Code = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Value = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ChangedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    Changed = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Translates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClaimId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ChangedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    Changed = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => new { x.Id, x.UserId, x.ClaimId });
                });

            migrationBuilder.CreateTable(
                name: "UserGroups",
                columns: table => new
                {
                    GroupId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ChangedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    Changed = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserGroups", x => new { x.UserId, x.GroupId });
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CitizenId = table.Column<long>(type: "bigint", nullable: false),
                    FullName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    RefreshToken = table.Column<string>(type: "text", nullable: true),
                    MobilePhones = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    Status = table.Column<bool>(type: "boolean", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Gender = table.Column<int>(type: "integer", nullable: false),
                    Address = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    Notes = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "bytea", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "bytea", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, defaultValue: new DateTime(2022, 9, 3, 17, 51, 11, 917, DateTimeKind.Local).AddTicks(8950)),
                    ChangedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    Changed = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Changed", "ChangedBy", "Code", "Created", "CreatedBy", "Name" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), null, null, "tr-TR", null, null, "Türkçe" },
                    { new Guid("00000000-0000-0000-0000-000000000002"), null, null, "en-US", null, null, "English" }
                });

            migrationBuilder.InsertData(
                table: "Translates",
                columns: new[] { "Id", "Changed", "ChangedBy", "Code", "Created", "CreatedBy", "LangId", "Value" },
                values: new object[,]
                {
                    { new Guid("013a7ba9-0839-43d8-8622-46e1cc36b06d"), null, null, "UsersClaims", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Kullanıcının Yetkileri" },
                    { new Guid("034364d2-a01f-4302-a7b5-e951d5950ff8"), null, null, "TrueButCellPhone", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "The information is correct. Cell phone is required." },
                    { new Guid("05e45e43-7c8a-428a-a2bc-b5dab2fd35c1"), null, null, "PasswordLowercaseLetter", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Must Contain At Least 1 Lowercase Letter!" },
                    { new Guid("0a2facd0-4bc4-4094-aca7-a68559e6d10f"), null, null, "Update", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Update" },
                    { new Guid("0b0589a0-f4cd-404a-b757-c68f0724319e"), null, null, "CouldNotBeVerifyCid", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Could not be verify Citizen Id" },
                    { new Guid("0e407368-440e-48dc-8072-e5aff375f191"), null, null, "DeleteConfirm", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Are you sure?" },
                    { new Guid("0f888893-eeac-4e1a-bb1e-060e389de08a"), null, null, "SendMobileCode", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Lütfen Size SMS Olarak Gönderilen Kodu Girin!" },
                    { new Guid("10e85791-f77e-4e68-af93-454a3418ed15"), null, null, "StringLengthMustBeGreaterThanThree", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Please Enter A Phrase Of At Least 3 Characters." },
                    { new Guid("14d885d9-31a0-409f-a6ee-a53f94fb64a3"), null, null, "OperationClaimExists", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Bu operasyon izni zaten mevcut." },
                    { new Guid("1bf7c9c9-f246-4b1b-9cd9-c6a9e1531d48"), null, null, "MobilePhones", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Mobile Phone" },
                    { new Guid("1e704e78-8dcb-4eb4-bb26-10d4b9f76d49"), null, null, "LogList", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "LogList" },
                    { new Guid("1f498a9f-d573-419d-8c05-b25fa38916d4"), null, null, "GroupName", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Grup Adı" },
                    { new Guid("22956e88-5aeb-4c45-b9f9-986dcd3e4bf7"), null, null, "Notes", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Notlar" },
                    { new Guid("233e4da5-a506-416d-b573-00d43bbdcd49"), null, null, "Create", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Create" },
                    { new Guid("25ad6665-690b-4dfb-b84f-01c273c3d1fe"), null, null, "NameAlreadyExist", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Oluşturmaya Çalıştığınız Nesne Zaten Var." },
                    { new Guid("29caa88a-7f63-4f6e-a0f0-19891ba8705a"), null, null, "FullName", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Tam Adı" },
                    { new Guid("2b1bd578-8973-4005-b63d-6b7361b57ac7"), null, null, "SmsServiceNotFound", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Unable to Reach SMS Service." },
                    { new Guid("2dbf2550-3925-4872-8c46-4ba51239a735"), null, null, "VerifyCid", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Verify Citizen Id" },
                    { new Guid("2f9e9eb0-b89f-4050-8e9f-4b540ffb9ea8"), null, null, "StringLengthMustBeGreaterThanThree", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Lütfen En Az 3 Karakterden Oluşan Bir İfade Girin." },
                    { new Guid("2fe1a353-8415-42e9-a9a5-40a9b2a2fcc3"), null, null, "Management", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Yönetim" },
                    { new Guid("337f5398-c1fd-49b2-a7db-7855b4098ddb"), null, null, "UserNotFound", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Credentials Could Not Verify. Please use the New Registration Screen." },
                    { new Guid("33bf6e9a-827e-40d6-bf91-69287a614131"), null, null, "Alias", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Alias" },
                    { new Guid("33d9bedc-ba44-4005-a337-98655be7c75c"), null, null, "Permissions", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Permissions" },
                    { new Guid("35094886-a959-4aa4-ab6f-ba278fd3e4c2"), null, null, "VerifyCid", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Kimlik No Doğrulandı." },
                    { new Guid("3543189f-b9cb-4eb0-b60c-46f158ac52d7"), null, null, "PasswordDigit", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "It Must Contain At Least 1 Digit!" },
                    { new Guid("362eeb42-78d6-4521-85b9-3dfa266cc508"), null, null, "Name", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Name" },
                    { new Guid("3641fdb9-1328-472b-b860-be9c9068a529"), null, null, "PasswordError", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Credentials Failed to Authenticate, Username and / or password incorrect." },
                    { new Guid("367dd424-398c-47bb-a96e-4f4c13b71459"), null, null, "Deleted", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Başarıyla Silindi." },
                    { new Guid("38957c5a-53f4-417c-a860-f56b814fd256"), null, null, "WrongCID", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Citizenship Number Not Found In Our System. Please Create New Registration!" },
                    { new Guid("395c3f3a-c837-4621-9c35-a63d8bc2e783"), null, null, "Management", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Management" },
                    { new Guid("3c10378e-a38f-4a84-ae8c-eacb94e7fcdc"), null, null, "ChangePassword", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Parola Değiştir" },
                    { new Guid("3e3c9085-9375-4362-b0ef-e8145a6c3a50"), null, null, "PasswordSpecialCharacter", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "En Az 1 Simge İçermelidir!" },
                    { new Guid("42601b4c-0d3b-4e0a-85f5-a6e02589a60a"), null, null, "GroupList", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Grup Listesi" },
                    { new Guid("427f092b-4498-4f3a-b0e4-6995562d57fa"), null, null, "PasswordUppercaseLetter", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "En Az 1 Büyük Harf İçermelidir!" },
                    { new Guid("4289222e-22b8-43fe-b1bd-2951806ca16a"), null, null, "AppMenu", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Application" },
                    { new Guid("4464ac2e-2e3c-4717-b272-2a0c1be011fa"), null, null, "Address", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Address" },
                    { new Guid("44ab149a-c4ea-4a64-a027-e8fb98b74fd5"), null, null, "PasswordError", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Kimlik Bilgileri Doğrulanamadı, Kullanıcı adı ve/veya parola hatalı." },
                    { new Guid("45e55b4e-f6f7-4d59-9265-d52356e010ae"), null, null, "Code", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Code" },
                    { new Guid("46c0e8f9-4e22-4d40-9f1b-18ef9b5878f1"), null, null, "SuccessfulLogin", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Sisteme giriş başarılı." },
                    { new Guid("477bf374-e326-4100-a99b-4812308ff56e"), null, null, "SendPassword", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Yeni Parolanız E-Posta Adresinize Gönderildi." },
                    { new Guid("4c310082-5b3f-4cd9-8181-7e24fddb2e11"), null, null, "Updated", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Successfully Updated." },
                    { new Guid("4c5f7735-c44e-450b-95ef-986af57595e5"), null, null, "Deleted", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Successfully Deleted." },
                    { new Guid("4d0fae81-9798-4790-82ee-ddb2aea0b760"), null, null, "Users", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Kullanıcılar" },
                    { new Guid("4e2ddcee-9598-4958-8308-5187dc9f4e9c"), null, null, "Required", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Bu alan zorunludur!" },
                    { new Guid("4e45438f-2fd3-4f71-b11c-de07ea79437a"), null, null, "DeleteConfirm", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Emin misiniz?" },
                    { new Guid("4f0cd345-79c6-402a-a455-deba147e609e"), null, null, "Login", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Login" },
                    { new Guid("4f7a681e-0d5d-4c5b-9a9e-e85f7df65961"), null, null, "GrupPermissions", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Grup Permissions" },
                    { new Guid("50d8bfab-33b6-46ef-8168-39a6f8743db3"), null, null, "UserList", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Kullanıcı Listesi" },
                    { new Guid("51984db9-958f-4a11-842d-acd106976b15"), null, null, "PasswordLength", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Must be at least 8 characters long! " },
                    { new Guid("534ee674-f5c8-4764-a602-9582c896cca9"), null, null, "Added", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Successfully Added." },
                    { new Guid("53fc4e1b-5de8-4d48-b81b-1f2458829537"), null, null, "Required", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "This field is required!" },
                    { new Guid("57a5ec1a-a281-4bc0-afee-6f315f7bd1af"), null, null, "Create", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Yeni" },
                    { new Guid("5bb4482e-ec50-4cb7-950f-49ead7d4ce29"), null, null, "NewPassword", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "New Password:" },
                    { new Guid("5c57297f-585d-41e6-bb1a-670a6b523287"), null, null, "Unknown", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Unknown!" },
                    { new Guid("5dbaaeb8-ba0b-4022-9261-ec45789b4789"), null, null, "OperationClaimExists", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "This operation permit already exists." },
                    { new Guid("6428e509-d82c-4683-9148-94e5a398a9d1"), null, null, "Add", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Ekle" },
                    { new Guid("64ea33a5-fa13-4820-9484-e49206009f93"), null, null, "Added", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Başarıyla Eklendi." },
                    { new Guid("66b3c7e4-dae1-4e10-b387-774cad442870"), null, null, "GrupPermissions", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Grup Yetkileri" },
                    { new Guid("67a91588-f63c-4fe8-a7f1-c83bd5c91b46"), null, null, "Login", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Giriş" },
                    { new Guid("68dc4b37-71b5-405a-ba44-21276be04ce1"), null, null, "NameAlreadyExist", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "The Object You Are Trying To Create Already Exists." },
                    { new Guid("6987697d-fa42-4a03-a6cb-bff0ae26dcfe"), null, null, "Languages", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Diller" },
                    { new Guid("69d1041f-92e4-4d2d-a50a-2b158ed82cf5"), null, null, "PasswordEmpty", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Parola boş olamaz!" },
                    { new Guid("6ac74305-bcf9-4af7-8121-7ced8538c8dc"), null, null, "GroupList", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Group List" },
                    { new Guid("6c166cbf-25cb-4b11-a0b5-156bef19af57"), null, null, "AuthorizationsDenied", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Yetkiniz olmayan bir alana girmeye çalıştığınız tespit edildi." },
                    { new Guid("6c18b231-10bd-4823-b2a3-e6994eb299a7"), null, null, "PasswordUppercaseLetter", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Must Contain At Least 1 Capital Letter!" },
                    { new Guid("6df7210a-a96a-49b1-88ee-ab7c677190a5"), null, null, "FullName", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Full Name" },
                    { new Guid("6ea9cf4f-c373-47b3-aee2-d7e1e7a7eb2e"), null, null, "TranslateWords", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Translate Words" },
                    { new Guid("6ffcf7d6-8b05-4a79-81d9-c21f93e6b1b8"), null, null, "Password", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Parola" },
                    { new Guid("70236ef5-e6da-405e-8714-2471c039dff8"), null, null, "Permissions", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "İzinler" },
                    { new Guid("718e6779-c256-462b-a09b-85a836fe8237"), null, null, "LangCode", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Lang Code" },
                    { new Guid("71eee4d6-6c30-4b9d-a808-1e544aa2d38f"), null, null, "Value", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Değer" },
                    { new Guid("726e00cc-d6eb-4f88-9ba6-43ad47d0a6b6"), null, null, "NewPassword", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Yeni Parola:" },
                    { new Guid("7425e542-24c1-4f16-b034-76e327fbe817"), null, null, "Save", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Kaydet" },
                    { new Guid("74c6b1b0-f295-4dd8-a06a-4f291464c2f9"), null, null, "LanguageList", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Dil Listesi" },
                    { new Guid("78212d3e-cb08-4432-b616-6b33f73f10e3"), null, null, "Notes", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Notes" },
                    { new Guid("7a1329a6-fc6b-49d2-9030-27fb58cc6da1"), null, null, "CouldNotBeVerifyCid", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Kimlik No Doğrulanamadı." },
                    { new Guid("7daed0fc-d389-4f3d-8fea-c932d0059352"), null, null, "Name", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Adı" },
                    { new Guid("80e3f153-fbb0-49b7-9d93-4051eb53ef4f"), null, null, "Email", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "E posta" },
                    { new Guid("80e64156-3296-4f62-9537-6709f9d853f2"), null, null, "TranslateWords", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Dil Çevirileri" },
                    { new Guid("816b1c16-2a00-4542-8cd0-3de8322d6309"), null, null, "OperationClaimList", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "OperationClaim List" },
                    { new Guid("84b68c50-ded4-42da-a03b-b4bbd2c86bad"), null, null, "ChangePassword", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Change Password" },
                    { new Guid("84db0902-a581-4c97-bb7e-b64cec24b66d"), null, null, "OperationClaimList", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Yetki Listesi" },
                    { new Guid("855cf178-4e53-418c-b40a-7d8bcaddb111"), null, null, "Password", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Password" },
                    { new Guid("89983521-3755-46d0-bcec-2cf7605815c0"), null, null, "CID", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Citizenship Number" },
                    { new Guid("914f962b-ded6-4b64-ba01-514fb4b7db84"), null, null, "NoRecordsFound", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "No Records Found" },
                    { new Guid("91b6712f-d2f6-4911-904c-0bf58f62b571"), null, null, "UsersClaims", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "User's Claims" },
                    { new Guid("92afe69e-8bc0-45d6-8f56-b4a78f65ac5f"), null, null, "SendMobileCode", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Please Enter The Code Sent To You By SMS!" },
                    { new Guid("92be6481-5e61-43ef-92c9-fcfd858dd9f6"), null, null, "Groups", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Groups" },
                    { new Guid("982172c2-cc96-4267-8901-3a209c2009cb"), null, null, "Email", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Email" },
                    { new Guid("98a94961-439f-44f4-bf23-6e518655393b"), null, null, "TranslateList", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Translate List" },
                    { new Guid("a10fa7db-d440-4a8d-91fc-e10b0b72b1b9"), null, null, "Languages", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Languages" },
                    { new Guid("a1e9797e-c489-4db5-ac3a-ba896857379d"), null, null, "InvalidCode", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Geçersiz Bir Kod Girdiniz!" },
                    { new Guid("a701c71a-2bfe-4b46-899a-0d42901910e6"), null, null, "Update", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Güncelle" },
                    { new Guid("ab053920-92d7-4f33-b7a5-20968396c414"), null, null, "UserNotFound", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Kimlik Bilgileri Doğrulanamadı. Lütfen Yeni Kayıt Ekranını kullanın." },
                    { new Guid("ac328a4d-a592-4063-b2af-1c01877bd07d"), null, null, "UsersGroups", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "User's Groups" },
                    { new Guid("ac4d9f4b-c2b4-4377-8b4c-9ae17816a0fd"), null, null, "PasswordEmpty", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Password can not be empty!" },
                    { new Guid("aca0834b-56ae-4c4a-89a7-7ec8b6fd8bdc"), null, null, "OperationClaim", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Operation Claim" },
                    { new Guid("ad09e4fe-ed0e-42fb-a9ab-7f8841211a4d"), null, null, "Save", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Save" },
                    { new Guid("adc9d9be-642d-41ee-855a-45537af55af7"), null, null, "Users", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Users" },
                    { new Guid("afb00f47-ca22-4ddf-a1dc-9311ed68cbf3"), null, null, "AuthorizationsDenied", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "It has been detected that you are trying to enter an area that you do not have authorization." },
                    { new Guid("b18c2e27-1075-4ecb-a88e-07975b1d19a8"), null, null, "WrongCID", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Vatandaşlık No Sistemimizde Bulunamadı. Lütfen Yeni Kayıt Oluşturun!" },
                    { new Guid("b5e793bd-8fdf-4cb7-b38a-9f7443b5af9a"), null, null, "Description", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Description" },
                    { new Guid("b988a369-d413-4da6-a738-34c09a999616"), null, null, "Address", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Adres" },
                    { new Guid("b9bf3e22-8f6c-44cf-a60a-69f5c7083ada"), null, null, "InvalidCode", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "You Entered An Invalid Code!" },
                    { new Guid("baefbda2-234d-4001-a1ff-67073a782309"), null, null, "PasswordDigit", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "En Az 1 Rakam İçermelidir!" },
                    { new Guid("bc3db746-ab46-4368-89cc-c2e7da2800c5"), null, null, "LanguageList", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Language List" },
                    { new Guid("bcb84637-00d2-4d73-8c00-fb923bb9e4a3"), null, null, "SendPassword", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Your new password has been sent to your e-mail address." },
                    { new Guid("bd87bf74-0ea6-443e-88fc-e15fa60bb9b1"), null, null, "Updated", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Başarıyla Güncellendi." },
                    { new Guid("bfc8c8b4-4ae6-4f27-8307-8671434d312e"), null, null, "Alias", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Görünen Ad" },
                    { new Guid("c0d3fc59-07e8-4a1c-9da9-c21c4096bb09"), null, null, "ConfirmPassword", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Parolayı Doğrula" },
                    { new Guid("c21cbbb7-b546-446e-8fd1-95f8918d1111"), null, null, "TrueButCellPhone", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Bilgiler doğru. Cep telefonu gerekiyor." },
                    { new Guid("c3da3b2b-1363-48de-b276-b1708ab42695"), null, null, "UserList", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "User List" },
                    { new Guid("c96aecb2-8d95-4194-a935-c29fc342a6a6"), null, null, "NoRecordsFound", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Kayıt Bulunamadı" },
                    { new Guid("d0d54f9f-4068-41f4-a275-4b8ec51d8c43"), null, null, "Delete", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Sil" },
                    { new Guid("d1bc350e-a6c4-417f-bf43-0b9054327e4c"), null, null, "Description", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Açıklama" },
                    { new Guid("d2997564-39d1-4fcf-b76a-a4d341283acb"), null, null, "ConfirmPassword", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Confirm Password" },
                    { new Guid("d3b0ea13-8fd0-4bcd-97b6-acf95ef5a361"), null, null, "TranslateList", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Dil Çeviri Listesi" },
                    { new Guid("d584c5c3-bd72-4d0e-98e9-f90fbb742af2"), null, null, "AppMenu", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Uygulama" },
                    { new Guid("d5d72c4c-d7d0-4d55-8ad3-6a7130945a77"), null, null, "Code", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Kod" },
                    { new Guid("d65073c1-1f8c-4d0d-8e98-00ed825fc530"), null, null, "GroupName", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Group Name" },
                    { new Guid("d6b7a2f7-ffcf-4306-b39d-06d02c68275d"), null, null, "SmsServiceNotFound", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "SMS Servisine Ulaşılamıyor." },
                    { new Guid("d9b6db3d-cbac-4778-a0c6-5b70c71f656e"), null, null, "LangCode", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Dil Kodu" },
                    { new Guid("dd7dadc2-a942-4968-b170-fc0ce9a032de"), null, null, "CID", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Vatandaşlık No" },
                    { new Guid("e1533612-c1fc-4d88-8014-eb779387b915"), null, null, "UsersGroups", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Kullanıcının Grupları" },
                    { new Guid("e195d01f-0c4c-4247-b551-fb5b41c08725"), null, null, "LogList", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "İşlem Kütüğü" },
                    { new Guid("e39b570a-d485-4408-a79e-c41801bd0c61"), null, null, "Unknown", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Bilinmiyor!" },
                    { new Guid("e4f6f0ba-5f0a-4368-b0eb-e2a820a3b86b"), null, null, "PasswordLowercaseLetter", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "En Az 1 Küçük Harf İçermelidir!" },
                    { new Guid("e5588741-9469-4758-b57d-051280034679"), null, null, "Delete", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Delete" },
                    { new Guid("e5820841-bc43-4591-9810-00b2d90381e8"), null, null, "Groups", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Gruplar" },
                    { new Guid("e59b4cf7-700a-4861-a23a-006f778c2896"), null, null, "OperationClaim", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Operasyon Yetkileri" },
                    { new Guid("e7d57b1b-f533-42a8-85ae-5200682177b3"), null, null, "Add", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Add" },
                    { new Guid("e9db04b9-6042-4452-a67a-fee3f3920bb2"), null, null, "PasswordSpecialCharacter", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Must Contain At Least 1 Symbol!" },
                    { new Guid("ea312dd9-92ba-4ace-b303-a4622db40137"), null, null, "TokenProviderException", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Token Provider boş olamaz!" },
                    { new Guid("ea55f696-d610-4f8d-9a35-f129a98e08a6"), null, null, "SuccessfulLogin", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Login to the system is successful." },
                    { new Guid("f6aa55a6-b153-493a-967d-1503e659cae1"), null, null, "Value", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Value" },
                    { new Guid("f6afdb72-9f41-4cbb-8f79-64abc1640924"), null, null, "PasswordLength", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Minimum 8 Karakter Uzunluğunda Olmalıdır!" },
                    { new Guid("f995bc49-c7d9-4ba5-a17f-d81896cbbe17"), null, null, "MobilePhones", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Cep Telefonu" },
                    { new Guid("fb57c7b8-ae9f-4bb3-9f00-ca9fb7538058"), null, null, "TokenProviderException", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Token Provider cannot be empty!" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MobileLogins_ExternalUserId_Provider",
                table: "MobileLogins",
                columns: new[] { "ExternalUserId", "Provider" });

            migrationBuilder.CreateIndex(
                name: "IX_Users_CitizenId",
                table: "Users",
                column: "CitizenId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_MobilePhones",
                table: "Users",
                column: "MobilePhones");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GroupClaims");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Logs");

            migrationBuilder.DropTable(
                name: "MobileLogins");

            migrationBuilder.DropTable(
                name: "OperationClaims");

            migrationBuilder.DropTable(
                name: "Translates");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserGroups");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
