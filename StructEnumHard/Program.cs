using System;

public class Program
{
    enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    public static void Main()
    {
        Point p = new Point();

        p.PointChanged += StructEventHandler;
        p.X = 10;

        Console.WriteLine(Enum.GetName(typeof(WeekDays), 4));

        Console.WriteLine("WeekDays constant names:");

        foreach (string str in Enum.GetNames(typeof(WeekDays)))
            Console.WriteLine(str);

        Console.WriteLine("Enum.TryParse():");

        WeekDays wdEnum;
        Enum.TryParse<WeekDays>("1", out wdEnum);
        Console.WriteLine(wdEnum);
    }

    static void StructEventHandler(int point)
    {
        Console.WriteLine("Point changed to {0}", point);
    }
}

struct Point
{
    private int _x, _y;

    public int X
    {
        get
        {
            return _x;
        }

        set
        {
            _x = value;
            PointChanged(_x);
        }
    }

    public int Y
    {
        get
        {
            return _y;
        }
        set
        {
            _y = value;
            PointChanged(_y);
        }
    }

    public event Action<int> PointChanged;
}