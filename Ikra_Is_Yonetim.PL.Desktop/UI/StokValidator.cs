using FluentValidation;
using FluentValidation.Results;
using FluentValidation.Validators;
using Ikra_Is_Yonetim.DAL.EntityFramework.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikra_Is_Yonetim.PL.Desktop.UI
{
    public class StokValidator : AbstractValidator<Stoklar>
    {
        private bool FiyatKontrol(decimal giris)
        {
            if (giris > 0) return true;
            else return false;
        }
        public StokValidator()
        {
            RuleFor(s => s.StokAdi)
                .NotEmpty()
                .WithErrorCode("H101")
                .WithMessage("Stok adı boş girilemez");
            RuleFor(f => f.StokKgBirimAlinan)
                  .GreaterThan(0m)
                  .WithErrorCode("H202")
                  .WithMessage("Stok girişi 0 kg'dan büyük olmalı(ör:0.2)");
            RuleFor(f => f.StokTutari)
             .GreaterThan(0.99m)
              .WithErrorCode("H203")
             .WithMessage("Stok giriş fiyatı 1₺'den büyük olmalıdır(ör:1.2)");
            RuleFor(f=>f.StokTutari)
                .ScalePrecision(2, 50, false)
             .WithErrorCode("H303")
             .WithMessage("Stok giriş fiyatı tutarsız");
        }
        protected override bool PreValidate(ValidationContext<Stoklar> context, ValidationResult result)
        {
            return base.PreValidate(context, result);
        }
    }
}
