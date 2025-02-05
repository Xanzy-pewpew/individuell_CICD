var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var cipherService = new CICD_cipher.CipherService();

app.MapGet("/", () => "Welcome to API for Caesar Cipher!");

//Endpoint for encrypting the input
app.MapGet("/encrypt", (string input) =>
{
    return cipherService.Encrypt(input);
});
//Endpoint for decrypting the input
app.MapGet("/decrypt", (string input) =>
{
    return cipherService.Decrypt(input);
});

app.Run();
