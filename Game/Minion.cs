using Heirloom;
using Heirloom.Geometry;

namespace Game
{
public class Minion
{
    private Image image;
    private Vector posicio;
    private Circle hitbox;
    
    public Minion(int MAX_MAPA)
    {
        Random rnd = new Random();
        image = new Image("imatges/130px/" + rnd.Next(1,5) + ".png");
        
        int offSet = 130;
        posicio.X = rnd.Next(0+offSet,MAX_MAPA-offSet);
        posicio.Y = rnd.Next(0+offSet,MAX_MAPA-offSet);
    }
    public void Draw(GraphicsContext gfx){
        gfx.DrawImage(image, posicio);
    }


}
}