namespace Advent2025.Models;

internal class Dial(int radius, int starting, int special)
{
    internal int SpecialHit => _specialHits;

    protected int _point = starting;
    protected int _specialHits;

    protected readonly int _zero = 0;
    protected readonly int _specialNumber = special;
    protected readonly int _radius = radius;


    internal virtual void TurnLeft(int ticks)
    {
        var input = ticks % _radius;

        if (_point - input >= _zero)
        {
            _point -= input;
        }
        else
        {
            _point = _radius - (input - _point);
        }

        Console.WriteLine($"radius: {_point}");

        if (_point == _specialNumber)
        {
            _specialHits++;
        }
    }

    internal virtual void TurnRight(int ticks)
    {
        var input = ticks % _radius;

        if (_point + input <= _radius)
        {
            _point += input;
        }
        else
        {
            _point = (input + _point) - _radius;
        }

        if (_point == _radius)
        {
            _point = _zero;
        }

        Console.WriteLine($"radius: {_point}");

        if (_point == _specialNumber)
        {
            _specialHits++;
        }
    }
}
