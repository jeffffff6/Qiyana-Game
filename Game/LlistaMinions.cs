using Heirloom;
using Heirloom.IO;
using Heirloom.Desktop;
using Heirloom.Geometry;
using Heirloom.Sound;
namespace Game;
public class LlistaMinions
{   
    const int INITIAL_MINIONS = 5;
    public List<Minion> list{get;}


    public LlistaMinions(){
        list = new List<Minion>();
    }
    public void AddInitialMinion(int MAX_MAPA){
        int i = 0;
        while(i<INITIAL_MINIONS){
            Minion minion = new Minion(MAX_MAPA);
            if(!OverlapHitboxMinions(minion.hitbox)){
                list.Add(minion);
                i++;
            }
        }
    }

    public bool OverlapHitboxMinions(Circle hitbox){
        foreach(Minion minion in list){
            if(minion.hitbox.Overlaps(hitbox)) return true;
        }
        return false;
    }

    public void RemoveMinion(Circle hitbox){
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i].hitbox.Overlaps(hitbox))
            {
                list.RemoveAt(i);
                break;
            }
        }
    }

    public void AddMinion(int MAX_MAPA){
        Minion minion = new Minion(MAX_MAPA);
        int retries = 100;
        while (retries-- > 0 && OverlapHitboxMinions(minion.hitbox))
        {
            minion = new Minion(MAX_MAPA);
        }
        if (retries > 0) {
            list.Add(minion);
            AudioSource currentSource = new(Files.OpenStream("sounds/coin.mp3")){
                IsLooping = false,
                Volume = 0.3f,
            };
            currentSource.Play();}
        }

}