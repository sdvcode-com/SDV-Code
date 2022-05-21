namespace SdvCode.Models.Enums
{
    using System.ComponentModel.DataAnnotations;

    public enum WebsiteActionStatus
    {
        [Display(Name = "Unread")]
        Unread = 1,

        [Display(Name = "Read")]
        Read = 2,

        [Display(Name = "Pinned")]
        Pinned = 3,
    }
}