using System;
using System.Collections.Generic;
using System.Text;

namespace FreeCourse.Shared.Service
{
    public interface ISharedIdentityService
    {
        public string GetUserId { get; }
    }
}
