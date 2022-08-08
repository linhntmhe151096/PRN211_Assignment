using AssigmentPRN211.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace AssigmentPRN211.Logic
{
    public class Rates
    {
        public static double Ratee(int movieid)
        {
            int totalrate=0;
            double? totalcom = 0;
            using (var context = new CenimaDBContext())
            {
                totalrate = context.Rates.Where(m => m.MovieId == movieid).Count();
                totalcom = context.Rates.Where(m => m.MovieId == movieid).Sum(r => r.NumericRating);
            }
               double rate = Math.Round((double)totalcom / totalrate, 2);
            if(rate == 0)
            {
                return 0;
            }
         
            return rate;
        }

        public static int countComment(int personid, int movieid)
        {
            int count = 0;
            using (var context = new CenimaDBContext())
            {
                count = context.Rates.Where(p=>p.PersonId == personid && p.MovieId == movieid).Count();
            }


            return count;
        }
       
    }
}
