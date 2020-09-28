namespace Pokemon_Beep.Combat
{
    class Ability
    {
        public Ability(string name, string description, int effect)
        {
            Name = name;
            Description = description;
            Effect = effect;
        }
        public string Name { get; }
        public string Description { get; }
        public int Effect { get; }

    }
}
