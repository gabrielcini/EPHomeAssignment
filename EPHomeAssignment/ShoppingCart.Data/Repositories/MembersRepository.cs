using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCart.Data.Context;
using ShoppingCart.Domain.Interfaces;
using ShoppingCart.Domain.Models;

namespace ShoppingCart.Data.Repositories
{
    public class MembersRepository: IMembersRepository
    {
        private ShoppingCartDbContext _context;

        public MembersRepository(ShoppingCartDbContext context)
        {
            _context = context;
        }

        public void AddMember(Member m)
        {
            _context.Members.Add(m);
            _context.SaveChanges();
        }
    }
}
