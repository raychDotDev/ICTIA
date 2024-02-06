using ICTIA.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICTIA.Data
{
    public class ICTIAGame : Game
    {
        public ICTIAGame() : base(new MainMenuScene())
        {

        }
    }

    public class MainMenuScene : Scene
    {
        public override void Init()
        {
            base.Init();
            Console.WriteLine("Harro");
        }
        
        public override void Dispose()
        {
            base.Dispose();
            Console.WriteLine("BB");
        }

        public override void Draw()
        {
            //TODO
        }

        public override void Update(float frameTime)
        {
            //TODO
        }
    }
}
