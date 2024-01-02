using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Newtonsoft.Json;
using Xunit;

namespace RecapApiTest;

public class RecapApiTests
{
    private readonly HttpClient _client = new HttpClient();
    
    [Fact]
    public async Task GetRequestReturnsOk()
    {
        //Arrange
        var response = await _client.GetAsync("http://localhost:5161/Recap");
        
        //Act
        

        //Assert
        response.StatusCode.Should().Be(HttpStatusCode.OK);
    }
}