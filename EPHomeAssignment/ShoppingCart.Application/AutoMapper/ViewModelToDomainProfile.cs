using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using ShoppingCart.Application.ViewModels;
using ShoppingCart.Domain.Models;

namespace ShoppingCart.Application.AutoMapper
{
    public class ViewModelToDomainProfile: Profile
    {
        public ViewModelToDomainProfile()
        {
            CreateMap<ProductViewModel, Product>()
                .ForMember(x=>x.Category, opt => opt.Ignore());
            CreateMap<CategoryViewModel, Category>();
            CreateMap<MemberViewModel, Member>();
        }
    }
}
