using MinimalApi.Dominimio.Entidades;

namespace Test.Domain.Entidades;

[TestClass]
public class VeiculoTest
{
    [TestMethod]
    public void TestarGetSetPropriedades()
    {
        //Arrange
        var veiculo = new Veiculo();

        //Act
        veiculo.Id = 1;
        veiculo.Nome = "testeNome";
        veiculo.Marca = "testeMarca";
        veiculo.Ano = 2022;
        //Assert
        Assert.AreEqual(1, veiculo.Id);
        Assert.AreEqual("testeNome", veiculo.Nome);
        Assert.AreEqual("testeMarca", veiculo.Marca);
        Assert.AreEqual(2022, veiculo.Ano);

    }
}