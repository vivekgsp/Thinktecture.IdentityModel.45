﻿/*
 * Copyright (c) Dominick Baier, Brock Allen.  All rights reserved.
 * see license.txt
 */

namespace Thinktecture.IdentityModel.Clients
{
    public class OidcAuthorizeResponse
    {
        public bool IsError { get; internal set; }

        public string Error { get; internal set; }
        public string Code { get; internal set; }
        public string State { get; internal set; }
    }
}
