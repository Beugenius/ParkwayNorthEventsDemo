using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IUnitOfWork
    {
        /// <summary>
        /// Get the Booking repository 
        /// </summary>
        public IGenericRepository<Booking> Bookings { get; }

        /// <summary>
        /// Get the ApplicationUsers repository 
        /// </summary>
        public IGenericRepository<ApplicationUser> ApplicationUsers { get; }

        /// <summary>
        /// Get the Vendor repository 
        /// </summary>
        public IGenericRepository<Supplier> Suppliers { get; }

        /// <summary>
        /// Get the VendorBookings repository 
        /// </summary>
        public IGenericRepository<ServicesBooked> ServicesBooked { get; }

        /// <summary>
        /// Get the Venue repository 
        /// </summary>
        public IGenericRepository<Venue> Venues { get; }
        /// <summary>
        /// Get the Booking repository 
        /// </summary>
        public IGenericRepository<VenuesBooked> VenuesBooked { get; }

        /// <summary>
        /// Get the Venue repository 
        /// </summary>
        public IGenericRepository<Transaction> Transactions { get; }
        /// <summary>
        /// Get the EventGallery repo
        /// </summary>
        public IGenericRepository<EventGallery> EventGallery { get; }
        /// <summary>
        /// Get the GalleryImages repo
        /// </summary>
        public IGenericRepository<GalleryImage> GalleryImages { get; }
        /// <summary>
        /// Save changes to data source 
        /// </summary>
        /// <returns></returns>
        int Commit();

        /// <summary>
        /// Save changes to data source asynchronously 
        /// </summary>
        /// <returns></returns>
        Task<int> CommitAsync();
    }
}
