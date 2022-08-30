using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GroupClaims",
                columns: table => new
                {
                    GroupId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClaimId = table.Column<Guid>(type: "uuid", nullable: false)
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
                    Created = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ChangedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    Changed = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
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
                    Created = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ChangedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    Changed = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
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
                    Created = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ChangedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    Changed = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
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
                    TimeStamp = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
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
                    SendDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsSend = table.Column<bool>(type: "boolean", nullable: false),
                    IsUsed = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ChangedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    Changed = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
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
                    Created = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ChangedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    Changed = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
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
                    Created = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ChangedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    Changed = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Translates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClaimId = table.Column<Guid>(type: "uuid", nullable: false),
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ChangedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    Changed = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => new { x.UserId, x.ClaimId });
                });

            migrationBuilder.CreateTable(
                name: "UserGroups",
                columns: table => new
                {
                    GroupId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ChangedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    Changed = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
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
                    BirthDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Gender = table.Column<int>(type: "integer", nullable: false),
                    Address = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    Notes = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "bytea", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "bytea", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp without time zone", nullable: true, defaultValue: new DateTime(2022, 8, 31, 0, 29, 33, 763, DateTimeKind.Local).AddTicks(4396)),
                    ChangedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    Changed = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
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
                    { new Guid("648cd7c0-ee6c-4cb7-82c3-9d5aeee8548d"), null, null, "Save", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Kaydet" },
                    { new Guid("b5c99cb3-0991-4518-a1b2-c20e0980b5b9"), null, null, "Save", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Save" },
                    { new Guid("1dd069de-fb34-4183-9635-2361df53d41f"), null, null, "GroupName", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Grup Adı" },
                    { new Guid("eb9d4f9e-9792-4fb2-ac7a-f42002e62605"), null, null, "GroupName", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Group Name" },
                    { new Guid("0892e1eb-90b9-46b6-b1eb-e7cf973b317d"), null, null, "FullName", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Tam Adı" },
                    { new Guid("fda6bbe7-cedc-4510-a65f-dff4c4a0ce5d"), null, null, "FullName", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Full Name" },
                    { new Guid("2ca6023a-bebe-418a-985d-c7527a1ab301"), null, null, "Address", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Adres" },
                    { new Guid("71f8c95d-ebc2-4a46-8c11-02afeb3c01c4"), null, null, "Address", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Address" },
                    { new Guid("97897b79-582a-454f-bc35-89ad55137278"), null, null, "Notes", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Notlar" },
                    { new Guid("6a5ffedb-e371-426f-a818-54c069f38db5"), null, null, "Notes", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Notes" },
                    { new Guid("af344899-a908-4f34-a4d7-65f8919e2c62"), null, null, "ConfirmPassword", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Parolayı Doğrula" },
                    { new Guid("ea401438-2bec-4269-9198-680cb993d69e"), null, null, "ConfirmPassword", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Confirm Password" },
                    { new Guid("c3180dc9-a42e-4a51-9d1f-6bc0937505bf"), null, null, "Code", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Kod" },
                    { new Guid("89db034b-620f-4165-9bbf-36ec08e74b80"), null, null, "ChangePassword", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Change Password" },
                    { new Guid("a704d73e-c48a-47a6-84b2-25869ee4514f"), null, null, "ChangePassword", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Parola Değiştir" },
                    { new Guid("aad98b91-ae17-4fec-a6a0-bc5ca9d0e2e5"), null, null, "NewPassword", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "New Password:" },
                    { new Guid("b23af6be-1f70-43c7-8d6b-ab9b3c76ff39"), null, null, "NewPassword", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Yeni Parola:" },
                    { new Guid("d62439f1-ff7e-476e-84cc-ece5a89d491c"), null, null, "PasswordSpecialCharacter", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "En Az 1 Simge İçermelidir!" },
                    { new Guid("517098c6-f826-4d9a-87bb-3c473be8839a"), null, null, "PasswordSpecialCharacter", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Must Contain At Least 1 Symbol!" },
                    { new Guid("7d55cd3f-cd8d-473b-b689-672ac85b9a7f"), null, null, "SendPassword", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Yeni Parolanız E-Posta Adresinize Gönderildi." },
                    { new Guid("651aed63-105b-490d-aee6-dcb277458ccb"), null, null, "SendPassword", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Your new password has been sent to your e-mail address." },
                    { new Guid("a7632a80-bf4d-45ee-866c-2127f4c4f014"), null, null, "InvalidCode", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Geçersiz Bir Kod Girdiniz!" },
                    { new Guid("79425b23-2563-4837-8c06-3839ca6f0c15"), null, null, "InvalidCode", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "You Entered An Invalid Code!" },
                    { new Guid("33bad072-f068-44ae-bab4-d11841d9e692"), null, null, "Code", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Code" },
                    { new Guid("88c33f2c-7936-4d60-903e-cf6521a90c35"), null, null, "SmsServiceNotFound", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "SMS Servisine Ulaşılamıyor." },
                    { new Guid("34da00c3-4557-4aa3-a9de-78a3d14e0120"), null, null, "TrueButCellPhone", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Bilgiler doğru. Cep telefonu gerekiyor." },
                    { new Guid("38983496-d989-4c2c-9028-259aa1baea2e"), null, null, "TrueButCellPhone", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "The information is correct. Cell phone is required." },
                    { new Guid("47669c83-91a1-4807-9b34-d4468c154c78"), null, null, "TokenProviderException", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Token Provider boş olamaz!" },
                    { new Guid("d7804e3f-8af7-49a2-8f93-87b290744266"), null, null, "TokenProviderException", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Token Provider cannot be empty!" },
                    { new Guid("635f3748-6d11-4f3d-9ddc-5ec2b692fb98"), null, null, "Unknown", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Bilinmiyor!" },
                    { new Guid("ac7c52cb-3940-4274-a8b4-e3637f7a7c65"), null, null, "Unknown", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Unknown!" },
                    { new Guid("cb420163-9089-4543-957d-117395c9586a"), null, null, "SmsServiceNotFound", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Unable to Reach SMS Service." },
                    { new Guid("64e2e8ee-d6d6-4907-960f-9b237671fa8b"), null, null, "Alias", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Görünen Ad" },
                    { new Guid("1e3740e2-9529-484d-a052-072fcf245d7a"), null, null, "Alias", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Alias" },
                    { new Guid("5c8c66b8-21f0-46d4-a439-db08191cc9a9"), null, null, "Description", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Açıklama" },
                    { new Guid("3b45d807-c146-415d-bc4e-78085410247c"), null, null, "LogList", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "LogList" },
                    { new Guid("9bb3351d-4b19-487d-901c-44076e68d5f0"), null, null, "LogList", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "İşlem Kütüğü" },
                    { new Guid("7ae7e589-f351-4b50-94ad-9575a6c9e6c0"), null, null, "TranslateList", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Translate List" },
                    { new Guid("b77d4cc7-5fea-496f-90b8-8818a44f20e0"), null, null, "TranslateList", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Dil Çeviri Listesi" },
                    { new Guid("9fedbe73-a9a3-4c7d-b93f-a8cdc43f655c"), null, null, "LanguageList", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Language List" },
                    { new Guid("04e3f431-e371-463b-b007-18590c7bb486"), null, null, "LanguageList", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Dil Listesi" },
                    { new Guid("3caf5a5f-b6d2-4cd1-8b67-7bb5eb2426a2"), null, null, "OperationClaimList", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "OperationClaim List" },
                    { new Guid("7ea943e5-7b8e-4897-9625-42d80febaade"), null, null, "OperationClaimList", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Yetki Listesi" },
                    { new Guid("7ed7874e-1bf3-40f5-bc79-85491d51de9c"), null, null, "UserList", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "User List" },
                    { new Guid("3dd5375f-64fe-473f-a700-9d283d7e794f"), null, null, "UserList", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Kullanıcı Listesi" },
                    { new Guid("6215c243-883f-4e13-b727-2b01f06963ca"), null, null, "Add", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Add" },
                    { new Guid("5af130b7-4179-417e-bdb2-9f529a32689d"), null, null, "Add", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Ekle" },
                    { new Guid("d433767b-a76d-4c4b-8a1b-4b51ec4b8ffc"), null, null, "GrupPermissions", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Grup Permissions" },
                    { new Guid("fe6fc2b2-b71a-4ea5-8f98-b737f6fb1db0"), null, null, "GrupPermissions", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Grup Yetkileri" },
                    { new Guid("f3b0e7d4-2c05-470b-ac2e-ecefe9984efa"), null, null, "GroupList", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Group List" },
                    { new Guid("341ea206-144f-4a95-8506-4f2eb4daf8b8"), null, null, "GroupList", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Grup Listesi" },
                    { new Guid("afa651bc-b75b-411e-8742-bd89b8b879b7"), null, null, "Permissions", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "İzinler" },
                    { new Guid("a3cec195-2e7f-4322-9675-579cf6b34c60"), null, null, "Description", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Description" },
                    { new Guid("f0661ce7-ec1f-4fe8-99a5-6fce21c8cb86"), null, null, "Value", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Değer" },
                    { new Guid("3bd440fe-a4ed-4696-9957-7ef0b3daecc9"), null, null, "Value", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Value" },
                    { new Guid("339efe81-7c42-4030-8d81-9ffc472b0a2a"), null, null, "LangCode", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Dil Kodu" },
                    { new Guid("5e6d21de-efe4-4e80-bbe0-a97f176a2ee4"), null, null, "LangCode", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Lang Code" },
                    { new Guid("40daa094-add4-4680-b9ff-7bdc77ac586c"), null, null, "Name", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Adı" },
                    { new Guid("2e15c2cf-8f94-493f-af63-50615a823cc5"), null, null, "PasswordDigit", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "It Must Contain At Least 1 Digit!" },
                    { new Guid("8c2c8031-7e98-4123-9395-421d880d9bd8"), null, null, "Name", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Name" },
                    { new Guid("3c061a84-225a-4d04-b615-13de986a759c"), null, null, "MobilePhones", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Mobile Phone" },
                    { new Guid("7b383321-aba4-490d-85c7-15a1bca89193"), null, null, "NoRecordsFound", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Kayıt Bulunamadı" },
                    { new Guid("9ab97f3b-5ab5-4e19-9bb1-53770e1cf3bb"), null, null, "NoRecordsFound", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "No Records Found" },
                    { new Guid("698cc22b-461f-43cd-9b06-7ed0bacb66fe"), null, null, "Required", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Bu alan zorunludur!" },
                    { new Guid("2db9517a-84a2-4f3c-b91d-1306908aa208"), null, null, "Required", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "This field is required!" },
                    { new Guid("d53a082b-077f-4905-b4ff-deff3e87f8af"), null, null, "Permissions", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Permissions" },
                    { new Guid("49f55700-96b0-4e8b-bb1a-c60f530bbc86"), null, null, "MobilePhones", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Cep Telefonu" },
                    { new Guid("8b2400bd-186c-4afe-a9f9-c43d05cdcd8e"), null, null, "PasswordDigit", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "En Az 1 Rakam İçermelidir!" },
                    { new Guid("9da21341-0ca5-481c-a0ca-071e62320715"), null, null, "PasswordLowercaseLetter", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Must Contain At Least 1 Lowercase Letter!" },
                    { new Guid("7c5164e3-4e00-4e49-b630-0bfc334c2726"), null, null, "PasswordLowercaseLetter", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "En Az 1 Küçük Harf İçermelidir!" },
                    { new Guid("a3deb409-01a8-4dbf-ba87-6556c17a9fa8"), null, null, "Added", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Başarıyla Eklendi." },
                    { new Guid("97e8e13f-c0f5-4bff-8a09-34e451e1768e"), null, null, "AppMenu", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Application" },
                    { new Guid("42d619fc-0226-4bc0-9703-51b0e30fb183"), null, null, "AppMenu", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Uygulama" },
                    { new Guid("6fe0ea27-2579-43d4-9b1b-1f091307071c"), null, null, "Management", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Management" },
                    { new Guid("78398f3a-2ed1-451a-8ba4-38863ea9ca88"), null, null, "Management", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Yönetim" },
                    { new Guid("1ac3574e-56e6-4030-ab0c-3e5346bb6038"), null, null, "TranslateWords", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Translate Words" },
                    { new Guid("71d3e1af-f440-42dd-ad15-712ac2a4f982"), null, null, "TranslateWords", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Dil Çevirileri" },
                    { new Guid("3414d895-00dc-4497-a8d9-43089b35aa14"), null, null, "Languages", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Languages" },
                    { new Guid("d85b8a2a-9a55-471c-8f26-4f1fb1b1e028"), null, null, "Languages", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Diller" },
                    { new Guid("8c88b7d3-3d35-4cde-941f-ea756f79fe98"), null, null, "OperationClaim", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Operation Claim" },
                    { new Guid("43d08270-fb6f-4821-8de4-7a5e1f9949ad"), null, null, "OperationClaim", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Operasyon Yetkileri" },
                    { new Guid("d8f8d673-3a1a-44b2-8188-53090e20c51e"), null, null, "Groups", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Groups" },
                    { new Guid("336cf876-c289-418a-85fd-1f1fb3de3a32"), null, null, "Users", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Users" },
                    { new Guid("32f8010b-95bb-45f4-9563-552e88f98e1d"), null, null, "Create", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Create" },
                    { new Guid("5a0ac35c-6ab8-44a1-9c03-0804197028eb"), null, null, "UsersClaims", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "User's Claims" },
                    { new Guid("64d7df14-c1a1-4b2f-b65b-95429f3872d6"), null, null, "UsersGroups", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "User's Groups" },
                    { new Guid("412ca3fe-1c68-49f9-a35e-5a23af723856"), null, null, "Delete", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Delete" },
                    { new Guid("76743ccd-878e-4031-9148-24a1b4ce627c"), null, null, "Login", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Giriş" },
                    { new Guid("725be0b3-8f85-4f3b-a80d-3338faf4366d"), null, null, "Email", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "E posta" },
                    { new Guid("015157b2-0393-4567-89d5-3d766ffd56d6"), null, null, "Password", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Parola" },
                    { new Guid("cd1e192c-1493-464f-8146-717e0b200868"), null, null, "Update", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Güncelle" },
                    { new Guid("2cdd0f2e-53de-4b3d-bd51-4751b43444c2"), null, null, "Delete", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Sil" },
                    { new Guid("abb3252f-ae18-4581-a3b3-cc82584386eb"), null, null, "UsersGroups", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Kullanıcının Grupları" },
                    { new Guid("2d1b6120-76ce-418f-9bf2-66739761d306"), null, null, "Added", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Successfully Added." },
                    { new Guid("333c2a35-9174-4744-88d3-f6fce25c8d2c"), null, null, "UsersClaims", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Kullanıcının Yetkileri" },
                    { new Guid("3c68afb2-9031-4ea9-bc96-b724c0d778e0"), null, null, "Users", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Kullanıcılar" },
                    { new Guid("154fcebc-78a6-4d8e-bdc1-b33db364117b"), null, null, "Groups", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Gruplar" },
                    { new Guid("4a4daca7-f419-406c-a26e-fd8dd3dac2e9"), null, null, "Login", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Login" },
                    { new Guid("32c8181e-e9b7-4fa0-839f-8344f8df2c58"), null, null, "Email", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Email" },
                    { new Guid("98e00a57-3a6e-47dc-8bf6-2c4a03568b0b"), null, null, "Password", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Password" },
                    { new Guid("02140d08-2260-4e0c-871c-bbb491a94a2f"), null, null, "Update", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Update" },
                    { new Guid("a63da07b-1dcd-40ec-9946-24ff463cf2c2"), null, null, "Create", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Yeni" },
                    { new Guid("93da597a-5957-4b5e-af6a-64d4e3c61cca"), null, null, "DeleteConfirm", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Emin misiniz?" },
                    { new Guid("49f8568c-b912-4eeb-a34d-18359745cd32"), null, null, "Updated", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Başarıyla Güncellendi." },
                    { new Guid("da2c76d5-f31a-4a6f-9817-1026d6d20856"), null, null, "Deleted", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Başarıyla Silindi." },
                    { new Guid("bcdbcf06-1872-471e-a59b-d6639bfde53a"), null, null, "PasswordUppercaseLetter", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Must Contain At Least 1 Capital Letter!" },
                    { new Guid("ea0757cd-fac8-48de-a44d-710eee9e78d7"), null, null, "PasswordUppercaseLetter", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "En Az 1 Büyük Harf İçermelidir!" },
                    { new Guid("da887c58-0ce4-41c0-909a-f30fbb458f0e"), null, null, "PasswordLength", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Must be at least 8 characters long! " },
                    { new Guid("ddcdb660-283b-41b8-835f-9ba617009b40"), null, null, "PasswordLength", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Minimum 8 Karakter Uzunluğunda Olmalıdır!" },
                    { new Guid("ef66fbb7-76e4-44a5-841d-18fda8671115"), null, null, "PasswordEmpty", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Password can not be empty!" },
                    { new Guid("e85b7294-902c-48c3-945e-1972b3f3a479"), null, null, "PasswordEmpty", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Parola boş olamaz!" },
                    { new Guid("a71c00ff-fd09-4a67-b275-c524e6747842"), null, null, "CID", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Citizenship Number" },
                    { new Guid("1d117708-24a7-421d-9162-45c5b76ff0d8"), null, null, "CID", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Vatandaşlık No" },
                    { new Guid("ac7da914-10ba-4873-94ed-a22668388315"), null, null, "WrongCID", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Citizenship Number Not Found In Our System. Please Create New Registration!" },
                    { new Guid("7881d53a-19c1-4309-8a0a-82209e5e0d96"), null, null, "WrongCID", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Vatandaşlık No Sistemimizde Bulunamadı. Lütfen Yeni Kayıt Oluşturun!" },
                    { new Guid("2c8889db-aa43-44d7-b4fc-883597b95956"), null, null, "NameAlreadyExist", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "The Object You Are Trying To Create Already Exists." },
                    { new Guid("744a653c-e632-4667-a277-cab6622ac52f"), null, null, "NameAlreadyExist", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Oluşturmaya Çalıştığınız Nesne Zaten Var." },
                    { new Guid("445157ff-d072-40cd-9334-e425040d9210"), null, null, "SendMobileCode", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Please Enter The Code Sent To You By SMS!" },
                    { new Guid("557569b7-573f-499b-9232-f7b67201beff"), null, null, "SendMobileCode", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Lütfen Size SMS Olarak Gönderilen Kodu Girin!" },
                    { new Guid("67d9f970-77e2-4d19-805c-38d736a7b67c"), null, null, "SuccessfulLogin", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Login to the system is successful." },
                    { new Guid("83609bf3-1c7a-4413-baf7-3e1498b8a5da"), null, null, "SuccessfulLogin", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Sisteme giriş başarılı." },
                    { new Guid("aa8f9fdf-7312-499d-a747-9b9c72cc14b4"), null, null, "PasswordError", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Credentials Failed to Authenticate, Username and / or password incorrect." },
                    { new Guid("17268f46-bb84-402f-aee6-1a6105afd168"), null, null, "Deleted", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Successfully Deleted." },
                    { new Guid("ccc1f256-947f-40d9-95d6-6a85022ebcc6"), null, null, "OperationClaimExists", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Bu operasyon izni zaten mevcut." },
                    { new Guid("f2be768d-83ed-4d38-8bde-5ba8b122582e"), null, null, "OperationClaimExists", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "This operation permit already exists." },
                    { new Guid("249c8d0f-f856-45b6-828b-1d5a971cc4e9"), null, null, "StringLengthMustBeGreaterThanThree", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Lütfen En Az 3 Karakterden Oluşan Bir İfade Girin." },
                    { new Guid("87cacac4-4b1c-458a-8406-6cf03830e387"), null, null, "StringLengthMustBeGreaterThanThree", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Please Enter A Phrase Of At Least 3 Characters." },
                    { new Guid("ca955d5e-3cc0-4920-802a-706246957f15"), null, null, "CouldNotBeVerifyCid", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Kimlik No Doğrulanamadı." },
                    { new Guid("eeb7c0aa-91af-4e56-b79a-a4276079a8af"), null, null, "Updated", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Successfully Updated." },
                    { new Guid("b0591ee6-c660-4b24-a873-3c5a5ede6253"), null, null, "CouldNotBeVerifyCid", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Could not be verify Citizen Id" },
                    { new Guid("47e7d151-81f7-45cb-8d4c-c52c5ca46181"), null, null, "VerifyCid", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Verify Citizen Id" },
                    { new Guid("f3dda3d0-b497-4a67-8b9f-eacca55eeb85"), null, null, "AuthorizationsDenied", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Yetkiniz olmayan bir alana girmeye çalıştığınız tespit edildi." },
                    { new Guid("6dbf59ce-da65-4787-9841-7806d157ba96"), null, null, "AuthorizationsDenied", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "It has been detected that you are trying to enter an area that you do not have authorization." },
                    { new Guid("4b696290-e789-4417-b54b-d8711686ef69"), null, null, "UserNotFound", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Kimlik Bilgileri Doğrulanamadı. Lütfen Yeni Kayıt Ekranını kullanın." },
                    { new Guid("5643f029-af63-47cb-a28a-552e1fc2d9a9"), null, null, "UserNotFound", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Credentials Could Not Verify. Please use the New Registration Screen." },
                    { new Guid("424db20e-e520-4c1c-9294-bbd118142b47"), null, null, "PasswordError", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Kimlik Bilgileri Doğrulanamadı, Kullanıcı adı ve/veya parola hatalı." },
                    { new Guid("1a5acc97-fd94-4b39-aa1a-c5382237d9c6"), null, null, "VerifyCid", null, null, new Guid("00000000-0000-0000-0000-000000000001"), "Kimlik No Doğrulandı." },
                    { new Guid("2ce3c738-09b5-4b48-b7f9-c7612600645c"), null, null, "DeleteConfirm", null, null, new Guid("00000000-0000-0000-0000-000000000002"), "Are you sure?" }
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
