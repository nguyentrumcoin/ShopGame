﻿using DUCtrongAPI.Models;
using DUCtrongAPI.Repositories.EmplementedRepository.Paging;
using DUCtrongAPI.Repositories.GenericRepository;
using DUCtrongAPI.Requests;

namespace DUCtrongAPI.Repositories.EmplementedRepository.CartRepos
{
    public interface ICartRepo : IRepository<Cart>
    {
        Task<bool> CheckCart(string userid, string productid);
        Task<Cart> GetCart(string userid, string productid);
        Task<PagedResult<Cart>> GetallCartPaging(CartPaging cartpaging);
        Task<bool> UpdateCart(UpdateCartModel updateCartModel);
        Task<bool> RemoveCart(string userid, string productid);
    }
}
