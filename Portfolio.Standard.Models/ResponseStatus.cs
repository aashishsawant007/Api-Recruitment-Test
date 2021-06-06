namespace Portfolio.Standard.Models
{
    public enum ResponseStatus
    {
        Success = 0,
        Failed = 1,
        PasswordExpired = 2,
        AccountLocked = 3,
        ConcurrencyException = 4,
        AuctionExpired = 5
    }
}