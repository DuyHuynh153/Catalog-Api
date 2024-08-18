using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using static Play.Catalog.Service.Dtos.Dtos;

namespace Play.Catalog.Service.Controllers
{

    [ApiController]
    [Route("items")]
    public class ItemsController : ControllerBase
    {
        private static readonly List<ItemDto> items = new()
        {
            new ItemDto(Guid.NewGuid(), "Potion","Restore 10% HP", 5, DateTimeOffset.UtcNow),
            new ItemDto(Guid.NewGuid(), "Antido","Restore 130% HP", 7, DateTimeOffset.UtcNow),
            new ItemDto(Guid.NewGuid(), "Sword","Damage 10% HP", 5, DateTimeOffset.UtcNow),
        };

        [HttpGet]
        public IEnumerable<ItemDto> Get()
        {
            return items;
        }

        [HttpGet("{id}")]
        public ItemDto GetById(Guid id)
        {
            var item = items.Where(item => item.Id == id).FirstOrDefault();
            return item;
        }


    }
}
