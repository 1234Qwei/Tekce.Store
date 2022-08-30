using Business.Fakes.Handlers.Languages;
using Business.Fakes.Handlers.Translates;
using Core.Utilities.IoC;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace Business.Helpers
{
    public static class FakeDataMiddlleware
    {
        public static async Task UseDbFakeDataCreator(this IApplicationBuilder app)
        {
            var mediator = ServiceTool.ServiceProvider.GetService<IMediator>();

            await mediator.Send(new CreateLanguageInternalCommand { Code = "tr-TR", Name = "Türkçe" });
            await mediator.Send(new CreateLanguageInternalCommand { Code = "en-EN", Name = "English" });

            await mediator.Send(new CreateTranslateInternalCommand { LangId= new System.Guid("00000000-0000-0000-0000-000000000000"), Code = "Login", Value = "Giriş" });
            await mediator.Send(new CreateTranslateInternalCommand { LangId= new System.Guid("00000000-0000-0000-0000-000000000000"), Code = "Email", Value = "E-posta" });
            await mediator.Send(new CreateTranslateInternalCommand { LangId= new System.Guid("00000000-0000-0000-0000-000000000000"), Code = "Password", Value = "Parola" });
            await mediator.Send(new CreateTranslateInternalCommand { LangId= new System.Guid("00000000-0000-0000-0000-000000000000"), Code = "Update", Value = "Güncelle" });
            await mediator.Send(new CreateTranslateInternalCommand { LangId= new System.Guid("00000000-0000-0000-0000-000000000000"), Code = "Delete", Value = "Sil" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000000"), Code = "UsersGroups", Value = "Kullanıcının Grupları" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000000"), Code = "UsersClaims", Value = "Kullanıcının Yetkileri" });
            await mediator.Send(new CreateTranslateInternalCommand { LangId= new System.Guid("00000000-0000-0000-0000-000000000000"), Code = "Create", Value = "Yeni" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000000"), Code = "Users", Value = "Kullanıcılar" });
            await mediator.Send(new CreateTranslateInternalCommand { LangId= new System.Guid("00000000-0000-0000-0000-000000000000"), Code = "Groups", Value = "Gruplar" });
            await mediator.Send(new CreateTranslateInternalCommand { LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "Login", Value = "Login" });
            await mediator.Send(new CreateTranslateInternalCommand { LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "Email", Value = "Email" });
            await mediator.Send(
                new CreateTranslateInternalCommand { LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "Password", Value = "Password" });
            await mediator.Send(new CreateTranslateInternalCommand { LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "Update", Value = "Update" });
            await mediator.Send(new CreateTranslateInternalCommand { LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "Delete", Value = "Delete" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "UsersGroups", Value = "User's Groups" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "UsersClaims", Value = "User's Claims" });
            await mediator.Send(new CreateTranslateInternalCommand { LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "Create", Value = "Create" });
            await mediator.Send(new CreateTranslateInternalCommand { LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "Users", Value = "Users" });
            await mediator.Send(new CreateTranslateInternalCommand { LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "Groups", Value = "Groups" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000000"), Code = "OperationClaim", Value = "Operasyon Yetkileri" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "OperationClaim", Value = "Operation Claim" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000000"), Code = "Languages", Value = "Diller" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "Languages", Value = "Languages" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000000"), Code = "TranslateWords", Value = "Dil Çevirileri" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000000"), Code = "TranslateWords", Value = "Translate Words" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000000"), Code = "Management", Value = "Yönetim" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "Management", Value = "Management" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000000"), Code = "AppMenu", Value = "Uygulama" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "AppMenu", Value = "App Menu" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000000"), Code = "Added", Value = "Başarıyla Eklendi." });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "Added", Value = "Successfully Added." });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000000"), Code = "Updated", Value = "Başarıyla Güncellendi." });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "Updated", Value = "Successfully Updated." });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000000"), Code = "Deleted", Value = "Başarıyla Silindi." });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "Deleted", Value = "Successfully Deleted." });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000000"), Code = "OperationClaimExists", Value = "Bu operasyon izni zaten mevcut." });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "OperationClaimExists", Value = "This operation permit already exists." });
            await mediator.Send(new CreateTranslateInternalCommand
            {
                LangId= new System.Guid("00000000-0000-0000-0000-000000000000"),
                Code = "StringLengthMustBeGreaterThanThree",
                Value = "Lütfen En Az 3 Karakterden Oluşan Bir İfade Girin."
            });
            await mediator.Send(new CreateTranslateInternalCommand
            {
                LangId= new System.Guid("00000000-0000-0000-0000-000000000001"),
                Code = "StringLengthMustBeGreaterThanThree",
                Value = "Please Enter A Phrase Of At Least 3 Characters."
            });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000000"), Code = "CouldNotBeVerifyCid", Value = "Kimlik No Doğrulanamadı." });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "CouldNotBeVerifyCid", Value = "Could not be verify Citizen Id" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000000"), Code = "VerifyCid", Value = "Kimlik No Doğrulandı." });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "VerifyCid", Value = "Verify Citizen Id" });
            await mediator.Send(new CreateTranslateInternalCommand
            {
                LangId= new System.Guid("00000000-0000-0000-0000-000000000000"),
                Code = "AuthorizationsDenied",
                Value = "Yetkiniz olmayan bir alana girmeye çalıştığınız tespit edildi."
            });
            await mediator.Send(new CreateTranslateInternalCommand
            {
                LangId= new System.Guid("00000000-0000-0000-0000-000000000001"),
                Code = "AuthorizationsDenied",
                Value = "It has been detected that you are trying to enter an area that you do not have authorization."
            });
            await mediator.Send(new CreateTranslateInternalCommand
            {
                LangId= new System.Guid("00000000-0000-0000-0000-000000000000"),
                Code = "UserNotFound",
                Value = "Kimlik Bilgileri Doğrulanamadı. Lütfen Yeni Kayıt Ekranını kullanın."
            });
            await mediator.Send(new CreateTranslateInternalCommand
            {
                LangId= new System.Guid("00000000-0000-0000-0000-000000000001"),
                Code = "UserNotFound",
                Value = "Credentials Could Not Verify. Please use the New Registration Screen."
            });
            await mediator.Send(new CreateTranslateInternalCommand
            {
                LangId= new System.Guid("00000000-0000-0000-0000-000000000000"),
                Code = "PasswordError",
                Value = "Kimlik Bilgileri Doğrulanamadı, Kullanıcı adı ve/veya parola hatalı."
            });
            await mediator.Send(new CreateTranslateInternalCommand
            {
                LangId= new System.Guid("00000000-0000-0000-0000-000000000001"),
                Code = "PasswordError",
                Value = "Credentials Failed to Authenticate, Username and / or password incorrect."
            });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000000"), Code = "SuccessfulLogin", Value = "Sisteme giriş başarılı." });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "SuccessfulLogin", Value = "Login to the system is successful." });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000000"), Code = "SendMobileCode", Value = "Lütfen Size SMS Olarak Gönderilen Kodu Girin!" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "SendMobileCode", Value = "Please Enter The Code Sent To You By SMS!" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000000"), Code = "NameAlreadyExist", Value = "Oluşturmaya Çalıştığınız Nesne Zaten Var." });
            await mediator.Send(new CreateTranslateInternalCommand
            {
                LangId= new System.Guid("00000000-0000-0000-0000-000000000001"),
                Code = "NameAlreadyExist",
                Value = "The Object You Are Trying To Create Already Exists."
            });
            await mediator.Send(new CreateTranslateInternalCommand
            {
                LangId= new System.Guid("00000000-0000-0000-0000-000000000000"),
                Code = "WrongCitizenId",
                Value = "Vatandaşlık No Sistemimizde Bulunamadı. Lütfen Yeni Kayıt Oluşturun!"
            });
            await mediator.Send(new CreateTranslateInternalCommand
            {
                LangId= new System.Guid("00000000-0000-0000-0000-000000000001"),
                Code = "WrongCitizenId",
                Value = "Citizenship Number Not Found In Our System. Please Create New Registration!"
            });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000000"), Code = "CitizenNumber", Value = "Vatandaşlık No" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "CitizenNumber", Value = "Citizenship Number" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000000"), Code = "PasswordEmpty", Value = "Parola boş olamaz!" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "PasswordEmpty", Value = "Password can not be empty!" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000000"), Code = "PasswordLength", Value = "Minimum 8 Karakter Uzunluğunda Olmalıdır!" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "PasswordLength", Value = "Must be at least 8 characters long! " });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000000"), Code = "PasswordUppercaseLetter", Value = "En Az 1 Büyük Harf İçermelidir!" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "PasswordUppercaseLetter", Value = "Must Contain At Least 1 Capital Letter!" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000000"), Code = "PasswordLowercaseLetter", Value = "En Az 1 Küçük Harf İçermelidir!" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "PasswordLowercaseLetter", Value = "Must Contain At Least 1 Lowercase Letter!" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000000"), Code = "PasswordDigit", Value = "En Az 1 Rakam İçermelidir!" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "PasswordDigit", Value = "It Must Contain At Least 1 Digit!" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000000"), Code = "PasswordSpecialCharacter", Value = "En Az 1 Simge İçermelidir!" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "PasswordSpecialCharacter", Value = "Must Contain At Least 1 Symbol!" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000000"), Code = "SendPassword", Value = "Yeni Parolanız E-Posta Adresinize Gönderildi." });
            await mediator.Send(new CreateTranslateInternalCommand
            {
                LangId= new System.Guid("00000000-0000-0000-0000-000000000001"),
                Code = "SendPassword",
                Value = "Your new password has been sent to your e-mail address."
            });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000000"), Code = "InvalidCode", Value = "Geçersiz Bir Kod Girdiniz!" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "InvalidCode", Value = "You Entered An Invalid Code!" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000000"), Code = "SmsServiceNotFound", Value = "SMS Servisine Ulaşılamıyor." });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "SmsServiceNotFound", Value = "Unable to Reach SMS Service." });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000000"), Code = "TrueButCellPhone", Value = "Bilgiler doğru. Cep telefonu gerekiyor." });
            await mediator.Send(new CreateTranslateInternalCommand
            {
                LangId= new System.Guid("00000000-0000-0000-0000-000000000001"),
                Code = "TrueButCellPhone",
                Value = "The information is correct. Cell phone is required."
            });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000000"), Code = "TokenProviderException", Value = "Token Provider boş olamaz!" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "TokenProviderException", Value = "Token Provider cannot be empty!" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000000"), Code = "Unknown", Value = "Bilinmiyor!" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "Unknown", Value = "Unknown!" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000000"), Code = "ChangePassword", Value = "Parola Değiştir" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "ChangePassword", Value = "Change Password" });
            await mediator.Send(new CreateTranslateInternalCommand { LangId= new System.Guid("00000000-0000-0000-0000-000000000000"), Code = "Save", Value = "Kaydet" });
            await mediator.Send(new CreateTranslateInternalCommand { LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "Save", Value = "Save" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000000"), Code = "GroupName", Value = "Grup Adı" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "GroupName", Value = "Group Name" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000000"), Code = "FullName", Value = "Tam Adı" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "FullName", Value = "Full Name" });
            await mediator.Send(new CreateTranslateInternalCommand { LangId= new System.Guid("00000000-0000-0000-0000-000000000000"), Code = "Address", Value = "Adres" });
            await mediator.Send(new CreateTranslateInternalCommand { LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "Address", Value = "Address" });
            await mediator.Send(new CreateTranslateInternalCommand { LangId= new System.Guid("00000000-0000-0000-0000-000000000000"), Code = "Notes", Value = "Notlar" });
            await mediator.Send(new CreateTranslateInternalCommand { LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "Notes", Value = "Notes" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000000"), Code = "ConfirmPassword", Value = "Parola Doğrula" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "ConfirmPassword", Value = "Confirm Password" });
            await mediator.Send(new CreateTranslateInternalCommand { LangId= new System.Guid("00000000-0000-0000-0000-000000000000"), Code = "Code", Value = "Kod" });
            await mediator.Send(new CreateTranslateInternalCommand { LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "Code", Value = "Code" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000000"), Code = "Alias", Value = "Görünen Ad" });
            await mediator.Send(new CreateTranslateInternalCommand { LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "Alias", Value = "Alias" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000000"), Code = "Description", Value = "Açıklama" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "Description", Value = "Description" });
            await mediator.Send(new CreateTranslateInternalCommand { LangId= new System.Guid("00000000-0000-0000-0000-000000000000"), Code = "Value", Value = "Değer" });
            await mediator.Send(new CreateTranslateInternalCommand { LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "Value", Value = "Value" });
            await mediator.Send(
                new CreateTranslateInternalCommand { LangId= new System.Guid("00000000-0000-0000-0000-000000000000"), Code = "LangCode", Value = "Dil Kodu" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "LangCode", Value = "Lang Code" });
            await mediator.Send(new CreateTranslateInternalCommand { LangId= new System.Guid("00000000-0000-0000-0000-000000000000"), Code = "Name", Value = "Adı" });
            await mediator.Send(new CreateTranslateInternalCommand { LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "Name", Value = "Name" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000000"), Code = "MobilePhones", Value = "Cep Telefonu" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "MobilePhones", Value = "Mobile Phone" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000000"), Code = "NoRecordsFound", Value = "Kayıt Bulunamadı" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "NoRecordsFound", Value = "No Records Found" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000000"), Code = "Required", Value = "Bu alan zorunludur!" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "Required", Value = "This field is required!" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000000"), Code = "Permissions", Value = "Permissions" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "Permissions", Value = "İzinler" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000000"), Code = "GroupList", Value = "Grup Listesi" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "GroupList", Value = "Group List" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000000"), Code = "GrupPermissions", Value = "Grup Yetkileri" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "GrupPermissions", Value = "Grup Permissions" });
            await mediator.Send(new CreateTranslateInternalCommand { LangId= new System.Guid("00000000-0000-0000-0000-000000000000"), Code = "Add", Value = "Ekle" });
            await mediator.Send(new CreateTranslateInternalCommand { LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "Add", Value = "Add" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000000"), Code = "UserList", Value = "Kullanıcı Listesi" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "UserList", Value = "User List" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000000"), Code = "OperationClaimList", Value = "Yetki Listesi" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "OperationClaimList", Value = "OperationClaim List" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000000"), Code = "LanguageList", Value = "Dil Listesi" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "LanguageList", Value = "Language List" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000000"), Code = "TranslateList", Value = "Dil Çeviri Listesi" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "TranslateList", Value = "Translate List" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000000"), Code = "LogList", Value = "İşlem Kütüğü" });
            await mediator.Send(new CreateTranslateInternalCommand { LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "LogList", Value = "LogList" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000000"), Code = "DeleteConfirm", Value = "Emin misiniz?" });
            await mediator.Send(new CreateTranslateInternalCommand
            { LangId= new System.Guid("00000000-0000-0000-0000-000000000001"), Code = "DeleteConfirm", Value = "Are you sure?" });
        }
    }
}