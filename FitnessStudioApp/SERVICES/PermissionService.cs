using System;
using System.Collections.Generic;
using FitnessStudioApp.MODELS;

namespace FitnessStudioApp.SERVICES
{
    [Flags]
    public enum Permission
    {
        None = 0,
        ViewOwnPlans = 1 << 0,
        ViewTimetable = 1 << 1,
        EditPlans = 1 << 2,
        ManageUsers = 1 << 3,
        ManageMemberships = 1 << 4,
        FullAccess = ViewOwnPlans | ViewTimetable | EditPlans | ManageUsers | ManageMemberships
    }

    public static class PermissionService
    {
        private static readonly Dictionary<UserRole, Permission> RolePermissions = new()
        {
            { UserRole.Client, Permission.ViewOwnPlans },
            { UserRole.Trainer, Permission.ViewTimetable | Permission.EditPlans },
            { UserRole.Admin, Permission.FullAccess }
        };

        public static Permission GetPermissions(UserRole role)
        {
            return RolePermissions.TryGetValue(role, out var p) ? p : Permission.None;
        }

        public static bool HasPermission(UserRole role, Permission permission)
        {
            return (GetPermissions(role) & permission) == permission;
        }
    }
}
