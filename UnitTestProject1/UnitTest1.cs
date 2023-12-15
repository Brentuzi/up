using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

[TestClass]
public class CaptchaLibraryTests
{
    [TestMethod]
    public void GenerateCaptcha_ReturnsNonEmptyString()
    {
        // Arrange
        CaptchaLibrary captchaLibrary = new CaptchaLibrary();

        // Act
        string captchaText = captchaLibrary.GenerateCaptcha(6);

        // Assert
        Assert.IsFalse(string.IsNullOrEmpty(captchaText));
    }

    [TestMethod]
    public void GenerateCaptcha_ReturnsCorrectLength()
    {
        // Arrange
        CaptchaLibrary captchaLibrary = new CaptchaLibrary();
        int length = 8;

        // Act
        string captchaText = captchaLibrary.GenerateCaptcha(length);

        // Assert
        Assert.AreEqual(length, captchaText.Length);
    }

    [TestMethod]
    public void ValidateCaptcha_CorrectInput()
    {
        // Arrange
        CaptchaLibrary captchaLibrary = new CaptchaLibrary();
        string correctCaptcha = "AbCdEf";
        string userInput = "AbCdEf";

        // Act
        bool isValid = captchaLibrary.ValidateCaptcha(userInput, correctCaptcha);

        // Assert
        Assert.IsTrue(isValid);
    }

    [TestMethod]
    public void ValidateCaptcha_IncorrectInput()
    {
        // Arrange
        CaptchaLibrary captchaLibrary = new CaptchaLibrary();
        string correctCaptcha = "AbCdEf";
        string userInput = "WrongInput";

        // Act
        bool isValid = captchaLibrary.ValidateCaptcha(userInput, correctCaptcha);

        // Assert
        Assert.IsFalse(isValid);
    }


    [TestMethod]
    public void ValidateCapscha_IncorrectInput()
    {
        // Arrange
        CaptchaLibrary captchaLibrary = new CaptchaLibrary();
        string correctCaptcha = "AbCdEf";
        string userInput = "WrongInput";

        // Act
        bool isValid = captchaLibrary.ValidateCaptcha(userInput, correctCaptcha);

        // Assert
        Assert.IsFalse(isValid);
    }





    [TestMethod]
    public void ValidateCaptcha_EmptyInput()
    {
        // Arrange
        CaptchaLibrary captchaLibrary = new CaptchaLibrary();
        string correctCaptcha = "AbCdEf";
        string userInput = string.Empty;

        // Act
        bool isValid = captchaLibrary.ValidateCaptcha(userInput, correctCaptcha);

        // Assert
        Assert.IsFalse(isValid);
    }

    [TestMethod]
    public void ValidateCaptcha_WhitespaceInput()
    {
        // Arrange
        CaptchaLibrary captchaLibrary = new CaptchaLibrary();
        string correctCaptcha = "AbCdEf";
        string userInput = "   ";

        // Act
        bool isValid = captchaLibrary.ValidateCaptcha(userInput, correctCaptcha);

        // Assert
        Assert.IsFalse(isValid);
    }
    [TestMethod]
    public void ValidateCaptcha_WhdtespaceInput()
    {
        // Arrange
        CaptchaLibrary captchaLibrary = new CaptchaLibrary();
        string correctCaptcha = "AbCdEf";
        string userInput = "   ";

        // Act
        bool isValid = captchaLibrary.ValidateCaptcha(userInput, correctCaptcha);

        // Assert
        Assert.IsFalse(isValid);
    }
    [TestMethod]
    public void ValidateCaptcha_WhiteaspaceInput()
    {
        // Arrange
        CaptchaLibrary captchaLibrary = new CaptchaLibrary();
        string correctCaptcha = "AbCdEf";
        string userInput = "   ";

        // Act
        bool isValid = captchaLibrary.ValidateCaptcha(userInput, correctCaptcha);

        // Assert
        Assert.IsFalse(isValid);
    }
    [TestMethod]
    public void ValidateCaptcha_WhitespsaceInput()
    {
        // Arrange
        CaptchaLibrary captchaLibrary = new CaptchaLibrary();
        string correctCaptcha = "AbCdEf";
        string userInput = "   ";

        // Act
        bool isValid = captchaLibrary.ValidateCaptcha(userInput, correctCaptcha);

        // Assert
        Assert.IsFalse(isValid);
    }

}
