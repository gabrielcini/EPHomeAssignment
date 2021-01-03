using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCart.Domain.Models;

namespace ShoppingCart.Domain.Interfaces
{
    public interface IMembersRepository
    {
        void AddMember(Member m);
    }
}
