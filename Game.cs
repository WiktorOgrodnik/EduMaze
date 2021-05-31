using System;

using SFML.System;
using SFML.Window;
using SFML.Graphics;

namespace EduMaze {
    class Game {
        private Maze theMaze;
        private RenderWindow gameWindow;
        private void InitVariables () {

        }

        private void InitWindow () {

            gameWindow = new RenderWindow (new VideoMode (800, 600), "EduMaze");
            gameWindow.SetFramerateLimit (60);
            gameWindow.SetVerticalSyncEnabled (true);

            gameWindow.KeyPressed += new EventHandler <KeyEventArgs> (KeyPressedHandler);
            gameWindow.Closed += new EventHandler (CloseEventHandler);
        }

        private void InitObjects () {

        }

        private void CloseEventHandler (object sender, EventArgs e) {
            gameWindow.Close();
        }

        private void KeyPressedHandler (object sender, KeyEventArgs e) {
            switch (e.Code) {
                case Keyboard.Key.Escape: 
                                            gameWindow.Close();
                                            break;
            }
        }

        public void ProcessEvents () {
            gameWindow.DispatchEvents();
        }

        public Boolean running {
            get => gameWindow.IsOpen;
        }

        public Game (ref Maze maze) {
            theMaze = maze;
            
            InitVariables ();
            InitWindow ();
            InitObjects ();
        }

        public void Update () {

        }

        public void Render () {
            //Console.WriteLine ("Jesteś w punkcie: " + theMaze.Position);

            /*int state = (int) theMaze.State;
            Console.WriteLine ("Dostępne ścieżki: ");
            if ((state & 1) == 1) Console.WriteLine ("1. W górę");
            if (((state >> 1) & 1) == 1) Console.WriteLine ("2. W prawo");
            if (((state >> 2) & 1) == 1) Console.WriteLine ("3. W dół");
            if (((state >> 3) & 1) == 1) Console.WriteLine ("4. W lewo");

            int direction = 0;
            try {
                String kierunek = Console.ReadLine();
                direction = Int32.Parse(kierunek);
            } catch (System.FormatException) {
                ;
            }

            Console.WriteLine ("Odczytano: " + direction.ToString());

            if (direction <= 4 && direction >= 0 && ((state >> (direction - 1)) & 1) == 1) theMaze.go (direction - 1);*/

            gameWindow.Clear (Color.White);
            gameWindow.Display ();
        }
    }
}