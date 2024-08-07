using FirstApiChallenge02.Communication.Response;

namespace FirstApiChallenge02.Repositorie;

public interface IBookRepositorie
{
    List<ResponseRegisterBookJson> SearchForAllBook();
    void SetBook(ResponseRegisterBookJson book);
    bool RemoveBook(int id);
    void UpdateBook(ResponseRegisterBookJson book);
}