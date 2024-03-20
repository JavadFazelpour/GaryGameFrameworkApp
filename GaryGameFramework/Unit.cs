namespace GaryGameFramework
{
    internal class Unit
    {
        public string Type { get; set; }
        public int ID { get; }
        public string Name { get; set; }
        public List<Weapon> Weapons { get; private set; }
        public Dictionary<string, object> Properties { get; set; }
        public Unit(int id) => ID = id;

        public void AddWeapon(Weapon weapon)
        {
            if (Weapons == null)
                Weapons = new List<Weapon>();
            Weapons.Add(weapon);
        }
        public void SetProperty(string property, object value)
        {
            if (Properties == null)
                Properties = new Dictionary<string, object>();
            if (!Properties.ContainsKey(property))
                Properties.Add(property, value);
            else
                Properties[property] = value;
        }
        public object GetProperty(string property)
        {
            if (Properties == null)
                return null;
            Properties.TryGetValue(property, out object value);
            return value;
        }

    }
}
