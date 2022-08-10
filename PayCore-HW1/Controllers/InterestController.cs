using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayCore_HW1.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class InterestController : ControllerBase
    {
        [HttpGet] 
        public ActionResult<Interest> Calculator(double balance,double interestRate,double year)
        {
            Interest interest = new Interest();//Interest sınıfından interest adında bir nesne türetildi.
            if((balance < 0 || interestRate < 0 || year < 0))//Gelen değerlerin 0'dan küçük olma durumları kontrol edildi.
            {
                return BadRequest(interest);//Eğer değerlerden biri 0'dan küçük gelirse BadRequest yani 400 Http kodu döndürüldü.
            }
            var compoundInterest = balance * Math.Pow(1 + (interestRate / 100), year);//Bileşik faiz hesaplanıp compountInterest değerine atandı.

            interest.InterestAmount = balance;//interest sınıfının InterestAmount property'sine faize yatırılan para atandı.
            interest.TotalBalance = compoundInterest;//interest sınıfının TotalBalance property'sine faiz hesaplanıp eklendi ve ana para atandı.
            
            return Ok(interest);//Ok durumu interest sınıfı olarak döndürüldü yani Htpp kodu 200 olarak geri dönüş verdi ve interest sınıfı response edildi.
        }
    }
}
