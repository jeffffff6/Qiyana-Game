using Heirloom;
namespace Game;
public class LlistaMinions
{
    public List<Minion> list;


    public LlistaMinions(){
        list = new List<Minion>();
    }
    public void AddMinion(int MAX_MAPA)
    {
        //if(true){
        //}
        Minion minion= new Minion(MAX_MAPA);
        for (int i = 0; i < 8; i++){
            list.Add(minion);
        }

    }
}