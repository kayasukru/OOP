﻿using OOP.GenericRepositoryDesignPattern.DAL.Abstract;
using OOP.GenericRepositoryDesignPattern.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.GenericRepositoryDesignPattern.DAL.Concrete
{
    public class EmployeeDal : BaseRepository<Employee>, IEmployeeDal
    {

    }
}
