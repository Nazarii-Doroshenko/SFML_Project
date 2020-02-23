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
        static Font Arial = new Font(@"9041.ttf");
        static int R = 40;

        static byte red = 20;
        static byte green = 20;
        static byte blue = 20;






        static void Main(string[] args)
        {
            Render();
        }
        static void text()
        {
            string a = "Controls: W = Forward; S = Back; A = Left; D = Right;";
            string ab = "Shift = 2x speed; Cntrl = 0.5x speed;";
            string b = "Ecs = Close; F = Restart; H = help;";
            string c = "X = Bigger radius; Z = Smaller radius";
            string co = "B = blue; R = red; G = green; (P = +color; M = -color)";
            string next = "To play press - Enter";

            Text text1 = new Text(a, Arial, 50);
            Text text3 = new Text(ab, Arial, 50);
            Text text2 = new Text(b, Arial, 50);
            Text text4 = new Text(c, Arial, 50);
            Text text5 = new Text(co, Arial, 50);
            Text Next = new Text(next, Arial, 70);

            ControlsWindow = new RenderWindow(new VideoMode(1200, 800), "Help");
            ControlsWindow.Clear(Color.Black);

            text1.Position = new Vector2f(10, 20);
            text2.Position = new Vector2f(10, 85);
            text3.Position = new Vector2f(10, 135);
            text4.Position = new Vector2f(10, 185);
            text5.Position = new Vector2f(10, 235);
            Next.Position = new Vector2f(545, 700);

            text1.DisplayedString = a;
            text2.DisplayedString = b;
            text3.DisplayedString = ab;
            text4.DisplayedString = c;
            text5.DisplayedString = co;
            Next.DisplayedString = next;

            ControlsWindow.Draw(text1);
            ControlsWindow.Draw(text2);
            ControlsWindow.Draw(text3);
            ControlsWindow.Draw(text4);
            ControlsWindow.Draw(text5);
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


        }
        static void RectPosM()
        {


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

            circle = new CircleShape(R);

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

            // circle.Position = new Vector2f(100f, 100f);
            window.SetFramerateLimit(45);
            while (IsWindowOpen())
            {

                window.DispatchEvents();
                FillColor();

                Draw();

            }
        }
        static void Input()
        {
            float dx = 0, dy = 0;
            if (Keyboard.IsKeyPressed(Keyboard.Key.W))
            {
                dx = 0;
                dy = -1;
                ApplyAdditionalMoveModifeirs(dx, dy);
            }
            if (Keyboard.IsKeyPressed(Keyboard.Key.A))
            {
                dx = -1;
                dy = 0;
                ApplyAdditionalMoveModifeirs(dx, dy);
            }
            if (Keyboard.IsKeyPressed(Keyboard.Key.S))
            {
                dx = 0;
                dy = 1;
                ApplyAdditionalMoveModifeirs(dx, dy);
            }
            if (Keyboard.IsKeyPressed(Keyboard.Key.D))
            {
                dx = 1;
                dy = 0;
                ApplyAdditionalMoveModifeirs(dx, dy);

            }
            logic(dx, dy);
            if (Keyboard.IsKeyPressed(Keyboard.Key.X))
            {
                R++;
                Vector2f pos = circle.Position;
                circle = new CircleShape(R);
                circle.Position = pos;
            }
            if (Keyboard.IsKeyPressed(Keyboard.Key.Z))
            {
                R--;
                Vector2f pos = circle.Position;
                circle = new CircleShape(R);
                circle.Position = pos;
            }
            if (Keyboard.IsKeyPressed(Keyboard.Key.Escape))
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
            if (Keyboard.IsKeyPressed(Keyboard.Key.F))
            {
                window.Close();
                Render();

            }

            NewColor();

        }
        static void NewColor()
        {

            if (Keyboard.IsKeyPressed(Keyboard.Key.R))
            {
                if (Keyboard.IsKeyPressed(Keyboard.Key.P))
                {
                    red++;
                }
                if (Keyboard.IsKeyPressed(Keyboard.Key.M))
                {
                    red--;
                }
            }
            if (Keyboard.IsKeyPressed(Keyboard.Key.G))
            {
                if (Keyboard.IsKeyPressed(Keyboard.Key.P))
                {
                    green++;
                }
                if (Keyboard.IsKeyPressed(Keyboard.Key.M))
                {
                    green--;
                }

            }
            if (Keyboard.IsKeyPressed(Keyboard.Key.B))
            {

                if (Keyboard.IsKeyPressed(Keyboard.Key.P))
                {
                    blue++;
                }
                if (Keyboard.IsKeyPressed(Keyboard.Key.M))
                {
                    blue--;
                }

            }
            circle.FillColor = new Color(red, green, blue);
        }
        
        static void LControl(float dx, float dy)
        {
            dx /= 2;
            dy /= 2;
            circle.Position += new Vector2f(dx, dy);
        }


        static void LShift(float dx, float dy)
        {
            dx *= 2;
            dy *= 2;
            circle.Position += new Vector2f(dx, dy);
        }
        static void DefaultGo(float dx, float dy)
        {
            circle.Position += new Vector2f(dx, dy);
        }
        static void ApplyAdditionalMoveModifeirs(float dx, float dy)
        {
            if (Keyboard.IsKeyPressed(Keyboard.Key.LControl))
            {
                LControl(dx, dy);
            }
            else if (Keyboard.IsKeyPressed(Keyboard.Key.LShift))
            {
                LShift(dx, dy);
            }
            else
            {
                DefaultGo(dx, dy);
            }


        }
        static void logic(float dx, float dy)
        {



            if (circle.Position == new Vector2f(1200f, 90f))
            {
                circle.Position = new Vector2f(0f, 0f);
            }
            else if (circle.Position == new Vector2f(110, 90))
            {
                circle.Position = new Vector2f(0f, 0f);
            }
            else if (circle.Position == new Vector2f(10f, 800f))
            {
                circle.Position = new Vector2f(0f, 0f);
            }
            else if (circle.Position == new Vector2f(1190f, 790f))
            {
                circle.Position = new Vector2f(0f, 0f);
            }
            else if (circle.Position == new Vector2f(1200f, 10f))
            {
                circle.Position = new Vector2f(0f, 0f);
            }
            /* else if (circle.Position == new Vector2f(0.5f, 100f))
             {
                 circle.Position = new Vector2f(0f, 0f);
             }
             else if (circle.Position == new Vector2f(100f, 0.5f))
             {
                 circle.Position = new Vector2f(0f, 0f);
             }*/
            else
            {
                //circle.Position = new Vector2f(dx, dy);
            }

        }


    }
}





