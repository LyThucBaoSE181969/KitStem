﻿using AutoMapper;
using SWP.KitStem.Repository.Models;
using SWP.KitStem.Service.BusinessModels.RequestModel;
using SWP.KitStem.Service.BusinessModels.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP.KitStem.Service.Utils
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            //// Using for users
            //CreateMap<ApplicationUser, UserProfileDTO>();

            //// Using for packages
            //CreateMap<Package, PackageResponseDTO>();
            //CreateMap<PackageLab, LabInPackageResponseDTO>()
            //    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Lab.Id))
            //    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Lab.Name))
            //    .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Lab.Price))
            //    .ForMember(dest => dest.MaxSupportTimes, opt => opt.MapFrom(src => src.Lab.MaxSupportTimes))
            //    .ForMember(dest => dest.Author, opt => opt.MapFrom(src => src.Lab.Author))
            //    .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Lab.Status))
            //    .ForMember(dest => dest.Level, opt => opt.MapFrom(src => src.Lab.Level));
            //CreateMap<Lab, LabInPackageResponseDTO>();
            //CreateMap<PackageCreateDTO, Package>();
            //CreateMap<Kit, KitInPackageResponseDTO>();
            //CreateMap<Package, PackageCartResponseDTO>()
            //    .ForMember(dest => dest.PackageId, opt => opt.MapFrom(src => src.Id))
            //    .ForMember(dest => dest.Labs, opt => opt.MapFrom(src => src.PackageLabs)).ReverseMap();

            //// Using for getting labs
            //CreateMap<Lab, LabResponseDTO>();
            //CreateMap<LabUploadDTO, Lab>();

            //// Using for getting KitComponents
            //CreateMap<KitComponent, KitComponentDTO>().ReverseMap();

            //// Using for Order
            //CreateMap<UserOrders, OrderResponseDTO>();
            //CreateMap<PackageOrder, PackageOrderResponseDTO>();
            //CreateMap<VNPaymentRequestDTO, Payment>()
            //    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            //    .ForMember(dest => dest.MethodId, opt => opt.MapFrom(src => OrderFulfillmentConstants.PaymentVnPay))
            //    .ForMember(dest => dest.Amount, opt => opt.MapFrom(src => src.Amount))
            //    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedDate))
            //    .ForMember(dest => dest.Status, opt => opt.MapFrom(src => false));
            //CreateMap<Payment, PaymentResponseDTO>();

            ////Using for getting Carts
            //CreateMap<Cart, CartDTO>().ReverseMap();
            //CreateMap<Cart, CartResponseDTO>().ReverseMap();

            // Using for Kit

            CreateMap<Kit, KitCreateRequest>().ReverseMap();
            CreateMap<Kit, KitModelResponse>()
                .ForMember(dest => dest.KitsCategory, opt => opt.MapFrom(src => src.Category))
                .ForMember(dest => dest.KitImages, opt => opt.MapFrom(src => src.KitImages));
            CreateMap<KitsCategory, CategoryModelRequest>();
            CreateMap<KitImage, KitImageRequest>();
            //// Using for KitImage
            CreateMap<KitImage, KitImageCreateRequest>().ReverseMap();

            ////Using for Component
            //CreateMap<Component, ComponentDTO>().ReverseMap();

        }
    }
}
