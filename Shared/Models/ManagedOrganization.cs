using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Remotely.Shared.Models
{
    public class ManagedOrganization
    {
        public string UserID { get; set; }
        public string OrganizationID { get; set; }

        [JsonIgnore]
        public RemotelyUser User { get; set; }
        [JsonIgnore]
        public Organization Organization { get; set; }
    }
}
