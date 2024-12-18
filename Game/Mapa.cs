using Heirloom;
namespace Game;
public class Mapa
{
    public Image image {get;}
    public Mapa()
    {
        image = new Image("imatges/map.png");
    }
    public void Draw(GraphicsContext gfx, Rectangle windowRectangle)
    {
        gfx.DrawImage(image, windowRectangle);
    }
    public void DrawMinions(in List<Minion> minions, GraphicsContext gfx){
        foreach (var minion in minions)
        {
            minion.Draw(gfx);
        }
    }
}