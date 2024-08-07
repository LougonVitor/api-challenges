using FirstApiChallenge02.Communication.Response;
using FirstApiChallenge02.Communication.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FirstApiChallenge02.Repositorie;

namespace FirstApiChallenge02.Controllers;

public class BookController : BookBaseController
{
    private readonly IBookRepositorie _bookRepositorie;
    public BookController(IBookRepositorie bookRepositorie)
    {
        this._bookRepositorie = bookRepositorie;
    }

    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterBookJson), StatusCodes.Status201Created)]
    public IActionResult CreateBook([FromBody] RequestRegisterBookJson request)
    {
        ResponseRegisterBookJson response = new ResponseRegisterBookJson()
        {
            Id = request.Id,
            Title = request.Title,
            Author = request.Author,
            BookGenre = request.BookGenre,
            Price = request.Price,
            QuantityStock = request.QuantityStock
        };
        _bookRepositorie.SetBook(response);

        return Created(string.Empty, response);
    }

    [HttpGet]
    [ProducesResponseType(typeof(ResponseRegisterBookJson), StatusCodes.Status200OK)]
    public IActionResult GetAllBooks()
    {
        List<ResponseRegisterBookJson> response = _bookRepositorie.SearchForAllBook();
        return Ok(response);
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseRegisterBookJson), StatusCodes.Status200OK)]
    public IActionResult DeleteBook([FromRoute]int id) 
    {
        _bookRepositorie.RemoveBook(id);
        return Ok();
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseRegisterBookJson), StatusCodes.Status204NoContent)]
    public IActionResult UpdateBook([FromBody]RequestRegisterBookJson request, [FromRoute]int id)
    {
        ResponseRegisterBookJson response = new ResponseRegisterBookJson()
        {
            Id = id,
            Title = request.Title,
            Author = request.Author,
            BookGenre = request.BookGenre,
            Price = request.Price,
            QuantityStock = request.QuantityStock
        };

        _bookRepositorie.UpdateBook(response);
        return NoContent();
    }
}