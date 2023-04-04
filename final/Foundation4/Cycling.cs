class Cycling : Activity
{
    public Cycling(string date, int length, float speed) : base(date, length)
    {
        _speed = speed;
        _name = "Cycling";
        _speed = _pace / 60;
        _pace = _speed / 60;

    }
}