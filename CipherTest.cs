using System;
using Xunit;

namespace CICD_cipher;

public class CipherTest
{
    private readonly CipherService _service;
    public CipherTest()
    {
        _service = new CipherService();
    }

    [Fact]
    public void EncryptToCaesar_ShouldEncryptCorrectly()
    {
        string input = "hey";
        string expected = "khb";
        string result = _service.EncryptToCaesar(input);
        Assert.Equal(expected, result);
    }
    [Fact]
    public void DecryptFromCaesar_ShouldDecryptCorrectly()
    {
        string input = "khb";
        string expected = "hey";
        string result = _service.DecrypteFromCaesar(input);
        Assert.Equal(expected, result);
    }
    [Fact]
    public void EncryptToCaesar_Uppercase_ShouldEncryptCorrectly()
    {
        string input = "HELLO";
        string expected = "KHOOR";
        string result = _service.EncryptToCaesar(input);
        Assert.Equal(expected, result);
    }
    [Fact]
    public void DecryptFromCaesar_Uppercase_ShouldDecryptCorrectly()
    {
        string input = "KHOOR";
        string expected = "HELLO";
        string result = _service.DecrypteFromCaesar(input);
        Assert.Equal(expected, result);
    }
    [Fact]
    public void EncryptToCaesar_Spaces_ShouldEncryptCorrectly()
    {
        string input = "hello there";
        string expected = "khoor wkhuh";
        string result = _service.EncryptToCaesar(input);
        Assert.Equal(expected, result);
    }
    [Fact]
    public void DecryptFromCaesar_Spaces_ShouldDecryptCorrectly()
    {
        string input = "khoor wkhuh";
        string expected = "hello there";
        string result = _service.DecrypteFromCaesar(input);
        Assert.Equal(expected, result);
    }
    [Fact]
    public void EncryptToCaesar_LoopAlphabet_ShouldEncryptCorrectly()
    {
        string input = "xyz";
        string expected = "abc";
        string result = _service.EncryptToCaesar(input);
        Assert.Equal(expected, result);
    }
    [Fact]
    public void DecryptFromCaesar_LoopAlphabet_ShouldDecryptCorrectly()
    {
        string input = "abc";
        string expected = "xyz";
        string result = _service.DecrypteFromCaesar(input);
        Assert.Equal(expected, result);
    }
    [Fact]
    public void EncryptToCaesar_IgnoreNonAlphabet_ShouldEncryptCorrectly()
    {
        string input = "hello, world!";
        string expected = "khoor, zruog!";
        string result = _service.EncryptToCaesar(input);
        Assert.Equal(expected, result);
    }
    [Fact]
    public void DecryptFromCaesar_IgnoreNonAlphabet_ShouldDecryptCorrectly()
    {
        string input = "khoor, zruog!";
        string expected = "hello, world!";
        string result = _service.DecrypteFromCaesar(input);
        Assert.Equal(expected, result);
    }
