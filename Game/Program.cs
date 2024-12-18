using Heirloom;
using Heirloom.Desktop;

namespace Game;

class Program
{
    public const int MAX_MAPA = 850;
    public static Window window;
    public static Qiyana qiyana;
    public static Mapa mapa;
    public static Minion minion;
    static void Main(string[] args)
    {
        Application.Run(()=>{
            window = new Window("Qiyana Game", (MAX_MAPA,MAX_MAPA));
            window.SetIcon(new Image("imatges/icon.png"));      window.IsResizable = false;     window.MoveToCenter();

            qiyana = new Qiyana(MAX_MAPA/2-(128/2),MAX_MAPA/2-(128/2));

            mapa = new Mapa();   

            
            var loop = GameLoop.Create(window.Graphics, OnUpdate);
            loop.Start();
        });
    }
    private static void OnUpdate(GraphicsContext gfx, float dt){

        var windowRectangle = new Rectangle(0, 0, window.Width, window.Height);
        gfx.DrawImage(mapa.image, windowRectangle);

        mapa.DrawMinions(in minions, gfx);
        qiyana.Draw(gfx);
        qiyana.Move(windowRectangle);
    }
}
