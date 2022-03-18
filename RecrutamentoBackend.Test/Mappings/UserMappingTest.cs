using FluentAssertions;

using RecrutamentoWebAPI.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RecrutamentoBackend.Test.Mappings
{
    public class UserMappingTest
    {
        [Fact]
        public void ShouldConvertToEntitySucefully()
        {
            //act
            string[] interest = { "test1", "test2" };
            var userModel = new RecrutamentoWebAPI.Models.User
            {
                Name = "Test",
                Email = "test@test.com",
                Number = "123456789",
                Interests = interest,
                Message = "Test"
            };


            //arrange
            var userEntity = UserMapping.ToEntity(userModel);
            /*string[] interest1 = { "TEST12123", "test2" };
            userModel.Interests = interest1;*/
            //assert
            userModel.Name.Should().Be(userEntity.Name);
            userModel.Email.Should().Be(userEntity.Email);
            userModel.Number.Should().Be(userEntity.Number);
            userModel.Message.Should().Be(userEntity.Message);
            /*var Interests = userModel.Zip(userEntity, (m, e) => new { Model = m, Entity = e });
            foreach (var nw in Interests)
            {
                Console.WriteLine(nw.Number + nw.Word);
            }
            */
            userModel.Interests.Length.Should().Be(userEntity.Interests.Length);
            for(var i = 0; i < userModel.Interests.Length; i++)
            {
                userModel.Interests[i].Should().Be(userEntity.Interests[i]);
            }
        }
    }
}
