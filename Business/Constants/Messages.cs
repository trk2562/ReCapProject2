using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    //Basit bir mesaj olduğu için sürekli new'lememek adına "static" ekledik.
    //Dipnot: publicler PASCAl KEY gereği değişkenleri büyük harf ile başlar.
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime = "Sistem bakımda.";
        public static string BrandListed = "Markalar listelendi.";
        public static string UserAdded = "Kullanıcı eklendi.";
        public static string UserDeleted = "Kullanıcı silindi.";
        public static string UserListed = "Kullanıcılar listelendi.";
        public static string UserUpdated = "Kullanıcı güncellendi";
        public static string RentalOrderUpdated = "Siparişler güncellendi.";
        public static string RentalOrderListed = "Siparişler listelendi.";
        public static string RentalOrderInvaild = "Sipariş güncellenemedi, araç teslim edilmedi.";
        public static string RentalOrderVaild = "Sipariş güncellendi.";
        public static string RentalOrderAdded = "Sipariş eklendi.";
        public static string RentalOrderDeleted = "Sipariş silindi.";
        public static string CarAdded = "Araç eklendi.";
        public static string CarDeleted = "Araç silindi.";
        public static string CarUpdated = "Araç güncellendi.";
        public static string CarListed = "Araçlar listelendi";
        public static string CustomerAdded = "Müşteri eklendi.";
        public static string CustomerDeleted = "Müşteri silindi.";
        public static string CustomerListed = "Müşleriler listelendi";
        public static string CustomerUpdated = "Müşteri güncellendi";
        public static string ColorListed = "Renkler listelendi.";
    }
}
