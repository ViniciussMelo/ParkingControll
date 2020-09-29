namespace ParkingControll.Services
{
    public static class AmountService
    {
        public const double FirstHourPrice = 2.00;
        public const double AdditionalPrice = 1.00;

        #region TotalPrice
        public static double TotalPrice(double totalHours)
        {
            var totalPrice = FirstHourPrice;

            if (totalHours <= 1) return totalPrice;

            return totalPrice + (totalHours * AdditionalPrice);
        }
        #endregion
    }
}
