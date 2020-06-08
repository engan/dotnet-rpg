namespace dotnet_rpg.Models
{
    public class Weapon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Damage { get; set; }
        public Character Character { get; set; } 

        // MESSAGE after dotnet ef migrations add Weapon:
        // 
        // The child/dependent side could not be determined for the 
        // one-to-one relationship between 'Character.Weapon' and 'Weapon.Character'. 
        // To identify the child/dependent side of the relationship, 
        // configure the foreign key property. If these navigations should not be part of 
        // the same relationship configure them without specifying the inverse. 
        // See http://go.microsoft.com/fwlink/?LinkId=724062 for more details.

        // A Character can exist without a Weapon
        // A Weapon cant exists without a Character
        // The weapon is the depended side of the relationship

        // Solution: Create a foreign key
        public int CharacterId { get; set; }
    }
}