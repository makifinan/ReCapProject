﻿using System;
using System.Collections.Generic;
using Entities.Concrete;
using System.Text;
using Core.DataAccess;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface ICarDal:IEntityRepository<Car>
    {
        List<CarDetailDto> GetCarDetail();
    }
}
