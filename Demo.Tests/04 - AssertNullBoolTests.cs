using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using static Demo.Funcionario;

namespace Demo.Tests
{
    public class AssertNullBoolTests
    {
        [Fact]
        public void Funcionario_Nome_NaoDeveSerNuloOrVazio()
        {
            //Arrange & Act
            var funcionario = FuncionarioFactory.Criar(nome: "", salario: 1000);

            //Assert
            Assert.False(string.IsNullOrEmpty(funcionario.Nome));
        }

        [Fact]
        public void Funcionario_Apelido_NaoDeveTerApelido()
        {
            //Arrange
            var funcionario = FuncionarioFactory.Criar(nome: "Geovane Godoi", salario: 1000);

            //Assert Null
            Assert.Null(funcionario.Apelido);

            //Assert Bool
            Assert.True(string.IsNullOrEmpty(funcionario.Apelido));
            Assert.False(funcionario.Apelido?.Length > 0);
        }
    }
}
