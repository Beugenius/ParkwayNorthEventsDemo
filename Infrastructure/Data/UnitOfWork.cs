using ApplicationCore.Interfaces;
using ApplicationCore.Models;
using ParkwayNorthEvents.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _dbContext;
        public UnitOfWork(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        #region Booking Repo
        private IGenericRepository<Booking> _Booking;

        public IGenericRepository<Booking> Bookings
        {
            get
            {
                if (_Booking == null)
                {
                    _Booking = new GenericRepository<Booking>(_dbContext);
                }
                return _Booking;
            }
        }
        #endregion
        #region Client Repo
        private IGenericRepository<ApplicationUser> _ApplicationUser;

        public IGenericRepository<ApplicationUser> ApplicationUsers
        {
            get
            {
                if (_ApplicationUser == null)
                {
                    _ApplicationUser = new GenericRepository<ApplicationUser>(_dbContext);
                }
                return _ApplicationUser;
            }
        }
        #endregion
        #region Supplier Repo
        private IGenericRepository<Supplier> _Supplier;

        public IGenericRepository<Supplier> Suppliers
        {
            get
            {
                if (_Supplier == null)
                {
                    _Supplier = new GenericRepository<Supplier>(_dbContext);
                }
                return _Supplier;
            }
        }
        #endregion
        #region ServicesBooked Repo
        private IGenericRepository<ServicesBooked> _ServicesBooked;

        public IGenericRepository<ServicesBooked> ServicesBooked
        {
            get
            {
                if (_ServicesBooked == null)
                {
                    _ServicesBooked = new GenericRepository<ServicesBooked>(_dbContext);
                }
                return _ServicesBooked;
            }
        }
        #endregion
        #region Venue Repo
        private IGenericRepository<Venue> _Venue;

        public IGenericRepository<Venue> Venues
        {
            get
            {
                if (_Venue == null)
                {
                    _Venue = new GenericRepository<Venue>(_dbContext);
                }
                return _Venue;
            }
        }
        #endregion
        #region Venues Booked Repo
        private IGenericRepository<VenuesBooked> _VenuesBooked;

        public IGenericRepository<VenuesBooked> VenuesBooked
        {
            get
            {
                if (_VenuesBooked == null)
                {
                    _VenuesBooked = new GenericRepository<VenuesBooked>(_dbContext);
                }
                return _VenuesBooked;
            }
        }
        #endregion
        #region Transactions Repo
        private IGenericRepository<Transaction> _Transactions;

        public IGenericRepository<Transaction> Transactions
        {
            get
            {
                if (_Transactions == null)
                {
                    _Transactions = new GenericRepository<Transaction>(_dbContext);
                }
                return _Transactions;
            }
        }
        #endregion
        #region EventGallery Repo
        private IGenericRepository<EventGallery> _EventGallery;
        public IGenericRepository<EventGallery> EventGallery
        {
            get
            {
                if (_EventGallery == null)
                {
                    _EventGallery = new GenericRepository<EventGallery>(_dbContext);
                }
                return _EventGallery;
            }
        }
        #endregion
        #region GalleryImage Repo
        private IGenericRepository<GalleryImage> _GalleryImage;
        public IGenericRepository<GalleryImage> GalleryImages
        {
            get
            {
                if (_GalleryImage == null)
                {
                    _GalleryImage = new GenericRepository<GalleryImage>(_dbContext);
                }
                return _GalleryImage;
            }
        }
        #endregion
        public int Commit()
        {
            return _dbContext.SaveChanges();
        }

        public async Task<int> CommitAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
