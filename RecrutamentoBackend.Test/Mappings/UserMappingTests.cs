using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecrutamentoWebAPI.Mappings;
using Xunit;

namespace RecrutamentoBackend.Test.Mappings
{
   
    public class UserMappingTests
    {
        [Fact]
        public void ShouldConvertToEntitySuccessfully()
        {
            //arrange
            var userModel = new RecrutamentoWebAPI.Models.User
            {
                Name = "Ro",
                Email = "r7@gmail.com",
                Number = "777777777",
                //Interests = "Backend",
                Message = "Obrigado"
            };

            //act
            var userEntity = UserMapping.ToEntity(userModel);

            //assert
            userModel.Name.Should().Be(userEntity.Name);
            userModel.Email.Should().Be(userEntity.Email);
            userModel.Number.Should().Be(userEntity.Number);
            //userModel.Interests.Should().Be(userEntity.Interests);
            userModel.Message.Should().Be(userEntity.Message);


            //Assert.Equals(userModel.Name, userEntity.Name);
            //Assert.Equals(userModel.Email, userEntity.Email);
            //Assert.Equals(userModel.Number, userEntity.Number);
            //Assert.Equals(userModel.Interests, userEntity.Interests);
            //Assert.Equals(userModel.Message, userEntity.Message);
        }
    }
}
