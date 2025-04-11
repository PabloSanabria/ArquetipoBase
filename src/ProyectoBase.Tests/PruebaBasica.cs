using Xunit;

namespace ProyectoBase.Tests
{
    public class PruebaBasica
    {
        [Fact]
        public void Suma_Simple()
        {
            Assert.Equal(2, 1 + 1);
        }
    }
}