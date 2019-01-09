﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RedStarter.Database.Contexts;
using RedStarter.Database.DataContract.Event;
using RedStarter.Database.Entities.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Database.Event
{
    public class EventRepository : IEventRepository
    {
        private readonly SISContext _context;
        private readonly IMapper _mapper;

        public EventRepository(SISContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        //CREATE EVENT
        public async Task<bool> CreateEvent(EventCreateRAO rao)
        {
            var entity = _mapper.Map<EventEntity>(rao);
            await _context.EventTableAccess.AddAsync(entity);
            return await _context.SaveChangesAsync() == 1;
        }

        //GET ALL EVENTS
        public async Task<IEnumerable<EventGetListItemRAO>> GetEvents()
        {
            var query = await _context.EventTableAccess.ToArrayAsync();
            var array = _mapper.Map<IEnumerable<EventGetListItemRAO>>(query);

            return array;
        }

        //GET EVENT BY ID
        public async Task<EventGetListItemRAO> GetEventById(int id)
        {
            var query = _context.EventTableAccess.Single(x => x.EventEntityId == id);
            var rao = _mapper.Map<EventGetListItemRAO>(query);

            return rao;
        }

        //EDIT EVENT
        public async Task<bool> EditEvent(EventEditRAO rao)
        {
            var entity = _context.EventTableAccess.Single(x => x.EventEntityId == rao.EventEntityId);
            entity.EventTitle = rao.EventTitle;
            entity.Information = rao.Information;

            return await _context.SaveChangesAsync() == 1;
        }
    }
}
