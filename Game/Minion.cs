using Heirloom;
using Heirloom.Geometry;

namespace Game
{
public class Minion
{
    private Image image;
    private Vector posicio;
    public Circle hitbox{get;}
    const int radius = 130/2;
    
    public Minion(int MAX_MAPA)
    {
        Random rnd = new Random();
        image = new Image("imatges/130px/" + rnd.Next(1,5) + ".png");
        
        int offSet = 145;
        posicio.X = rnd.Next(0+22,MAX_MAPA-offSet);
        posicio.Y = rnd.Next(0+22,MAX_MAPA-offSet);
        hitbox = new Circle(posicio,radius);
    }
    public void Draw(GraphicsContext gfx){
        gfx.DrawImage(image, posicio);
    }
    public int Radius(){
        return radius;
    }

}
}