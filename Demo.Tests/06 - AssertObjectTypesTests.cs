using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using static Demo.Funcionario;

namespace Demo.Tests
{
    public class AssertObjectTypesTests
    {
        [Fact]
        public void Funcionario_Criar_DeveRetornarTipoFuncionario()
        {
            //Arrange & Act
            var funcionario = FuncionarioFactory.Criar(nome: "Geovane", salario: 1000);

            //Assert
            Assert.IsType<Funcionario>(funcionario);
        }

        [Fact]
        public void Funcionario_Criar_DeveRetornarTipoDerivadoPessoa()
        {
            //Arrange & Act
            var funcionario = FuncionarioFactory.Criar(nome: "Geovane", salario: 1000);

            //Assert
            Assert.IsAssignableFrom<Pessoa>(funcionario);
        }
    }
}

