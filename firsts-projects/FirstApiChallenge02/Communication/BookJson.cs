using FirstApiChallenge02.Enums;

namespace FirstApiChallenge02.Communication;

public class BookJson
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public BookGenre BookGenre { get; set; }
    public decimal Price { get; set; }
    public int QuantityStock { get; set; }
}