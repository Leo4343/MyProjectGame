using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntiArcanoid
{
    interface ICreature
    {
        Size size { get; }
        Point speed { get; }
        Point position { get; }
    }
}
