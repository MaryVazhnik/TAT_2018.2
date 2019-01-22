using System;

namespace DEV_8
{
    class Inkover
    {
        ICommand averagePrice;
        ICommand averagePriceType;
        ICommand counAll;
        ICommand countType;

        public Inkover(ICommand averagePrice, ICommand averagePriceType, ICommand counAll, ICommand countType)
        {
            this.averagePrice = averagePrice;
            this.averagePriceType = averagePriceType;
            this.counAll = counAll;
            this.countType = countType;
        }

        public void AveragePrice()
        {
            averagePrice.Execute();
        }

        public void AveragePriceType()
        {
            averagePriceType.Execute();
        }

        public void CountAll()
        {
            counAll.Execute();
        }

        public void CountType()
        {
            countType.Execute();
        }
    }
}