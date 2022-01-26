﻿using Microsoft.AspNetCore.Http;
using System;

namespace DREDD.API.Infrastructure.Services
{
    public interface IIdentityService
    {
        string GetUserIdentity();
    }
    public class IdentityService : IIdentityService
    {
        private IHttpContextAccessor _context;

        public IdentityService(IHttpContextAccessor context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public string GetUserIdentity()
        {
            return _context.HttpContext.User.FindFirst("sub").Value;
        }
    }
}
