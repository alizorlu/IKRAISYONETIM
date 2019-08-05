using FluentValidation;
using Ikra_Is_Yonetim.DAL.EntityFramework.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikra_Is_Yonetim.PL.Desktop.UI
{
    public class MalzemeValidator:AbstractValidator<Malzeme>
    {
        public MalzemeValidator()
        {
            RuleFor(s => s.KullanimKg)
                .GreaterThan(0m)
                .WithErrorCode("H202")
                .WithMessage("Stoktan malzeme kullanımı 0kg'dan büyük olur");
            RuleFor(s => s.Stok)
                  .NotNull()
                  .WithErrorCode("H505")
                  .WithMessage("Malzeme kullanımı için bir stok seçmelisiniz.");
            RuleFor(s => s.KullanimKg)
                .NotNull()
                .LessThanOrEqualTo(sa => sa.Stok.StokKgBirimKalan)
                .WithErrorCode("Özel Hata")
                .WithMessage("Malzeme kullanım miktarı stok kalan miktarından az veya eşit olmalı");
        }
    }
}
