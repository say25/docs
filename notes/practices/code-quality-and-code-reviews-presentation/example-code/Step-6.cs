public namespace Discounts.Commons
{
    public static class Constants
    {
        public const int MAXIMUM_DISCOUNT_FOR_LOYALTY = 5;
        public const decimal DISCOUNT_FOR_SIMPLE_CUSTOMERS = 0.1m;
        public const decimal DISCOUNT_FOR_VALUABLE_CUSTOMERS = 0.3m;
        public const decimal DISCOUNT_FOR_MOST_VALUABLE_CUSTOMERS = 0.4m;
    }

    public class DiscountManager
    {
        public decimal ApplyDiscount(decimal price, AccountStatus accountStatus, int timeOfHavingAccountInYears)
        {
            decimal priceAfterDiscount = 0;
            decimal discountForLoyaltyInPercentage = (timeOfHavingAccountInYears > Constants.MAXIMUM_DISCOUNT_FOR_LOYALTY) ? (decimal) Constants.MAXIMUM_DISCOUNT_FOR_LOYALTY / 100 : (decimal) timeOfHavingAccountInYears / 100;
            switch (accountStatus)
            {
                case AccountStatus.NotRegistered:
                    priceAfterDiscount = price;
                    break;
                case AccountStatus.SimpleCustomer:
                    priceAfterDiscount = (price - (Constants.DISCOUNT_FOR_SIMPLE_CUSTOMERS * price));
                    priceAfterDiscount = priceAfterDiscount - (discountForLoyaltyInPercentage * priceAfterDiscount);
                    break;
                case AccountStatus.ValuableCustomer:
                    priceAfterDiscount = (price - (Constants.DISCOUNT_FOR_VALUABLE_CUSTOMERS * price));
                    priceAfterDiscount = priceAfterDiscount - (discountForLoyaltyInPercentage * priceAfterDiscount);
                    break;
                case AccountStatus.MostValuableCustomer:
                    priceAfterDiscount = (price - (Constants.DISCOUNT_FOR_MOST_VALUABLE_CUSTOMERS * price));
                    priceAfterDiscount = priceAfterDiscount - (discountForLoyaltyInPercentage * priceAfterDiscount);
                    break;
                default:
                    throw new NotImplementedException();
            }
            return priceAfterDiscount;
        }
    }
}
