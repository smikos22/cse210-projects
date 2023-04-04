class Running : Activity
{
    public Running(string date, int length, float distance) : base(date, length)
    {
        _distance = distance;
        _name = "Running";
        _speed = _length / _distance;
        _pace = _speed / 60;
    }
}