public namespace Discounts.Commons
{
    public static class PriceExtensions
    {
        public static decimal ApplyDiscountForAccountStatus(this decimal price, decimal discountSize)
        {
            return price - (discountSize * price);
        }

        public static decimal ApplyDiscountForTimeOfHavingAccount(this decimal price, int timeOfHavingAccountInYears)
        {
            decimal discountForLoyaltyInPercentage = (timeOfHavingAccountInYears > Constants.MAXIMUM_DISCOUNT_FOR_LOYALTY)
                ? (decimal) Constants.MAXIMUM_DISCOUNT_FOR_LOYALTY / 100
                : (decimal) timeOfHavingAccountInYears / 100;

            return price - (discountForLoyaltyInPercentage * price);
        }
    }

    public class DiscountManager
    {
        public decimal ApplyDiscount(decimal price, AccountStatus accountStatus, int timeOfHavingAccountInYears)
        {
            decimal priceAfterDiscount = 0;
            switch (accountStatus)
            {
                case AccountStatus.NotRegistered:
                    priceAfterDiscount = price;
                    break;
                case AccountStatus.SimpleCustomer:
                    priceAfterDiscount = price.ApplyDiscountForAccountStatus(Constants.DISCOUNT_FOR_SIMPLE_CUSTOMERS)
                                              .ApplyDiscountForTimeOfHavingAccount(timeOfHavingAccountInYears);
                    break;
                case AccountStatus.ValuableCustomer:
                    priceAfterDiscount = price.ApplyDiscountForAccountStatus(Constants.DISCOUNT_FOR_VALUABLE_CUSTOMERS)
                                              .ApplyDiscountForTimeOfHavingAccount(timeOfHavingAccountInYears);
                    break;
                case AccountStatus.MostValuableCustomer:
                    priceAfterDiscount = price.ApplyDiscountForAccountStatus(Constants.DISCOUNT_FOR_MOST_VALUABLE_CUSTOMERS)
                                              .ApplyDiscountForTimeOfHavingAccount(timeOfHavingAccountInYears);
                    break;
                default:
                    throw new NotImplementedException();
            }
            return priceAfterDiscount;
        }
    }
}
