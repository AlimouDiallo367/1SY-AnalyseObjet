public class Regular : Beverage
{
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
