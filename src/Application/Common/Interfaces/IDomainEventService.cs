using Potato.Domain.Common;
using System.Threading.Tasks;

namespace Potato.Application.Common.Interfaces
{
    public interface IDomainEventService
    {
        Task Publish(DomainEvent domainEvent);
    }
}
