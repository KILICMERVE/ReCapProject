﻿using Business.Abstract;
using Business.Constans;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        [CacheRemoveAspect("IRentalService.Get")]
        [PerformanceAspect(5)]
        public IResult Add(Rental rental)
        {
            var result = _rentalDal.GetAll(r=>r.RentalId==rental.RentalId);
            foreach (var res in result)
            {
                if (res.ReturnDate>rental.RentDate || res.ReturnDate==null)
                {
                    return new ErrorResult(Messages.RentalNotAdded);
                }
            }
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.Added);
        }

        [CacheRemoveAspect("IRentalService.Get")]
        [PerformanceAspect(5)]
        public IResult Delete(Rental rental)
        {
            if (rental.ReturnDate != null)
            {
                _rentalDal.Delete(rental);
                return new SuccessResult(Messages.Deleted);
            }
            return new SuccessResult("Araç teslim edilmediği için kayıt sililenmedi");
        }

        [CacheAspect]
        [PerformanceAspect(5)]
        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        [CacheAspect]
        public IDataResult<Rental> GetById(int rentalId)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r=>r.RentalId==rentalId));
        }

        [CacheRemoveAspect("IRentalService.Get")]
        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.Updated);
        }
    }
}
