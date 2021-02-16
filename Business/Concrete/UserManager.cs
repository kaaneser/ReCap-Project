using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(User user)
        {
            if (user.Password.Length <= 4) // Password is too short error
                return new ErrorResult(Messages.PassError);
            return new SuccessResult(Messages.UserAdded);
        }

        public IResult Delete(User user)
        {
            if (user.UserId == 1) // First user is default user
                return new ErrorResult();
            return new SuccessResult();
        }

        public IDataResult<List<User>> GetAll()
        {
            if (DateTime.Now.Hour == 23)
                return new ErrorDataResult<List<User>>();
            return new SuccessDataResult<List<User>>();
        }

        public IResult Update(User user)
        {
            return new SuccessResult();
        }
    }
}
