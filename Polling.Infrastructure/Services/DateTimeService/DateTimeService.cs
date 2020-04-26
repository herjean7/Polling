using Polling.Application.Interfaces;
using System;

namespace Polling.Infrastructure.Services.DateTimeService
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
