﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SportsStore.Web.Infrastructure.Abstract
{
    public interface IAuthProvider
    {
        bool Authenticate(string username, string password);
    }
}
