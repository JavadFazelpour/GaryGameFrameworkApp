
namespace GaryGameFramework
{
    internal class UnitTester
    {
        public void TestType(Unit unit, string type, string expectedOutputType)
        {
            Console.WriteLine("\nTesting setting/getting the type property.");
            unit.Type = type;
            string outputType = unit.Type;
            string msg = expectedOutputType == outputType ? "Test passed" : $"Test failed: {outputType} didn't match {expectedOutputType}";
            Console.WriteLine(msg);
        }
        public void TestUnitSpecificProperty(Unit unit, string propertyName, object inputValue, object expectedOutputValue)
        {
            Console.WriteLine("\nTesting setting/getting a unit-specific property.");
            unit.SetProperty(propertyName, inputValue);
            object outputValue = unit.GetProperty(propertyName);
            string msg = outputValue.Equals(expectedOutputValue) ? "Test passed" : $"Test failed: {outputValue} didn't match {expectedOutputValue}";
            Console.WriteLine(msg);
        }
        public void TestChangeProperty(Unit unit, string propertyName, object inputValue, object expectedOutputValue)
        {
            Console.WriteLine("\nTesting changing an exsisting property's value.");
            unit.SetProperty(propertyName, inputValue);
            object outputValue = unit.GetProperty(propertyName);
            string msg = expectedOutputValue.Equals(outputValue) ? "Test passed" : $"Test failed: {outputValue} didn't match {expectedOutputValue}";
            Console.WriteLine(msg);
        }
        public void TestNoExistentProperty(Unit unit, string propertyName)
        {
            Console.WriteLine("\nTesting getting a non-existent property's value.");
            object outputValue = unit.GetProperty(propertyName);
            string msg = outputValue == null ? "Test passed" : $"Test failed with value of {outputValue}";
            Console.WriteLine(msg);
        }
        public void TestUnitID(Unit unit, object expectedOutputValue)
        {
            Console.WriteLine("\nTesting getting unit ID");
            object outputValue = unit.ID;
            string msg = expectedOutputValue.Equals(outputValue) ? "Test passed" : $"Test failed {outputValue} didn't match {expectedOutputValue}";
            Console.WriteLine(msg);
        }
        public void TestUnitName(Unit unit, string inputName, string expectedOutputValue)
        {
            Console.WriteLine("\nTesting setting/getting unit name");
            unit.Name = inputName;
            string outPutName = unit.Name;
            string msg = expectedOutputValue.Equals(outPutName) ? "Test passed" : $"Test failed {outPutName} didn't match {expectedOutputValue}";
            Console.WriteLine(msg);
        }
        public void TestUnitWeapon(Unit unit,Weapon weapon, Weapon expectedOutputValue)
        {
            Console.WriteLine("\nTesting setting a weapon");
            unit.AddWeapon(weapon);
            var outputValue = unit.Weapons[0];
            string msg=expectedOutputValue.Equals(outputValue)? "Test passed" : $"Test failed {outputValue} didn't match {expectedOutputValue}";
            Console.WriteLine(msg);
        }
    }
}
