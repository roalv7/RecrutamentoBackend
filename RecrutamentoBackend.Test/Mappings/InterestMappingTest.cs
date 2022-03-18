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
    public class InterestMappingTest
    {
        [Fact]
        public void ShouldConvertToEntitySucefully()
        {
            //act
            var interestModel = new RecrutamentoWebAPI.Models.Interest
            {
                Description =  "Teste"
            };


            //arrange
            var interestEntity = InterestMapping.ToEntity(interestModel);


            //assert
            interestModel.Description.Should().Be(interestEntity.Description);
        }
    }
}
