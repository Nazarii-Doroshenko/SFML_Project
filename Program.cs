//Install-Package SFML.Net -Version 2.5.0;
using SFML.Graphics;
using SFML.Window;
using SFML.System;
using System;


namespace NEWTEST
{
    class Program
    {
        static RenderWindow window;
        static bool IsWindowOpen() => window.IsOpen;
        static CircleShape circle;
        static RectangleShape rect, rect1, rect2, rectb1, recty1, recty2;
        static ConsoleColor col;
      



        static void Main(string[] args)
        {
            Render();        
        }

       static void ShapesDraw()
        {
            rect.Draw(window, RenderStates.Default);
            rect1.Draw(window, RenderStates.Default);
            rect2.Draw(window, RenderStates.Default);
            rectb1.Draw(window, RenderStates.Default);
            recty1.Draw(window, RenderStates.Default);
            recty2.Draw(window, RenderStates.Default);
            circle.Draw(window, RenderStates.Default);

        }
        static void Draw()
        {

            window.Clear();

            ShapesDraw();
            
            Input();

            window.Display();
        }
        static void FillColor()
        {
            rect.FillColor = Color.Black;
            rect1.FillColor = Color.Yellow;
            rect2.FillColor = Color.Yellow;
            rectb1.FillColor = Color.Black;
            recty1.FillColor = Color.Yellow;
            recty2.FillColor = Color.Yellow;

            rect.OutlineColor = Color.Yellow;
            circle.FillColor = Color.Blue;
        }
        static void ShapesRend()
        {
            rect = new RectangleShape(new Vector2f(1190f, 790f));
            rect1 = new RectangleShape(new Vector2f(10f, 800f));
            rect2 = new RectangleShape(new Vector2f(1200f, 10f));
            rectb1 = new RectangleShape(new Vector2f(100f, 100f));
            recty1 = new RectangleShape(new Vector2f(0.5f, 100f));
            recty2 = new RectangleShape(new Vector2f(100f, 0.5f));
            rect.OutlineThickness = 10;

            circle = new CircleShape(35);
        }
        static void Render()
        {

            window = new RenderWindow(new VideoMode(1200, 800), "TEST SFML_ PROJECT");

            ShapesRend();

            window.SetFramerateLimit(60);
            while (IsWindowOpen())
            {

                window.DispatchEvents();
                FillColor();
                
                Draw();
            }
        }
        static void Input()
        {

            if (Keyboard.IsKeyPressed(Keyboard.Key.W))
            {
                if (Keyboard.IsKeyPressed(Keyboard.Key.LControl))
                {
                    circle.Position += new Vector2f(0f, -0.5f);
                }
                else if (Keyboard.IsKeyPressed(Keyboard.Key.LShift))
                {
                    circle.Position += new Vector2f(0f, -2f);
                }
                else
                {
                    circle.Position += new Vector2f(0f, -1f);
                }
                logic();
            }
            if (Keyboard.IsKeyPressed(Keyboard.Key.A))
            {
                if (Keyboard.IsKeyPressed(Keyboard.Key.LControl))
                {
                    circle.Position += new Vector2f(-0.5f, 0f);
                }
                else if (Keyboard.IsKeyPressed(Keyboard.Key.LShift))
                {
                    circle.Position += new Vector2f(-2f, 0f);
                }
                else
                {
                    circle.Position += new Vector2f(-1f, 0f);
                }
                logic();
            }
            if (Keyboard.IsKeyPressed(Keyboard.Key.S))
            {
                if (Keyboard.IsKeyPressed(Keyboard.Key.LControl))
                {
                    circle.Position += new Vector2f(0f, 0.5f);
                }
                else if (Keyboard.IsKeyPressed(Keyboard.Key.LShift))
                {
                    circle.Position += new Vector2f(0f, 2f);
                }
                else
                {
                    circle.Position += new Vector2f(0f, 1f);
                }
                logic();
            }
            if (Keyboard.IsKeyPressed(Keyboard.Key.D))
            {
                if (Keyboard.IsKeyPressed(Keyboard.Key.LControl))
                {
                    circle.Position += new Vector2f(0.5f, 0f);
                }
                else if (Keyboard.IsKeyPressed(Keyboard.Key.LShift))
                {
                    circle.Position += new Vector2f(2f, 0f);
                }
                else
                {
                    circle.Position += new Vector2f(1f, 0f);
                }
                logic();
            }
            if (Keyboard.IsKeyPressed(Keyboard.Key.F) || Keyboard.IsKeyPressed(Keyboard.Key.Escape))
            {
                window.Close();
            }
            if (Keyboard.IsKeyPressed(Keyboard.Key.H)) {
                
                if (Keyboard.IsKeyPressed(Keyboard.Key.Enter))
                {
                    Render();
                }
            }
            if (Keyboard.IsKeyPressed(Keyboard.Key.R))
            {
                window.Close();
                Render();
            }
        }
        static bool logic()
        {

            if (col == ConsoleColor.Yellow)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
