﻿using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using Orchard.Security.Permissions;

namespace Orchard.Users {
    [UsedImplicitly]
    public class Permissions : IPermissionProvider {
        public static readonly Permission ManageUsers = new Permission { Description = "Manage users", Name = "ManageUsers" };

        public string PackageName {
            get {
                return "Users";
            }
        }

        public IEnumerable<Permission> GetPermissions() {
            return new Permission[] {
                ManageUsers,
            };
        }

        public IEnumerable<PermissionStereotype> GetDefaultStereotypes() {
            return new[] {
                new PermissionStereotype {
                    Name = "Administrators",
                    Permissions = new[] {ManageUsers}
                }
            };
        }

    }
}
