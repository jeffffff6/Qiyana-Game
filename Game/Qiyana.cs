using Heirloom;
using Heirloom.IO;
using Heirloom.Geometry;
using Heirloom.Sound;


namespace Game;
public class Qiyana
{
    private Image image;
    private Vector posicio;
    private Circle hitbox;
    private int speed;
    public Qiyana(int x, int y)
    {
        image = new Image("imatges/qiyana.png");
        speed = 4;
        posicio = new Vector(x,y);
        hitbox = new Circle(posicio,128/2);
    }
    public void Draw(GraphicsContext gfx){
        gfx.DrawImage(image, posicio);
    }
    public void Move(Rectangle finestra, List<Minion> list, int MAX_MAPA){
        var novaPosicio = new Rectangle(posicio, image.Size);
        if(Input.CheckKey(Key.A, ButtonState.Down)){
            novaPosicio.X -= speed;
        }
        if(Input.CheckKey(Key.D, ButtonState.Down)){
            novaPosicio.X += speed;
        }
        if(Input.CheckKey(Key.W, ButtonState.Down)){
            novaPosicio.Y -= speed;
        }
        if(Input.CheckKey(Key.S, ButtonState.Down)){
            novaPosicio.Y += speed;
        }
        if(finestra.Contains(novaPosicio)){
            posicio.X = novaPosicio.X;
            posicio.Y = novaPosicio.Y;
        }
        hitbox = new Circle(posicio,128/2);
        AudioSource currentSource = null;
        for (int i = 0; i < list.Count; i++){
            if(list[i].hitbox.Overlaps(hitbox)){
                list.RemoveAt(i);
                currentSource = new AudioSource(Files.OpenStream("sounds/coin.mp3")) { IsLooping = false };
                currentSource.Play();
                list.Add(new Minion(MAX_MAPA));
            }
        }
    }
}