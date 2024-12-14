using Heirloom;
namespace Moviment;
public class Qiyana
{
    private Image imatge;
    private Vector posicio;
    private int velocitat;
    public Qiyana(int x, int y)
    {
        imatge = new Image("imatges/qiyana.png");
        velocitat = 4;
        posicio = new Vector(x,y);
    }
    public void Pinta(GraphicsContext gfx){
        gfx.DrawImage(imatge, posicio);
    }
    public void Mou(Rectangle finestra){
        var novaPosicio = new Rectangle(posicio, imatge.Size);
        if(Input.CheckKey(Key.A, ButtonState.Down)){
            novaPosicio.X -= velocitat;
        }
        if(Input.CheckKey(Key.D, ButtonState.Down)){
            novaPosicio.X += velocitat;
        }
        if(Input.CheckKey(Key.W, ButtonState.Down)){
            novaPosicio.Y -= velocitat;
        }
        if(Input.CheckKey(Key.S, ButtonState.Down)){
            novaPosicio.Y += velocitat;
        }

        if(finestra.Contains(novaPosicio)){
            posicio.X = novaPosicio.X;
            posicio.Y = novaPosicio.Y;
        }
    }
}