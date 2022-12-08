using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Teste.controller
{
    public class LoginControllerTeste
    {
        [Fact]
        public void loginController_Retornar_Usuario_Invalido()
        {
            // Arrange
            var fakeRepository = new Mock<IUsuarioRepository>();
        }
    }
}
