using Heirloom;

namespace Game
{
    public class GoldScore
    {
        private int gold;
        private Vector scorePosition;

        public GoldScore(Rectangle window){
            scorePosition = new Vector(0, 0);
        }
        public void DrawGoldScore(GraphicsContext gfx){
            gfx.DrawText("Gold :"+gold+"g", scorePosition, font: default, 25);
        }
    }
    
}