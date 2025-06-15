using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Model
{
    public static class StaffRepository
    {
        public static List<StaffModel> Staff { get; set; } = new List<StaffModel>()
        {
            new StaffModel
                {
                    StaffId = 1,
                    FirstName = "Hannah",
                    LastName = "Nathan",
                    Email = "eokereke47@gmail.com",
                    Password = "1234",  // Note: In production, never store plain passwords
                    IsVerified = true,
                    Location = true,
                    CreatedAt = DateTime.UtcNow,  // Using UtcNow instead of Now
                    UpdatedAt = DateTime.UtcNow
                },
                new StaffModel
                {
                    StaffId = 2,  // Changed from 1 to 2 for unique IDs
                    FirstName = "Nathan",
                    LastName = "Caleb",
                    Email = "caleb@gmail.com",
                    Password = "123479",
                    IsVerified = true,
                    Location = true,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                }
        };
    }
}