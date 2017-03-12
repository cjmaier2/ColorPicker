using System.Collections.Generic;

namespace ColorPicker
{
    public class MyColor
    {
        public string Name { get; set; }
        public string Hex { get; set; }

        public MyColor()
        {
        }

        public static IList<MyColor> GetColors()
        {
            return new List<MyColor>
            {
                new MyColor { Hex = "#00ff00" },
                new MyColor { Hex = "#ff0000" },
                new MyColor { Hex = "#0000ff" },
                new MyColor { Hex = "#f4a460" },
                new MyColor { Hex = "#ffb6c1" },
                new MyColor { Hex = "#ffff00" },
                new MyColor { Hex = "#ffa500" },
                new MyColor { Hex = "#cccccc" },
                new MyColor { Hex = "#ffffff" },
                new MyColor { Hex = "#000000" },
                new MyColor { Hex = "#800080" },
                new MyColor { Hex = "#000080" },
                new MyColor { Hex = "#ff00ff" },
                new MyColor { Hex = "#00ffff" }
            };
        }
    }
}
