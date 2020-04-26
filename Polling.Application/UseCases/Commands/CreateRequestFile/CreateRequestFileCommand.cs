using Polling.Application.Interfaces;
using MediatR;
using System.Threading.Tasks;

namespace Polling.Application.UseCases.Commands.CreateRequestFile
{
    public class CreateRequestFileCommand : IRequest<int>
    {

    }

    public class CreateRequestFileCommandHandler : IRequestHandler<CreateRequestFileCommand, int>
    {
        private readonly IFilingService _context;

        public CreateRequestFileCommandHandler(IFilingService context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateRequestFileCommand request)
        {

        }
    }
}
