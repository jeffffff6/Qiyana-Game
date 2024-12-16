using Heirloom;
using Heirloom.Desktop;

namespace Moviment;

class Program
{
    private static Window finestra;
    private static Qiyana qiyana;
    //private static Mapa mapa;
    public const int MAX_MAPA = 900;
    static void Main(string[] args)
    {
        Application.Run(()=>{
            finestra = new Window("Qiyana Game", (MAX_MAPA,MAX_MAPA));
            finestra.SetIcon(new Image("imatges/icon.png"));
            finestra.IsResizable = false;
            finestra.MoveToCenter();
            qiyana = new Qiyana(10,10);

            //mapa = new Mapa();   

         
            var loop = GameLoop.Create(finestra.Graphics, OnUpdate);
            loop.Start();

        });
    }
    private static void OnUpdate(GraphicsContext gfx, float dt){

        var rectangleFinestra = new Rectangle(0, 0, finestra.Width, finestra.Height);
        Image fondo  = new Image("imatges/mapa2.png");
        gfx.DrawImage(fondo, rectangleFinestra);
        qiyana.Pinta(gfx);
        qiyana.Mou(rectangleFinestra);
    }
}
