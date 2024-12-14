using Heirloom;
using Heirloom.IO;
namespace Moviment;
public class Mapa
{
    private readonly Image imatge;
    public Mapa()
    {
        imatge = new Image(Files.OpenStream("imatges/mapa.png"));
    }
    public void Pinta(GraphicsContext gfx, Rectangle finestra)
    {
        var yScale = finestra.Height / imatge.Height;
        var xScale = finestra.Width / imatge.Width;
        var scale = Calc.Min(xScale, yScale);

        var xOffset = finestra.Min.X + (finestra.Width - (imatge.Width * scale)) / 2F;
        var yOffset = finestra.Min.Y + (finestra.Height - (imatge.Height * scale)) / 2F;


        gfx.DrawImage(imatge, Matrix.CreateTransform(xOffset, yOffset, 0, scale, scale));
    }
}