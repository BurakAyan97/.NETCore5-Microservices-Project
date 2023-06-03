using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FreeCourse.Shared.Service
{
    public class SharedIdentityService : ISharedIdentityService
    {
        private IHttpContextAccessor _contextAccessor;//Kullanabilmek için Basket .API startupında ekledik.

        public SharedIdentityService(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }

        public string GetUserId => _contextAccessor.HttpContext.User.FindFirst("sub").Value;//Tokendeki kişinin id sini al. Tokenda hatırlarsan "sub":"{string bir id var guid gibi}"
    }
}
