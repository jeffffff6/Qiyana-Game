using Heirloom;

namespace Game
{
    public class GoldScore
    {
        private int gold;
        private Vector scorePosition;
        private Font font;

        public GoldScore(Rectangle window){
            scorePosition = new Vector(10, 10);
            font = Font.Default;
        }
        public void DrawGoldScore(GraphicsContext gfx){
            gfx.DrawText("Gold :"+gold+"g", scorePosition, font, 25);
        }
    }
    
}