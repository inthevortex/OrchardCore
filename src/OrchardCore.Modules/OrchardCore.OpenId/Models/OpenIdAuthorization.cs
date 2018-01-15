using System;
using System.Collections.Generic;

namespace OrchardCore.OpenId.Models
{
    public class OpenIdAuthorization
    {
        /// <summary>
        /// Gets or sets the unique identifier
        /// associated with the current application.
        /// </summary>
        public string AuthorizationId { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the client application
        /// associated with the current authorization.
        /// </summary>
        public string ApplicationId { get; set; }

        /// <summary>
        /// Gets or sets the physical identifier
        /// associated with the current authorization.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the scopes associated with the current authorization.
        /// </summary>
        public ISet<string> Scopes { get; set; } = new HashSet<string>(StringComparer.Ordinal);

        /// <summary>
        /// Gets or sets the status of the current authorization.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the subject associated with the current authorization.
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Gets or sets the type of the current authorization.
        /// </summary>
        public string Type { get; set; }
    }
}