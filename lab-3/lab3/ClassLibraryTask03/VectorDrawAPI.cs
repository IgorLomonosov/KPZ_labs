﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTask03
{
    public class VectorDrawAPI : IDrawAPI
    {
        public void DrawShape()
        {
            Console.WriteLine("Рендеринг векторної графіки");
        }
    }
}
