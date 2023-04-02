public abstract class Activity
{
    protected DateTime _date;
    protected int _length;
    public virtual double GetDistance()
    {
        return 0;
    }
    
    public virtual double GetSpeed()
    {
        return 0;
    }
    
    public virtual double GetPace()
    {
        return 0;
    }
//    public string GetSummary()
//    {
//    }
}