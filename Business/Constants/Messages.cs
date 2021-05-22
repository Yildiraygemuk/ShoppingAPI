using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün başarıyla eklendi.";
        public static string ProductUpdated = "Ürün başarıyla güncellendi.";
        public static string ProductDeleted = "Ürün başarıyla silindi.";

        public static string CategoryAdded = "Kategori başarıyla eklendi.";
        public static string CategoryUpdated = "Kategori başarıyla güncellendi.";
        public static string CategoryDeleted = "Kategori başarıyla silindi.";

        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string UserAlreadyExist = "Kullanıcı mevcut";
        public static string PasswordError = "Şifre Hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserRegistered = "Kullanıcı başarıyla kayıt edildi";
        public static string AccesesTokenCreated = "Access Token başarıyla oluşturuldu";
        public static string AuthorizationDenied = "Yetkiniz Yok";

        public static string ProductNameAlreadyExists = "Ürün zaten mevcut";
    }
}
