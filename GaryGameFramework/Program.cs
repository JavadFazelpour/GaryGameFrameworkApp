namespace GaryGameFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int val1 = 25;
            int val2 = 15;
            UnitTester tester = new UnitTester();
            Unit unit = new Unit(1000);
            Weapon weapon = new Weapon();

            tester.TestType(unit, "infantry", "infantry");
            tester.TestUnitSpecificProperty(unit, "hitPoints", val1, val1);
            tester.TestChangeProperty(unit, "hitPoints", val2, val2);
            tester.TestNoExistentProperty(unit, "strength");
            tester.TestUnitID(unit, 1000);
            tester.TestUnitName(unit, "Damon", "Damon");
            tester.TestUnitWeapon(unit, weapon, weapon);
        }
    }
}
