public class Expresso : Beverage
{
    public Expresso(int chocolate, int steamedMilk, int whippedCream)
    {
        extraPrices = 0.30f * steamedMilk + 0.6f * chocolate + 1.1f * whippedCream; 
    }
    private float _price = 3.0f;
    public override string GetDescription()
    {
        return "expresso";
    }

    public override float Cost()
    {
        return _price;
    }
}
