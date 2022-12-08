﻿using Chapter.Controllers;
using Chapter.Interface;
using Chapter.Models;
using Chapter.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoChapter.Controller
{
    public class LoginControllerTeste
    {
        [Fact]
        public void LoginController_Retornar_Usuario_Invalido()
        {
            //Arrange
            var fakeRepository = new Mock<IUsuarioRepository>();
            fakeRepository.Setup(x => x.Login(It.IsAny<string>(), It.IsAny<string>())).Returns((Usuario)null);

            LoginViewModel dadosLogin = new LoginViewModel();

            dadosLogin.Email = "email@email.com";
            dadosLogin.Senha = "123";

            var controller = new LoginController(fakeRepository.Object);


            //Act
            var resultado = controller.Login(dadosLogin);

            //Assert
            Assert.IsType<UnauthorizedObjectResult>(resultado);
        }
    }
}
