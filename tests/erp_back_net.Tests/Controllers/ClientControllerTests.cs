using erp_back_net.Controllers;
using erp_back_net.Entities.Client.Dtos;
using erp_back_net.Services.Client;
using Microsoft.AspNetCore.Mvc;

namespace erp_back_net.tests.Controllers;

public class ClientControllerTests
{
    private readonly Mock<IClientService> _mockService;
    private readonly ClientController _controller;

    public ClientControllerTests()
    {
        _mockService = new Mock<IClientService>();
        _controller = new ClientController(_mockService.Object);
    }
    
    [Fact]
    public async Task Create_ReturnsCreatedClient()
    {
        // Arrange
        var createDto = new ClientCreateDto { Name = "Cliente Teste" };
        var createdClient = new ClientDto { Id = 1, Name = "Cliente Teste" };

        _mockService
            .Setup(s => s.CreateAsync(createDto))
            .ReturnsAsync(createdClient);

        // Act
        var result = await _controller.Create(createDto);

        // Assert
        var actionResult = Assert.IsType<CreatedAtActionResult>(result.Result);
        var returnValue = Assert.IsType<ClientDto>(actionResult.Value);
        Assert.Equal(createdClient.Id, returnValue.Id);
        Assert.Equal("Cliente Teste", returnValue.Name);

        _mockService.Verify(s => s.CreateAsync(createDto), Times.Once);
    }
}