public class Biking : Activity
{
    private double _speed;

    public Biking(string date, double minutes, double speed)
        : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed * _minutes) / 60;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }
    public override string GetActivityType()
    {
        return "Biking";
    }
}

