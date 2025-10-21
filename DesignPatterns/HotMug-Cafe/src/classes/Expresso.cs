public class Expresso : Beverage
{
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
