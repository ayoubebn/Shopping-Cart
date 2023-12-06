
namespace ShoppingCart.Repositories
{
    public interface ICartRepository
    {

        Task<int> AddItem(int bookId, int qty);
        Task<int> RemoveItem(int bookId);
        Task<ShoppingeCart> GetUserCart();
        Task<int> GetCartItemCount(string userId = "");
        Task<ShoppingeCart> GetCart(string userId);
        Task<bool> DoCheckout();
    }
}
