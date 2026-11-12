public class InstantBarRenderer : BarRenderer
{
    public override void ChangeValue(float value, float maxValue)
    {
        SliderBar.value = value;
    }
}
