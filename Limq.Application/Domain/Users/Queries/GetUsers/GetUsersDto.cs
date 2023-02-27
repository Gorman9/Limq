﻿namespace Limq.Application.Domain.Users.Queries.GetUsers;
public record GetUsersDto
{
    public Guid Id { get; set; }

    public string UserName { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

#pragma warning disable CA1819 // Properties should not return arrays
    public byte[] Avatar { get; set; }
#pragma warning restore CA1819 // Properties should not return arrays

    public bool Status { get; set; }
}
