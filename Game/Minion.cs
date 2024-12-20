using Heirloom;
using Heirloom.Geometry;

namespace Game
{
public class Minion
{
    private Image image;
    private Vector position;
    public Circle hitbox { get;}
    const int RADIUS = 65;
    
    public Minion(int MAX_MAPA)
    {
        var rnd = new Random();
        image = new Image("imatges/130px/" + rnd.Next(1,5) + ".png");

        position = new Vector{
            X = rnd.Next(0 + RADIUS, MAX_MAPA - RADIUS),
            Y = rnd.Next(0 + RADIUS, MAX_MAPA - RADIUS) 
        };
        hitbox = new Circle(position, RADIUS);
    }
    public void Draw(GraphicsContext gfx){
        gfx.DrawImage(image, position);
    }
    public int Radius(){
        return RADIUS;
    }

}
}