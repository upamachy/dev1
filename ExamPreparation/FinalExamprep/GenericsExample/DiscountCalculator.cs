namespace GenericsExample
{
    public class DiscountCalculator<Tproduct> where Tproduct: Product
    {
        public float CalculateDiscount(Tproduct product)
        {
            return product.price;
        }

    }
}
