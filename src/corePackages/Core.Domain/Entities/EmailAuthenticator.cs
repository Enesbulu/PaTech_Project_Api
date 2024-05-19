﻿using Core.Domain.Entities.Base;

namespace Core.Domain.Entities
{
    public class EmailAuthenticator : Entity<Guid>
    {
        public Guid UserId { get; set; }
        public string? ActivationKey { get; set; }
        public bool IsVerified { get; set; }
        public virtual User User { get; set; }

        public EmailAuthenticator()
        {
            User = default!;
        }

        public EmailAuthenticator(Guid id, Guid userId, string? activationKey, bool isVerified) : this()
        {
            Id = id;
            UserId = userId;
            ActivationKey = activationKey;
            IsVerified = isVerified;
        }
    }
}
