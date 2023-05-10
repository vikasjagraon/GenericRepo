using CodeWithParveenYadav.Service;
using CodeWithParveenYadav.Enums;
using  CodeWithParveenYadav.Interfaces;
using Xunit;
using CodeWithParveenYadav.Validators;
using System.Threading.Tasks;
using TestClassLib.Fixture;
using Moq;

namespace TestClassLib
{
    public class TestClass 
    {
        [Fact]
        public void PasswordValid_Positive()
        {
            //Arrange
            var passwordValidator = new PasswordValidator();
            const string password = "Th1sIsapassword!";

            //Act
            bool isValid = passwordValidator.IsValid(password);

            //Assert
            Assert.True(isValid, $"The password { password } is  valid");
        }

        [Fact]
        public void PasswordValid_Negative()
        {
            //Arrange
            var passwordValidator = new PasswordValidator();
            const string password = "Th1sIsapassword";

            //Act
            bool isValid = passwordValidator.IsValid(password);

            //Assert
            Assert.False(isValid, $"The password { password } is  valid");
        }

        [Fact]
        public void PasswordValid_WhenInputIsEmpty_Negative()
        {
            //Arrange
            var passwordValidator = new PasswordValidator();
            const string password = "";

            //Act
            bool isValid = passwordValidator.IsValid(password);

            //Assert
            Assert.False(isValid, $"The password { password } is  valid");
        }

        #region Theory

        [Theory]
        [InlineData("Th1sIsapassword!", true)]
        [InlineData("Th1s!", false)]
        [InlineData("", false)]

        public void ValidatePassword_WithInlineData(string password, bool expectedResult)
        {
            //Arrange
            var passwordValidator = new PasswordValidator();

            //Act
            bool isValid = passwordValidator.IsValid(password);

            //Assert
            Assert.Equal(expectedResult, isValid);
        }


        [Theory]
        [MemberData(nameof(ValidatePassword_TestCases_Fixture.TestData), MemberType = typeof(ValidatePassword_TestCases_Fixture))]
        public void ValidatePassword_WthMemberData(ValidatePassword_TestCases_Fixture fixture)
        {
            //Arrange
            var passwordValidator = new PasswordValidator();

            //Act
            bool actualResult = passwordValidator.IsValid(fixture.Password);

            //Assert
            Assert.Equal(fixture.ExpectedResult, actualResult);
        }
        #endregion

        #region Mocking
        [Fact]
        public void PasswordValid_Mocking()
        {
            //Arrange
            var passwordValidator = new PasswordValidator();
            const string password = "123";

            Mock<PasswordValidator> mockService = new Mock<PasswordValidator>();

            mockService.Setup(s => s.MakeDBCall(It.IsAny<string>())).Returns("test");

            //Act
            bool isValid = passwordValidator.IsValid(password);

            //Assert
            Assert.False(isValid, $"The password {password} is  valid");
        }
        #endregion
    }
}