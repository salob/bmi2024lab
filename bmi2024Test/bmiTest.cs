namespace bmi2024Test;
using BMICalculator;
[TestClass]
public class BMITest
{
    [TestMethod]
    public void TestBMICategorySingle()
    {
      BMI bmi = new BMI() { WeightStones = 12, WeightPounds = 0, HeightFeet = 5, HeightInches = 10 };
      Assert.AreEqual(bmi.BMICategory, BMICategory.Normal);
    }

    [DataTestMethod]
    [DataRow(12, 0, 5, 10, BMICategory.Normal)]
    [DataRow(15, 0, 5, 10, BMICategory.Obese)]
    [DataRow(15, 0, 5, 10, BMICategory.Obese)]
    [DataRow(7, 0, 5, 10, BMICategory.Underweight)]
    [DataRow(11, 0, 5, 3, BMICategory.Overweight)]
    public void TestBMICategoryMultiple(int ws, int wp, int hf, int hi, BMICategory cat)
    {
        BMI bmi = new BMI() { WeightStones = ws, WeightPounds = wp, HeightFeet = hf, HeightInches = hi };
        Assert.AreEqual(bmi.BMICategory, cat);
    }
}
