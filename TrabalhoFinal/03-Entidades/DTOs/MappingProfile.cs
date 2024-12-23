﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinal._03_Entidades.DTOs.Joia;

namespace TrabalhoFinal._03_Entidades.DTOs
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ClienteLoginDTO, _03_Entidades.Cadastro>().ReverseMap();
            CreateMap<CreateJoiaDTO, Joias>().ReverseMap();
        }
    }
}
