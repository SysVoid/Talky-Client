using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talky_Client
{
    class ClientColour
    {

        public Color Color { get; private set; }
        public bool MinusOne { get; private set; } = false;

        public ClientColour(Color color, bool minusOne)
        {
            Color = color;
            MinusOne = minusOne;
        }

    }
}
