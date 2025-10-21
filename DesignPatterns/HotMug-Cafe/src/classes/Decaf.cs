public class Decaf : Beverage
{
    private float _price = 2.0f;
    public override string GetDescription()
    {
        return "decaf";
    }

    public override float Cost()
    {
        return _price;
    }
}
