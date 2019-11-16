using OOPStudy.NullAndSpecialCaseAndOptionalObjectDemo;
using OOPStudy.NullAndSpecialCaseAndOptionalObjectDemo.Rules;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPStudy.SpecialCaseDemo
{
    class SpecialCaseDemo
    {
        static void ClaimWarrantyWithConditions(SoldArticle article, bool isInGoodCondition, bool isBroken)
        {
            //DateTime now = DateTime.Now;

            //if (isInGoodCondition && !isBroken &&
            //    article.MoneyBackGuarantee != null &&
            //    article.MoneyBackGuarantee.IsValidOn(now))
            //{
            //    Console.WriteLine("Offer money back.");
            //}

            //if (isBroken &&
            //    article.ExpressWarranty != null &&
            //    article.ExpressWarranty.IsValidOn(now))
            //{
            //    Console.WriteLine("Offer repair.");
            //}
        }

        static void ClaimWarrantyWithoutConditions(SoldArticle article)
        {
            //DateTime now = DateTime.Now;

            //if (article.MoneyBackGuarantee.IsValidOn(now))
            //{
            //    Console.WriteLine("Offer money back.");
            //}

            //if (article.ExpressWarranty.IsValidOn(now))
            //{
            //    Console.WriteLine("Offer repair.");
            //}
        }

        static void ClaimWarrantyTheOOWay(SoldArticle article)
        {
            DateTime now = DateTime.Now;

            article.NotOperational();
            article.MoneyBackGuarantee.Claim(now, () => Console.WriteLine("Offer money back."));
            article.ExpressWarranty.Claim(now, () => Console.WriteLine("Offer repair."));
        }

        static void Demo()
        {
            DateTime sellingDate = new DateTime(2016, 8, 9);
            TimeSpan moneyBackSpan = TimeSpan.FromDays(30);
            TimeSpan warrantySpan = TimeSpan.FromDays(365);

            IWarranty moneyBack = new TimeLimitedWarranty(sellingDate, moneyBackSpan);
            IWarranty expressWarranty = new LifetimeWarranty(sellingDate);

            SoldArticle goods = new SoldArticle(moneyBack, expressWarranty, new CommonWarrantyRulesFactory());
            SoldArticle noMoneyBackGoods = new SoldArticle(VoidWarranty.Value, expressWarranty, new CommonWarrantyRulesFactory());

            ClaimWarrantyWithoutConditions(goods);
            ClaimWarrantyWithoutConditions(noMoneyBackGoods);
            
            Console.ReadLine();
        }

        static void RulesChainingDemo()
        {
            DateTime sellingDate = new DateTime(2016, 8, 9);
            TimeSpan moneyBackSpan = TimeSpan.FromDays(30);
            TimeSpan warrantySpan = TimeSpan.FromDays(365);

            IWarranty moneyBack = new TimeLimitedWarranty(sellingDate, moneyBackSpan);
            IWarranty expressWarranty = new LifetimeWarranty(sellingDate);
            IWarranty circuitryWarranty = new LifetimeWarranty(DateTime.Today);

            SoldArticle article = new SoldArticle(moneyBack, expressWarranty, new DefaultRules());
            article.InstallCircuitry(new Part(DateTime.Now), circuitryWarranty);

            article = new SoldArticle(moneyBack, expressWarranty, new ChristmasRules());
            article.InstallCircuitry(new Part(DateTime.Now), circuitryWarranty);
        }
    }
}
