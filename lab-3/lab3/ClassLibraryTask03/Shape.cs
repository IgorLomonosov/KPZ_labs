﻿namespace ClassLibraryTask03
{
    public abstract class Shape
    {
        protected IDrawAPI drawAPI;
        protected Shape(IDrawAPI drawAPI)
        {
            this.drawAPI = drawAPI;
        }
        public abstract void Draw();
    }
}
