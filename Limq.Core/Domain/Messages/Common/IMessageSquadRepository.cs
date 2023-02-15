﻿using Limq.Core.Domain.Messages.Models;
using MediatR;

namespace Limq.Core.Domain.Messages.Common;
public interface IMessageSquadRepository
{
    Task<Unit> Add(MessageSquad messageSquad);

    Task<MessageSquad> Find(Guid squadId, Guid userId);

    Task<Unit> Remove(Guid squadId, Guid userId);
}
