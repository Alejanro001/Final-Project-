using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Reservation.DATA.EF//.Metadata
{
    //public class AspNetUser
    //{

    //    public string Id { get; set; }
    //    public string Email { get; set; }
    //    public bool EmailConfirmed { get; set; }
    //    public string PasswordHash { get; set; }
    //    public string SecurityStamp { get; set; }
    //    public string PhoneNumber { get; set; }
    //    public bool PhoneNumberConfirmed { get; set; }
    //    public bool TwoFactorEnabled { get; set; }
    //    public Nullable<System.DateTime> LockoutEndDateUtc { get; set; }
    //    public bool LockoutEnabled { get; set; }
    //    public int AccessFailedCount { get; set; }
    //    public string UserName { get; set; }
    //}
    public class LocationMetadata
    {
        public int LocationID { get; set; }
        [Required(ErrorMessage = "While house calls are on the table for possible future endevors, we do not currently really do that. Please select a location.")]
        public string LocationName { get; set; }
        [Display(Name = "Address")]
        [Required(ErrorMessage = "Please enter the street address.")]
        public string Address { get; set; }
        [Display(Name = "City")]
        [Required(ErrorMessage = "Please enter the city.")]
        public string City { get; set; }
        [Display(Name = "State")]
        [Required(ErrorMessage = "Please enter the two letter postal code.")]
        public string State { get; set; }
        [Display(Name = "Zip code")]
        [Required(ErrorMessage = "Please enter the zip code")]
        public string ZipCode { get; set; }
        [Range(1, int.MaxValue)]
        public byte ReservationLimit { get; set; }
    }
    [MetadataType(typeof(LocationMetadata))]
    public partial class Location { };
    public class OwnerAssetMetadata
    {   //TODO - Finish adding metadata
        public int OwnerAssetID { get; set; }
        public string AssetName { get; set; }
        public string OwnerID { get; set; }
        public string AssetPhoto { get; set; }
        public string SpecialNotes { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime DateAdded { get; set; }
    }
    [MetadataType(typeof(OwnerAssetMetadata))]
    public partial class OwnerAsset { };
    public class ReservationMetadata
    {
        public int ReservationID { get; set; }
        public int LocationID { get; set; }
        public System.DateTime ReservationDate { get; set; }
        public int OwnerAssetID { get; set; }

    }
    [MetadataType(typeof(Reservation))]
    public partial class Reservation { };
    public class UserDetailMetadata
    {
        public string UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    [MetadataType(typeof(UserDetail))]
    public partial class UserDetail { };
}
