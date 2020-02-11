//Install-Package SFML.Net -Version 2.5.0
using SFML.Graphics;
using SFML.Window;
using SFML.System;
using System;


namespace NEWTEST
{
    class Program
    {
        static RenderWindow window, ControlsWindow;
        static bool IsWindowOpen() => window.IsOpen;
        static bool IsHelpWindowOpen() => ControlsWindow.IsOpen;
        static CircleShape circle;
        static RectangleShape rect, rect1, rect2, rectb1, recty1, recty2;
        static RectangleShape rectbl1, rectbl2;//bl = block
        static Font Arial = new Font(@"C:\Users\User\source\repos\NEWTEST\9041.ttf");




        static void Main(string[] args)
        {

            Render();
        }
        static void text()
        {

            string a = "Controls: W = Forward; S = Back; A = Left; D = Right;";
            string ab = "Shift = 2x speed; Cntrl = 0.5x speed;";
            string b = "Ecs / F = Close; R = Restart; H = help;";
            string next = "To play press - Enter";
           
            Text text1 = new Text(a, Arial, 50);
            Text text3 = new Text(ab, Arial, 50);
            Text text2 = new Text(b, Arial, 50);
            Text Next = new Text(next, Arial, 70);
            ControlsWindow = new RenderWindow(new VideoMode(1200, 800), "Help");
            ControlsWindow.Clear(Color.Black);
            text1.Position = new Vector2f(10, 200);
            text2.Position = new Vector2f(10, 270);
            text3.Position = new Vector2f(10, 340);
            Next.Position = new Vector2f(10, 400);
            text1.DisplayedString = a;
            text2.DisplayedString = b;
            text3.DisplayedString = ab;
            Next.DisplayedString = next;
            ControlsWindow.Draw(text1);
            ControlsWindow.Draw(text2);
            ControlsWindow.Draw(text3);
            ControlsWindow.Draw(Next);
            ControlsWindow.Display();

            while (IsHelpWindowOpen())
            {
                if (Keyboard.IsKeyPressed(Keyboard.Key.Enter))
                {
                    ControlsWindow.Close();
                }
                if (Keyboard.IsKeyPressed(Keyboard.Key.F) || Keyboard.IsKeyPressed(Keyboard.Key.Escape))
                {
                    ControlsWindow.Close();
                }

            }
        }
        
        static void ShapesDraw()
        {

            rect.Draw(window, RenderStates.Default);
            rectbl2.Draw(window, RenderStates.Default);
            rect1.Draw(window, RenderStates.Default);
            rect2.Draw(window, RenderStates.Default);

            recty1.Draw(window, RenderStates.Default);
            recty2.Draw(window, RenderStates.Default);


            rectbl1.Draw(window, RenderStates.Default);
            rectb1.Draw(window, RenderStates.Default);

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



            rectbl2.FillColor = Color.Black;
            rectbl1.FillColor = Color.Yellow;

            rectbl2.OutlineColor = Color.Yellow;

            circle.FillColor = Color.Blue;
        }
        static void ShapesRend()
        {
            rectbl2 = new RectangleShape(new Vector2f(1200f, 90f));
            rect = new RectangleShape(new Vector2f(1190f, 790f));
            rect1 = new RectangleShape(new Vector2f(10f, 800f));
            rect2 = new RectangleShape(new Vector2f(1200f, 10f));
            rectb1 = new RectangleShape(new Vector2f(100f, 100f));
            recty1 = new RectangleShape(new Vector2f(0.5f, 100f));
            recty2 = new RectangleShape(new Vector2f(100f, 0.5f));

            rect.OutlineThickness = 10;
            rectbl2.OutlineThickness = 10;

            circle = new CircleShape(35);

            rectbl1 = new RectangleShape(new Vector2f(110, 90));
        }
        static void Render()
        {
            
            window = new RenderWindow(new VideoMode(1200, 800), "TEST SFML_ PROJECT");
            text();
            while (IsHelpWindowOpen())
            {
                if (Keyboard.IsKeyPressed(Keyboard.Key.Enter))
                {
                    ControlsWindow.Close();
                }

            }
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

            }
            if (Keyboard.IsKeyPressed(Keyboard.Key.F) || Keyboard.IsKeyPressed(Keyboard.Key.Escape))
            {
                window.Close();
            }
            if (Keyboard.IsKeyPressed(Keyboard.Key.H))
            {
                text();
                while (IsHelpWindowOpen())
                {
                    if (Keyboard.IsKeyPressed(Keyboard.Key.Enter))
                    {
                        ControlsWindow.Close();
                    }

                }
            }
            if (Keyboard.IsKeyPressed(Keyboard.Key.R))
            {
                window.Close();
                Render();
            }
            
        }


        /* static bool logic()
         {


         }*/
    }
}




