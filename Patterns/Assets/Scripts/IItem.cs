public interface IWeapon
{
    WeaponsType WeaponsType { get; set; }  
    int MaxBullets { get; set; }    
    int CurrentBulletsCount { get; set; }    
    void Interact();
}
