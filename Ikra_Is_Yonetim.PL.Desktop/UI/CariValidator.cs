using FluentValidation;
using Ikra_Is_Yonetim.DAL.EntityFramework.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikra_Is_Yonetim.PL.Desktop.UI
{
    public class CariValidator:AbstractValidator<Musteriler>
    {
        public CariValidator()
        {

            RuleFor(sa => sa.Email)
                .EmailAddress()
                .WithErrorCode("SE101")
                .WithMessage("Lütfen geçerli bir email adresi giriniz.");
            RuleFor(s => s.Telefon)
               .NotEmpty()
               .WithErrorCode("H101")               
               .WithMessage("Telefon numarası boş geçilemez.");
            RuleFor(s => s.FirmaAdres)
              .NotEmpty()
              .WithErrorCode("H101")
              .WithMessage("Cari adresi boş geçilemez.");
            RuleFor(s => s.FirmaAdSoyad)
              .NotEmpty()
              .WithErrorCode("H101")
              .WithMessage("Cari adı boş geçilemez.");
            RuleFor(s => s.Telefon)
               .Length(11)
               .WithErrorCode("H202")
               .WithMessage("Telefon numarası 11 haneli olmalıdır.");
            RuleFor(s => s.GunlukYemekSayisi)
             .GreaterThan(0)
             .WithErrorCode("H101")
             .WithMessage("Günlük yemek sayısı 0'dan büyük olmalıdır.");
            RuleFor(s => s.GunlukYemekFiyati)
            .GreaterThan(0m)
            .WithErrorCode("H101")
            .WithMessage("Günlük yemek ücreti 0 tl'den büyük olmalıdır.");
        }
    }
}
