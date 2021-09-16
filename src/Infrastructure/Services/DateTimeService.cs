using Potato.Application.Common.Interfaces;
using System;

namespace Potato.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
