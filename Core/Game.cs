using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICTIA.Core
{
    public abstract class Game
    {
        protected Point WindowSize = new Point(720, 480);
        
        protected string Title = "Game";
        
        protected ConfigFlags Flags = ConfigFlags.FLAG_VSYNC_HINT;

        public static float FrameTime => Raylib.GetFrameTime();
        
        public Scene Scene { get; private set; }

        public Game(Scene startScene)
        {
            this.SetScene(startScene);
        }

        protected virtual void Init()
        {
            Raylib.InitWindow(this.WindowSize.X, this.WindowSize.Y, this.Title);
        }

        public void Run()
        {
            Init();

            //TODO: Добавить подгрузку ресурсов
            while (!Raylib.WindowShouldClose())
            {
                this.Scene.Update(Game.FrameTime);

                Raylib.BeginDrawing();
                Raylib.ClearBackground(Raylib.BLACK);

                this.Scene.Draw();

                GameLoop(Game.FrameTime);

                Raylib.EndDrawing();
            }

            //TODO: Добавить отгрузку ресурсов
            Raylib.CloseWindow();
        }

        protected virtual void GameLoop(float frameTime)
        { 
            //TODO
        }

        public void SetScene(Scene scene)
        {
            this.Scene?.Dispose();
            this.Scene = scene;
            this.Scene.Init();
        }

        public virtual void Draw()
        {
            this.Scene.Draw();
        }

        public virtual void Update(float frameTime)
        {
            this.Scene.Update(frameTime);
        }
    }

    public abstract class Scene
    {
        public virtual void Init()
        { }

        public virtual void Dispose()
        { }

        public abstract void Draw();

        public abstract void Update(float frameTime);

    }
}
