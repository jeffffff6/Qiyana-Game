using Heirloom;
using Heirloom.Geometry;

namespace Game
{
public class Minion
{
    private Image image;
    private Vector posicio;
    private Circle hitbox;
    
    public Minion()
    {
        Random rnd = new Random();
        int randomIndex = rnd.Next(1,5);

        string randomMinionImage = "imatges/minions/" +randomIndex+ ".png";
        image = new Image("imatges/minions/.png");
    }

}
}