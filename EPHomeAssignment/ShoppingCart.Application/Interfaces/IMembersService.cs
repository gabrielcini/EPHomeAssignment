using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCart.Application.ViewModels;

namespace ShoppingCart.Application.Interfaces
{
    public interface IMembersService
    {
        void AddMember(MemberViewModel m);
    }
}
