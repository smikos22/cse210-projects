public abstract class Activity
{
    protected string _date;
    protected int _length;
    protected float _distance;
    protected float _speed;
    protected float _pace;
    protected string _name;
    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }
    public virtual double GetDistance()
    {
        return _distance;
    }
    
    public virtual double GetSpeed()
    {
        return _speed;
    }
    
    public virtual double GetPace()
    {
        return _pace;
    }
    public string GetSummary()
    {
        string summary;
        summary = $"{_date} {_name}({_length} min) - Distance: {(float)Math.Round(_distance, 1)} km, Speed: {(float)Math.Round(_speed, 1)} kph, Pace: {(float)Math.Round(_pace, 1)} min per km";
        return summary;
    }
}