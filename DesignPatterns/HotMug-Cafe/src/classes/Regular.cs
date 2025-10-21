public class Regular : Beverage
{
    public Regular(int chocolate, int steamedMilk, int whippedCream)
    {
        extraPrices = 0.30f * steamedMilk + 0.6f * chocolate + 1.1f * whippedCream; 
    }
    private float _price = 2.5f;
    public override string GetDescription()
    {
        return "régulier";
    }

    public override float Cost()
    {
        return _price;
    }
}
