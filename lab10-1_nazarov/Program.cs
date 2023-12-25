public class Rectangle
{
    public int X1 { get; set; }
    public int Y1 { get; set; }
    public int X2 { get; set; }
    public int Y2 { get; set; }

    public Rectangle(int x1, int y1, int x2, int y2)
    {
        X1 = x1;
        Y1 = y1;
        X2 = x2;
        Y2 = y2;
    }

    public virtual string GetCoordinates()
    {
        return $"Координаты прямоугольника: ({X1}, {Y1}), ({X2}, {Y2})";
    }
}

public class Envelope : Rectangle
{
    public Envelope(int x1, int y1, int x2, int y2)
        : base(x1, y1, x2, y2)
    {
    }

    public override string GetCoordinates()
    {
        return $"Изображение конверта: {base.GetCoordinates()}";
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Введите x1: ");
        int x1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите y1: ");
        int y1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите x2: ");
        int x2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите y2: ");
        int y2 = Convert.ToInt32(Console.ReadLine());

        Rectangle rectangle = new Rectangle(x1, y1, x2, y2);
        Console.WriteLine(rectangle.GetCoordinates());

        Envelope envelope = new Envelope(x1, y1, x2, y2);
        Console.WriteLine(envelope.GetCoordinates());
    }
}