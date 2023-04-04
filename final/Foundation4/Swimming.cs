class Swimming : Activity
{
    public Swimming(string date, int length, float distance) : base(date, length)
    {
        _distance = distance;
        _name = "Swimming";
        _speed = _length / _distance;
        _pace = _speed / 60;
    }
}