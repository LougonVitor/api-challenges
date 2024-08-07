using FirstApiChallenge02.Communication.Response;
using FirstApiChallenge02;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace FirstApiChallenge02.Repositorie;

public class BookRepositorie : IBookRepositorie
{
    public bool RemoveBook(int id)
    {
        string pathFile = @"Persistence\BookJson.json";
        string bookJson = File.ReadAllText(pathFile);

        List<ResponseRegisterBookJson> books = JsonConvert.DeserializeObject<List<ResponseRegisterBookJson>>(bookJson);

        if(books.Any() && books != null)
        {
            foreach (var book in books)
            {
                if (book.Id == id)
                {
                    books.Remove(book);
                    break;
                }

                continue;
            }

            string booksSerialized = JsonConvert.SerializeObject(books);
            File.WriteAllText(pathFile, booksSerialized);

            return true;
        }

        string booksNullSerialized = JsonConvert.SerializeObject(books);
        File.WriteAllText(pathFile, booksNullSerialized);

        return true;
    }

    public List<ResponseRegisterBookJson> SearchForAllBook()
    {
        string pathFile = @"Persistence\BookJson.json";
        string bookJson = File.ReadAllText(pathFile);

        List<ResponseRegisterBookJson> books = JsonConvert.DeserializeObject<List<ResponseRegisterBookJson>>(bookJson);
        return books;
    }

    public void SetBook(ResponseRegisterBookJson book)
    {
        string pathFile = @"Persistence\BookJson.json";
        string bookJsonOld = File.ReadAllText(pathFile);

        List<ResponseRegisterBookJson>? books = JsonConvert.DeserializeObject<List<ResponseRegisterBookJson>>(bookJsonOld);

        if(books != null)
        {
            books.Add(book);

            string bookJsonNew = JsonConvert.SerializeObject(books);
            File.WriteAllText(pathFile, bookJsonNew);
        }
        else
        {
            List<ResponseRegisterBookJson> newBooks = new List<ResponseRegisterBookJson>();
            newBooks.Add(book);

            string newBookJson = JsonConvert.SerializeObject(newBooks);
            File.WriteAllText(pathFile, newBookJson);
        }
    }

    public void UpdateBook(ResponseRegisterBookJson response)
    {
        string pathFile = @"Persistence\BookJson.json";
        string bookJsonOld = File.ReadAllText(pathFile);

        List<ResponseRegisterBookJson> books = JsonConvert.DeserializeObject<List<ResponseRegisterBookJson>>(bookJsonOld);

        if(books != null && books.Any())
        {
            foreach (var book in books)
            {
                if(book.Id == response.Id)
                {
                    if(response.Title != null || response.Title.Equals("string")) book.Title = response.Title;
                    if(response.Author != null || response.Author.Equals("string")) book.Author = response.Author;
                    if(response.BookGenre != null) book.BookGenre = response.BookGenre;
                    if(response.Price != null) book.Price = response.Price;
                    if(response.QuantityStock != null) book.QuantityStock = response.QuantityStock;
                }
                continue;
            }
        } 
        
        string bookSerialized = JsonConvert.SerializeObject(books);
        File.WriteAllText(pathFile, bookSerialized);
    }
}