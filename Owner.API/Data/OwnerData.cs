
using Owner.API.Model;
using System;
using System.Collections.Generic;

namespace Owner.API.Data
{
    public class OwnerData
    {
        public List<OwnerModel> GetAll()
        {
            return new List<OwnerModel>

            {
                new OwnerModel
                {
                    Id = 1,
                    Name = "Beste",
                    Surname = "Karagoz",
                    Date = DateTime.Now,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam accumsan.1",
                    Type = "Type1"
                },
                new OwnerModel
                {
                    Id = 2,
                    Name = "John",
                    Surname = "Doe",
                    Date = DateTime.Now,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam accumsan.2",
                    Type = "Type2"
                },
                new OwnerModel
                {
                    Id = 3,
                    Name = "Jane",
                    Surname = "Doe",
                    Date = DateTime.Now,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam accumsan.3",
                    Type = "Type3"
                },
                new OwnerModel
                {
                    Id = 4,
                    Name = "Elliot",
                    Surname = "Alderson",
                    Date = DateTime.Now,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam accumsan.4",
                    Type = "Type4"
                },
                new OwnerModel
                {
                    Id = 5,
                    Name = "Ada",
                    Surname = "Lovelace",
                    Date = DateTime.Now,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam accumsan.5",
                    Type = "Type5"
                }
            };
        }
    }
}