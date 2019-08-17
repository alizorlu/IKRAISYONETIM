using Ikra_Is_Yonetim.DAL.EntityFramework.Tables;
using Iyzipay;
using Iyzipay.Model;
using Iyzipay.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikra_Is_Yonetim._3rdApp.IyzicoManager
{
    public interface IIyzicoPaymentManager
    {
        CheckoutFormInitialize GetPaymentForm(List<Siparisler> siparisler);

        //Ödeme tamamlandığında fatura.pdf geriye döner
        string PaymentMulti(List<Siparisler> siparisler);
    }
    public class IyzicoPayment : IIyzicoPaymentManager
    {
        private Options _option { get; set; }
        public IyzicoPayment()
        {
            _option = new Options() {
                ApiKey= "sandbox-yaeizT9y3QajbIBVK9OlQpOQTKr3wAJK",
                BaseUrl= "https://sandbox-api.iyzipay.com/",
                SecretKey= "sandbox-7zFqCyb250ZOJGlclPuvThpx9ePD5O4g"
            };
        }
        public CheckoutFormInitialize GetPaymentForm(List<Siparisler> siparisler)
        {
            decimal totalUcret = 0m;
            foreach (var item in siparisler)
            {
                totalUcret += item.YemekSayisi * item.Musteri.GunlukYemekFiyati;
            }
            CreateCheckoutFormInitializeRequest request = new CreateCheckoutFormInitializeRequest();
            request.Locale = Locale.TR.ToString();
            request.ConversationId = "123456789";
            request.Price = totalUcret.ToString("0.0");
            request.PaidPrice = totalUcret.ToString("0.0");
            request.Currency = Currency.TRY.ToString();
            request.BasketId = "B67832";
            request.PaymentGroup = PaymentGroup.PRODUCT.ToString();
            request.CallbackUrl = "http://localhost:63013/order/paymentForm";

            var musteri = siparisler.First().Musteri;
            if (musteri == null) return null;
            Buyer buyer = new Buyer();
            buyer.Id = musteri.Id.ToString();
            buyer.Name = musteri.FirmaAdSoyad;
            buyer.Surname = musteri.FirmaAdSoyad;
            buyer.GsmNumber = $"+9{musteri.Telefon}";
            buyer.Email = musteri.Email;
            buyer.IdentityNumber = musteri.Id.ToString();
            buyer.LastLoginDate = musteri.LastLogin.ToString("yyyy-MM-dd HH:mm:ss");
            buyer.RegistrationDate = musteri.LastLogin.ToString("yyyy-MM-dd HH:mm:ss");
            buyer.RegistrationAddress = musteri.FirmaAdres.ToString();
            buyer.Ip = "85.34.78.112";
            buyer.City = "Elazig";
            buyer.Country = "Turkey";
            buyer.ZipCode = "23000";
            request.Buyer = buyer;

            Address billingAddress = new Address();
            billingAddress.ContactName = musteri.FirmaAdSoyad;
            billingAddress.City = "Elazig";
            billingAddress.Country = "Turkey";
            billingAddress.Description = musteri.FirmaAdres;
            billingAddress.ZipCode = "23000";
            request.BillingAddress = billingAddress;
            request.ShippingAddress = billingAddress;


            List<BasketItem> basketItems = new List<BasketItem>();
            foreach (var item in siparisler)
            {
                basketItems.Add(new BasketItem()
                {
                    Id = item.Id.ToString(),
                    Name = $"{item.Yemek.YemekAdi}-{item.Yemek.PorsiyonGr} gr",
                    Category1 = "Yemek",
                    Category2 = "Günlük Yemek",
                    ItemType = BasketItemType.PHYSICAL.ToString(),
                    Price = (item.YemekSayisi * item.Musteri.GunlukYemekFiyati)
                    .ToString("0.00"),

                });
            }
            request.BasketItems = basketItems;
         

            return
                CheckoutFormInitialize.Create(request,this._option);

        }

        public string PaymentMulti(List<Siparisler> siparisler)
        {
            throw new NotImplementedException();
        }
    }
    class IyzicoPaymentManager
    {
    }
}
