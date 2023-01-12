﻿using denemeBlazor.Services.Interfaces;
using SportsStore.Data.Entities;

namespace denemeBlazor.Bussines.Dtos
{
    public class AppUserListDto : IListDto
    {
        public int Id { get ; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public int AppRoleId { get; set; }

        public AppRoleListDto AppRole { get; set; }
    }
}
