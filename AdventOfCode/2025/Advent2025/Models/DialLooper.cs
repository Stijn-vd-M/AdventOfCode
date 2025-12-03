namespace Advent2025.Models;

internal sealed class DialLooper(int radius, int starting, int special)
    : Dial(radius, starting, special)
{
    internal override void TurnLeft(int ticks)
    {
        var input = ModCheck(ticks);

        if (_point == _zero)
        {
            _point = _radius;
        }

        for (var i = 0; i < input; i++)
        {
            _point--;

            if (_point < _zero)
            {
                _point = _radius - 1;
            }
            else if (_point == _zero)
            {
                _specialHits++;
            }
        }

        Console.WriteLine($"point: {_point}");
    }

    internal override void TurnRight(int ticks)
    {
        var input = ModCheck(ticks);

        for (var i = 0; i < input; i++)
        {
            _point++;

            if (_point == _radius)
            {
                _specialHits++;
                _point = _zero;
            }
        }

        Console.WriteLine($"point: {_point}");
    }


    private int ModCheck(int ticks)
    {
        var mod = ticks % _radius;
        _specialHits += ((ticks - mod) / _radius);

        return mod;
    }
}
