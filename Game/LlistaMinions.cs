using Heirloom;
using Heirloom.Desktop;
using Heirloom.Geometry;
namespace Game;
public class LlistaMinions
{   
    const int INITIAL_MINIONS = 5;
    public List<Minion> list{get;}


    public LlistaMinions(){
        list = new List<Minion>();
    }
    public void AddMinion(int MAX_MAPA)
    {
        int i = 0;
        while(i<INITIAL_MINIONS){
            Minion minion = new Minion(MAX_MAPA);
            if(OverlapHitbox(minion.hitbox)){
                list.Add(minion);
                i++;
            }
        }
    }

    public bool OverlapHitbox(Circle hitbox)
    {
        for (int i = 0; i < list.Count; i++)
        {
            if(list[i].hitbox.Overlaps(hitbox)) return false;
        }
        return true;
    }

}