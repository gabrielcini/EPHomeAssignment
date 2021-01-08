using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using ShoppingCart.Application.ViewModels;
using ShoppingCart.Domain.Models;

namespace ShoppingCart.Application.AutoMapper
{
    public class DomainToViewModelProfile: Profile
    {
        public DomainToViewModelProfile()
        {
            CreateMap<Product, ProductViewModel>();

            CreateMap<Category, CategoryViewModel>();
            CreateMap<Member, MemberViewModel>();
        }
    }
}
