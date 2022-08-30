using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace DataAccess.Concrete.Configurations
{
    public class TranslateEntityConfiguration : BaseConfiguration<Translate>
    {
        public override void Configure(EntityTypeBuilder<Translate> builder)
        {
            builder.Property(x => x.LangId).IsRequired();
            builder.Property(x => x.Code).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Value).HasMaxLength(500).IsRequired();
            builder.HasData(GetTranslates());

            base.Configure(builder);
        }

        private List<Translate> GetTranslates()
        {
            return new List<Translate>()
            {
               new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "Login", Value = "Giriş" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "Email", Value = "E posta" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "Password", Value = "Parola" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "Update", Value = "Güncelle" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "Delete", Value = "Sil" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "UsersGroups", Value = "Kullanıcının Grupları" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "UsersClaims", Value = "Kullanıcının Yetkileri" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "Create", Value = "Yeni" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "Users", Value = "Kullanıcılar" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "Groups", Value = "Gruplar" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000002"), Code = "Login", Value = "Login" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000002"), Code = "Email", Value = "Email" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000002"), Code = "Password", Value = "Password" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000002"), Code = "Update", Value = "Update" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000002"), Code = "Delete", Value = "Delete" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000002"), Code = "UsersGroups", Value = "User's Groups" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000002"), Code = "UsersClaims", Value = "User's Claims" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000002"), Code = "Create", Value = "Create" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000002"), Code = "Users", Value = "Users" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000002"), Code = "Groups", Value = "Groups" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "OperationClaim", Value = "Operasyon Yetkileri" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000002"), Code = "OperationClaim", Value = "Operation Claim" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "Languages", Value = "Diller" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000002"), Code = "Languages", Value = "Languages" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "TranslateWords", Value = "Dil Çevirileri" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000002"), Code = "TranslateWords", Value = "Translate Words" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "Management", Value = "Yönetim" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000002"), Code = "Management", Value = "Management" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "AppMenu", Value = "Uygulama" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000002"), Code = "AppMenu", Value = "Application" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "Added", Value = "Başarıyla Eklendi." },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000002"), Code = "Added", Value = "Successfully Added." },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "Updated", Value = "Başarıyla Güncellendi." },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000002"), Code = "Updated", Value = "Successfully Updated." },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "Deleted", Value = "Başarıyla Silindi." },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000002"), Code = "Deleted", Value = "Successfully Deleted." },
                new Translate
                { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "OperationClaimExists", Value = "Bu operasyon izni zaten mevcut." },
                new Translate
                {
                    Id = Guid.NewGuid(),
                    LangId= new System.Guid("00000000-0000-0000-0000-000000000002"),
                    Code = "OperationClaimExists",
                    Value = "This operation permit already exists."
                },
                new Translate
                {
                    Id = Guid.NewGuid(),
                    LangId= new System.Guid("00000000-0000-0000-0000-000000000001"),
                    Code = "StringLengthMustBeGreaterThanThree",
                    Value = "Lütfen En Az 3 Karakterden Oluşan Bir İfade Girin."
                },
                new Translate
                {
                    Id = Guid.NewGuid(),
                    LangId= new System.Guid("00000000-0000-0000-0000-000000000002"),
                    Code = "StringLengthMustBeGreaterThanThree",
                    Value = "Please Enter A Phrase Of At Least 3 Characters."
                },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "CouldNotBeVerifyCid", Value = "Kimlik No Doğrulanamadı." },
                new Translate
                { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000002"), Code = "CouldNotBeVerifyCid", Value = "Could not be verify Citizen Id" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "VerifyCid", Value = "Kimlik No Doğrulandı." },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000002"), Code = "VerifyCid", Value = "Verify Citizen Id" },
                new Translate
                {
                    Id = Guid.NewGuid(),
                    LangId= new System.Guid("00000000-0000-0000-0000-000000000001"),
                    Code = "AuthorizationsDenied",
                    Value = "Yetkiniz olmayan bir alana girmeye çalıştığınız tespit edildi."
                },
                new Translate
                {
                    Id = Guid.NewGuid(),
                    LangId= new System.Guid("00000000-0000-0000-0000-000000000002"),
                    Code = "AuthorizationsDenied",
                    Value =
                        "It has been detected that you are trying to enter an area that you do not have authorization."
                },
                new Translate
                {
                    Id = Guid.NewGuid(),
                    LangId= new System.Guid("00000000-0000-0000-0000-000000000001"),
                    Code = "UserNotFound",
                    Value = "Kimlik Bilgileri Doğrulanamadı. Lütfen Yeni Kayıt Ekranını kullanın."
                },
                new Translate
                {
                    Id = Guid.NewGuid(),
                    LangId= new System.Guid("00000000-0000-0000-0000-000000000002"),
                    Code = "UserNotFound",
                    Value = "Credentials Could Not Verify. Please use the New Registration Screen."
                },
                new Translate
                {
                    Id = Guid.NewGuid(),
                    LangId= new System.Guid("00000000-0000-0000-0000-000000000001"),
                    Code = "PasswordError",
                    Value = "Kimlik Bilgileri Doğrulanamadı, Kullanıcı adı ve/veya parola hatalı."
                },
                new Translate
                {
                    Id = Guid.NewGuid(),
                    LangId= new System.Guid("00000000-0000-0000-0000-000000000002"),
                    Code = "PasswordError",
                    Value = "Credentials Failed to Authenticate, Username and / or password incorrect."
                },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "SuccessfulLogin", Value = "Sisteme giriş başarılı." },
                new Translate
                { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000002"), Code = "SuccessfulLogin", Value = "Login to the system is successful." },
                new Translate
                {
                    Id = Guid.NewGuid(),
                    LangId= new System.Guid("00000000-0000-0000-0000-000000000001"),
                    Code = "SendMobileCode",
                    Value = "Lütfen Size SMS Olarak Gönderilen Kodu Girin!"
                },
                new Translate
                {
                    Id = Guid.NewGuid(),
                    LangId= new System.Guid("00000000-0000-0000-0000-000000000002"),
                    Code = "SendMobileCode",
                    Value = "Please Enter The Code Sent To You By SMS!"
                },
                new Translate
                {
                    Id = Guid.NewGuid(),
                    LangId= new System.Guid("00000000-0000-0000-0000-000000000001"),
                    Code = "NameAlreadyExist",
                    Value = "Oluşturmaya Çalıştığınız Nesne Zaten Var."
                },
                new Translate
                {
                    Id = Guid.NewGuid(),
                    LangId= new System.Guid("00000000-0000-0000-0000-000000000002"),
                    Code = "NameAlreadyExist",
                    Value = "The Object You Are Trying To Create Already Exists."
                },
                new Translate
                {
                    Id = Guid.NewGuid(),
                    LangId= new System.Guid("00000000-0000-0000-0000-000000000001"),
                    Code = "WrongCID",
                    Value = "Vatandaşlık No Sistemimizde Bulunamadı. Lütfen Yeni Kayıt Oluşturun!"
                },
                new Translate
                {
                    Id = Guid.NewGuid(),
                    LangId= new System.Guid("00000000-0000-0000-0000-000000000002"),
                    Code = "WrongCID",
                    Value = "Citizenship Number Not Found In Our System. Please Create New Registration!"
                },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "CID", Value = "Vatandaşlık No" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000002"), Code = "CID", Value = "Citizenship Number" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "PasswordEmpty", Value = "Parola boş olamaz!" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000002"), Code = "PasswordEmpty", Value = "Password can not be empty!" },
                new Translate
                {
                    Id = Guid.NewGuid(),
                    LangId= new System.Guid("00000000-0000-0000-0000-000000000001"),
                    Code = "PasswordLength",
                    Value = "Minimum 8 Karakter Uzunluğunda Olmalıdır!"
                },
                new Translate
                { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000002"), Code = "PasswordLength", Value = "Must be at least 8 characters long! " },
                new Translate
                {
                    Id = Guid.NewGuid(),
                    LangId= new System.Guid("00000000-0000-0000-0000-000000000001"),
                    Code = "PasswordUppercaseLetter",
                    Value = "En Az 1 Büyük Harf İçermelidir!"
                },
                new Translate
                {
                    Id = Guid.NewGuid(),
                    LangId= new System.Guid("00000000-0000-0000-0000-000000000002"),
                    Code = "PasswordUppercaseLetter",
                    Value = "Must Contain At Least 1 Capital Letter!"
                },
                new Translate
                {
                    Id = Guid.NewGuid(),
                    LangId= new System.Guid("00000000-0000-0000-0000-000000000001"),
                    Code = "PasswordLowercaseLetter",
                    Value = "En Az 1 Küçük Harf İçermelidir!"
                },
                new Translate
                {
                    Id = Guid.NewGuid(),
                    LangId= new System.Guid("00000000-0000-0000-0000-000000000002"),
                    Code = "PasswordLowercaseLetter",
                    Value = "Must Contain At Least 1 Lowercase Letter!"
                },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "PasswordDigit", Value = "En Az 1 Rakam İçermelidir!" },
                new Translate
                { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000002"), Code = "PasswordDigit", Value = "It Must Contain At Least 1 Digit!" },
                new Translate
                { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "PasswordSpecialCharacter", Value = "En Az 1 Simge İçermelidir!" },
                new Translate
                {
                    Id = Guid.NewGuid(),
                    LangId= new System.Guid("00000000-0000-0000-0000-000000000002"),
                    Code = "PasswordSpecialCharacter",
                    Value = "Must Contain At Least 1 Symbol!"
                },
                new Translate
                {
                    Id = Guid.NewGuid(),
                    LangId= new System.Guid("00000000-0000-0000-0000-000000000001"),
                    Code = "SendPassword",
                    Value = "Yeni Parolanız E-Posta Adresinize Gönderildi."
                },
                new Translate
                {
                    Id = Guid.NewGuid(),
                    LangId= new System.Guid("00000000-0000-0000-0000-000000000002"),
                    Code = "SendPassword",
                    Value = "Your new password has been sent to your e-mail address."
                },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "InvalidCode", Value = "Geçersiz Bir Kod Girdiniz!" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000002"), Code = "InvalidCode", Value = "You Entered An Invalid Code!" },
                new Translate
                { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "SmsServiceNotFound", Value = "SMS Servisine Ulaşılamıyor." },
                new Translate
                { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000002"), Code = "SmsServiceNotFound", Value = "Unable to Reach SMS Service." },
                new Translate
                {
                    Id = Guid.NewGuid(),
                    LangId= new System.Guid("00000000-0000-0000-0000-000000000001"),
                    Code = "TrueButCellPhone",
                    Value = "Bilgiler doğru. Cep telefonu gerekiyor."
                },
                new Translate
                {
                    Id = Guid.NewGuid(),
                    LangId= new System.Guid("00000000-0000-0000-0000-000000000002"),
                    Code = "TrueButCellPhone",
                    Value = "The information is correct. Cell phone is required."
                },
                new Translate
                { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "TokenProviderException", Value = "Token Provider boş olamaz!" },
                new Translate
                { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000002"), Code = "TokenProviderException", Value = "Token Provider cannot be empty!" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "Unknown", Value = "Bilinmiyor!" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000002"), Code = "Unknown", Value = "Unknown!" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "NewPassword", Value = "Yeni Parola:" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000002"), Code = "NewPassword", Value = "New Password:" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "ChangePassword", Value = "Parola Değiştir" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000002"), Code = "ChangePassword", Value = "Change Password" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "Save", Value = "Kaydet" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000002"), Code = "Save", Value = "Save" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "GroupName", Value = "Grup Adı" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000002"), Code = "GroupName", Value = "Group Name" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "FullName", Value = "Tam Adı" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000002"), Code = "FullName", Value = "Full Name" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "Address", Value = "Adres" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000002"), Code = "Address", Value = "Address" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "Notes", Value = "Notlar" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000002"), Code = "Notes", Value = "Notes" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "ConfirmPassword", Value = "Parolayı Doğrula" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000002"), Code = "ConfirmPassword", Value = "Confirm Password" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "Code", Value = "Kod" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000002"), Code = "Code", Value = "Code" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "Alias", Value = "Görünen Ad" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000002"), Code = "Alias", Value = "Alias" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "Description", Value = "Açıklama" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000002"), Code = "Description", Value = "Description" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "Value", Value = "Değer" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000002"), Code = "Value", Value = "Value" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "LangCode", Value = "Dil Kodu" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000002"), Code = "LangCode", Value = "Lang Code" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "Name", Value = "Adı" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000002"), Code = "Name", Value = "Name" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "MobilePhones", Value = "Cep Telefonu" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000002"), Code = "MobilePhones", Value = "Mobile Phone" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "NoRecordsFound", Value = "Kayıt Bulunamadı" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000002"), Code = "NoRecordsFound", Value = "No Records Found" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "Required", Value = "Bu alan zorunludur!" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000002"), Code = "Required", Value = "This field is required!" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "Permissions", Value = "Permissions" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000002"), Code = "Permissions", Value = "İzinler" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "GroupList", Value = "Grup Listesi" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000002"), Code = "GroupList", Value = "Group List" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "GrupPermissions", Value = "Grup Yetkileri" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000002"), Code = "GrupPermissions", Value = "Grup Permissions" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "Add", Value = "Ekle" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000002"), Code = "Add", Value = "Add" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "UserList", Value = "Kullanıcı Listesi" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000002"), Code = "UserList", Value = "User List" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "OperationClaimList", Value = "Yetki Listesi" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000002"), Code = "OperationClaimList", Value = "OperationClaim List" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "LanguageList", Value = "Dil Listesi" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000002"), Code = "LanguageList", Value = "Language List" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "TranslateList", Value = "Dil Çeviri Listesi" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000002"), Code = "TranslateList", Value = "Translate List" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "LogList", Value = "İşlem Kütüğü" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000002"), Code = "LogList", Value = "LogList" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "DeleteConfirm", Value = "Emin misiniz?" },
                new Translate { Id = Guid.NewGuid(), LangId= new System.Guid("00000000-0000-0000-0000-000000000002"), Code = "DeleteConfirm", Value = "Are you sure?" }
            };
        }
    }
}