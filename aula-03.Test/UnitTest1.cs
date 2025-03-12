namespace aula_03.Test;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void Soma_Deve_Retornar_5()
    {
        int resultado = 2 + 3;

       Assert.AreEqual(5, resultado);
    }
    [Test]
public void Deve_Aumentar_Canal()
{
    tv.SelecionarCanal(10);
    tv.AumentarCanal();
    Assert.AreEqual(11, tv.Canal);
}

[Test]
public void Deve_Diminuir_Canal()
{
    tv.SelecionarCanal(10);
    tv.DiminuirCanal();
    Assert.AreEqual(9, tv.Canal);
}

[Test]
public void Deve_Selecionar_Canal_Pelo_Numero()
{
    tv.SelecionarCanal(505);
    Assert.AreEqual(505, tv.Canal);
}
}
