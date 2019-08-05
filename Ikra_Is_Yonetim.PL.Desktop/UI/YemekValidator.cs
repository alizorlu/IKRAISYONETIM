using FluentValidation;
using Ikra_Is_Yonetim.DAL.EntityFramework.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikra_Is_Yonetim.PL.Desktop.UI
{
    
    public class YemekValidator : AbstractValidator<Yemekler>
    {
        public YemekValidator()
        {
            RuleFor(s => s.YemekAdi)
                .NotEmpty()
                .WithErrorCode("H101")
                .WithMessage("Yemek adı boş olamaz");
            RuleFor(s => s.PorsiyonGr)
                .GreaterThan(0m)
                .WithErrorCode("H202")
                .WithMessage("Porsiyon miktarı 0gr'dan büyük olur");

            RuleFor(s => s.Malzemeler)
                 .NotNull().
                 WithErrorCode("H303")
                 .WithMessage("Malzemeler listesi boş olamaz");

        }
    }
}
