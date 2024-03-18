using TaskCopeCommon.Entities;

namespace TaskCopeCommon.Data
{
    public static class TestData
    {
        public static List<Role> Roles = new List<Role>()
        {
            new Role()
            {
                 Name = "TeamLead"
            },
            new Role()
            {
                 Name = "Senior"
            },
            new Role()
            {
                 Name = "Middle"
            },
            new Role()
            {
                 Name = "Junior"
            }
        };

        public static List<User> Users = new List<User>() {
            new User()
            {
                FullName = "John Doe",
                RoleId = 1,
                Email = "JDoe@gmail.com",
                Password = "AD12345"
            }, new User()
            {
                FullName = "Alex Brown",
                RoleId = 2,
                Email = "ABrown@gmail.com",
                Password = "AB12345"
            }, new User()
            {
                FullName = "Leanne Graham",
                RoleId = 2,
                Email = "Leanne@gmail.com",
                Password = "LG12345"
            }, new User()
            {
                FullName = "Ervin Howell",
                RoleId = 3,
                Email = "EHowell@gmail.com",
                Password = "EH12345"
            }, new User()
            {
                FullName = "Clementine Bauch",
                RoleId = 3,
                Email = "CBauch@gmail.com",
                Password = "CB12345"
            }, new User()
            {
                FullName = "Patricia Lebsack",
                RoleId = 4,
                Email = "PatricaL@gmail.com",
                Password = "PL12345"
            }, new User()
            {
                FullName = "Chelsey Dietrich",
                RoleId = 4,
                Email = "ChelseyD@gmail.com",
                Password = "CD12345"
            }
        };
    }
}