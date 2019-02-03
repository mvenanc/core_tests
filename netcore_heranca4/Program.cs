using System;

namespace netcore_heranca4 {
    class Program {
        public static void Main () {
            Shape[] shapes = {
                new Rectangle (10, 12),
                new Square (5),
                new Circle (3)
            };
            foreach (var shape in shapes) {
                Console.WriteLine ($"{shape}: area, {Shape.GetArea(shape)}; " +
                    $"perimeter, {Shape.GetPerimeter(shape)}");
                var rect = shape as Rectangle;
                if (rect != null) {
                    Console.WriteLine ($"   Is Square: {rect.IsSquare()}, Diagonal: {rect.Diagonal}");
                    continue;
                }
                var sq = shape as Square;
                if (sq != null) {
                    Console.WriteLine ($"   Diagonal: {sq.Diagonal}");
                    continue;
                }
            }
        }

        // The example displays the following output:
        //         Rectangle: area, 120; perimeter, 44
        //            Is Square: False, Diagonal: 15.62
        //         Square: area, 25; perimeter, 20
        //            Diagonal: 7.07
        //         Circle: area, 28.27; perimeter, 18.85
        
    }
}
