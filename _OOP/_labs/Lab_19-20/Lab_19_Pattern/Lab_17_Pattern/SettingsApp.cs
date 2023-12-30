using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_18_Pattern
{
    public class App
    {
        public color col { get; set; }
        public SizeOfText size { get; set; }

        public void setColor(string colorName)
        {
            col = color.getInstance(colorName);
        }

        public void setSize(string sizeText)
        {
            size = SizeOfText.getInstance(sizeText);
        }
    }

    public class color
    {
        private static color instance;
        public string _color { get; private set; }

        protected color(string _color)
        {
            this._color = _color;
        }

        public static color getInstance(string _color)
        {
            if (instance == null)
                instance = new color(_color);
            return instance;
        }
    }

    public class SizeOfText
    {
        private static SizeOfText instance;
        public string size { get; private set; }

        protected SizeOfText(string name)
        {
            this.size = name;
        }

        public static SizeOfText getInstance(string name)
        {
            if (instance == null)
                instance = new SizeOfText(name);
            return instance;
        }
    }
}
