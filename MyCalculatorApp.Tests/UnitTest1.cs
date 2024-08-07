using FluentAssertions;

namespace MyCalculatorApp.Tests;

public class UnitTest1
{
    [Fact]
    public void MyClass_Should_Exists()
    {
        // Arrange
        var calculator = new MyCalculatorApp();

        //Assert
        Assert.NotNull(calculator);
        Assert.True(true);
    }
    
    [Fact]
    public void MyMethod_Should_Exists()
    {
        // Arrange
        var calculator = new MyCalculatorApp();

        //Assert
        Assert.NotNull(calculator.Add);
    }
    
    [Fact]
    public void MyMethod_Should_Accept_Integer_Parameters()
    {
        // Arrange
        var addMethodInfo = typeof(MyCalculatorApp).GetMethod("Add");
        
        // Act
        
        //Assert
        Assert.NotNull(addMethodInfo);
        Assert.Equal(2, addMethodInfo.GetParameters().Length);
        Assert.Equal(typeof(int), addMethodInfo.GetParameters()[0].ParameterType);
        Assert.Equal(typeof(int), addMethodInfo.GetParameters()[1].ParameterType);
    }
    
    [Fact]
    public void MyMethod_Should_CatchError_If_Parameters_Is_Not_Integer()
    {
        // Arrange
        var addMethodInfo = typeof(MyCalculatorApp).GetMethod("Add");
        
        // Act
        
        //Assert
        Assert.NotNull(addMethodInfo);
        Assert.Equal(2, addMethodInfo.GetParameters().Length);
        Assert.NotEqual(typeof(string), addMethodInfo.GetParameters()[0].ParameterType);
        Assert.NotEqual(typeof(string), addMethodInfo.GetParameters()[1].ParameterType);
    }
    
    [Fact]
    public void MyMethod_Should_Return_Some_Integer_Value()
    {
        // Arrange
        var addMethodInfo = typeof(MyCalculatorApp).GetMethod("Add");
        
        // Act

        //Assert
        Assert.Equal(typeof(int), addMethodInfo!.ReturnParameter.ParameterType);
        Assert.NotEqual(typeof(string), addMethodInfo.ReturnParameter.ParameterType);
    }
    
    [Fact]
    public void MyMethod_Should_Return_Except_Value()
    {
        // Arrange
        var calculator = new MyCalculatorApp();
        
        // Act
        var result = calculator.Add(2, 5);

        //Assert
        Assert.Equal(7, result);
        result.Should().Be(7).And.NotBe(3);
    }
}