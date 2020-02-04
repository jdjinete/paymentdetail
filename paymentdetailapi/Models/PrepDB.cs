using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace paymentdetailapi.Models{

    public static class PrepDB{

        public static void PrepPopulation(IApplicationBuilder app){
            
            using (var serviceScope = app.ApplicationServices.CreateScope()){

                SeedData(serviceScope.ServiceProvider.GetService<PaymentDetailContext>());
            }

        }

        public static void SeedData(PaymentDetailContext context){
            Console.WriteLine("Appling migrations");
            context.Database.Migrate();
            if(!context.PaymentDetails.Any()){
                Console.WriteLine("seeding data");
                context.PaymentDetails.AddRange(
                    new PaymentDetail(){ CardName="Jesus Jinete", CardNumber="1234567890123456",CVV="123",ExpirationDate="12/12"},
                    
                    new PaymentDetail(){ CardName="Other Pete", CardNumber="9994567890123999",CVV="124",ExpirationDate="12/11"}
                );

            }else{
                Console.WriteLine("Already have data- not seeding");
            }
        }
    }
}