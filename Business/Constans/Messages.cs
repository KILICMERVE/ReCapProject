using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constans
{
    public static class Messages
    {
        public static string Added = "Ekleme işlemi başarılı";
        public static string CarNameInvalid = "Araba ismi veya fiyatı geçersiz";
        public static string Updated = "Güncelleme başarılı";
        public static string CarUpdatedInvalid = "Araba ismi veya fiyatı geçersiz";
        public static string Deleted = "Silme işlemi başarılı";
        public static string MaintenanceTime="Sistem bakımda";
        public static string CarListed = "Araçlar listelendi";
        public static string BrandListed="Marklar listelendi";
        public static string BrandNameInvalid = "Marka ismi geçersiz";
        public static string ColorNameInvalid="Renk ismi geçersiz";
        public static string UserNameInvalid="Kullanıcı ismi geçersiz";
        public static string UserListed="Kullanıcılar listelendi";
        public static string CustomerListed="Müşteriler listelendi";
        public static string RentalNotAdded;
        public static string CheckIfCarCountOfBrandCorrect = "Bu modelde en fazla 10 araç ekleyebilirsiniz";
        public static string CheckIfCarCountOfNameExists="Bu isimde bir araç zaten var.";
        public static string CarImageLimitExceeded = "Araç için eklenebilecek fotoğraf sınırı aşıldı";
        public static string AuthorizationDenied="Yetkiniz yok";
        public static string AccessTokenCreated="token oluşturuldu";
        public static string UserAlreadyExists="Kullanıcı mevcut";
        public static string SuccessfulLogin="Giriş başarılı";
        public static string PasswordError ="Parola hatalı";
        public static string UserNotFound ="Kullanıcı bulunamadı";
        public static string UserRegistered="Kayıt olundu";
    }
}
